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
            if (permisos ==  3|| permisos == 0)
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
            if (permisos == 1 || permisos == 0)
            {
                Buscar_Cliente buscar = new Buscar_Cliente();
                buscar.Show();
            }
            else
            {
                MessageBox.Show("No tiene los permisos para ejecutar esta acción...");
            }
        }

        private void registrarClienteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (permisos == 1 || permisos == 0)
            {
                Registrar_Cliente registrar = new Registrar_Cliente();
                registrar.Show();
            }
            else
            {
                MessageBox.Show("No tiene los permisos para ejecutar esta acción...");
            }
        }

        private void ventasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cambiarIVAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (permisos == 1 || permisos == 0 )
            {
                Cambiar_IVA nuevo = new Cambiar_IVA();
                nuevo.Show();

            }
            else
            {
                MessageBox.Show("No tiene los permisos para ejecutar esta acción...");
            }
        }

        private void reporteDeVentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (permisos == 1 || permisos == 0)
            {
                Consultar_Venta venta = new Consultar_Venta();
                venta.Show();
            }
            else
            {
                MessageBox.Show("No tiene los permisos para ejecutar esta acción...");
            }

        }

        private void registrarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (permisos == 2 || permisos == 0)
            {
                Registrar_Cliente registrar = new Registrar_Cliente();
                registrar.Show();
            }
            else
            {
                MessageBox.Show("No tiene los permisos para ejecutar esta acción...");
            }
        }

        private void buscarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (permisos == 1 || permisos == 0)
            {
                Buscar_Cliente buscar = new Buscar_Cliente();
                buscar.Show();
            }
            else
            {
                MessageBox.Show("No tiene los permisos para ejecutar esta acción...");
            }

        }

        private void modificarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (permisos == 1 || permisos == 0)
            {
                Modificar_Cliente modificar = new Modificar_Cliente();
                modificar.Show();

            }
            else
            {
                MessageBox.Show("No tiene los permisos para ejecutar esta acción...");
            }
        }

        private void reporteDeClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (permisos == 1 || permisos == 0)
            {

                Reporte_Cliente reporte = new Reporte_Cliente();
                reporte.Show();
            }
            else
            {
                MessageBox.Show("No tiene los permisos para ejecutar esta acción...");
            }
        }

        private void registrarProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (permisos == 2 || permisos == 0)
            {
                Registrar_Producto reporte = new Registrar_Producto();
                reporte.Show();

            }
            else
            {
                MessageBox.Show("No tiene los permisos para ejecutar esta acción...");
            }
        }

        private void buscarProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (permisos == 1 || permisos == 2 || permisos == 0)
            {
                Buscar_Producto buscar = new Buscar_Producto();
                buscar.Show();

            }
            else
            {
                MessageBox.Show("No tiene los permisos para ejecutar esta acción...");
            }
        }

        private void modificarProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (permisos == 2 || permisos == 0)
            {

                Modificar_Producto modificar = new Modificar_Producto();
                modificar.Show();
            }
            else
            {
                MessageBox.Show("No tiene los permisos para ejecutar esta acción...");
            }
        }

        private void reporteDeProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (permisos == 0 || permisos == 1)
            {
                Reporte_de_producto reporte = new Reporte_de_producto();
                reporte.Show();

            }
            else
            {
                MessageBox.Show("No tiene los permisos para ejecutar esta acción...");
            }
        }

        private void modificarClienteToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (permisos == 1 || permisos == 0)
            {
                Modificar_Cliente modificar = new Modificar_Cliente();
                modificar.Show();

            }
            else
            {
                MessageBox.Show("No tiene los permisos para ejecutar esta acción...");
            }
        }

        private void reporteDeClienteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (permisos == 1 || permisos == 0)
            {

                Reporte_Cliente reporte = new Reporte_Cliente();
                reporte.Show();
            }
            else
            {
                MessageBox.Show("No tiene los permisos para ejecutar esta acción...");
            }
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 inicioSecion = new Form1();
            this.Close();
            inicioSecion.Show();
        }


    }
}
