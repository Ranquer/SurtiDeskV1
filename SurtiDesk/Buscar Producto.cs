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
using System.IO;
using System.Drawing.Imaging;

namespace SurtiDesk
{
    public partial class Buscar_Producto : Form
    {
        MySqlConnection conexion = new MySqlConnection("server=127.0.0.1; database=surtidesk; Uid=root; pwd=cococo;");
        public Buscar_Producto()
        {
            InitializeComponent();
        }


        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                conexion.Open();
                string query = "select * from producto where idProducto = " + textBoxCodigoDeProducto.Text.ToString() + "";
                MySqlCommand command = new MySqlCommand(query, conexion);
                MySqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    textBoxDescripcion.Text = reader["descripcion"].ToString();
                    textBoxPrecio.Text = reader["precio"].ToString();
                    textBoxStock.Text = reader["stock"].ToString();
                    textBoxStockMinimo.Text = reader["stockMinimo"].ToString();
                    textBoxStockMaximo.Text = reader["stockMaximo"].ToString();
                    byte[] arraimag = (byte[])command.ExecuteScalar();
                    MemoryStream memory = new MemoryStream(arraimag);
                    Image img = Image.FromStream(memory);
                    pictureBoxProducto.Image = img;

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
    }
}
