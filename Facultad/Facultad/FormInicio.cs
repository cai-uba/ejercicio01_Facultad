using Facultad.Entidades;
using Facultad.Persistencia;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
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

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            // 1) Validaciones
            Boolean permiteAvanzar = true;

            // 1.1) Validaciones de integridad de datos
            if (txtUsuario.Text == "")
            {
                permiteAvanzar = false;
                MessageBox.Show("El nombre de usuario no puede estar vacio");
            }

            if (txtPassword.Text == "")
            {
                permiteAvanzar = false;
                MessageBox.Show("La contraseña no puede estar vacia.");
            }

            // 1.) Validaciones de negocio

            // 1.1) Longitud de usuario (mayor igual a 6)
            if (txtUsuario.Text.Length < 6)
            {
                permiteAvanzar = false; 
                MessageBox.Show("El nombre de usuario debe de tener como mínimo 6 caracteres.");
            }

            // 1.2) Longitud de password (mayor igual a 6)
            if (txtPassword.Text.Length < 6)
            {
                permiteAvanzar = false; 
                MessageBox.Show("La contraseña debe de tener como mínimo 6 caracteres.");
            }

            permiteAvanzar = validarCredenciales(txtUsuario.Text, txtPassword.Text);


            // 1.3) Primero Login? -> Cambio password y 1.4) Expira password?
            if (permiteAvanzar)
            {
                validarEstadoClave(txtUsuario.Text);
            }

            // 2) Redirigir
            if (permiteAvanzar)
            {
                this.Hide();
                FormMenu formMenu = new FormMenu();
                formMenu.ShowDialog();
            }
        }

        private Boolean validarCredenciales(String usuarioLogin, string passwordLogin)
        {
            Credencial credencialLogin = buscarUsuario(usuarioLogin);
            if(credencialLogin == null)
            {
                return false;
                MessageBox.Show("Usuario no existe");
            } else
            {
                if(!credencialLogin.Password.Equals(passwordLogin))
                {
                    return false; 
                    MessageBox.Show("Contraseña incorrecta");
                }
            }

            return true;
        }

        private void validarEstadoClave(String usuarioLogin)
        {
            Credencial credencialLogin = buscarUsuario(usuarioLogin);

            if (credencialLogin.FechaUltimoIngreso == null)
            {
                // Redirigir al cambio de contraseña
            }

            if(credencialLogin.FechaUltimoIngreso < DateTime.Today.AddDays(-30)){
                // Redirigir al cambio de contraseña
            }
            
        }

        private Credencial buscarUsuario(String usuarioLogin)
        {
            Credencial credencialLogin = null;
            
            foreach(Credencial credencial in obtenerCredenciales())
            {
                if (credencial.Usuario.Equals(usuarioLogin))
                {
                    credencialLogin = credencial;
                }
            }

            return credencialLogin;
        }

        private List<Credencial> obtenerCredenciales()
        {
            PersistenciaUtils persistenciaUtils = new PersistenciaUtils();

            List<String> listado = persistenciaUtils.LeerRegistro("credenciales.csv");
            List<Credencial> listadoCredenciales = new List<Credencial>();

            int contador = 0;
            foreach (String registro in listado)
            {
                if(contador == 0)
                {
                    contador++;
                    continue;
                }
                Credencial credencial = new Credencial(registro);
                listadoCredenciales.Add(credencial);
            }

            return listadoCredenciales;
        }

    }
}
