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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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

            DDDTextBox.Enabled = false;
            DDDTextBox.ReadOnly = true;

            CEP.KeyPress += CEP_KeyPress;
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
            try
            {
                Cursor.Current = Cursors.WaitCursor;

                string cep = CEP.Text;
                // Remove o hifen para que não haja erros
                if (cep[5] == '-')
                {
                    cep = cep.Remove(5, 1);
                }

                PesquisarCEP pesquisarCep = new PesquisarCEP();

                InfosViaService endereco = await pesquisarCep.ConsultarCEP(cep);

                LogradouroTextBox.Text = endereco.Logradouro;
                BairroTextBox.Text = endereco.Bairro;
                LocalidadeTextBox.Text = endereco.Localidade;
                UFTextBox.Text = endereco.UF;
                DDDTextBox.Text = endereco.DDD;

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }


        }

        private void contextMenuStrip3_Opening(object sender, CancelEventArgs e)
        {

        }

        private void contextMenuStrip4_Opening(object sender, CancelEventArgs e)
        {

        }

        private void DDDTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void CEP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                BtnPesquisarCep.PerformClick();
            }
        }
    }
}
