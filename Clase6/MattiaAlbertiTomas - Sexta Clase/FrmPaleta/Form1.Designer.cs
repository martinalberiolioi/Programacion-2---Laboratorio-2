namespace FrmPaleta
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
            this.Agregar = new System.Windows.Forms.Button();
            this.Quitar = new System.Windows.Forms.Button();
            this.Colores = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // Agregar
            // 
            this.Agregar.Location = new System.Drawing.Point(62, 29);
            this.Agregar.Name = "Agregar";
            this.Agregar.Size = new System.Drawing.Size(107, 51);
            this.Agregar.TabIndex = 0;
            this.Agregar.Text = "Agregar";
            this.Agregar.UseVisualStyleBackColor = true;
            this.Agregar.Click += new System.EventHandler(this.Agregar_Click);
            // 
            // Quitar
            // 
            this.Quitar.Location = new System.Drawing.Point(418, 29);
            this.Quitar.Name = "Quitar";
            this.Quitar.Size = new System.Drawing.Size(107, 51);
            this.Quitar.TabIndex = 1;
            this.Quitar.Text = "Quitar";
            this.Quitar.UseVisualStyleBackColor = true;
            this.Quitar.Click += new System.EventHandler(this.Quitar_Click);
            // 
            // Colores
            // 
            this.Colores.FormattingEnabled = true;
            this.Colores.Location = new System.Drawing.Point(12, 108);
            this.Colores.Name = "Colores";
            this.Colores.Size = new System.Drawing.Size(548, 199);
            this.Colores.TabIndex = 2;
            this.Colores.SelectedIndexChanged += new System.EventHandler(this.Colores_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 320);
            this.Controls.Add(this.Colores);
            this.Controls.Add(this.Quitar);
            this.Controls.Add(this.Agregar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Agregar;
        private System.Windows.Forms.Button Quitar;
        private System.Windows.Forms.ListBox Colores;
    }
}

