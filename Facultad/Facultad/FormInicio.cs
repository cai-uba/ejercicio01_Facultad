﻿using System;
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
    public partial class FormInicio : Form
    {
        public FormInicio()
        {
            InitializeComponent();
        }

        private void btnSaludar_Click(object sender, EventArgs e)
        {

            // 1) Validaciones
            
            // 1.1) Validaciones de integridad de datos

            // 1.) Validaciones de negocio

            // 1.1) Longitud de usuario (mayor igual a 6)

            // 1.2) Longitud de password (mayor igual a 6)

            // 1.3) Primero Login? -> Cambio password

            // 1.4) Expira password?

            // 2) Redirigir
            this.Hide();
            FormMenu formMenu = new FormMenu();
            formMenu.ShowDialog();
        }

    }
}
