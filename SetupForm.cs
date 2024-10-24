using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tic_Tac_Toe___Ivan_Suralta
{
    public partial class SetupForm : Form
    {
        private bool isPlayerXTurn = true;
        private int roundsPlayed = 0;



        public SetupForm()
        {
            InitializeComponent();
        }

        private void btnGrid_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;

            // Check if the button is already clicked
            if (clickedButton.Text != "")
            {
                MessageBox.Show("Invalid move, this spot is already taken!");
                return;
            }

            // Set the symbol for the current player
            if (isPlayerXTurn)
            {
                clickedButton.Text = "X";
            }
            else
            {
                clickedButton.Text = "O";
            }

            // Switch turn to the other player
            isPlayerXTurn = !isPlayerXTurn;

            roundsPlayed++;

            // Check if we have a winner after the move
            CheckWinner();

            // Check if it's a draw
            if (roundsPlayed == 9)
            {
                MessageBox.Show("It's a draw!");
                ResetGrid();
            }
        }

        private void CheckWinner()
        {
            // Winning combinations (row, column, diagonal)
            if (IsWinningCombination(btn1, btn2, btn3) ||
                IsWinningCombination(btn4, btn5, btn6) ||
                IsWinningCombination(btn7, btn8, btn9) ||
                IsWinningCombination(btn1, btn4, btn7) ||
                IsWinningCombination(btn2, btn5, btn8) ||
                IsWinningCombination(btn3, btn6, btn9) ||
                IsWinningCombination(btn1, btn5, btn9) ||
                IsWinningCombination(btn3, btn5, btn7))
            {
                string winner = isPlayerXTurn ? "O" : "X";  // Since we switched turns earlier
                MessageBox.Show($"{winner} wins!");
                ResetGrid();
            }
        }

        private bool IsWinningCombination(Button b1, Button b2, Button b3)
        {
            return b1.Text != "" && b1.Text == b2.Text && b2.Text == b3.Text;
        }

        private void ResetGrid()
        {
            // Reset each button for a new game
            btn1.Text = "";
            btn2.Text = "";
            btn3.Text = "";
            btn4.Text = "";
            btn5.Text = "";
            btn6.Text = "";
            btn7.Text = "";
            btn8.Text = "";
            btn9.Text = "";

            roundsPlayed = 0;
            isPlayerXTurn = true;  // Reset turn to Player X
        }
    }
}
