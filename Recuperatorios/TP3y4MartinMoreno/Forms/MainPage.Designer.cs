namespace Forms
{
    partial class MainPage
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnUsuariosLista = new System.Windows.Forms.Button();
            this.btnImplementosLista = new System.Windows.Forms.Button();
            this.btnClasesLista = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelHora = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnUsuariosLista
            // 
            this.btnUsuariosLista.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnUsuariosLista.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnUsuariosLista.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnUsuariosLista.Location = new System.Drawing.Point(12, 23);
            this.btnUsuariosLista.Name = "btnUsuariosLista";
            this.btnUsuariosLista.Size = new System.Drawing.Size(229, 48);
            this.btnUsuariosLista.TabIndex = 0;
            this.btnUsuariosLista.TabStop = false;
            this.btnUsuariosLista.Text = "USUARIOS";
            this.btnUsuariosLista.UseVisualStyleBackColor = false;
            this.btnUsuariosLista.Click += new System.EventHandler(this.btnUsuariosLista_Click);
            // 
            // btnImplementosLista
            // 
            this.btnImplementosLista.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnImplementosLista.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnImplementosLista.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnImplementosLista.Location = new System.Drawing.Point(12, 105);
            this.btnImplementosLista.Name = "btnImplementosLista";
            this.btnImplementosLista.Size = new System.Drawing.Size(229, 48);
            this.btnImplementosLista.TabIndex = 1;
            this.btnImplementosLista.Text = "Implementos";
            this.btnImplementosLista.UseVisualStyleBackColor = false;
            this.btnImplementosLista.Click += new System.EventHandler(this.btnImplementosLista_Click);
            // 
            // btnClasesLista
            // 
            this.btnClasesLista.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnClasesLista.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnClasesLista.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnClasesLista.Location = new System.Drawing.Point(12, 188);
            this.btnClasesLista.Name = "btnClasesLista";
            this.btnClasesLista.Size = new System.Drawing.Size(229, 48);
            this.btnClasesLista.TabIndex = 2;
            this.btnClasesLista.Text = "Clases";
            this.btnClasesLista.UseVisualStyleBackColor = false;
            this.btnClasesLista.Click += new System.EventHandler(this.btnClasesLista_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(311, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(318, 37);
            this.label1.TabIndex = 3;
            this.label1.Text = "Escuela de dibujo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Showcard Gothic", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(316, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(309, 67);
            this.label2.TabIndex = 4;
            this.label2.Text = "Donatelo";
            // 
            // labelHora
            // 
            this.labelHora.AutoSize = true;
            this.labelHora.Location = new System.Drawing.Point(489, 23);
            this.labelHora.Name = "labelHora";
            this.labelHora.Size = new System.Drawing.Size(136, 15);
            this.labelHora.TabIndex = 5;
            this.labelHora.Text = "DD/MM/YYYY HH:MI:SS";
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.BackgroundImage = global::Forms.Properties.Resources.Color_Bg_transparente;
            this.ClientSize = new System.Drawing.Size(652, 269);
            this.Controls.Add(this.labelHora);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClasesLista);
            this.Controls.Add(this.btnImplementosLista);
            this.Controls.Add(this.btnUsuariosLista);
            this.Name = "MainPage";
            this.Text = "MainPage";
            this.Load += new System.EventHandler(this.MainPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUsuariosLista;
        private System.Windows.Forms.Button btnImplementosLista;
        private System.Windows.Forms.Button btnClasesLista;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelHora;
    }
}
