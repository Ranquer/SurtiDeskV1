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

        public Registrar_Venta()
        {
            InitializeComponent();
        }

        private void dataGridViewNota_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBoxFolio_TextChanged(object sender, EventArgs e)
        {
            conexion.Open();
            MySqlCommand mySqlCommand = new MySqlCommand("slect * from venta order by id desc limit 1");
            MySqlDataReader registro = mySqlCommand.ExecuteReader();

            if(registro.Read())
            {

            }
            else
            {

            }
        }
    }
}
