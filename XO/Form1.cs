using System;
using System.Drawing;
using System.Windows.Forms;

namespace XO
{
    public partial class Form1 : Form
    {
        private bool isPlayer1Turn = true;
        private int player1Score = 0;
        private int player2Score = 0;

        public Form1()
        {
            InitializeComponent();
            AttachClickEventsToButtons();
        }

        private void AttachClickEventsToButtons()
        {
            btnA1.Click += Button_Click;
            btnA2.Click += Button_Click;
            btnA3.Click += Button_Click;
            btnB1.Click += Button_Click;
            btnB2.Click += Button_Click;
            btnB3.Click += Button_Click;
            btnC1.Click += Button_Click;
            btnC2.Click += Button_Click;
            btnC3.Click += Button_Click;
        }

        private void Button_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn.Text != "")
                return;

            string symbol = isPlayer1Turn ? "X" : "O";
            btn.Text = symbol;

            btnDisplayTurn.Text = isPlayer1Turn ? "Player1" : "Player2";

            if (CheckForWin(symbol))
            {
                MessageBox.Show($"Player {symbol} wins!");

                if (symbol == "X")
                    player1Score++;
                else
                    player2Score++;

                btnPlayer1Score.Text = player1Score.ToString();
                btnPlayer2Score.Text = player2Score.ToString();
            }
            else if (CheckForDraw())
            {
                MessageBox.Show("It's a draw!");
                btnReset_Click(sender, e);
            }

            //switch turns
            isPlayer1Turn = !isPlayer1Turn;
        }


        private bool CheckForWin(string symbol)
        {
            //check rows 
            if (btnA1.Text == symbol && btnA2.Text == symbol && btnA3.Text == symbol)
                return true;
            if (btnB1.Text == symbol && btnB2.Text == symbol && btnB3.Text == symbol)
                return true;
            if (btnC1.Text == symbol && btnC2.Text == symbol && btnC3.Text == symbol)
                return true;

            //check columns 
            if (btnA1.Text == symbol && btnB1.Text == symbol && btnC1.Text == symbol)
                return true;
            if (btnA2.Text == symbol && btnB2.Text == symbol && btnC2.Text == symbol)
                return true;
            if (btnA3.Text == symbol && btnB3.Text == symbol && btnC3.Text == symbol)
                return true;

            //check diagonals
            if (btnA1.Text == symbol && btnB2.Text == symbol && btnC3.Text == symbol)
                return true;
            if (btnA3.Text == symbol && btnB2.Text == symbol && btnC1.Text == symbol)
                return true;

            return false; // no winning 
        }


        private bool CheckForDraw()
        {
            return btnA1.Text != "" &&
                   btnA2.Text != "" &&
                   btnA3.Text != "" &&
                   btnB1.Text != "" &&
                   btnB2.Text != "" &&
                   btnB3.Text != "" &&
                   btnC1.Text != "" &&
                   btnC2.Text != "" &&
                   btnC3.Text != "" &&
                   !CheckForWin("X") && !CheckForWin("O");
        }
        //reset
        private void btnReset_Click(object sender, EventArgs e)
        {
            btnA1.Text = "";
            btnA2.Text = "";
            btnA3.Text = "";
            btnB1.Text = "";
            btnB2.Text = "";
            btnB3.Text = "";
            btnC1.Text = "";
            btnC2.Text = "";
            btnC3.Text = "";

            isPlayer1Turn = true;
        }

        //exit game
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //new game
        private void btnNewGame_Click(object sender, EventArgs e)
        {
            player1Score = 0;
            player2Score = 0;

            btnReset_Click(sender, e);

            btnPlayer1Score.Text =  player1Score.ToString();
            btnPlayer2Score.Text =  player2Score.ToString();
        }

    }
}



