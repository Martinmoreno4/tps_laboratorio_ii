namespace Forms
{
    partial class ListaImplementos
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
            this.btnAgregarImp = new System.Windows.Forms.Button();
            this.btnCancelarIm = new System.Windows.Forms.Button();
            this.dtgImplementos = new System.Windows.Forms.DataGridView();
            this.btnEliminiar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgImplementos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAgregarImp
            // 
            this.btnAgregarImp.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnAgregarImp.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAgregarImp.ForeColor = System.Drawing.Color.Navy;
            this.btnAgregarImp.Location = new System.Drawing.Point(270, 12);
            this.btnAgregarImp.Name = "btnAgregarImp";
            this.btnAgregarImp.Size = new System.Drawing.Size(149, 42);
            this.btnAgregarImp.TabIndex = 3;
            this.btnAgregarImp.Text = "Agregar";
            this.btnAgregarImp.UseVisualStyleBackColor = false;
            this.btnAgregarImp.Click += new System.EventHandler(this.btnAgregarImp_Click);
            // 
            // btnCancelarIm
            // 
            this.btnCancelarIm.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnCancelarIm.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCancelarIm.ForeColor = System.Drawing.Color.Navy;
            this.btnCancelarIm.Location = new System.Drawing.Point(345, 260);
            this.btnCancelarIm.Name = "btnCancelarIm";
            this.btnCancelarIm.Size = new System.Drawing.Size(75, 23);
            this.btnCancelarIm.TabIndex = 4;
            this.btnCancelarIm.Text = "cancelar";
            this.btnCancelarIm.UseVisualStyleBackColor = false;
            this.btnCancelarIm.Click += new System.EventHandler(this.btnCancelarIm_Click);
            // 
            // dtgImplementos
            // 
            this.dtgImplementos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgImplementos.Location = new System.Drawing.Point(12, 12);
            this.dtgImplementos.Name = "dtgImplementos";
            this.dtgImplementos.RowTemplate.Height = 25;
            this.dtgImplementos.Size = new System.Drawing.Size(243, 271);
            this.dtgImplementos.TabIndex = 5;
            // 
            // btnEliminiar
            // 
            this.btnEliminiar.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnEliminiar.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEliminiar.ForeColor = System.Drawing.Color.Navy;
            this.btnEliminiar.Location = new System.Drawing.Point(270, 68);
            this.btnEliminiar.Name = "btnEliminiar";
            this.btnEliminiar.Size = new System.Drawing.Size(149, 42);
            this.btnEliminiar.TabIndex = 6;
            this.btnEliminiar.Text = "Eliminiar";
            this.btnEliminiar.UseVisualStyleBackColor = false;
            this.btnEliminiar.Click += new System.EventHandler(this.btnEliminiar_Click);
            // 
            // ListaImplementos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.BackgroundImage = global::Forms.Properties.Resources.Color_Bg_transparente;
            this.ClientSize = new System.Drawing.Size(432, 296);
            this.Controls.Add(this.btnEliminiar);
            this.Controls.Add(this.dtgImplementos);
            this.Controls.Add(this.btnCancelarIm);
            this.Controls.Add(this.btnAgregarImp);
            this.Name = "ListaImplementos";
            this.Text = "ListaAviso";
            this.Load += new System.EventHandler(this.ListaImplementos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgImplementos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnAgregarImp;
        private System.Windows.Forms.Button btnCancelarIm;
        private System.Windows.Forms.DataGridView dtgImplementos;
        private System.Windows.Forms.Button btnEliminiar;
    }
}