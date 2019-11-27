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
        MySqlConnection conexion = new MySqlConnection("server=127.0.0.1; database=surtidesk; Uid=root; pwd=cococo;");

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
            
            MySqlCommand codigo = new MySqlCommand();

            conexion.Open();
            codigo.Connection = conexion;
            codigo.CommandText = ("select *from Empleado where idEmpleado = '" + textCodigoEmpleado.Text + "' and contra = '" + textContraseña.Text + "'");


            MySqlDataReader leer = codigo.ExecuteReader();
            if (leer.Read())
            {
                Desktop deskt = new Desktop(Int32.Parse(textCodigoEmpleado.Text));
                this.Hide();
                deskt.Show();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrecto");
            }

            conexion.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
