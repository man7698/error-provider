using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace errorprovider
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtnome_Validating(object sender, CancelEventArgs e)
        {
            if (txtnome.Text == string.Empty)
            {

                errorProvider1.SetError(txtnome, "Voce precisa digitar um nome !!!");

            }
            else
                errorProvider1.SetError(txtnome,"");
        }

        private void btnok_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Operação Realizada com Sucesso !!!");
        }

        private void btnhabilitar_Click(object sender, EventArgs e)
        {
            frmhabilitar h = new frmhabilitar();
            h.btnok.Enabled = true;
            h.Show();
            
        }

        private void txtidade_Validating(object sender, CancelEventArgs e)
        {
            if (txtidade.Text == string.Empty)
            {
                errorProvider1.SetError(txtidade, "Voce precisa digitar uma idade");

            }
            else
            {
                errorProvider1.SetError(txtidade,"");
                if (int.Parse(txtidade.Text) < 18)
                {
                    errorProvider1.SetError(txtidade, "Voce deve ter 18 anos ou mais !!");
                }
                else
                    errorProvider1.SetError(txtidade, "");

            }
        }
    }
}
