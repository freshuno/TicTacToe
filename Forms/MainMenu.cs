using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            TicTacToe tictactoe = new TicTacToe(true);
            tictactoe.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TicTacToe tictactoe = new TicTacToe(false);
            tictactoe.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AboutBox AboutBox = new AboutBox();
            AboutBox.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
