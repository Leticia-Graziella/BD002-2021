using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Academy_Coding
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
            string servidor = txt_servidorSource.Text;
                
            string dataBase = txt_dataBaseSouce.Text;

            string usuario = txt_usuarioSource.Text;
            string senha = txt_senhaSource.Text;

            string tabela = txt_tabelaSource.Text;

            Conexao conexaoTarget = new Conexao();
             Conexao conexaosource = new Conexao();
            if (cb_autentificacaoSource.Checked)
            {
               


                conexaosource.Connection(servidor,  dataBase);
                
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
                string tipo;
                 if (c.DataType.ToString() == "System.String")
                { 
                   
                    tipo= SqlHelper.GetDbType(c.DataType).ToString() + "(max)"; 
                }
                else 
                {
                    tipo=SqlHelper.GetDbType(c.DataType).ToString(); 
                }

                create += c.ColumnName + " " + tipo + ",";
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

