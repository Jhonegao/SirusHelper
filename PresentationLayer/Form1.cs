using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btn_Salvar_Click(object sender, EventArgs e)
        {
            
            //classe responsavel por realizar conexao fisica com banco de dados
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\entra21\Documents\dbSirus.mdf;Integrated Security=True;Connect Timeout=30"; 
            //classe responsavel por realizar um querry no DB
            SqlCommand command = new SqlCommand();

            try
            {
                connection.Open();
                command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                MessageBox.Show("DB Error");
                throw;
            }
            finally
            {
                //finaly sempre executa.
                connection.Close();
            }
        }
    }
}
