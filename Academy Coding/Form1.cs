﻿using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace AcademyCoding
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       
        private void txt_usuarioSource_TextChanged(object sender, EventArgs e)
        {

        }
        private void  txt_senhaSource_TextChanged(object sender, EventArgs e)
        {

        }
        private void cb_autentificacaoSource_Click_1(object sender, EventArgs e)
        {
            if (cb_autentificacaoSource.Checked)
            {
                txt_usuarioSource.Enabled = false;
            ;
            }
            else
                txt_usuarioSource.Enabled = true;
              
           
            if (cb_autentificacaoSource.Checked)
            {
             ;
                txt_senhaSource.Enabled = false;
            }
            else
               
            txt_senhaSource.Enabled = true;


        }  
        private void Form1_Load_1(object sender, EventArgs e)
        {
            cb_autentificacaoSource.Enabled = true;
                      
        }

        private void cb_autentificacaoTarget_Click(object sender, EventArgs e)
        {
            if (cb_autentificacaoTarget.Checked)
            {
                txt_usuarioTarget.Enabled = false;

            }
            else
                txt_usuarioTarget.Enabled = true;


            if (cb_autentificacaoTarget.Checked)
            {
                
               txt_senhaTarget.Enabled = false;
            }
            else

                txt_senhaTarget.Enabled = true;


        }
       
        private void btn_start_Click(object sender, EventArgs e)
        {
            IGerais g = new IGerais();

            if (g.CampoVazio(txt_servidorSource, "Servidor Source"))
                return;

            if (g.CampoVazio(txt_dataBaseSource, "DataBase Source"))
                return;

            if (g.CampoVazio(txt_tabelaSource, "Tabela Source"))
                return;

            if (g.CampoVazio(txt_usuarioSource, "Usuario Source"))
                return;


            if (g.CampoVazio(txt_senhaTarget, "Senha Target"))
                return;
            if (g.CampoVazio(txt_servidorTarget, "Servidor Target"))
                return;

            if (g.CampoVazio(txt_dataBaseTarget, "DataBase Target"))
                return;

            if (g.CampoVazio(txt_tabelaTarget, "Tabela Target"))
                return;

            if (g.CampoVazio(txt_usuarioTarget, "Usuario Target"))
                return;

            if (g.CampoVazio(txt_senhaTarget, "Senha Target"))
                return;


            string  servidor = txt_servidorSource.Text;
                
            string  dataBase = txt_dataBaseSource.Text;

            string  usuario = txt_usuarioSource.Text;
            string  senha = txt_senhaSource.Text;

            string tabela = txt_tabelaSource.Text;

            Conexao conexaoTarget = new Conexao();
            Conexao conexaosource = new Conexao();
            if (cb_autentificacaoSource.Checked)
            {
               


                conexaosource.Connection(txt_servidorSource.Text,  txt_dataBaseSource.Text);
                
            }
            else {

                conexaosource.Connection(servidor, dataBase,usuario,senha);
            }
            if (cb_autentificacaoTarget.Checked)
            {



                conexaoTarget.Connection(txt_servidorTarget.Text , txt_dataBaseTarget.Text);

            }
            else
            {

                conexaoTarget.Connection(txt_servidorTarget.Text, txt_dataBaseTarget.Text, txt_usuarioTarget.Text, txt_senhaTarget.Text);
            }

            conexaosource.SqlConnection.Open();
            conexaoTarget.SqlConnection.Open();

            String consulta = "select * from "+ tabela;

            SqlCommand sqlCommand = new SqlCommand(consulta, conexaosource.SqlConnection);
            SqlDataReader reader = sqlCommand.ExecuteReader();
            DataTable data = new DataTable();
            data.Load(reader);

            SqlBulkCopy insert = new SqlBulkCopy(conexaoTarget.SqlConnection);



            string create = " create table " + txt_tabelaTarget.Text + "( ";
           
            foreach (DataColumn c in data.Columns)
            {
                string _tipo;
                 if (c.DataType.ToString() == "System.String")
                { 
                   
                    _tipo= SqlHelper.GetDbType(c.DataType).ToString() + "(max)"; 
                }
                else 
                {
                    _tipo=SqlHelper.GetDbType(c.DataType).ToString(); 
                }

                create += c.ColumnName + " " + _tipo + ",";
                insert.ColumnMappings.Add(c.ColumnName, c.ColumnName);


            }
                
            create = create.Substring(0, create.Length - 1) + ")";
           // MessageBox.Show(create);
                
            SqlCommand command = new SqlCommand(create, conexaoTarget.SqlConnection ) ;
            try
            { 
            command.ExecuteNonQuery();
            insert.DestinationTableName = txt_tabelaTarget.Text;
            insert.WriteToServer(data);

            MessageBox.Show("Ok");
            }
           catch(SqlException erro)
            {
              MessageBox.Show("Ocorreu um erro!\n" + erro.Message);
               

            }
           
           

        }
            
                   
    }


        

    }

