namespace Forms
{
    partial class AvisoImplementos
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnAceptImpAv = new System.Windows.Forms.Button();
            this.btnCancImpAv = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtCant = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.lblAviso = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(8, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingresar implementos";
            // 
            // btnAceptImpAv
            // 
            this.btnAceptImpAv.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnAceptImpAv.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAceptImpAv.ForeColor = System.Drawing.Color.Navy;
            this.btnAceptImpAv.Location = new System.Drawing.Point(88, 150);
            this.btnAceptImpAv.Name = "btnAceptImpAv";
            this.btnAceptImpAv.Size = new System.Drawing.Size(75, 23);
            this.btnAceptImpAv.TabIndex = 1;
            this.btnAceptImpAv.Text = "Aceptar";
            this.btnAceptImpAv.UseVisualStyleBackColor = false;
            this.btnAceptImpAv.Click += new System.EventHandler(this.btnAceptImpAv_Click);
            // 
            // btnCancImpAv
            // 
            this.btnCancImpAv.BackColor = System.Drawing.Color.SandyBrown;
            this.btnCancImpAv.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCancImpAv.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCancImpAv.Location = new System.Drawing.Point(173, 150);
            this.btnCancImpAv.Name = "btnCancImpAv";
            this.btnCancImpAv.Size = new System.Drawing.Size(75, 23);
            this.btnCancImpAv.TabIndex = 2;
            this.btnCancImpAv.Text = "Cancelar";
            this.btnCancImpAv.UseVisualStyleBackColor = false;
            this.btnCancImpAv.Click += new System.EventHandler(this.btnCancImpAv_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(88, 63);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(160, 23);
            this.txtNombre.TabIndex = 3;
            // 
            // txtCant
            // 
            this.txtCant.Location = new System.Drawing.Point(88, 105);
            this.txtCant.Name = "txtCant";
            this.txtCant.Size = new System.Drawing.Size(160, 23);
            this.txtCant.TabIndex = 4;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNombre.Location = new System.Drawing.Point(23, 65);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(59, 17);
            this.lblNombre.TabIndex = 5;
            this.lblNombre.Text = "Nombre";
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCantidad.Location = new System.Drawing.Point(16, 107);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(66, 17);
            this.lblCantidad.TabIndex = 6;
            this.lblCantidad.Text = "Cantidad";
            // 
            // lblAviso
            // 
            this.lblAviso.AutoSize = true;
            this.lblAviso.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAviso.Location = new System.Drawing.Point(12, 195);
            this.lblAviso.Name = "lblAviso";
            this.lblAviso.Size = new System.Drawing.Size(46, 19);
            this.lblAviso.TabIndex = 7;
            this.lblAviso.Text = "label";
            this.lblAviso.Visible = false;
            // 
            // AvisoImplementos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.BackgroundImage = global::Forms.Properties.Resources.Color_Bg_transparente_2;
            this.ClientSize = new System.Drawing.Size(261, 227);
            this.Controls.Add(this.lblAviso);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtCant);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.btnCancImpAv);
            this.Controls.Add(this.btnAceptImpAv);
            this.Controls.Add(this.label1);
            this.Name = "AvisoImplementos";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAceptImpAv;
        private System.Windows.Forms.Button btnCancImpAv;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtCant;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label lblAviso;
    }
}