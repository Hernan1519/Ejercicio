using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string apellido= txtApellido.Text;
            string edad= txtEdad.Text;
            string direccion= txtDireccion.Text;

            if (nombre == "")
                txtNombre.BackColor = Color.Red;
            else if (apellido =="")
                txtApellido.BackColor = Color.Red;
            else if(edad == "")
                txtEdad.BackColor = Color.Red;
            else if (direccion =="")
                txtDireccion.BackColor = Color.Red;

            txtDatos.Text = "Nombre : " + nombre + "\r\n" +
                    "Apellido: " + apellido + "\r\n" +
                    "Edad: " + edad + "\r\n" +
                    "Dirección: " + direccion;


        }

        private void txtEdad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 59) && e.KeyChar != 8)
                e.Handled = true;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
