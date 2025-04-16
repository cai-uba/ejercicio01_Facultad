namespace Facultad
{
    partial class FormMenu
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
            this.txtAlumnos = new System.Windows.Forms.Button();
            this.txtPersonal = new System.Windows.Forms.Button();
            this.btnReporte = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtAlumnos
            // 
            this.txtAlumnos.Location = new System.Drawing.Point(140, 58);
            this.txtAlumnos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtAlumnos.Name = "txtAlumnos";
            this.txtAlumnos.Size = new System.Drawing.Size(100, 28);
            this.txtAlumnos.TabIndex = 0;
            this.txtAlumnos.Text = "Alumnos";
            this.txtAlumnos.UseVisualStyleBackColor = true;
            this.txtAlumnos.Click += new System.EventHandler(this.txtAlumnos_Click);
            // 
            // txtPersonal
            // 
            this.txtPersonal.Location = new System.Drawing.Point(140, 142);
            this.txtPersonal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPersonal.Name = "txtPersonal";
            this.txtPersonal.Size = new System.Drawing.Size(100, 28);
            this.txtPersonal.TabIndex = 1;
            this.txtPersonal.Text = "Personal";
            this.txtPersonal.UseVisualStyleBackColor = true;
            this.txtPersonal.Click += new System.EventHandler(this.txtPersonal_Click);
            // 
            // btnReporte
            // 
            this.btnReporte.Location = new System.Drawing.Point(140, 219);
            this.btnReporte.Name = "btnReporte";
            this.btnReporte.Size = new System.Drawing.Size(100, 31);
            this.btnReporte.TabIndex = 2;
            this.btnReporte.Text = "Reportes";
            this.btnReporte.UseVisualStyleBackColor = true;
            this.btnReporte.Click += new System.EventHandler(this.btnReporte_Click);
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btnReporte);
            this.Controls.Add(this.txtPersonal);
            this.Controls.Add(this.txtAlumnos);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormMenu";
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button txtAlumnos;
        private System.Windows.Forms.Button txtPersonal;
        private System.Windows.Forms.Button btnReporte;
    }
}