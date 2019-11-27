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
    public partial class Registrar_Venta : Form
    {
        MySqlConnection conexion = new MySqlConnection("server=127.0.0.1; database=surtidesk; Uid=root; pwd=cococo;");
        int idEmpleado;
        public Registrar_Venta(int idEmpleado)
        {
            InitializeComponent();
            this.idEmpleado = idEmpleado;
        }

        private void dataGridViewNota_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBoxFolio_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBoxRFCCliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void Registrar_Venta_Load(object sender, EventArgs e)
        {
            conexion.Open();
            int folio;
            MySqlCommand comando = new MySqlCommand(String.Format("select * from venta order by folio"), conexion);
            MySqlDataReader reader = comando.ExecuteReader();
            if(reader.Read())
            {
                textBoxFolio.Text = reader["folio"].ToString();                
                folio = Int32.Parse(textBoxFolio.Text) + 1;
                textBoxFolio.Text = folio.ToString();

            }
            else
            {
                textBoxFolio.Text = "1";
            }
            reader.Close();
            textBoxFecha.Text = DateTime.Now.ToString("d");
            textBoxCodigoEmpleado.Text = idEmpleado.ToString();
            comando = new MySqlCommand(String.Format("select * from empleado where idEmpleado = "+textBoxCodigoEmpleado.Text+""), conexion);
            reader = comando.ExecuteReader();
            if(reader.Read())
            {
                textBoxNombreEmpleado.Text = reader["nombre"].ToString();
            }
            else
            {
                MessageBox.Show("Error");
            }
            conexion.Close();
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            conexion.Open();
            MySqlCommand comando = new MySqlCommand(String.Format("select * from cliente where idCliente = "+textBoxRFCCliente.Text+""), conexion);
            MySqlDataReader reader = comando.ExecuteReader();
            if(reader.Read())
            {
                textBoxNombreCliente.Text = reader["nombre"].ToString();
            }
            else
            {
                MessageBox.Show("El cliente no existe...");
            }
            conexion.Close();
        }
    }
}
