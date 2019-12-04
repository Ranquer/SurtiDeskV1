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
    public partial class Cambiar_IVA : Form
    {
        MySqlConnection conexion = new MySqlConnection("server=127.0.0.1; database=surtidesk; Uid=root; pwd=cococo;");


        public Cambiar_IVA()
        {
            InitializeComponent();
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            conexion.Open();
            MySqlCommand cmd = new MySqlCommand("INSERT INTO iva VALUES(@idIVA,@porcentaje,@vigencia)",conexion);
            cmd.Parameters.AddWithValue("@idIVA", Convert.ToInt32(textBoxidIVA.Text));
            cmd.Parameters.AddWithValue("@porcentaje", Convert.ToDouble(textBoxPorcentaje.Text));
            cmd.Parameters.AddWithValue("@vigencia", Convert.ToString(DateTime.Now.ToString("yyyy/MM/dd")));
            cmd.ExecuteNonQuery();
            conexion.Close();
            this.Close();
        }

        private void Cambiar_IVA_Load(object sender, EventArgs e)
        {
            conexion.Open();
            MySqlCommand cmd = new MySqlCommand("select * from iva order by idIVA desc", conexion);
            MySqlDataReader read = cmd.ExecuteReader();
            if (read.Read())
            {
                textBoxidIVA.Text = Convert.ToString(Convert.ToInt32(read["idIVA"].ToString()) + 1);
                textBoxVigencia.Text = DateTime.Now.ToString("dd/MM/yyyy");
            }
            conexion.Close();
        }
    }
}
