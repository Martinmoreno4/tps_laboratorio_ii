namespace Forms
{
    partial class ListaUsuario
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
            this.btnAgregarUsuario = new System.Windows.Forms.Button();
            this.btnCancelarUs = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAgregarUsuario
            // 
            this.btnAgregarUsuario.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnAgregarUsuario.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAgregarUsuario.ForeColor = System.Drawing.Color.Navy;
            this.btnAgregarUsuario.Location = new System.Drawing.Point(12, 12);
            this.btnAgregarUsuario.Name = "btnAgregarUsuario";
            this.btnAgregarUsuario.Size = new System.Drawing.Size(149, 42);
            this.btnAgregarUsuario.TabIndex = 1;
            this.btnAgregarUsuario.Text = "Agregar";
            this.btnAgregarUsuario.UseVisualStyleBackColor = false;
            this.btnAgregarUsuario.Click += new System.EventHandler(this.btnAgregarUsuario_Click);
            // 
            // btnCancelarUs
            // 
            this.btnCancelarUs.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnCancelarUs.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCancelarUs.ForeColor = System.Drawing.Color.Navy;
            this.btnCancelarUs.Location = new System.Drawing.Point(12, 205);
            this.btnCancelarUs.Name = "btnCancelarUs";
            this.btnCancelarUs.Size = new System.Drawing.Size(75, 23);
            this.btnCancelarUs.TabIndex = 3;
            this.btnCancelarUs.Text = "cancelar";
            this.btnCancelarUs.UseVisualStyleBackColor = false;
            this.btnCancelarUs.Click += new System.EventHandler(this.btnCancelarUs_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(187, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(476, 216);
            this.dataGridView1.TabIndex = 4;
            // 
            // ListaUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.BackgroundImage = global::Forms.Properties.Resources.Color_Bg_transparente;
            this.ClientSize = new System.Drawing.Size(675, 240);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnCancelarUs);
            this.Controls.Add(this.btnAgregarUsuario);
            this.Name = "ListaUsuario";
            this.Text = "ListaUsuario";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnAgregarUsuario;
        private System.Windows.Forms.Button btnCancelarUs;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}