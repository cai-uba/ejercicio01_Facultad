using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Facultad
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void txtAlumnos_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormAlumnos formAlumnos = new FormAlumnos();
            formAlumnos.ShowDialog();
        }

        private void txtPersonal_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormPersonal formAlumnos = new FormPersonal();
            formAlumnos.ShowDialog();
        }
    }
}
