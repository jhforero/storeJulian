using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyectoTienda
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            try
            {
                ValidateForm();
            }
            catch (Exception )
            {
                MessageBox.Show("Ocurrio un error");
            }
            
        }

        private void ValidateForm()
        {
            if (txtAge.Text == ""||txtIdentificacion.Text == "" || txtNombre.Text == "")
            {
                MessageBox.Show("Ingrese los datos solicitados");
                txtAge.Focus();
                txtNombre.Focus();
                txtIdentificacion.Focus();

                   

            }
            else if (Convert.ToInt32(txtAge.Text) < 18)
            {
                MessageBox.Show("Debe ser mayor de edad");
            }
            else if (Convert.ToInt32(txtAge.Text) >= 18)
            {
                CallForm();
              
            }
        }

        private void CallForm()
        {
            FormCatalogo objeto1 = new FormCatalogo();
            Hide();
            objeto1.Show();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
