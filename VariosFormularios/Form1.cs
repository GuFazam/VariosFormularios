using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VariosFormularios
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            if (textBoxInserir.Text == "") // este if está validando o textBoxInserir caso o btnInserir seja clicado sem nenhum texto inserido nele
            {
                MessageBox.Show("Por favor insira um nome no campo!!!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Warning); // cria uma mensagem de aviso
                textBoxInserir.Focus(); // Direciona o foco para textBoxInserir
                return;
            }
            //else é opcional por causa do Return

            textBoxMultTexto.Text += textBoxInserir.Text + ", "; // += adiciona o valor à direita à variável ou propriedade à esquerda e atribui o resultado à variável ou à propriedade à esquerda, o + sózino tá concatenando
            textBoxInserir.Clear(); // está linha limpa o textBoxInserir
            textBoxInserir.Focus(); // Direciona o foco para textBoxInserir
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            textBoxInserir.Clear(); // está linha limpa o textBoxInserir
            textBoxMultTexto.Clear(); // está linha limpa o textBoxMultiTexto
            textBoxInserir.Focus(); // Direciona o foco para textBoxInserir
        }
    }
}
