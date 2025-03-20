namespace TicTacToe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            RestartGame();
        }
        public enum Player
        {
            X, O
        }
        List<Button> buttons;
        int numberOfClicks;
        int playerXWins;
        int playerOWins;
        bool newGame;
        Player currentPlayer;

        private void RestartGame()
        {
            numberOfClicks = 0;
            currentPlayer = Player.X;
            buttons = new List<Button> { button1, button2, button3, button4, button5, button6, button7, button8, button9 };
            foreach (Button button in buttons)
            {
                button.Text = "";
                button.Enabled = true;
                button.BackColor = Color.White;
            }
        }

        private void buttonClick(object sender, EventArgs e)
        {
            newGame = true;
            Button button = (Button)sender;
            button.Text = currentPlayer.ToString();
            button.BackColor = Color.LightGray;
            if (currentPlayer == Player.X) {
             currentPlayer = Player.O;
            }
            else
            {
                currentPlayer = Player.X;
            }
            button.Enabled = false;
            numberOfClicks++;
            checkWin();
            if (newGame)
            {
                botMove();
            }
        }
        public void botMove()
        {
            Random random = new Random();
            int index = random.Next(0, buttons.Count);
            if (buttons[index].Enabled == true)
            {
                buttons[index].Text = currentPlayer.ToString();
                buttons[index].Enabled = false;
                buttons[index].BackColor = Color.LightGray;
                currentPlayer = Player.X;
                numberOfClicks++;
                checkWin();
            }
            else
            {
                botMove();
            }
        }
        private void checkWin()
        {
            if (buttons[0].Text == buttons[1].Text && buttons[1].Text == buttons[2].Text && buttons[0].Text != "")
            {
                Victory();
            }
            else if (buttons[3].Text == buttons[4].Text && buttons[4].Text == buttons[5].Text && buttons[3].Text != "")
            {
                Victory();
            }
            else if (buttons[6].Text == buttons[7].Text && buttons[7].Text == buttons[8].Text && buttons[6].Text != "")
            {
                Victory();
            }
            else if (buttons[0].Text == buttons[3].Text && buttons[3].Text == buttons[6].Text && buttons[0].Text != "")
            {
                Victory();
            }
            else if (buttons[1].Text == buttons[4].Text && buttons[4].Text == buttons[7].Text && buttons[1].Text != "")
            {
                Victory();
            }
            else if (buttons[2].Text == buttons[5].Text && buttons[5].Text == buttons[8].Text && buttons[2].Text != "")
            {
                Victory();
            }
            else if (buttons[0].Text == buttons[4].Text && buttons[4].Text == buttons[8].Text && buttons[0].Text != "")
            {
                Victory();
            }
            else if (buttons[2].Text == buttons[4].Text && buttons[4].Text == buttons[6].Text && buttons[2].Text != "")
            {
                Victory();
            }
            else if (numberOfClicks == 9)
            {
                MessageBox.Show("It's a draw!");
                RestartGame();
            }
        }
        private void Victory()
        {
            if (currentPlayer == Player.O)
            {
                playerXWins++;
                MessageBox.Show("Player X wins!");
                label1.Text = "Player X wins: " + playerXWins;
            }
            else
            {
                playerOWins++;
                MessageBox.Show("Player O wins!");
                label2.Text = "Player O wins: " + playerOWins;
            }
            newGame = false;
            RestartGame();
        }
    }
}
