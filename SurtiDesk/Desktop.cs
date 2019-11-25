using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SurtiDesk
{
    public partial class Desktop : Form
    {
        public Desktop()
        {
            InitializeComponent();
        }

        private void registrarVentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Registrar_Venta registrar_Venta = new Registrar_Venta();
            registrar_Venta.Show();
            registrar_Venta.Focus();
        }

        private void Desktop_Load(object sender, EventArgs e)
        {
            
        }

        private void modificarClienteToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void registrarClienteToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 inicioSecion = new Form1();
            this.Close();
            inicioSecion.Show();
        }

        
    }
}
