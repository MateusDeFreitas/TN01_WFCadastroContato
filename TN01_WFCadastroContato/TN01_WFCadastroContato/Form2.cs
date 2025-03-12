using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TN01_WFCadastroContato
{
    public partial class Form2 : Form
    {
        int radio;
        string tipoRadio;
        public Form2()
        {
            InitializeComponent();
            textBoxTelefone.PlaceholderText = "(__) _____-____";
            this.Text = "Cadastrar Contato";
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form = new Form1();
            form.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBoxNome.Text == "")
            {
                MessageBox.Show("O campo nome está vazio", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else if (textBoxSobreNome.Text == "")
            {
                MessageBox.Show("O campo sobrenome está vazio", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else if (textBoxTelefone.Text == "")
            {
                MessageBox.Show("O campo telefone está vazio", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else if (textBoxEmail.Text == "")
            {
                MessageBox.Show("O campo email está vazio", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else if (radio < 1 || radio > 3)
            {
                MessageBox.Show("O campo tipo de telefone está vazio", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (radio == 1)
                {
                    tipoRadio = "Pessoal";
                }
                else if (radio == 2)
                {
                    tipoRadio = "Comercial";
                }
                if (radio == 3)
                {
                    tipoRadio = "Recados";
                }

                string nome = textBoxNome.Text;
                string sobrenome = textBoxSobreNome.Text;
                string telefone = textBoxTelefone.Text;
                string email = textBoxEmail.Text;
                MessageBox.Show($"O nome cadastrado foi: {nome}\nO sobrenome cadastrado foi: {sobrenome}\nO número de telefone cadstrado foi: {telefone}\nO tipo de telefone cadastrado foi: {tipoRadio}\nO emal cadastrado foi: {email}\n", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            radio = 1;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            radio = 2;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            radio = 3;
        }
    }
}
