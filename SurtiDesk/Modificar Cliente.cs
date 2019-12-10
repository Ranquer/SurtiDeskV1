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
    public partial class Modificar_Cliente : Form
    {

        MySqlConnection conexion = new MySqlConnection("server=127.0.0.1; database=surtidesk; Uid=root; pwd=cococo;");
        public Modificar_Cliente()
        {
            InitializeComponent();
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
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
                MessageBox.Show("Error:" + error + "");
            }
        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonModificar_Click(object sender, EventArgs e)
        {
            try
            {
                conexion.Open();
                string query = "update cliente set nombre = @nombre, apellido = @apellido, telefono = @telefono, domicilio = @domicilio, email = @email, saldo = @saldo, limiteCredito = @limiteCredito where idCliente = @idCliente";
                MySqlCommand command = new MySqlCommand(query, conexion);
                command.Parameters.AddWithValue("@nombre", textNombre.Text.ToString());
                command.Parameters.AddWithValue("@apellido", textBoxApellidos.Text.ToString());
                command.Parameters.AddWithValue("@telefono", textBoxTelefono.Text.ToString());
                command.Parameters.AddWithValue("@domicilio", textBoxDomicilio.Text.ToString());
                command.Parameters.AddWithValue("@email", textBoxEmail.Text.ToString());
                command.Parameters.AddWithValue("@saldo", Convert.ToDouble(textBoxSaldo.Text.ToString()));
                command.Parameters.AddWithValue("@limiteCredito", Convert.ToDouble(textBoxLimiteDeCredito.Text.ToString()));
                command.Parameters.AddWithValue("@idCliente", Convert.ToInt32(textBoxNumeroDeCliente.Text.ToString()));
                command.ExecuteNonQuery();
                conexion.Close();
                this.Close();
            }
            catch (Exception error)
            {
                MessageBox.Show("error:" + error + "");
            }
        }
    }
}
