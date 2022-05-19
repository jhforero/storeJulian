using System;
using System.Windows.Forms;

namespace proyectoTienda
{
    public partial class FormCatalogo : Form, IForm
    {
        public FormCatalogo()
        {
            InitializeComponent();

        }

        private void btnIr_Click(object sender, EventArgs e)
        {
            try
            {
                ValidateForm();
            }
            catch (Exception error)
            {
                MessageBox.Show("Ocurrio un error " + error.Message.ToString());
            }

        }

        private void ValidateForm()
        {
            int opc;
            if (txtOpc.Text == "")
            {
                MessageBox.Show("Por favor digite una opcion valida");
            }
            else
            {
                opc = Convert.ToInt32(txtOpc.Text);

                switch (opc)
                {
                    case 1:
                        //Llamar al formulario formNike
                        Formnike objnike = new Formnike();
                        objnike.contrato = this;
                        objnike.Show();
                        break;

                    case 2:
                        //Llamar al formulario formAdidas
                        FormAdidas objAdidas = new FormAdidas();
                        objAdidas.contrato = this;
                        objAdidas.Show();

                        break;

                    case 3:
                        //Llamar al formulario formAdidas
                        formpuma objPuma = new formpuma();
                        objPuma.contrato = this;
                        objPuma.Show();
                        break;
                }
            }

        }

        private void label7_Click(object sender, EventArgs e)
        {
        }



        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtSubTotal.Text = "0";
        }

        public void ObtenerTotal(double totalNike)
        {
            double total = Convert.ToDouble(txtSubTotal.Text ?? "0");
            txtSubTotal.Text = Convert.ToString(total + totalNike);
        }
    }


}
