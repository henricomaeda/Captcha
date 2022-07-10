using System;
using System.Windows.Forms;

namespace Captcha
{
    public partial class FrmCaptcha : Form
    {
        // Definindo a captcha como inválida.
        private int i = -1;

        public FrmCaptcha()
        {
            // Iniciando componente de verificação.
            InitializeComponent();
        }

        private void FrmCaptcha_Load(object sender, EventArgs e)
        {
            // Definindo uma captcha aleatória.
            Random r = new Random();
            i = r.Next(0, 3);

            // Definindo mensagem de seleção no título.
            if (i == 0) Text = "Selecione a imagem que representa os cookies.";
            else if (i == 1) Text = "Selecione a imagem que representa as folhas.";
            else if (i == 2) Text = "Selecione a imagem que representa um laço.";
            else Text = "Não foi possível realizar a mensagem de seleção.";
        }

        private void VerifyCaptcha(object sender, EventArgs e)
        {
            // Definindo variáveis padrões para a resposta do usuário.
            var t = "Você realizou a verificação com sucesso!";
            var c = "";
            var b = MessageBoxButtons.OK;
            var icon = MessageBoxIcon.Information;

            // Verificando escolha do usuário e definindo mensagem.
            if (sender == picCookie && i == 0) Enabled = false;
            else if (sender == picLeaves && i == 1) Enabled = false;
            else if (sender == picRibbon && i == 2) Enabled = false;
            else
            {
                t = "Não foi possível realizar a verificação.";
                icon = MessageBoxIcon.Error;
            }

            // Enviando resposta para o usuário.
            MessageBox.Show(t, c, b, icon);

            // Processando se a verificação detectar um robô.
            if (Enabled != false) Application.ExitThread();
            else
            {
                // Processando se usuário.
                picCookie.Enabled = false;
                picLeaves.Enabled = false;
                picRibbon.Enabled = false;
                Enabled = true;
            }
        }
    }
}
