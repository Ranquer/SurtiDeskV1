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
        int idEmpleado, permisos;
        public Desktop(int idEmpleado, int permisos)
        {
            InitializeComponent();
            this.idEmpleado = idEmpleado;
            this.permisos = permisos;
        }

        private void registrarVentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(permisos == 5 || permisos == 0)
            {
                Registrar_Venta registrar_Venta = new Registrar_Venta(idEmpleado);
                registrar_Venta.Show();
                registrar_Venta.Focus();
            }
            else
            {
                MessageBox.Show("No tiene los permisos para ejecutar esta acción...");
            }
        }

        private void Desktop_Load(object sender, EventArgs e)
        {
            
        }

        private void modificarClienteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Buscar_Cliente buscar = new Buscar_Cliente();
            buscar.Show();
        }

        private void registrarClienteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Registrar_Cliente registrar = new Registrar_Cliente();
            registrar.Show();
        }

        private void ventasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cambiarIVAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cambiar_IVA nuevo = new Cambiar_IVA();
            nuevo.Show();
        }

        private void reporteDeVentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Consultar_Venta venta = new Consultar_Venta();
            venta.Show();
        }

        private void registrarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Registrar_Cliente registrar = new Registrar_Cliente();
            registrar.Show();
        }

        private void buscarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Buscar_Cliente buscar = new Buscar_Cliente();
            buscar.Show();
        }

        private void modificarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Modificar_Cliente modificar = new Modificar_Cliente();
            modificar.Show();
        }

        private void reporteDeClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reporte_Cliente reporte = new Reporte_Cliente();
            reporte.Show();
        }

        private void registrarProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Registrar_Producto reporte = new Registrar_Producto();
            reporte.Show();
        }

        private void buscarProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Buscar_Producto buscar = new Buscar_Producto();
            buscar.Show();
        }

        private void modificarProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Modificar_Producto modificar = new Modificar_Producto();
            modificar.Show();
        }

        private void reporteDeProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reporte_de_producto reporte = new Reporte_de_producto();
            reporte.Show();
        }

        private void modificarClienteToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Modificar_Cliente modificar = new Modificar_Cliente();
            modificar.Show();
        }

        private void reporteDeClienteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Reporte_Cliente reporte = new Reporte_Cliente();
            reporte.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 inicioSecion = new Form1();
            this.Close();
            inicioSecion.Show();
        }

        
    }
}
