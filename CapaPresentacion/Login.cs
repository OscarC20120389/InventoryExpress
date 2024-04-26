using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CapaNegocio;
using CapaEntidad;

namespace CapaPresentacion
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }



        private void botoncancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void botoningresar_Click(object sender, EventArgs e)
        {

            //Expresion lambda listar retorna una lista de usuarios donde con la lambda devolvemos aquel usuario que tenga algo iagual lo escrito en la caja de texto
            Usuario ousuario = new CN_Usuario().Listar().Where(u => u.Documento == txtusuario.Text && u.Clave == txtclave.Text ).FirstOrDefault();

            if (ousuario != null)
            {

                Inicio form = new Inicio(ousuario);
                form.FormClosing += frm_closing;
                form.Show();
                this.Hide();

            }
            else {
                MessageBox.Show("No se encontro el usuario","Mensaje",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }
            
        }

        private void frm_closing(object sender, FormClosingEventArgs e) {
            txtusuario.Text = "";
            txtclave.Text = "";
            this.Show();
        }
    }
}
