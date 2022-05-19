using System;
using System.Windows.Forms;

namespace proyectoTienda
{
    public partial class formpuma : Form
    {
        double total;
        public IForm contrato { get; set; }

        public formpuma()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void LblCantidadSuperstar_Click(object sender, EventArgs e)
        {

        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            contrato.ObtenerTotal(total);
            this.Dispose();
        }

        private void btnRestaSuperstar_Click(object sender, EventArgs e)
        {
            RestarPumaMash();
        }

        private void btnSumaSuperstar_Click(object sender, EventArgs e)
        {
            AumentarPumaMash();
        }

        private void btnResta500_Click(object sender, EventArgs e)
        {
            RestarFuture();
        }

        private void BtnSuma500_Click(object sender, EventArgs e)
        {
            AumentarFuture();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void TxtTotalAdidas_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void LblAdidasSuperstar_Click(object sender, EventArgs e)
        {

        }

        private void Cmb350_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CmbSuperstar_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnsumalife_Click(object sender, EventArgs e)
        {
            AumentarLife();
        }

        private void btnrestalife_Click(object sender, EventArgs e)
        {
            RestarLife();
        }

        private void AumentarFuture()
        {
            int cantidad = Convert.ToInt32(Lblcontadorfuture.Text);
            cantidad++;
            Lblcontadorfuture.Text = cantidad.ToString();
            if (cantidad >= 1)
            {
                btnRestafuture.Enabled = true;
            }
            CalcularTotal();
        }

        private void RestarFuture()
        {
            int cantidad = Convert.ToInt32(Lblcontadorfuture.Text);
            if (cantidad >= 1)
            {
                cantidad--;
                Lblcontadorfuture.Text = cantidad.ToString();
            }
            else if (cantidad <= 1)
            {
                btnRestafuture.Enabled = false;
            }
            CalcularTotal();
        }


        private void AumentarPumaMash()
        {
            int cantidad = Convert.ToInt32(lblContadorMash.Text);
            cantidad++;
            lblContadorMash.Text = cantidad.ToString();
            if (cantidad >= 1)
            {
                btnRestaSmash.Enabled = true;
            }
            CalcularTotal();
        }

        private void RestarPumaMash()
        {
            int cantidad = Convert.ToInt32(lblContadorMash.Text);
            if (cantidad >= 1)
            {
                cantidad--;
                lblContadorMash.Text = cantidad.ToString();
            }
            else if (cantidad <= 1)
            {
                btnRestaSmash.Enabled = false;
            }

            CalcularTotal();
        }

        private void AumentarLife()
        {
            int cantidad = Convert.ToInt32(lblContadorPumaLife.Text);
            cantidad++;
            lblContadorPumaLife.Text = cantidad.ToString();
            if (cantidad >= 1)
            {
                btnrestalife.Enabled = true;
            }
            CalcularTotal();
        }

        private void RestarLife()
        {
            int cantidad = Convert.ToInt32(lblContadorPumaLife.Text);
            if (cantidad >= 1)
            {
                cantidad--;
                lblContadorPumaLife.Text = cantidad.ToString();
            }
            else if (cantidad <= 1)
            {
                btnrestalife.Enabled = false;
            }

            CalcularTotal();
        }

        private void CalcularTotal()
        {
            double precioFuture = Convert.ToInt32(Lblcontadorfuture.Text) * Convert.ToDouble(lblpumafuture.Text);
            double precioPumaMash = Convert.ToInt32(Lblpumasmash.Text) * Convert.ToDouble(lblContadorMash.Text);
            double precioLife = Convert.ToInt32(lblContadorPumaLife.Text) * Convert.ToDouble(lblpumalife.Text);
            total = precioFuture + precioPumaMash + precioLife;
            TxtTotalpuma.Text = Convert.ToString(total);
        }

       
    }
}
