using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace AcademyCoding
{
    public partial class ITelaInicial : Form
    {
        public ITelaInicial()
        {
            InitializeComponent();
        }

        private void cb_autentificacaoSource_Click_1(object sender, EventArgs e)
        {
            if (cb_autentificacaoSource.Checked)
            {
                txt_usuarioSource.Enabled = false;
                lb_usuarioSource.Enabled = false;
            }
            else 
            {
                txt_usuarioSource.Enabled = true;
                lb_usuarioSource.Enabled = true;
            }

            if (cb_autentificacaoSource.Checked)
            {
                
                txt_senhaSource.Enabled = false;
                lb_senhaSource.Enabled = false;
            }
            else
            {
                txt_senhaSource.Enabled = true;
                lb_senhaSource.Enabled = true;
            }
                
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
                lb_usuarioTarget.Enabled = false;
            }
            else
            {
                txt_usuarioTarget.Enabled = true;
                lb_usuarioTarget.Enabled = true;

            }

            if (cb_autentificacaoTarget.Checked)
            {

                txt_senhaTarget.Enabled = false;
                lb_senhaTarget.Enabled = false;
            }
            else
            {
                txt_senhaTarget.Enabled = true;
                lb_senhaTarget.Enabled = true;
            }

        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            Gerais g = new Gerais();

            if (g.CampoVazio(txt_servidorSource, "Servidor Source"))
                return;

            if (g.CampoVazio(txt_dataBaseSource, "DataBase Source"))
                return;

            if (g.CampoVazio(txt_tabelaSource, "Tabela Source"))
                return;
            if (!(cb_autentificacaoTarget.Checked))
            {
                if (g.CampoVazio(txt_usuarioSource, "Usuario Source"))
                    return;
                if (g.CampoVazio(txt_senhaSource, "Senha Source"))
                    return;
            }



            if (g.CampoVazio(txt_servidorTarget, "Servidor Target"))
                return;

            if (g.CampoVazio(txt_dataBaseTarget, "DataBase Target"))
                return;

            if (g.CampoVazio(txt_tabelaTarget, "Tabela Target"))
                return;
            if (!(cb_autentificacaoTarget.Checked))
            {
                if (g.CampoVazio(txt_usuarioTarget, "Usuario Target"))
                    return;

                if (g.CampoVazio(txt_senhaTarget, "Senha Target"))
                    return;
            }


            Conexao conexaoTarget = new Conexao();
            Conexao conexaoSource = new Conexao();

            if (cb_autentificacaoSource.Checked)
            {
                conexaoSource.Connection(txt_servidorSource.Text, txt_dataBaseSource.Text);
            }
            else
            {
                conexaoSource.Connection(txt_servidorSource.Text, txt_dataBaseSource.Text, txt_usuarioSource.Text, txt_senhaSource.Text);
            }

            if (cb_autentificacaoTarget.Checked)
            {
                conexaoTarget.Connection(txt_servidorTarget.Text, txt_dataBaseTarget.Text);
            }
            else
            {
                conexaoTarget.Connection(txt_servidorTarget.Text, txt_dataBaseTarget.Text, txt_usuarioTarget.Text, txt_senhaTarget.Text);
            }

            try
            {
                conexaoSource.sqlConnection.Open();
                conexaoTarget.sqlConnection.Open();

                String consulta = "select * from " + txt_tabelaSource.Text;

                SqlCommand sqlCommand = new SqlCommand(consulta, conexaoSource.sqlConnection);
                SqlDataReader reader = sqlCommand.ExecuteReader();
                DataTable data = new DataTable();
                data.Load(reader);

                SqlBulkCopy insert = new SqlBulkCopy(conexaoTarget.sqlConnection);

                string create = " create table " + txt_tabelaTarget.Text + "( ";

                foreach (DataColumn c in data.Columns)
                {
                    string tipo;
                    if (c.DataType.ToString() == "System.String")
                    {
                        tipo = SqlHelper.GetDbType(c.DataType).ToString() + "(max)";
                    }
                    else
                    {
                        tipo = SqlHelper.GetDbType(c.DataType).ToString();
                    }

                    create += c.ColumnName + " " + tipo + ",";
                    insert.ColumnMappings.Add(c.ColumnName, c.ColumnName);

                }

                create = create.Substring(0, create.Length - 1) + ")";

                SqlCommand command = new SqlCommand(create, conexaoTarget.sqlConnection);

                command.ExecuteNonQuery();
                insert.DestinationTableName = txt_tabelaTarget.Text;
                insert.WriteToServer(data);

                insert.Close();
                reader.Close();
                conexaoSource.sqlConnection.Close();
                conexaoTarget.sqlConnection.Close();
                MessageBox.Show("Tabela " +"'" + txt_tabelaTarget.Text+ "'" + " salva com sucesso!!");
                }
                 catch (SqlException erro)
                {
                 MessageBox.Show("Ocorreu um erro!\n" + erro.Message);
                 }
            }
    }
  }

