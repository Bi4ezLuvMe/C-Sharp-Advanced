using System;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;

namespace tic_tac_toe
{

    public partial class TicTacToe : Form
    {
        public int Counter = 0;
        public TicTacToe()
        {
            InitializeComponent();
        }
        private bool isDraw()
        {
            if(button2.Text != "-"&& button3.Text != "-" && button4.Text != "-" && button5.Text != "-" && button6.Text != "-" && button7.Text != "-" && button8.Text != "-" && button9.Text != "-" && button10.Text != "-")
            {
                return true;
            }
            return false;
        }
        private bool isComputerWon()
        {
            if(button2.Text == "O"&& button3.Text == "O" && button4.Text == "O")
            {
                return true;
            }
            if (button2.Text == "O" && button5.Text == "O" && button8.Text == "O")
            {
                return true;
            }
            if (button8.Text == "O" && button9.Text == "O" && button10.Text == "O")
            {
                return true;
            }
            if (button4.Text == "O" && button7.Text == "O" && button10.Text == "O")
            {
                return true;
            }
            if (button2.Text == "O" && button6.Text == "O" && button10.Text == "O")
            {
                return true;
            }
            if (button4.Text == "O" && button6.Text == "O" && button8.Text == "O")
            {
                return true;
            }
            if (button3.Text == "O" && button6.Text == "O" && button9.Text == "O")
            {
                return true;
            }
            if (button5.Text == "O" && button6.Text == "O" && button7.Text == "O")
            {
                return true;
            }
            return false;
        }
        private bool isHumanWon()
        {
            if (button2.Text == "X" && button3.Text == "X" && button4.Text == "X")
            {
                return true;
            }
            if (button2.Text == "X" && button5.Text == "X" && button8.Text == "X")
            {
                return true;
            }
            if (button8.Text == "X" && button9.Text == "X" && button10.Text == "X")
            {
                return true;
            }
            if (button4.Text == "X" && button7.Text == "X" && button10.Text == "X")
            {
                return true;
            }
            if (button2.Text == "X" && button6.Text == "X" && button10.Text == "X")
            {
                return true;
            }
            if (button4.Text == "X" && button6.Text == "X" && button8.Text == "X")
            {
                return true;
            }
            if (button3.Text == "X" && button6.Text == "X" && button9.Text == "X")
            {
                return true;
            }
            if (button5.Text == "X" && button6.Text == "X" && button7.Text == "X")
            {
                return true;
            }
            return false;
        }
        private void Computer()
        {
            Random random = new Random();
            int index = random.Next(1, 9);
            bool temp = false;
            while (temp == false)
            {
                if (index == 1) { if (button2.Text == "-") { button2.Text = "O"; button2.IsAccessible = false; temp = true; } else { index++; } }
                if (index == 2) { if (button3.Text == "-") { button3.Text = "O"; button3.IsAccessible = false; temp = true; } else { index++; } }
                if (index == 3) { if (button4.Text == "-") { button4.Text = "O"; button4.IsAccessible = false; temp = true; } else { index++; } }
                if (index == 4) { if (button5.Text == "-") { button5.Text = "O"; button5.IsAccessible = false; temp = true; } else { index++; } }
                if (index == 5) { if (button6.Text == "-") { button6.Text = "O"; button6.IsAccessible = false; temp = true; } else { index++; } }
                if (index == 6) { if (button7.Text == "-") { button7.Text = "O"; button7.IsAccessible = false; temp = true; } else { index++; } }
                if (index == 7) { if (button8.Text == "-") { button8.Text = "O"; button8.IsAccessible = false; temp = true; } else { index++; } }
                if (index == 8) { if (button9.Text == "-") { button9.Text = "O"; button9.IsAccessible = false; temp = true; } else { index++; } }
                if (index == 9) { if (button10.Text == "-") { button10.Text = "O"; button10.IsAccessible = false; temp = true; } else { index = 1; } }
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        public void button1_Click_1(object sender, EventArgs e)
        {
            button2.Visible = true;
            button3.Visible = true;
            button4.Visible = true;
            button5.Visible = true;
            button6.Visible = true;
            button7.Visible = true;
            button8.Visible = true;
            button9.Visible = true;
            button10.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button2.Text == "-")
            {
                button2.Text = "X";
                button2.IsAccessible = false;
                Counter++;
                if (Counter != 9)
                {
                    Computer();
                    Counter++;
                }
                if (isComputerWon())
                {
                    label2.Text = "Computer won! Better luck next time!";
                }
                else if (isHumanWon())
                {
                    label2.Text = "You won! Good job!";
                }
                else if(isDraw())
                {
                    label2.Text = "It's a draw :(";
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button3.Text == "-")
            {
                button3.Text = "X";
                button3.IsAccessible = false;
                Counter++;
                if (Counter != 9)
                {
                    Computer();
                    Counter++;
                }
                if (isComputerWon())
                {
                    label2.Text = "Computer won! Better luck next time!";
                }
                else if(isHumanWon())
                {
                    label2.Text = "You won! Good job!";
                }
                else if(isDraw())
                {
                    label2.Text = "It's a draw :(";
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (button4.Text == "-")
            {
                button4.Text = "X";
                button4.IsAccessible = false;
                Counter++;
                if (Counter != 9)
                {
                    Computer();
                    Counter++;
                }
                if (isComputerWon())
                {
                    label2.Text = "Computer won! Better luck next time!";
                }
                else if(isHumanWon())
                {
                    label2.Text = "You won! Good job!";
                }
                else if(isDraw())
                {
                    label2.Text = "It's a draw :(";
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (button5.Text == "-")
            {
                button5.Text = "X";
                button5.IsAccessible = false;
                Counter++;
                if (Counter != 9)
                {
                    Computer();
                    Counter++;
                }
                if (isComputerWon())
                {
                    label2.Text = "Computer won! Better luck next time!";
                }
                else if(isHumanWon())
                {
                    label2.Text = "You won! Good job!";
                }
                else if(isDraw())
                {
                    label2.Text = "It's a draw :(";
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (button6.Text == "-")
            {
                button6.Text = "X";
                button6.IsAccessible = false;
                Counter++;
                if (Counter != 9)
                {
                    Computer();
                    Counter++;
                }
                if (isComputerWon())
                {
                    label2.Text = "Computer won! Better luck next time!";
                }
                else if(isHumanWon())
                {
                    label2.Text = "You won! Good job!";
                }
                else if(isDraw())
                {
                    label2.Text = "It's a draw :(";
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (button7.Text == "-")
            {
                button7.Text = "X";
                button7.IsAccessible = false;
                Counter++;
                if (Counter != 9)
                {
                    Computer();
                    Counter++;
                }
                if (isComputerWon())
                {
                    label2.Text = "Computer won! Better luck next time!";
                }
                else if (isHumanWon())
                {
                    label2.Text = "You won! Good job!";
                }
                else if (isDraw())
                {
                    label2.Text = "It's a draw :(";
                }
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (button8.Text == "-")
            {
                button8.Text = "X";
                button8.IsAccessible = false;
                Counter++;
                if (Counter != 9)
                {
                    Computer();
                    Counter++;
                }
                if (isComputerWon())
                {
                    label2.Text = "Computer won! Better luck next time!";
                }
                else if (isHumanWon())
                {
                    label2.Text = "You won! Good job!";
                }
                else if (isDraw())
                {
                    label2.Text = "It's a draw :(";
                }
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (button9.Text == "-")
            {
                button9.Text = "X";
                button9.IsAccessible = false;
                Counter++;
                if (Counter != 9)
                {
                    Computer();
                    Counter++;
                }
                if (isComputerWon())
                {
                    label2.Text = "Computer won! Better luck next time!";
                }
                else if (isHumanWon())
                {
                    label2.Text = "You won! Good job!";
                }
                else if (isDraw())
                {
                    label2.Text = "It's a draw :(";
                }
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (button10.Text == "-")
            {
                button10.Text = "X";
                button10.IsAccessible = false;
                Counter++;
                if (Counter != 9)
                {
                    Computer();
                    Counter++;
                }
                if (isComputerWon())
                {
                    label2.Text = "Computer won! Better luck next time!";
                }
                else if (isHumanWon())
                {
                    label2.Text = "You won! Good job!";
                }
                else if (isDraw())
                {
                    label2.Text = "It's a draw :(";
                }
            }
        }

        public void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
