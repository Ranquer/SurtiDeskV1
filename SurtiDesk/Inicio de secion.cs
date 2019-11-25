using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SurtiDesk.mysql;
using MySql.Data.MySqlClient;

namespace SurtiDesk
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void buttonEntrar_Click(object sender, EventArgs e)
        {
            string usser;
            usser = textCodigoEmpleado.Text;
            string pass;
            pass = textContraseña.Text;
            Desktop deskt = new Desktop();
            MySqlConnection conexion = new MySqlConnection("server=127.0.0.1; database=surtidesk; Uid=root; pwd=cococo;");
            conexion.Open();

            MySqlCommand codigo = new MySqlCommand();
            MySqlConnection conecta = new MySqlConnection();

            codigo.Connection = conexion;
            codigo.CommandText = ("select *from Empleado where idEmpleado = '" + usser + "' and contra = '" + pass + "'");

            MySqlDataReader leer = codigo.ExecuteReader();
            if (leer.Read())
            {
                this.Hide();
                deskt.Show();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrecto");
            }
            conexion.Close();
        }
    }
}
