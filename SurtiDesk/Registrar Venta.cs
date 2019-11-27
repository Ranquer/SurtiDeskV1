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
        //DataSet dataset;
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
            if (reader.Read())
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
            comando = new MySqlCommand(String.Format("select * from empleado where idEmpleado = " + textBoxCodigoEmpleado.Text + ""), conexion);
            reader = comando.ExecuteReader();
            if (reader.Read())
            {
                textBoxNombreEmpleado.Text = reader["nombre"].ToString();
            }
            else
            {
                MessageBox.Show("Error");
            }
            conexion.Close();

            conexion.Open();
            comando = new MySqlCommand(String.Format("select * from IVA order by idIVA"), conexion);
            reader = comando.ExecuteReader();
            if (reader.Read())
            {
                textBoxIVA.Text = reader["porcentaje"].ToString();
            }
            conexion.Close();
        }

        private void textBoxRFCCliente_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                conexion.Open();
                MySqlCommand comando = new MySqlCommand(String.Format("select * from cliente where idCliente = " + textBoxRFCCliente.Text + ""), conexion);
                MySqlDataReader reader = comando.ExecuteReader();
                if (reader.Read())
                {
                    textBoxNombreCliente.Text = reader["nombre"].ToString();
                }
                else
                {
                    MessageBox.Show("Error");
                }
                conexion.Close();
            }
        }

        private void dataGridViewNota_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridViewNota_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            conexion.Open();
            if (dataGridViewNota.Rows[e.RowIndex].Cells[0].Value.ToString() != "")
            {
                MySqlCommand comando = new MySqlCommand(String.Format("select * from producto where idProducto = " + dataGridViewNota.CurrentCell.Value.ToString() + ""), conexion);
                MySqlDataReader reader = comando.ExecuteReader();
                if (reader.Read())
                {
                    dataGridViewNota.Rows[e.RowIndex].Cells[1].Value = reader["descripcion"].ToString();
                    dataGridViewNota.Rows[e.RowIndex].Cells[2].Value = reader["precio"].ToString();
                }
            }
            conexion.Close();
            if (dataGridViewNota.Rows[e.RowIndex].Cells[3].Value != null)
            {
                int valor = Int32.Parse(dataGridViewNota.Rows[e.RowIndex].Cells[2].Value.ToString()) * Int32.Parse(dataGridViewNota.Rows[e.RowIndex].Cells[3].Value.ToString());
                dataGridViewNota.Rows[e.RowIndex].Cells[4].Value = valor.ToString();

            }

            double total = 0;
            foreach (DataGridViewRow row in dataGridViewNota.Rows)
            {
                total += Convert.ToDouble(row.Cells["ImporteProducto"].Value);
            }
            double iva = (Convert.ToDouble(textBoxIVA.Text) / 100) + 1;
            textBoxSubTotal.Text = Convert.ToString(total);
            double total1 = total * iva;
            textBoxTotal.Text = Convert.ToString(total1);
        }

        private void textBoxSubTotal_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxIVA_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxTotal_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonVender_Click(object sender, EventArgs e)
        {
            //if(textBoxRFCCliente.Text == "")
            //{
            //    MessageBox.Show("¡¡Ingrese por favor el numero del cliente!!");
            //}
            //else
            //{
            //    if (comboBoxMetodoDePago != null)
            //    {
            //        conexion.Open();
                    
            //        string query = "insert into venta(folio, fecha, total, idEmpleado, idCliente, idIVA, metodoPago) values(" + textBoxFolio.Text.ToString() + ", " + textBoxFecha.Text.ToString() + ", " + textBoxTotal.Text.ToString() + ", " + textBoxCodigoEmpleado.Text.ToString() + ", " + textBoxRFCCliente.Text.ToString() + ", " + textBoxIVA.Text.ToString() + ", " + comboBoxMetodoDePago.Text.ToString(); + " )";
            //        MySqlCommand comando = new MySqlCommand(query, conexion);
            //        comando.ExecuteNonQuery();
            //        conexion.Close();
            //    }
            //}
        }

        private void guardarDetalleVenta()
        {
            //int idProducto;
            //int cantidad;
            //float precioVenta;
            //conexion.Open();
            //string query = "insert into detalle_venta(@folio, @idProducto, @cantidad, @precio) values()";
            //MySqlCommand comando = new MySqlCommand(query, conexion);

            //conexion.Close();
        }
    }
}
