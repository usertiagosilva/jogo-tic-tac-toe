namespace JogoDaVelha
{
    public partial class Form1 : Form
    {
        // Declare a vari�vel de controle aqui, dentro da classe Form1, mas fora dos m�todos.
        private bool isXTurn = true; // Indica que o jogador X come�a o jogo

        private Button[,] buttons; // Para armazenar os bot�es do tabuleiro

        public Form1()
        {
            InitializeComponent(); // Inicializa os componentes visuais do formul�rio
            InitializeBoard(); // M�todo que inicializa o tabuleiro
            {
                buttons = new Button[3, 3]
                {
        { btn00, btn01, btn02 },
        { btn10, btn11, btn12 },
        { btn20, btn21, btn22 }
                };

                foreach (Button btn in buttons)
                {
                    btn.Click += ButtonClick; // Associa o evento de clique a todos os bot�es
                }
            }
        }
        private void CheckWinner()
        {
            // Verifica linhas, colunas e diagonais
            for (int i = 0; i < 3; i++)
            {
                if (buttons[i, 0].Text != "" && buttons[i, 0].Text == buttons[i, 1].Text && buttons[i, 1].Text == buttons[i, 2].Text)
                {
                    ShowWinner(buttons[i, 0].Text);
                    return;
                }

                if (buttons[0, i].Text != "" && buttons[0, i].Text == buttons[1, i].Text && buttons[1, i].Text == buttons[2, i].Text)
                {
                    ShowWinner(buttons[0, i].Text);
                    return;
                }
            }

            // Verifica as diagonais
            if (buttons[0, 0].Text != "" && buttons[0, 0].Text == buttons[1, 1].Text && buttons[1, 1].Text == buttons[2, 2].Text)
            {
                ShowWinner(buttons[0, 0].Text);
                return;
            }
            if (buttons[0, 2].Text != "" && buttons[0, 2].Text == buttons[1, 1].Text && buttons[1, 1].Text == buttons[2, 0].Text)
            {
                ShowWinner(buttons[0, 2].Text);
                return;
            }

            // Verifica empate
            if (AllButtonsClicked())
            {
                lblStatus.Text = "Empate!";
            }
        }

        private void ShowWinner(string winner)
        {
            lblStatus.Text = $"Jogador {winner} venceu!";
            DisableButtons();
        }
        private bool AllButtonsClicked()
        {
            foreach (Button btn in buttons)
            {
                if (btn.Text == "")
                    return false; // Se h� bot�es n�o clicados, n�o � empate
            }
            return true;
        }
        private void DisableButtons()
        {
            foreach (Button btn in buttons)
            {
                btn.Enabled = false;
            }
        }
        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            foreach (Button btn in buttons)
            {
                btn.Text = ""; // Limpa o texto dos bot�es
                btn.Enabled = true; // Reativa os bot�es
            }

            lblStatus.Text = ""; // Limpa a mensagem de status
            isXTurn = true; // Reinicia o turno para o jogador X
        }
        private void ButtonClick(object sender, EventArgs e)
        {
            Button btn = sender as Button;

            if (btn.Text == "") // Verifica se o bot�o est� vazio
            {
                btn.Text = isXTurn ? "X" : "O"; // Insere "X" ou "O"
                isXTurn = !isXTurn; // Alterna o turno
                CheckWinner(); // Verifica se h� um vencedor
            }
        }

        private void InitializeBoard()
        {
            // Aqui voc� inicializa o tabuleiro e associa os eventos de clique aos bot�es.
        }

        // Outros m�todos, como ButtonClick() e CheckWinner(), ir�o vir aqui.
    }
}
