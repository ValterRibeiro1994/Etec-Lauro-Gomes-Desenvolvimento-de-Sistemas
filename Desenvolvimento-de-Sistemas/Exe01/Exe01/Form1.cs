using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exe01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            if (validarEntradas())
            {
                outputResposta.Text = "Seja bem-vindo " + inputNome.Text;
                return;
            }
        }

        private bool validarCampo(string campo)
        {
            return String.IsNullOrEmpty(campo);
        }

        private bool validarEntradas()
        {
            if (validarCampo(inputNome.Text))
            {
                outputResposta.Text = "Campo nome está vazio, tente novamente !!!";
                return false;
            }

            if (validarCampo(inputSenha.Text))
            {
                outputResposta.Text = "Campo senha está vazio, tente novamente !!!";
                return false;
            }

            return true;
        }
    }
}
