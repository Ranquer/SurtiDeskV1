namespace SurtiDesk
{
    partial class Form1
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
            this.textCodigoEmpleado = new System.Windows.Forms.TextBox();
            this.textContraseña = new System.Windows.Forms.TextBox();
            this.labelCodigoDeEmpleado = new System.Windows.Forms.Label();
            this.labelContraseña = new System.Windows.Forms.Label();
            this.buttonEntrar = new System.Windows.Forms.Button();
            this.buttonSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textCodigoEmpleado
            // 
            this.textCodigoEmpleado.Location = new System.Drawing.Point(454, 243);
            this.textCodigoEmpleado.Name = "textCodigoEmpleado";
            this.textCodigoEmpleado.Size = new System.Drawing.Size(313, 20);
            this.textCodigoEmpleado.TabIndex = 0;
            // 
            // textContraseña
            // 
            this.textContraseña.Location = new System.Drawing.Point(454, 300);
            this.textContraseña.Name = "textContraseña";
            this.textContraseña.Size = new System.Drawing.Size(313, 20);
            this.textContraseña.TabIndex = 1;
            this.textContraseña.UseSystemPasswordChar = true;
            // 
            // labelCodigoDeEmpleado
            // 
            this.labelCodigoDeEmpleado.AutoSize = true;
            this.labelCodigoDeEmpleado.Location = new System.Drawing.Point(451, 227);
            this.labelCodigoDeEmpleado.Name = "labelCodigoDeEmpleado";
            this.labelCodigoDeEmpleado.Size = new System.Drawing.Size(104, 13);
            this.labelCodigoDeEmpleado.TabIndex = 3;
            this.labelCodigoDeEmpleado.Text = "Codigo de empleado";
            // 
            // labelContraseña
            // 
            this.labelContraseña.AutoSize = true;
            this.labelContraseña.Location = new System.Drawing.Point(451, 284);
            this.labelContraseña.Name = "labelContraseña";
            this.labelContraseña.Size = new System.Drawing.Size(61, 13);
            this.labelContraseña.TabIndex = 4;
            this.labelContraseña.Text = "Contraseña";
            // 
            // buttonEntrar
            // 
            this.buttonEntrar.Location = new System.Drawing.Point(454, 365);
            this.buttonEntrar.Name = "buttonEntrar";
            this.buttonEntrar.Size = new System.Drawing.Size(75, 23);
            this.buttonEntrar.TabIndex = 5;
            this.buttonEntrar.Text = "Entrar";
            this.buttonEntrar.UseVisualStyleBackColor = true;
            this.buttonEntrar.Click += new System.EventHandler(this.buttonEntrar_Click);
            // 
            // buttonSalir
            // 
            this.buttonSalir.Location = new System.Drawing.Point(692, 365);
            this.buttonSalir.Name = "buttonSalir";
            this.buttonSalir.Size = new System.Drawing.Size(75, 23);
            this.buttonSalir.TabIndex = 6;
            this.buttonSalir.Text = "Salir";
            this.buttonSalir.UseVisualStyleBackColor = true;
            this.buttonSalir.Click += new System.EventHandler(this.buttonSalir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::SurtiDesk.Properties.Resources.logo_surtidora_header;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.buttonSalir);
            this.Controls.Add(this.buttonEntrar);
            this.Controls.Add(this.labelContraseña);
            this.Controls.Add(this.labelCodigoDeEmpleado);
            this.Controls.Add(this.textContraseña);
            this.Controls.Add(this.textCodigoEmpleado);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SurtiDesk Inicio de seción";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textCodigoEmpleado;
        private System.Windows.Forms.TextBox textContraseña;
        private System.Windows.Forms.Label labelCodigoDeEmpleado;
        private System.Windows.Forms.Label labelContraseña;
        private System.Windows.Forms.Button buttonEntrar;
        private System.Windows.Forms.Button buttonSalir;
    }
}

