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
    public partial class FormAdidas : Form
    {
        double total;

        public IForm contrato { get; set; }

        public FormAdidas()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void LblAdidasSuperstar_Click(object sender, EventArgs e)
        {

        }

        private void BtnSuma500_Click(object sender, EventArgs e)
        {
            if (ValidarTalla500())
            {
                Aumentar500();
            }

        }


        private bool ValidarTalla500()
        {

            if (Cmb500.Text == "")
            {
                MessageBox.Show("Seleccione una talla");
                return false;
            }
            return true;
        }


        private void Aumentar500()
        {
            int cantidad = Convert.ToInt32(LblCantidad500.Text);
            cantidad++;
            LblCantidad500.Text = cantidad.ToString();
            if (cantidad >= 1)
            {
                btnResta500.Enabled = true;
            }
            CalcularTotal();
        }



        private void RestarYeezy500()
        {
            int cantidad = Convert.ToInt32(LblCantidad500.Text);
            if (cantidad >= 1)
            {
                cantidad--;
                LblCantidad500.Text = cantidad.ToString();
            }
            else if (cantidad <= 1)
            {
                btnResta500.Enabled = false;
            }
            CalcularTotal();
        }



        private bool ValidarTallaSuperstar()
        {
            if (CmbSuperstar.Text == "")
            {
                MessageBox.Show("Seleccione una talla");
                return false;
            }
            return true;

        }

        private void AumentarSuperstar()
        {
            int cantidad = Convert.ToInt32(LblCantidadSuperstar.Text);
            cantidad++;
            LblCantidadSuperstar.Text = cantidad.ToString();
            if (cantidad >= 1)
            {
                btnRestaSuperstar.Enabled = true;
            }


        }


        private void RestarSuperstar()
        {
            int cantidad = Convert.ToInt32(LblCantidadSuperstar.Text);
            if (cantidad >= 1)
            {
                cantidad--;
                LblCantidadSuperstar.Text = cantidad.ToString();
            }
            else if (cantidad <= 1)
            {
                btnRestaSuperstar.Enabled = false;
            }
            CalcularTotal();
        }



        private void Cmb500_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnResta500_Click(object sender, EventArgs e)
        {
            RestarYeezy500();
        }

        private void btnSumaSuperstar_Click(object sender, EventArgs e)
        {

            if (ValidarTallaSuperstar())
            {
                AumentarSuperstar();
                CalcularTotal();
            }
        }

        private void aumentar350()
        {
            int cantidad = Convert.ToInt32(LblCantidad350.Text);
            cantidad++;
            LblCantidad350.Text = cantidad.ToString();
            if (cantidad >= 1)
            {
                btnResta350.Enabled = true;
            }
            CalcularTotal();

        }

        private void Restar350()
        {
            int cantidad = Convert.ToInt32(LblCantidad350.Text);
            if (cantidad >= 1)
            {
                cantidad--;
                LblCantidad350.Text = cantidad.ToString();
            }
            else if (cantidad <= 1)
            {
                btnResta350.Enabled = false;
            }
            CalcularTotal();
        }
        private bool ValidarTalla350()
        {
            if (Cmb350.Text == "")
            {
                MessageBox.Show("Seleccione una talla");
                return false;
            }
            return true;
        }

        private void btnRestaSuperstar_Click(object sender, EventArgs e)
        {
            RestarSuperstar();
        }

        private void btnSuma350_Click(object sender, EventArgs e)
        {
            if (ValidarTalla350())

            {
                aumentar350();
            }
        }
        private void CalcularTotal()
        {
            double precioyeezy = Convert.ToInt32(LblCantidad500.Text) * Convert.ToDouble(LblAdidasYeezy500.Text);
            double preciosuperstar = Convert.ToInt32(LblCantidadSuperstar.Text) * Convert.ToDouble(LblAdidasSuperstar.Text);
            double precio350 = Convert.ToInt32(LblCantidad350.Text) * Convert.ToDouble(LblAdidasYeezy350.Text);
            total = precioyeezy + preciosuperstar + precio350;
            TxtTotalAdidas.Text = Convert.ToString(total);
        }
        private void btnResta350_Click(object sender, EventArgs e)
        {
            Restar350();
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            contrato.ObtenerTotal(total);
            this.Dispose();
        }
    }
}
