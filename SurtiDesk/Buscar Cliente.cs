using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SurtiDesk
{
    public partial class Buscar_Cliente : Form
    {
        MySqlConnection conexion = new MySqlConnection("server=127.0.0.1; database=surtidesk; Uid=root; pwd=cococo;");
        public Buscar_Cliente()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                conexion.Open();
                string query = "select * from cliente where idCliente = " + textBoxNumeroDeCliente.Text.ToString() + "";
                MySqlCommand command = new MySqlCommand(query, conexion);
                MySqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    textNombre.Text = reader["nombre"].ToString();
                    textBoxApellidos.Text = reader["apellido"].ToString();
                    textBoxTelefono.Text = reader["telefono"].ToString();
                    textBoxDomicilio.Text = reader["domicilio"].ToString();
                    textBoxEmail.Text = reader["email"].ToString();
                    textBoxSaldo.Text = reader["saldo"].ToString();
                    textBoxLimiteDeCredito.Text = reader["limiteCredito"].ToString();
                }
                else
                {
                    MessageBox.Show("El cliente que busca no existe...");
                }

                conexion.Close();
            }
            catch (Exception error)
            {
                MessageBox.Show("Error:"+error+"");
            }
        }
    }
}
