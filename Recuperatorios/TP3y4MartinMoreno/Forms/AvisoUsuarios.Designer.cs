namespace Forms
{
    partial class AvisoUsuarios
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
            this.CBoxClase = new System.Windows.Forms.ComboBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.CBoxGenero = new System.Windows.Forms.ComboBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.btnCancAvUs = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CBoxClase
            // 
            this.CBoxClase.FormattingEnabled = true;
            this.CBoxClase.Items.AddRange(new object[] {
            "Lunes",
            "Martes",
            "Miercoles",
            "Jueves",
            "Viernes"});
            this.CBoxClase.Location = new System.Drawing.Point(109, 65);
            this.CBoxClase.Name = "CBoxClase";
            this.CBoxClase.Size = new System.Drawing.Size(164, 23);
            this.CBoxClase.TabIndex = 0;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(109, 216);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(164, 23);
            this.txtTelefono.TabIndex = 1;
            // 
            // CBoxGenero
            // 
            this.CBoxGenero.FormattingEnabled = true;
            this.CBoxGenero.Items.AddRange(new object[] {
            "Masculino",
            "Femenenino",
            "Otro"});
            this.CBoxGenero.Location = new System.Drawing.Point(109, 115);
            this.CBoxGenero.Name = "CBoxGenero";
            this.CBoxGenero.Size = new System.Drawing.Size(164, 23);
            this.CBoxGenero.TabIndex = 2;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(109, 315);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(164, 23);
            this.txtApellido.TabIndex = 3;
            // 
            // txtDni
            // 
            this.txtDni.Location = new System.Drawing.Point(109, 166);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(164, 23);
            this.txtDni.TabIndex = 4;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(109, 265);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(164, 23);
            this.txtNombre.TabIndex = 5;
            // 
            // btnCancAvUs
            // 
            this.btnCancAvUs.BackColor = System.Drawing.Color.SandyBrown;
            this.btnCancAvUs.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCancAvUs.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCancAvUs.Location = new System.Drawing.Point(154, 365);
            this.btnCancAvUs.Name = "btnCancAvUs";
            this.btnCancAvUs.Size = new System.Drawing.Size(75, 23);
            this.btnCancAvUs.TabIndex = 6;
            this.btnCancAvUs.Text = "Cancelar";
            this.btnCancAvUs.UseVisualStyleBackColor = false;
            this.btnCancAvUs.Click += new System.EventHandler(this.btnCancAvUs_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(7, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 22);
            this.label1.TabIndex = 7;
            this.label1.Text = "Clase";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Black", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(7, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 22);
            this.label2.TabIndex = 8;
            this.label2.Text = "Genero";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Black", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(7, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 22);
            this.label3.TabIndex = 9;
            this.label3.Text = "DNI";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Black", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(7, 219);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 22);
            this.label4.TabIndex = 10;
            this.label4.Text = "Telefono";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Black", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(7, 268);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 22);
            this.label5.TabIndex = 11;
            this.label5.Text = "Nombre";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Black", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(7, 318);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 22);
            this.label6.TabIndex = 12;
            this.label6.Text = "Apellido";
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnAceptar.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAceptar.ForeColor = System.Drawing.Color.Navy;
            this.btnAceptar.Location = new System.Drawing.Point(53, 365);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 13;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Black", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(19, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(256, 27);
            this.label7.TabIndex = 14;
            this.label7.Text = "Ingresar nuevo Usuario";
            // 
            // AvisoUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.BackgroundImage = global::Forms.Properties.Resources.Color_Bg_transparente_2;
            this.ClientSize = new System.Drawing.Size(296, 400);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancAvUs);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtDni);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.CBoxGenero);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.CBoxClase);
            this.Name = "AvisoUsuarios";
            this.Text = "AvisoUsuarios";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CBoxClase;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.ComboBox CBoxGenero;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button btnCancAvUs;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Label label7;
    }
}