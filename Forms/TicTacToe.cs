namespace TicTacToe
{
    public partial class TicTacToe : Form
    {
        public TicTacToe(bool Mode)
        {
            InitializeComponent();
            RestartGame();
            botMode = Mode;
            if (!botMode)
            {
                label3.Visible = true;
            }
        }
        public enum Player
        {
            X, O
        }
        List<Button> buttons;
        int numberOfClicks;
        int playerXWins;
        int playerOWins;
        bool botMode;
        bool newGame;
        Player currentPlayer;
        private readonly int[,] winPatterns = new int[,]
        {
         { 0, 1, 2 }, { 3, 4, 5 }, { 6, 7, 8 }, 
         { 0, 3, 6 }, { 1, 4, 7 }, { 2, 5, 8 }, 
         { 0, 4, 8 }, { 2, 4, 6 }              
         };
        private void RestartGame()
        {
            numberOfClicks = 0;
            currentPlayer = Player.X;
            label3.Text = $"Current player: {currentPlayer}";
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
            label3.Text = $"Current player: {currentPlayer}";
            button.Enabled = false;
            numberOfClicks++;
            checkWin();
            if (newGame && botMode)
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
            foreach (var i in Enumerable.Range(0, winPatterns.GetLength(0)))
            {
                if (buttons[winPatterns[i, 0]].Text == buttons[winPatterns[i, 1]].Text &&
                    buttons[winPatterns[i, 1]].Text == buttons[winPatterns[i, 2]].Text &&
                    buttons[winPatterns[i, 0]].Text != "")
                {
                    Victory();
                    return;
                }
            }

            if (numberOfClicks == 9)
            {
                MessageBox.Show("It's a draw!");
                newGame = false;
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
