namespace calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private int numeroAtual = 0; // Armazena o n�mero atual antes da opera��o
        private string resultado = ""; // Armazena o n�mero que est� sendo digitado
        private string operacaoAtual = ""; // Armazena a opera��o atual (por exemplo, "+")
        private bool operacaoEmAndamento = false;
        private void btn_1_Click(object sender, EventArgs e)
        {
            if (operacaoEmAndamento)
            {
                // Se uma opera��o estiver em andamento, reinicia o resultado e come�a a exibir o n�mero atual
                resultado = "1";
                lbl_resultado.Text = resultado;
                operacaoEmAndamento = false;
            }
            else
            {
                // Adiciona o n�mero ao resultado atual
                resultado += "1";
                lbl_resultado.Text = resultado;
            }
        }

        private void lbl_resultado_Click(object sender, EventArgs e)
        {

        }

        private void btn_mais_Click(object sender, EventArgs e)
        {
            lbl_operacao.Text = "+ " + resultado;
            if (resultado != "")
            {
                // Armazena o n�mero atual antes da opera��o
                numeroAtual = Int32.Parse(resultado);
                resultado = "";
                lbl_resultado.Text = "0";
            }
            operacaoAtual = "+";
            operacaoEmAndamento = true;
        }

        private void btn_igual_Click(object sender, EventArgs e)
        {
            lbl_operacao.Text = "";
            if (resultado != "")
            {
                int numeroInserido = Int32.Parse(resultado);

                switch (operacaoAtual)
                {
                    case "+":
                        numeroAtual += numeroInserido;
                        break;
                    case "-":
                        numeroAtual -= numeroInserido;
                        break;
                    case "/":
                        numeroAtual = (numeroAtual / numeroInserido);
                        break;
                    case "*":
                        numeroAtual = (numeroAtual * numeroInserido);
                        break;


                        // Adicione outros casos para outras opera��es, como subtra��o, multiplica��o e divis�o
                }

                lbl_resultado.Text = numeroAtual.ToString();
                resultado = "";
                operacaoAtual = ""; // Reseta a opera��o ap�s o c�lculo
                operacaoEmAndamento = false;
            }

        }
        public void numclick(int numero)
        {


        }

        private void btn_2_Click(object sender, EventArgs e)
        {
            if (operacaoEmAndamento)
            {
                // Se uma opera��o estiver em andamento, reinicia o resultado e come�a a exibir o n�mero atual
                resultado = "2";
                lbl_resultado.Text = resultado;
                operacaoEmAndamento = false;
            }
            else
            {
                // Adiciona o n�mero ao resultado atual
                resultado += "2";
                lbl_resultado.Text = resultado;
            }
        }

        private void btn_3_Click(object sender, EventArgs e)
        {
            if (operacaoEmAndamento)
            {
                // Se uma opera��o estiver em andamento, reinicia o resultado e come�a a exibir o n�mero atual
                resultado = "3";
                lbl_resultado.Text = resultado;
                operacaoEmAndamento = false;
            }
            else
            {
                // Adiciona o n�mero ao resultado atual
                resultado += "3";
                lbl_resultado.Text = resultado;
            }
        }

        private void btn_4_Click(object sender, EventArgs e)
        {
            if (operacaoEmAndamento)
            {
                // Se uma opera��o estiver em andamento, reinicia o resultado e come�a a exibir o n�mero atual
                resultado = "4";
                lbl_resultado.Text = resultado;
                operacaoEmAndamento = false;
            }
            else
            {
                // Adiciona o n�mero ao resultado atual
                resultado += "4";
                lbl_resultado.Text = resultado;
            }
        }

        private void btn_5_Click(object sender, EventArgs e)
        {
            if (operacaoEmAndamento)
            {
                // Se uma opera��o estiver em andamento, reinicia o resultado e come�a a exibir o n�mero atual
                resultado = "5";
                lbl_resultado.Text = resultado;
                operacaoEmAndamento = false;
            }
            else
            {
                // Adiciona o n�mero ao resultado atual
                resultado += "5";
                lbl_resultado.Text = resultado;
            }
        }

        private void btn_6_Click(object sender, EventArgs e)
        {
            if (operacaoEmAndamento)
            {
                // Se uma opera��o estiver em andamento, reinicia o resultado e come�a a exibir o n�mero atual
                resultado = "6";
                lbl_resultado.Text = resultado;
                operacaoEmAndamento = false;
            }
            else
            {
                // Adiciona o n�mero ao resultado atual
                resultado += "6";
                lbl_resultado.Text = resultado;
            }
        }

        private void btn_7_Click(object sender, EventArgs e)
        {
            if (operacaoEmAndamento)
            {
                // Se uma opera��o estiver em andamento, reinicia o resultado e come�a a exibir o n�mero atual
                resultado = "7";
                lbl_resultado.Text = resultado;
                operacaoEmAndamento = false;
            }
            else
            {
                // Adiciona o n�mero ao resultado atual
                resultado += "7";
                lbl_resultado.Text = resultado;
            }
        }

        private void btn_8_Click(object sender, EventArgs e)
        {
            if (operacaoEmAndamento)
            {
                // Se uma opera��o estiver em andamento, reinicia o resultado e come�a a exibir o n�mero atual
                resultado = "8";
                lbl_resultado.Text = resultado;
                operacaoEmAndamento = false;
            }
            else
            {
                // Adiciona o n�mero ao resultado atual
                resultado += "8";
                lbl_resultado.Text = resultado;
            }
        }

        private void btn_9_Click(object sender, EventArgs e)
        {
            if (operacaoEmAndamento)
            {
                // Se uma opera��o estiver em andamento, reinicia o resultado e come�a a exibir o n�mero atual
                resultado = "9";
                lbl_resultado.Text = resultado;
                operacaoEmAndamento = false;
            }
            else
            {
                // Adiciona o n�mero ao resultado atual
                resultado += "9";
                lbl_resultado.Text = resultado;
            }
        }

        private void btn_menos_Click(object sender, EventArgs e)
        {
            lbl_operacao.Text = "- " + resultado;
            if (resultado != "")
            {
                // Armazena o n�mero atual antes da opera��o
                numeroAtual = Int32.Parse(resultado);
                resultado = "";
                lbl_resultado.Text = "0";
            }
            operacaoAtual = "-";
            operacaoEmAndamento = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_C_Click(object sender, EventArgs e)
        {
            resultado = "0";
            numeroAtual = 0;
            lbl_resultado.Text = resultado;
        }

        private void btn_divisao_Click(object sender, EventArgs e)
        {
            lbl_operacao.Text = "/ " + resultado;
            if (resultado != "")
            {
                // Armazena o n�mero atual antes da opera��o
                numeroAtual = Int32.Parse(resultado);
                resultado = "";
                lbl_resultado.Text = "0";
            }
            operacaoAtual = "/";
            operacaoEmAndamento = true;
        }

        private void btn_vezes_Click(object sender, EventArgs e)
        {
            lbl_operacao.Text = "* " + resultado;
            if (resultado != "")
            {
                // Armazena o n�mero atual antes da opera��o
                numeroAtual = Int32.Parse(resultado);
                resultado = "";
                lbl_resultado.Text = "0";
            }
            operacaoAtual = "*";
            operacaoEmAndamento = true;
        }
    }
}
