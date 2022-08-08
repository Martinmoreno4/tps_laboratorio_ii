namespace Forms
{
    partial class ListaClases
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
            this.listClases = new System.Windows.Forms.ListView();
            this.colDia = new System.Windows.Forms.ColumnHeader();
            this.colHorarios = new System.Windows.Forms.ColumnHeader();
            this.btnCancelarCl = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listClases
            // 
            this.listClases.BackColor = System.Drawing.Color.WhiteSmoke;
            this.listClases.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colDia,
            this.colHorarios});
            this.listClases.FullRowSelect = true;
            this.listClases.GridLines = true;
            this.listClases.HideSelection = false;
            this.listClases.Location = new System.Drawing.Point(12, 12);
            this.listClases.Name = "listClases";
            this.listClases.Size = new System.Drawing.Size(244, 279);
            this.listClases.TabIndex = 16;
            this.listClases.UseCompatibleStateImageBehavior = false;
            this.listClases.View = System.Windows.Forms.View.Details;
            // 
            // colDia
            // 
            this.colDia.Text = "Dia";
            this.colDia.Width = 120;
            // 
            // colHorarios
            // 
            this.colHorarios.Text = "Horarios";
            this.colHorarios.Width = 120;
            // 
            // btnCancelarCl
            // 
            this.btnCancelarCl.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnCancelarCl.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCancelarCl.ForeColor = System.Drawing.Color.Navy;
            this.btnCancelarCl.Location = new System.Drawing.Point(181, 299);
            this.btnCancelarCl.Name = "btnCancelarCl";
            this.btnCancelarCl.Size = new System.Drawing.Size(75, 23);
            this.btnCancelarCl.TabIndex = 17;
            this.btnCancelarCl.Text = "Volver";
            this.btnCancelarCl.UseVisualStyleBackColor = false;
            this.btnCancelarCl.Click += new System.EventHandler(this.btnCancelarCl_Click);
            // 
            // ListaClases
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.BackgroundImage = global::Forms.Properties.Resources.Color_Bg_transparente;
            this.ClientSize = new System.Drawing.Size(267, 334);
            this.Controls.Add(this.btnCancelarCl);
            this.Controls.Add(this.listClases);
            this.Name = "ListaClases";
            this.Text = "ListaClases";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listClases;
        private System.Windows.Forms.ColumnHeader colDia;
        private System.Windows.Forms.ColumnHeader colHorarios;
        private System.Windows.Forms.Button btnCancelarCl;
    }
}