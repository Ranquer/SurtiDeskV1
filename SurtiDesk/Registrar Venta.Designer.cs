namespace SurtiDesk
{
    partial class Registrar_Venta
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
            this.textBoxFolio = new System.Windows.Forms.TextBox();
            this.textBoxFecha = new System.Windows.Forms.TextBox();
            this.textBoxCodigoEmpleado = new System.Windows.Forms.TextBox();
            this.textBoxNombreEmpleado = new System.Windows.Forms.TextBox();
            this.labelFolio = new System.Windows.Forms.Label();
            this.labelCodigoEmpleado = new System.Windows.Forms.Label();
            this.labelFecha = new System.Windows.Forms.Label();
            this.labelNombreEmpleado = new System.Windows.Forms.Label();
            this.textBoxRFCCliente = new System.Windows.Forms.TextBox();
            this.textBoxNombreCliente = new System.Windows.Forms.TextBox();
            this.labelRFCCliente = new System.Windows.Forms.Label();
            this.labelNombreCliente = new System.Windows.Forms.Label();
            this.dataGridViewNota = new System.Windows.Forms.DataGridView();
            this.CodigoProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescripcionProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantidadProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ImporteProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBoxIVA = new System.Windows.Forms.TextBox();
            this.textBoxSubTotal = new System.Windows.Forms.TextBox();
            this.labelIVA = new System.Windows.Forms.Label();
            this.labelSubTotal = new System.Windows.Forms.Label();
            this.textBoxTotal = new System.Windows.Forms.TextBox();
            this.labelTotal = new System.Windows.Forms.Label();
            this.buttonVender = new System.Windows.Forms.Button();
            this.buttonSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNota)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxFolio
            // 
            this.textBoxFolio.Location = new System.Drawing.Point(33, 68);
            this.textBoxFolio.Name = "textBoxFolio";
            this.textBoxFolio.ReadOnly = true;
            this.textBoxFolio.Size = new System.Drawing.Size(207, 20);
            this.textBoxFolio.TabIndex = 0;
            this.textBoxFolio.TextChanged += new System.EventHandler(this.textBoxFolio_TextChanged);
            // 
            // textBoxFecha
            // 
            this.textBoxFecha.Location = new System.Drawing.Point(342, 68);
            this.textBoxFecha.Name = "textBoxFecha";
            this.textBoxFecha.ReadOnly = true;
            this.textBoxFecha.Size = new System.Drawing.Size(207, 20);
            this.textBoxFecha.TabIndex = 1;
            // 
            // textBoxCodigoEmpleado
            // 
            this.textBoxCodigoEmpleado.Location = new System.Drawing.Point(33, 179);
            this.textBoxCodigoEmpleado.Name = "textBoxCodigoEmpleado";
            this.textBoxCodigoEmpleado.ReadOnly = true;
            this.textBoxCodigoEmpleado.Size = new System.Drawing.Size(207, 20);
            this.textBoxCodigoEmpleado.TabIndex = 2;
            // 
            // textBoxNombreEmpleado
            // 
            this.textBoxNombreEmpleado.Location = new System.Drawing.Point(342, 178);
            this.textBoxNombreEmpleado.Name = "textBoxNombreEmpleado";
            this.textBoxNombreEmpleado.ReadOnly = true;
            this.textBoxNombreEmpleado.Size = new System.Drawing.Size(207, 20);
            this.textBoxNombreEmpleado.TabIndex = 3;
            // 
            // labelFolio
            // 
            this.labelFolio.AutoSize = true;
            this.labelFolio.Location = new System.Drawing.Point(34, 49);
            this.labelFolio.Name = "labelFolio";
            this.labelFolio.Size = new System.Drawing.Size(29, 13);
            this.labelFolio.TabIndex = 4;
            this.labelFolio.Text = "Folio";
            // 
            // labelCodigoEmpleado
            // 
            this.labelCodigoEmpleado.AutoSize = true;
            this.labelCodigoEmpleado.Location = new System.Drawing.Point(33, 160);
            this.labelCodigoEmpleado.Name = "labelCodigoEmpleado";
            this.labelCodigoEmpleado.Size = new System.Drawing.Size(90, 13);
            this.labelCodigoEmpleado.TabIndex = 5;
            this.labelCodigoEmpleado.Text = "Codigo Empleado";
            // 
            // labelFecha
            // 
            this.labelFecha.AutoSize = true;
            this.labelFecha.Location = new System.Drawing.Point(342, 48);
            this.labelFecha.Name = "labelFecha";
            this.labelFecha.Size = new System.Drawing.Size(37, 13);
            this.labelFecha.TabIndex = 6;
            this.labelFecha.Text = "Fecha";
            // 
            // labelNombreEmpleado
            // 
            this.labelNombreEmpleado.AutoSize = true;
            this.labelNombreEmpleado.Location = new System.Drawing.Point(342, 160);
            this.labelNombreEmpleado.Name = "labelNombreEmpleado";
            this.labelNombreEmpleado.Size = new System.Drawing.Size(94, 13);
            this.labelNombreEmpleado.TabIndex = 7;
            this.labelNombreEmpleado.Text = "Nombre Empleado";
            // 
            // textBoxRFCCliente
            // 
            this.textBoxRFCCliente.Location = new System.Drawing.Point(33, 121);
            this.textBoxRFCCliente.Name = "textBoxRFCCliente";
            this.textBoxRFCCliente.Size = new System.Drawing.Size(207, 20);
            this.textBoxRFCCliente.TabIndex = 8;
            // 
            // textBoxNombreCliente
            // 
            this.textBoxNombreCliente.Location = new System.Drawing.Point(342, 121);
            this.textBoxNombreCliente.Name = "textBoxNombreCliente";
            this.textBoxNombreCliente.ReadOnly = true;
            this.textBoxNombreCliente.Size = new System.Drawing.Size(207, 20);
            this.textBoxNombreCliente.TabIndex = 9;
            // 
            // labelRFCCliente
            // 
            this.labelRFCCliente.AutoSize = true;
            this.labelRFCCliente.Location = new System.Drawing.Point(33, 102);
            this.labelRFCCliente.Name = "labelRFCCliente";
            this.labelRFCCliente.Size = new System.Drawing.Size(63, 13);
            this.labelRFCCliente.TabIndex = 12;
            this.labelRFCCliente.Text = "RFC Cliente";
            // 
            // labelNombreCliente
            // 
            this.labelNombreCliente.AutoSize = true;
            this.labelNombreCliente.Location = new System.Drawing.Point(342, 102);
            this.labelNombreCliente.Name = "labelNombreCliente";
            this.labelNombreCliente.Size = new System.Drawing.Size(79, 13);
            this.labelNombreCliente.TabIndex = 13;
            this.labelNombreCliente.Text = "Nombre Cliente";
            // 
            // dataGridViewNota
            // 
            this.dataGridViewNota.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewNota.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodigoProducto,
            this.DescripcionProducto,
            this.PrecioProducto,
            this.CantidadProducto,
            this.ImporteProducto});
            this.dataGridViewNota.Location = new System.Drawing.Point(33, 235);
            this.dataGridViewNota.Name = "dataGridViewNota";
            this.dataGridViewNota.RowHeadersVisible = false;
            this.dataGridViewNota.Size = new System.Drawing.Size(516, 346);
            this.dataGridViewNota.TabIndex = 14;
            this.dataGridViewNota.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewNota_CellContentClick);
            // 
            // CodigoProducto
            // 
            this.CodigoProducto.HeaderText = "Codigo";
            this.CodigoProducto.Name = "CodigoProducto";
            this.CodigoProducto.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.CodigoProducto.Width = 70;
            // 
            // DescripcionProducto
            // 
            this.DescripcionProducto.HeaderText = "Descripcion Producto";
            this.DescripcionProducto.Name = "DescripcionProducto";
            this.DescripcionProducto.ReadOnly = true;
            this.DescripcionProducto.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.DescripcionProducto.Width = 220;
            // 
            // PrecioProducto
            // 
            this.PrecioProducto.HeaderText = "Precio";
            this.PrecioProducto.Name = "PrecioProducto";
            this.PrecioProducto.ReadOnly = true;
            this.PrecioProducto.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.PrecioProducto.Width = 70;
            // 
            // CantidadProducto
            // 
            this.CantidadProducto.HeaderText = "Cantidad";
            this.CantidadProducto.Name = "CantidadProducto";
            this.CantidadProducto.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.CantidadProducto.Width = 70;
            // 
            // ImporteProducto
            // 
            this.ImporteProducto.HeaderText = "Importe";
            this.ImporteProducto.Name = "ImporteProducto";
            this.ImporteProducto.ReadOnly = true;
            this.ImporteProducto.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ImporteProducto.Width = 83;
            // 
            // textBoxIVA
            // 
            this.textBoxIVA.Location = new System.Drawing.Point(445, 595);
            this.textBoxIVA.Name = "textBoxIVA";
            this.textBoxIVA.ReadOnly = true;
            this.textBoxIVA.Size = new System.Drawing.Size(100, 20);
            this.textBoxIVA.TabIndex = 15;
            // 
            // textBoxSubTotal
            // 
            this.textBoxSubTotal.Location = new System.Drawing.Point(445, 622);
            this.textBoxSubTotal.Name = "textBoxSubTotal";
            this.textBoxSubTotal.ReadOnly = true;
            this.textBoxSubTotal.Size = new System.Drawing.Size(100, 20);
            this.textBoxSubTotal.TabIndex = 16;
            // 
            // labelIVA
            // 
            this.labelIVA.AutoSize = true;
            this.labelIVA.Location = new System.Drawing.Point(415, 602);
            this.labelIVA.Name = "labelIVA";
            this.labelIVA.Size = new System.Drawing.Size(24, 13);
            this.labelIVA.TabIndex = 17;
            this.labelIVA.Text = "IVA";
            // 
            // labelSubTotal
            // 
            this.labelSubTotal.AutoSize = true;
            this.labelSubTotal.Location = new System.Drawing.Point(386, 629);
            this.labelSubTotal.Name = "labelSubTotal";
            this.labelSubTotal.Size = new System.Drawing.Size(53, 13);
            this.labelSubTotal.TabIndex = 18;
            this.labelSubTotal.Text = "Sub Total";
            // 
            // textBoxTotal
            // 
            this.textBoxTotal.Location = new System.Drawing.Point(445, 649);
            this.textBoxTotal.Name = "textBoxTotal";
            this.textBoxTotal.ReadOnly = true;
            this.textBoxTotal.Size = new System.Drawing.Size(100, 20);
            this.textBoxTotal.TabIndex = 19;
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Location = new System.Drawing.Point(404, 656);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(31, 13);
            this.labelTotal.TabIndex = 20;
            this.labelTotal.Text = "Total";
            // 
            // buttonVender
            // 
            this.buttonVender.Location = new System.Drawing.Point(33, 624);
            this.buttonVender.Name = "buttonVender";
            this.buttonVender.Size = new System.Drawing.Size(120, 23);
            this.buttonVender.TabIndex = 21;
            this.buttonVender.Text = "Vender";
            this.buttonVender.UseVisualStyleBackColor = true;
            // 
            // buttonSalir
            // 
            this.buttonSalir.Location = new System.Drawing.Point(241, 620);
            this.buttonSalir.Name = "buttonSalir";
            this.buttonSalir.Size = new System.Drawing.Size(120, 23);
            this.buttonSalir.TabIndex = 22;
            this.buttonSalir.Text = "Salir";
            this.buttonSalir.UseVisualStyleBackColor = true;
            // 
            // Registrar_Venta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SurtiDesk.Properties.Resources.logo_surtidora_header;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(584, 681);
            this.Controls.Add(this.buttonSalir);
            this.Controls.Add(this.buttonVender);
            this.Controls.Add(this.labelTotal);
            this.Controls.Add(this.textBoxTotal);
            this.Controls.Add(this.labelSubTotal);
            this.Controls.Add(this.labelIVA);
            this.Controls.Add(this.textBoxSubTotal);
            this.Controls.Add(this.textBoxIVA);
            this.Controls.Add(this.dataGridViewNota);
            this.Controls.Add(this.labelNombreCliente);
            this.Controls.Add(this.labelRFCCliente);
            this.Controls.Add(this.textBoxNombreCliente);
            this.Controls.Add(this.textBoxRFCCliente);
            this.Controls.Add(this.labelNombreEmpleado);
            this.Controls.Add(this.labelFecha);
            this.Controls.Add(this.labelCodigoEmpleado);
            this.Controls.Add(this.labelFolio);
            this.Controls.Add(this.textBoxNombreEmpleado);
            this.Controls.Add(this.textBoxCodigoEmpleado);
            this.Controls.Add(this.textBoxFecha);
            this.Controls.Add(this.textBoxFolio);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Registrar_Venta";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Registrar_Venta";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNota)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxFolio;
        private System.Windows.Forms.TextBox textBoxFecha;
        private System.Windows.Forms.TextBox textBoxCodigoEmpleado;
        private System.Windows.Forms.TextBox textBoxNombreEmpleado;
        private System.Windows.Forms.Label labelFolio;
        private System.Windows.Forms.Label labelCodigoEmpleado;
        private System.Windows.Forms.Label labelFecha;
        private System.Windows.Forms.Label labelNombreEmpleado;
        private System.Windows.Forms.TextBox textBoxRFCCliente;
        private System.Windows.Forms.TextBox textBoxNombreCliente;
        private System.Windows.Forms.Label labelRFCCliente;
        private System.Windows.Forms.Label labelNombreCliente;
        private System.Windows.Forms.DataGridView dataGridViewNota;
        private System.Windows.Forms.TextBox textBoxIVA;
        private System.Windows.Forms.TextBox textBoxSubTotal;
        private System.Windows.Forms.Label labelIVA;
        private System.Windows.Forms.Label labelSubTotal;
        private System.Windows.Forms.TextBox textBoxTotal;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.Button buttonVender;
        private System.Windows.Forms.Button buttonSalir;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescripcionProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantidadProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn ImporteProducto;
    }
}