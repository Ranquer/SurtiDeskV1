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
    public partial class Registrar_Producto : Form
    {
        MySqlConnection conexion = new MySqlConnection("server=127.0.0.1; database=surtidesk; Uid=root; pwd=cococo;");
        public Registrar_Producto()
        {
            InitializeComponent();
        }

        private void buttonSubirImagen_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog getFile = new OpenFileDialog();
                getFile.InitialDirectory = "C:\\Users\\chemb\\OneDrive\\Desktop\\SurtiDeskV1\\Recursos";
                getFile.Filter = "Archivos de Imagen (*.jpg)(*.jpeg)|*.jpg;*.jpeg|PNG (*.png)|*.png| Todos los archivos|*.*";
                if (getFile.ShowDialog() == DialogResult.OK)
                {
                    pictureBoxProducto.Image = Image.FromFile(getFile.FileName);
                    //getFile.FileName; ruta
                }
            }
            catch(Exception error)
            {
                MessageBox.Show("Error: " + error + "");
            }
        }
        private void Registrar_Producto_Load(object sender, EventArgs e)
        {
            try
            {
                conexion.Open();
                string query = "select * from producto order by idProducto desc";
                MySqlCommand command = new MySqlCommand(query, conexion);
                MySqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    int folio = Convert.ToInt32(reader["idCliente"].ToString()) + 1;
                    textBoxCodigoDeProducto.Text = folio.ToString();
                }
                else
                {
                    textBoxCodigoDeProducto.Text = "1";
                }
                conexion.Close();
            }
            catch (Exception error)
            {
                textBoxCodigoDeProducto.Text = "1";
                conexion.Close();
            }
        }
        private void buttonSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void buttonRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                if(textBoxCodigoDeProducto.Text == "" || textBoxDescripcion.Text == "" || textBoxPrecio.Text == "" || textBoxStock.Text == "" || textBoxStockMinimo.Text == "" || textBoxStockMaximo.Text == "" || pictureBoxProducto.Image == null)
                {
                    MessageBox.Show("Falta algun elemento por rellenar...");
                }
                else
                {
                    conexion.Open();
                    string query = "insert into producto values(@idProducto, @descripcion, @precio, @stock, @stockMinimo, @stockMaximo, @imagenProducto)";
                    MySqlCommand command = new MySqlCommand(query, conexion);
                    MemoryStream memoryStream = new MemoryStream();
                    pictureBoxProducto.Image.Save(memoryStream, ImageFormat.Jpeg);
                    byte[] abyte = memoryStream.ToArray();
                    command.Parameters.AddWithValue("@idProducto", Convert.ToInt32(textBoxCodigoDeProducto.Text));
                    command.Parameters.AddWithValue("@descripcion", textBoxDescripcion.Text.ToString());
                    command.Parameters.AddWithValue("@precio", Convert.ToDouble(textBoxPrecio.Text));
                    command.Parameters.AddWithValue("@stock", Convert.ToInt32(textBoxPrecio.Text));
                    command.Parameters.AddWithValue("@stockMinimo", Convert.ToInt32(textBoxStockMinimo.Text));
                    command.Parameters.AddWithValue("@stockMaximo", Convert.ToInt32(textBoxStockMaximo.Text));
                    command.Parameters.AddWithValue("@imagenProducto", abyte );
                    int i;
                    i = command.ExecuteNonQuery();
                    if (i>0)
                    {
                        MessageBox.Show("datos guardados correctamente");
                    }
                    
                    conexion.Close();
                }
            }
            catch(Exception error)
            {
                MessageBox.Show("Error: " + error + "");
            }
        }
    }
}
