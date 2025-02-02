﻿namespace SurtiDesk
{
    partial class Desktop
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuPrincipal = new System.Windows.Forms.MenuStrip();
            this.ventasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarVentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteDeVentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cambiarIVAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.empleadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteDeClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarProductoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarProductoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarProductoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteDeProductoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.empleadosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarClienteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarClienteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarClienteToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteDeClienteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuPrincipal
            // 
            this.menuPrincipal.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ventasToolStripMenuItem,
            this.empleadosToolStripMenuItem,
            this.productosToolStripMenuItem,
            this.empleadosToolStripMenuItem1,
            this.salirToolStripMenuItem});
            this.menuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.menuPrincipal.Name = "menuPrincipal";
            this.menuPrincipal.Size = new System.Drawing.Size(1264, 24);
            this.menuPrincipal.TabIndex = 0;
            this.menuPrincipal.Text = "menuStrip1";
            // 
            // ventasToolStripMenuItem
            // 
            this.ventasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarVentaToolStripMenuItem,
            this.reporteDeVentaToolStripMenuItem,
            this.cambiarIVAToolStripMenuItem});
            this.ventasToolStripMenuItem.Name = "ventasToolStripMenuItem";
            this.ventasToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.ventasToolStripMenuItem.Text = "Ventas";
            this.ventasToolStripMenuItem.Click += new System.EventHandler(this.ventasToolStripMenuItem_Click);
            // 
            // registrarVentaToolStripMenuItem
            // 
            this.registrarVentaToolStripMenuItem.Name = "registrarVentaToolStripMenuItem";
            this.registrarVentaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.registrarVentaToolStripMenuItem.Text = "Registrar Venta";
            this.registrarVentaToolStripMenuItem.Click += new System.EventHandler(this.registrarVentaToolStripMenuItem_Click);
            // 
            // reporteDeVentaToolStripMenuItem
            // 
            this.reporteDeVentaToolStripMenuItem.Name = "reporteDeVentaToolStripMenuItem";
            this.reporteDeVentaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.reporteDeVentaToolStripMenuItem.Text = "Reporte de venta";
            this.reporteDeVentaToolStripMenuItem.Click += new System.EventHandler(this.reporteDeVentaToolStripMenuItem_Click);
            // 
            // cambiarIVAToolStripMenuItem
            // 
            this.cambiarIVAToolStripMenuItem.Name = "cambiarIVAToolStripMenuItem";
            this.cambiarIVAToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cambiarIVAToolStripMenuItem.Text = "Cambiar IVA";
            this.cambiarIVAToolStripMenuItem.Click += new System.EventHandler(this.cambiarIVAToolStripMenuItem_Click);
            // 
            // empleadosToolStripMenuItem
            // 
            this.empleadosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarClienteToolStripMenuItem,
            this.buscarClienteToolStripMenuItem,
            this.modificarClienteToolStripMenuItem,
            this.reporteDeClienteToolStripMenuItem});
            this.empleadosToolStripMenuItem.Name = "empleadosToolStripMenuItem";
            this.empleadosToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.empleadosToolStripMenuItem.Text = "Clientes";
            // 
            // registrarClienteToolStripMenuItem
            // 
            this.registrarClienteToolStripMenuItem.Name = "registrarClienteToolStripMenuItem";
            this.registrarClienteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.registrarClienteToolStripMenuItem.Text = "Registrar Cliente";
            this.registrarClienteToolStripMenuItem.Click += new System.EventHandler(this.registrarClienteToolStripMenuItem_Click);
            // 
            // buscarClienteToolStripMenuItem
            // 
            this.buscarClienteToolStripMenuItem.Name = "buscarClienteToolStripMenuItem";
            this.buscarClienteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.buscarClienteToolStripMenuItem.Text = "Buscar Cliente";
            this.buscarClienteToolStripMenuItem.Click += new System.EventHandler(this.buscarClienteToolStripMenuItem_Click);
            // 
            // modificarClienteToolStripMenuItem
            // 
            this.modificarClienteToolStripMenuItem.Name = "modificarClienteToolStripMenuItem";
            this.modificarClienteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.modificarClienteToolStripMenuItem.Text = "Modificar Cliente";
            this.modificarClienteToolStripMenuItem.Click += new System.EventHandler(this.modificarClienteToolStripMenuItem_Click);
            // 
            // reporteDeClienteToolStripMenuItem
            // 
            this.reporteDeClienteToolStripMenuItem.Name = "reporteDeClienteToolStripMenuItem";
            this.reporteDeClienteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.reporteDeClienteToolStripMenuItem.Text = "Reporte de Cliente";
            this.reporteDeClienteToolStripMenuItem.Click += new System.EventHandler(this.reporteDeClienteToolStripMenuItem_Click);
            // 
            // productosToolStripMenuItem
            // 
            this.productosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarProductoToolStripMenuItem,
            this.buscarProductoToolStripMenuItem,
            this.modificarProductoToolStripMenuItem,
            this.reporteDeProductoToolStripMenuItem});
            this.productosToolStripMenuItem.Name = "productosToolStripMenuItem";
            this.productosToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.productosToolStripMenuItem.Text = "Productos";
            // 
            // registrarProductoToolStripMenuItem
            // 
            this.registrarProductoToolStripMenuItem.Name = "registrarProductoToolStripMenuItem";
            this.registrarProductoToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.registrarProductoToolStripMenuItem.Text = "Registrar Producto";
            this.registrarProductoToolStripMenuItem.Click += new System.EventHandler(this.registrarProductoToolStripMenuItem_Click);
            // 
            // buscarProductoToolStripMenuItem
            // 
            this.buscarProductoToolStripMenuItem.Name = "buscarProductoToolStripMenuItem";
            this.buscarProductoToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.buscarProductoToolStripMenuItem.Text = "Buscar Producto";
            this.buscarProductoToolStripMenuItem.Click += new System.EventHandler(this.buscarProductoToolStripMenuItem_Click);
            // 
            // modificarProductoToolStripMenuItem
            // 
            this.modificarProductoToolStripMenuItem.Name = "modificarProductoToolStripMenuItem";
            this.modificarProductoToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.modificarProductoToolStripMenuItem.Text = "Modificar Producto";
            this.modificarProductoToolStripMenuItem.Click += new System.EventHandler(this.modificarProductoToolStripMenuItem_Click);
            // 
            // reporteDeProductoToolStripMenuItem
            // 
            this.reporteDeProductoToolStripMenuItem.Name = "reporteDeProductoToolStripMenuItem";
            this.reporteDeProductoToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.reporteDeProductoToolStripMenuItem.Text = "Reporte de Producto";
            this.reporteDeProductoToolStripMenuItem.Click += new System.EventHandler(this.reporteDeProductoToolStripMenuItem_Click);
            // 
            // empleadosToolStripMenuItem1
            // 
            this.empleadosToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarClienteToolStripMenuItem1,
            this.modificarClienteToolStripMenuItem1,
            this.modificarClienteToolStripMenuItem2,
            this.reporteDeClienteToolStripMenuItem1});
            this.empleadosToolStripMenuItem1.Name = "empleadosToolStripMenuItem1";
            this.empleadosToolStripMenuItem1.Size = new System.Drawing.Size(77, 20);
            this.empleadosToolStripMenuItem1.Text = "Empleados";
            // 
            // registrarClienteToolStripMenuItem1
            // 
            this.registrarClienteToolStripMenuItem1.Name = "registrarClienteToolStripMenuItem1";
            this.registrarClienteToolStripMenuItem1.Size = new System.Drawing.Size(171, 22);
            this.registrarClienteToolStripMenuItem1.Text = "Registrar Cliente";
            this.registrarClienteToolStripMenuItem1.Click += new System.EventHandler(this.registrarClienteToolStripMenuItem1_Click);
            // 
            // modificarClienteToolStripMenuItem1
            // 
            this.modificarClienteToolStripMenuItem1.Name = "modificarClienteToolStripMenuItem1";
            this.modificarClienteToolStripMenuItem1.Size = new System.Drawing.Size(171, 22);
            this.modificarClienteToolStripMenuItem1.Text = "Buscar Cliente";
            this.modificarClienteToolStripMenuItem1.Click += new System.EventHandler(this.modificarClienteToolStripMenuItem1_Click);
            // 
            // modificarClienteToolStripMenuItem2
            // 
            this.modificarClienteToolStripMenuItem2.Name = "modificarClienteToolStripMenuItem2";
            this.modificarClienteToolStripMenuItem2.Size = new System.Drawing.Size(180, 22);
            this.modificarClienteToolStripMenuItem2.Text = "Modificar Cliente";
            this.modificarClienteToolStripMenuItem2.Click += new System.EventHandler(this.modificarClienteToolStripMenuItem2_Click);
            // 
            // reporteDeClienteToolStripMenuItem1
            // 
            this.reporteDeClienteToolStripMenuItem1.Name = "reporteDeClienteToolStripMenuItem1";
            this.reporteDeClienteToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.reporteDeClienteToolStripMenuItem1.Text = "Reporte de Cliente";
            this.reporteDeClienteToolStripMenuItem1.Click += new System.EventHandler(this.reporteDeClienteToolStripMenuItem1_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // Desktop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SurtiDesk.Properties.Resources.Surtidora_Titulo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.menuPrincipal);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Desktop";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Escritorio";
            this.Load += new System.EventHandler(this.Desktop_Load);
            this.menuPrincipal.ResumeLayout(false);
            this.menuPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuPrincipal;
        private System.Windows.Forms.ToolStripMenuItem ventasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarVentaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteDeVentaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem empleadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteDeClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarProductoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarProductoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarProductoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteDeProductoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem empleadosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem registrarClienteToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem modificarClienteToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarClienteToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem reporteDeClienteToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem cambiarIVAToolStripMenuItem;
    }
}