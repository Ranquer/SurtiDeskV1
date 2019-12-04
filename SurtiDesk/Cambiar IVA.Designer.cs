namespace SurtiDesk
{
    partial class Cambiar_IVA
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
            this.textBoxidIVA = new System.Windows.Forms.TextBox();
            this.labelidIVA = new System.Windows.Forms.Label();
            this.textBoxPorcentaje = new System.Windows.Forms.TextBox();
            this.labelPorcentaje = new System.Windows.Forms.Label();
            this.labelVigencia = new System.Windows.Forms.Label();
            this.textBoxVigencia = new System.Windows.Forms.TextBox();
            this.buttonGuardar = new System.Windows.Forms.Button();
            this.buttonSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxidIVA
            // 
            this.textBoxidIVA.Location = new System.Drawing.Point(176, 193);
            this.textBoxidIVA.Name = "textBoxidIVA";
            this.textBoxidIVA.ReadOnly = true;
            this.textBoxidIVA.Size = new System.Drawing.Size(230, 20);
            this.textBoxidIVA.TabIndex = 0;
            // 
            // labelidIVA
            // 
            this.labelidIVA.AutoSize = true;
            this.labelidIVA.Location = new System.Drawing.Point(176, 174);
            this.labelidIVA.Name = "labelidIVA";
            this.labelidIVA.Size = new System.Drawing.Size(32, 13);
            this.labelidIVA.TabIndex = 1;
            this.labelidIVA.Text = "idIVA";
            // 
            // textBoxPorcentaje
            // 
            this.textBoxPorcentaje.Location = new System.Drawing.Point(176, 236);
            this.textBoxPorcentaje.Name = "textBoxPorcentaje";
            this.textBoxPorcentaje.Size = new System.Drawing.Size(230, 20);
            this.textBoxPorcentaje.TabIndex = 0;
            // 
            // labelPorcentaje
            // 
            this.labelPorcentaje.AutoSize = true;
            this.labelPorcentaje.Location = new System.Drawing.Point(176, 220);
            this.labelPorcentaje.Name = "labelPorcentaje";
            this.labelPorcentaje.Size = new System.Drawing.Size(58, 13);
            this.labelPorcentaje.TabIndex = 3;
            this.labelPorcentaje.Text = "Porcentaje";
            // 
            // labelVigencia
            // 
            this.labelVigencia.AutoSize = true;
            this.labelVigencia.Location = new System.Drawing.Point(176, 263);
            this.labelVigencia.Name = "labelVigencia";
            this.labelVigencia.Size = new System.Drawing.Size(48, 13);
            this.labelVigencia.TabIndex = 4;
            this.labelVigencia.Text = "Vigencia";
            // 
            // textBoxVigencia
            // 
            this.textBoxVigencia.Location = new System.Drawing.Point(176, 280);
            this.textBoxVigencia.Name = "textBoxVigencia";
            this.textBoxVigencia.ReadOnly = true;
            this.textBoxVigencia.Size = new System.Drawing.Size(230, 20);
            this.textBoxVigencia.TabIndex = 5;
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.Location = new System.Drawing.Point(176, 354);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(75, 23);
            this.buttonGuardar.TabIndex = 1;
            this.buttonGuardar.Text = "Guardar";
            this.buttonGuardar.UseVisualStyleBackColor = true;
            this.buttonGuardar.Click += new System.EventHandler(this.buttonGuardar_Click);
            // 
            // buttonSalir
            // 
            this.buttonSalir.Location = new System.Drawing.Point(330, 353);
            this.buttonSalir.Name = "buttonSalir";
            this.buttonSalir.Size = new System.Drawing.Size(75, 23);
            this.buttonSalir.TabIndex = 2;
            this.buttonSalir.Text = "Salir";
            this.buttonSalir.UseVisualStyleBackColor = true;
            // 
            // Cambiar_IVA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SurtiDesk.Properties.Resources.logo_surtidora_header;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(584, 681);
            this.Controls.Add(this.buttonSalir);
            this.Controls.Add(this.buttonGuardar);
            this.Controls.Add(this.textBoxVigencia);
            this.Controls.Add(this.labelVigencia);
            this.Controls.Add(this.labelPorcentaje);
            this.Controls.Add(this.textBoxPorcentaje);
            this.Controls.Add(this.labelidIVA);
            this.Controls.Add(this.textBoxidIVA);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Cambiar_IVA";
            this.ShowIcon = false;
            this.Text = "Cambiar_IVA";
            this.Load += new System.EventHandler(this.Cambiar_IVA_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxidIVA;
        private System.Windows.Forms.Label labelidIVA;
        private System.Windows.Forms.TextBox textBoxPorcentaje;
        private System.Windows.Forms.Label labelPorcentaje;
        private System.Windows.Forms.Label labelVigencia;
        private System.Windows.Forms.TextBox textBoxVigencia;
        private System.Windows.Forms.Button buttonGuardar;
        private System.Windows.Forms.Button buttonSalir;
    }
}