using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InfosCEP
{
    public partial class ConsultorDeCEP : Form
    {
        public ConsultorDeCEP()
        {
            InitializeComponent();
                
            LogradouroTextBox.Enabled = false;
            LogradouroTextBox.ReadOnly = true;

            BairroTextBox.Enabled = false;
            BairroTextBox.ReadOnly = true;

            LocalidadeTextBox.Enabled = false;
            LocalidadeTextBox.ReadOnly = true;

            UFTextBox.Enabled = false;
            UFTextBox.ReadOnly = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void CEP_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private async void BtnPesquisarCep_ClickAsync(object sender, EventArgs e)
        {
            string cep = CEP.Text;
            PesquisarCEP pesquisarCep = new PesquisarCEP();

            try
            {
                InfosViaService endereco = await pesquisarCep.ConsultarCEP(cep);

                LogradouroTextBox.Text = endereco.Logradouro;
                BairroTextBox.Text = endereco.Bairro;
                LocalidadeTextBox.Text = endereco.Localidade;
                UFTextBox.Text = endereco.UF;

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void contextMenuStrip3_Opening(object sender, CancelEventArgs e)
        {

        }

        private void contextMenuStrip4_Opening(object sender, CancelEventArgs e)
        {

        }
    }
}
