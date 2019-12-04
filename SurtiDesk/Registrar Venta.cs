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
        int idIVA;
        List<int> vs = new List<int>();
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
            if (textBoxRFCCliente.Text == "")
            {
                textBoxNombreCliente.Text = "";
            }
            else
            {
                conexion.Open();
                MySqlCommand cmd = new MySqlCommand(String.Format("select * from cliente where idCliente = " + textBoxRFCCliente.Text + ""), conexion);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    textBoxNombreCliente.Text = reader["nombre"].ToString();
                }
                else
                {
                    textBoxNombreCliente.Clear();
                }
                conexion.Close();
            }
        }
        private void Registrar_Venta_Load(object sender, EventArgs e)
        {
            conexion.Open();
            int folio;
            MySqlCommand comando = new MySqlCommand(String.Format("select * from venta order by folio desc"), conexion);
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
            textBoxFecha.Text = DateTime.Now.ToString("dd/MM/yyyy");
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
                idIVA = Int32.Parse(reader["idIVA"].ToString());
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
        public bool buscarElementoList(List<int> list, int elemento)
        {
            for(int i=0;i<list.Count();i++)
            {
                if(list[i]==elemento)
                {
                    return true;
                }
            }
            return false;
        }
        private void dataGridViewNota_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (buscarElementoList(vs, Convert.ToInt32(dataGridViewNota.Rows[e.RowIndex].Cells[0].Value)) == false && dataGridViewNota.CurrentCell.Value != null)
                {
                    string query = "select * from producto where idProducto = " + dataGridViewNota.CurrentCell.Value.ToString() + "";
                    conexion.Open();
                    int id = Convert.ToInt32(dataGridViewNota.CurrentCell.Value);
                    vs.Add(id);
                    MySqlCommand command = new MySqlCommand(query, conexion);
                    MySqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        dataGridViewNota.Rows[e.RowIndex].Cells[1].Value = reader["descripcion"].ToString();
                        dataGridViewNota.Rows[e.RowIndex].Cells[2].Value = reader["precio"].ToString();
                    }
                    else
                    {
                        dataGridViewNota.CurrentCell.Value = null;
                    }
                    conexion.Close();
                }
                else if (dataGridViewNota.CurrentCell.Value == null)
                {
                    dataGridViewNota.Rows[e.RowIndex].Cells[1].Value = null;
                    dataGridViewNota.Rows[e.RowIndex].Cells[2].Value = null;
                }
                else 
                {
                    dataGridViewNota.CurrentCell.Value = null;
                    MessageBox.Show("Elemento ya existente");
                }
                if (dataGridViewNota.Rows[e.RowIndex].Cells[3].Value != null)
                {
                    int valorI = Int32.Parse(dataGridViewNota.Rows[e.RowIndex].Cells[2].Value.ToString()) * Int32.Parse(dataGridViewNota.Rows[e.RowIndex].Cells[3].Value.ToString());
                    dataGridViewNota.Rows[e.RowIndex].Cells[4].Value = valorI.ToString();

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
            catch (Exception error)
            {
                MessageBox.Show("Error: " + error + "");
            }
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
            if(textBoxNombreCliente.Text == "")
            {
                MessageBox.Show("Porfavor Ingrese un RFC de cliente  valido...");
            }
            else
            {
                if(comboBoxMetodoDePago.Text == "")
                {
                    MessageBox.Show("Favor de introducir un metodo de pago...");
                }
                else
                {
                    conexion.Open();
                    string metodoPago = comboBoxMetodoDePago.Text.ToString();
                    string query = "insert into venta values(@folio, @fecha, @total, @idEmpleado, @idCliente, @idIVA, @sistemaDePago)";
                    MySqlCommand cmd = new MySqlCommand(query, conexion);
                    cmd.Parameters.AddWithValue("@folio", Convert.ToInt32(textBoxFolio.Text));
                    cmd.Parameters.AddWithValue("@fecha", Convert.ToString(DateTime.Now.ToString("yyyy/MM/dd")));
                    cmd.Parameters.AddWithValue("@total", Convert.ToDouble(textBoxTotal.Text));
                    cmd.Parameters.AddWithValue("@idEmpleado", Convert.ToInt32(textBoxCodigoEmpleado.Text));
                    cmd.Parameters.AddWithValue("@idCliente", Convert.ToInt32(textBoxRFCCliente.Text));
                    cmd.Parameters.AddWithValue("@idIVA", Convert.ToInt32(textBoxIVA.Text));
                    cmd.Parameters.AddWithValue("@sistemaDePago",  Convert.ToInt32(comboBoxMetodoDePago.SelectedIndex.ToString()));
                    cmd.ExecuteNonQuery();
                    conexion.Close();
                    guardarDetalleVenta();
                }
            }
            limpiarTodo();
        }
        private int tipoPago(string tipopago)
        {
            int opc = 0;
            switch(tipopago)
            {
                case "Efectivo":
                    opc = 1;
                    break;
                case "Credito":
                    opc = 2;
                    break;
                case "Pago con Tarjeta":
                    opc = 3;
                    break;
                case "Puntos":
                    opc = 4;
                    break;
                case "Vales de despensa":
                    opc = 5;
                    break;
                case "Pagos mixtos":
                    opc = 6;
                    break;
            }
            return opc;
        }
        private string tipoPago(int tipoPago)
        {
            string opc =  null;
            switch(tipoPago)
            {
                case 1:
                    opc = "Efectivo";
                    break;
                case 2:
                    opc = "Credito";
                    break;
                case 3:
                    opc = "Pago con Tarjeta";
                    break;
                case 4:
                    opc = "Puntos";
                    break;
                case 5:
                    opc = "Vales de despensa";
                    break;
                case 6:
                    opc = "Pagos mixto";
                    break;
            }
            return opc;
        }
        private void guardarDetalleVenta()
        {
            conexion.Open();
            string query = "insert into detalle_venta values(@folio, @idProducto, @cantidad, @precio)";
            MySqlCommand cmd = new MySqlCommand(query, conexion);
            try
            {
                foreach (DataGridViewRow row in dataGridViewNota.Rows)
                {
                    cmd.Parameters.Clear();
                    if (Convert.ToInt32(row.Cells["CodigoProducto"].Value) != 0)
                    {
                        cmd.Parameters.AddWithValue("@folio", textBoxFolio.Text.ToString());
                        cmd.Parameters.AddWithValue("@idProducto", Convert.ToInt32(row.Cells["CodigoProducto"].Value));
                        cmd.Parameters.AddWithValue("@cantidad", Convert.ToInt32(row.Cells["CantidadProducto"].Value));
                        cmd.Parameters.AddWithValue("@precio", Convert.ToInt32(row.Cells["PrecioProducto"].Value));
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch(Exception error)
            {
                MessageBox.Show("Error: " + error + "");
            }
            conexion.Close();
        }
        private void limpiarTodo()
        {
            while (dataGridViewNota.Rows.Count > 1)
            {
                dataGridViewNota.Rows.Remove(dataGridViewNota.CurrentRow);
            }
            textBoxRFCCliente.Clear();
            textBoxNombreCliente.Clear();
            comboBoxMetodoDePago.SelectedIndex = -1;
            Registrar_Venta_Load(this, null);
        }
        private void dataGridViewNota_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
