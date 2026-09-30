using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3MLIDTS_JosathVazquez_04
{
    public partial class lbTelefono : Form
    {
        public lbTelefono()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            rbMasculino.Checked = false;
            rbFemenino.Checked = false; 
            rbOtro.Checked = false;
              
            txtNombre.Clear();
            txtApellido.Clear();
            txtTelefono.Clear();
            txtEdad.Clear();
            txtEstatura.Clear();

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string genero = "";
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            string telefono = txtTelefono.Text;
            string edad = txtEdad.Text;
            string estatura = txtEstatura.Text;
            string mensaje = "";
            if (rbMasculino.Checked)
            {
             genero = "Masculino";
            }
            else if (rbFemenino.Checked)
            {
                genero = "Femenino";
            }
            else if (rbOtro.Checked)
            {
                genero = "Otro";
            }
            mensaje = "Nombre: \n" + nombre + "\nApellido: \n" + apellido + "\nTelefono: \n" + telefono + "\nEdad: \n" + edad + "\nEstatura: \n" + estatura + "\nGenero: \n" + genero; 
            string RutaFile = "C:\\Users\\josathxd\\Documentoss\\3MAgostoLidts.txt";
    
            bool ArchivoExiste = File.Exists(RutaFile);
            using(StreamWriter Writer = new StreamWriter(RutaFile, true))
            {
             if (ArchivoExiste)
            {
                Writer.WriteLine();
            }
             Writer.WriteLine(mensaje);
            }
            

            MessageBox.Show(mensaje, "Registro de Usuario", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

           
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }
    }
}
