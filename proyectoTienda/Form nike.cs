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
    public partial class Formnike : Form
    {
        double total;

        public IForm contrato { get; set; }

        public Formnike()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            RestarForceOne();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (ValidarTallaF())
            {
                AumentaForceOne();
            }
        }

        private void BotonMasJ_Click(object sender, EventArgs e)
        {


            if (ValidarTallaJ())
            {
                AumentarJordan();
            }
        }

        private void BotonMenosJ_Click(object sender, EventArgs e)
        {
            RestarJordan();

        }

        private void CmbJordan1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CmbDawn_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnsumadawn_Click(object sender, EventArgs e)
        {
            if (validarTallaD())
            {
                AumentarDawn();
            }
        }

        private void LblDawnprecio_Click(object sender, EventArgs e)
        {

        }

        private void btnrestadawn_Click(object sender, EventArgs e)
        {
            RestarDawn();
        }

        #region:Funciones para el calculo del catalogo Nike

        private void AumentarJordan()
        {
            int cantidad = Convert.ToInt32(LblCantidadJ.Text);
            cantidad++;
            LblCantidadJ.Text = cantidad.ToString();
            if (cantidad >= 1)
            {
                BotonMenosJ.Enabled = true;
            }
            CalcularTotal();
        }

        private void AumentarDawn()
        {
            int cantidad = Convert.ToInt32(LblCantidadDawn.Text);
            cantidad++;
            LblCantidadDawn.Text = cantidad.ToString();
            if (cantidad >= 1)
            {
                btnrestadawn.Enabled = true;
            }
            CalcularTotal();
        }

        private void AumentaForceOne()
        {
            int cantidad = Convert.ToInt32(LblCantidadF.Text);
            cantidad++;
            LblCantidadF.Text = cantidad.ToString();
            if (cantidad >= 1)
            {
                button2.Enabled = true;
            }
            CalcularTotal();
        }


        private void RestarDawn()
        {

            int cantidad = Convert.ToInt32(LblCantidadDawn.Text);
            if (cantidad >= 1)
            {
                cantidad--;
                LblCantidadDawn.Text = cantidad.ToString();
            }
            else if (cantidad <= 1)
            {
                btnrestadawn.Enabled = false;
            }
            CalcularTotal();
        }

        private void RestarForceOne()
        {
            int cantidad = Convert.ToInt32(LblCantidadF.Text);
            if (cantidad >= 1)
            {
                cantidad--;
                LblCantidadF.Text = cantidad.ToString();
            }
            else if (cantidad <= 1)
            {
                button2.Enabled = false;
            }
            CalcularTotal();
        }

        private void RestarJordan()
        {

            int cantidad = Convert.ToInt32(LblCantidadJ.Text);
            if (cantidad >= 1)
            {
                cantidad--;
                LblCantidadJ.Text = cantidad.ToString();
            }
            else if (cantidad <= 1)
            {
                BotonMenosJ.Enabled = false;
            }
            CalcularTotal();
        }

        private void CalcularTotal()
        {
            double precioF = Convert.ToInt32(LblCantidadF.Text) * Convert.ToDouble(LblForcePrecio.Text);
            double precioD = Convert.ToInt32(LblCantidadDawn.Text) * Convert.ToDouble(LblDawnprecio.Text);
            double precioJ = Convert.ToInt32(LblCantidadJ.Text) * Convert.ToDouble(LblJordanprecio.Text);
            total = precioF + precioD + precioJ;
            TxtTotalNike.Text = Convert.ToString(total);
        }

        #endregion

        #region:Validar Tallas

        private bool ValidarTallaF()
        {
            if (CmbNikeairforce.Text == "")
            {
                MessageBox.Show("Seleccione una talla");
                return false;
            }
            return true;
        }

        private bool ValidarTallaJ()
        {

            if (CmbJordan1.Text == "")
            {
                MessageBox.Show("Seleccione una talla");
                return false;
            }
            return true;
        }

        private bool validarTallaD()
        {

            if (CmbDawn.Text == "")
            {
                MessageBox.Show("Seleccione una talla");
                return false;
            }
            return true;
        }
        #endregion

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            contrato.ObtenerTotal(total);
            this.Dispose();            
        }

        private void TxtTotalNike_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
