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
            this.SuspendLayout();
            // 
            // txtAlumnos
            // 
            this.txtAlumnos.Location = new System.Drawing.Point(105, 47);
            this.txtAlumnos.Name = "txtAlumnos";
            this.txtAlumnos.Size = new System.Drawing.Size(75, 23);
            this.txtAlumnos.TabIndex = 0;
            this.txtAlumnos.Text = "Alumnos";
            this.txtAlumnos.UseVisualStyleBackColor = true;
            this.txtAlumnos.Click += new System.EventHandler(this.txtAlumnos_Click);
            // 
            // txtPersonal
            // 
            this.txtPersonal.Location = new System.Drawing.Point(105, 115);
            this.txtPersonal.Name = "txtPersonal";
            this.txtPersonal.Size = new System.Drawing.Size(75, 23);
            this.txtPersonal.TabIndex = 1;
            this.txtPersonal.Text = "Personal";
            this.txtPersonal.UseVisualStyleBackColor = true;
            this.txtPersonal.Click += new System.EventHandler(this.txtPersonal_Click);
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtPersonal);
            this.Controls.Add(this.txtAlumnos);
            this.Name = "FormMenu";
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button txtAlumnos;
        private System.Windows.Forms.Button txtPersonal;
    }
}