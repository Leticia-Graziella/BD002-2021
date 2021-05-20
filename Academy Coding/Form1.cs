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


             Conexao conexaosource = new Conexao();
            if (cb_autentificacaoSource.Checked)
            {
               


                conexaosource.Connection(servidor,  dataBase);
                
            }
            else {

                conexaosource.Connection(servidor, dataBase,usuario,senha);               
            }

            conexaosource.SqlConnection.Open();

               String consulta = "select * from "+ tabela;

            SqlCommand sqlCommand = new SqlCommand(consulta, conexaosource.SqlConnection);
            SqlDataReader reader = sqlCommand.ExecuteReader();
            DataTable data = new DataTable();
            data.Load(reader);

            string informacao = " ";
            foreach (DataRow r in data.Rows)
            {
                informacao += r[1].ToString();
            }
            MessageBox.Show(informacao);



        }
            
                   
    }


        

    }

