using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aulas1a3
{

    public partial class Form1 : Form
    {

        private bool ValidarCampo(TextBox txt, out double valor)
        {
            if (double.TryParse(txt.Text, out valor))
            {
                txt.BackColor = Color.White;
                return true;
            }
            else
            {
                txt.BackColor = Color.Red;
                valor = 0;
                return false;
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }





        private void btnCriar_Click(object sender, EventArgs e)
        {
            double x, y, z;

            bool okX = ValidarCampo(txtX, out x);
            bool okY = ValidarCampo(txtY, out y);

            // Se X ou Y forem inválidos
            if (!okX || !okY)
            {
                lblResultado.Text = "Corrija os valores a vermelho!";
                return;
            }

            // Se Z estiver vazio, criar Ponto2D
            if (string.IsNullOrWhiteSpace(txtZ.Text))
            {
                Ponto2D p = new Ponto2D(x, y);

                lblResultado.Text = p.EscreverPonto();
            }
            else
            {
                // Se Z estiver preenchido, validar e criar Ponto3D
                if (!ValidarCampo(txtZ, out z))
                {
                    lblResultado.Text = "Corrija o valor de Z!";
                    return;
                }

                Ponto3D p = new Ponto3D(x, y, z);

                lblResultado.Text = p.EscreverPonto();
            }
        }

        private void lblResultado_Click(object sender, EventArgs e)
        {

        }
    }
}

