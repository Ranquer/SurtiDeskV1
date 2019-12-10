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
    public partial class Registrar_Cliente : Form
    {
        MySqlConnection conexion = new MySqlConnection("server=127.0.0.1; database=surtidesk; Uid=root; pwd=cococo;");
        public Registrar_Cliente()
        {
            InitializeComponent();
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                conexion.Open();
                string query = "insert into cliente values(@idCliente, @nombre, @apellido, @telefono, @domicilio, @email, @saldo, @limiteCredito)";
                MySqlCommand command = new MySqlCommand(query, conexion);
                command.Parameters.AddWithValue("@idCliente", Convert.ToInt32(textBoxIdCliente.Text));
                command.Parameters.AddWithValue("@nombre", textBoxNombreCliente.Text.ToString());
                command.Parameters.AddWithValue("@apellido", Convert.ToString(textBoxApellido.Text));
                command.Parameters.AddWithValue("@telefono", textBoxTelefono.Text.ToString());
                command.Parameters.AddWithValue("@domicilio", textBoxDomicilio.Text.ToString());
                command.Parameters.AddWithValue("@email", textBoxEmail.Text.ToString());
                command.Parameters.AddWithValue("@saldo", 0.0);
                command.Parameters.AddWithValue("@limiteCredito", Convert.ToDouble(textBoxLimiteDeCredito.Text.ToString()));
                command.ExecuteNonQuery();
                conexion.Close();
                this.Close();
            }
            catch(Exception error)
            {
                MessageBox.Show("Error "+error+"");
                this.Close();
            }
        }

        private void Registrar_Cliente_Load(object sender, EventArgs e)
        {
            try
            {
                conexion.Open();
                string query = "select * from cliente order by idCliente desc";
                MySqlCommand command = new MySqlCommand(query, conexion);
                MySqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    int folio = Convert.ToInt32(reader["idCliente"].ToString()) + 1;
                    textBoxIdCliente.Text = folio.ToString();
                }
                else
                {
                    
                }
                conexion.Close();
            }
            catch (Exception error)
            {
                textBoxIdCliente.Text = "1";
                conexion.Close();
            }
        }
    }
}
