using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NumberGuessingGame
{
    public partial class main : Form
    {
        Random random = new Random();
        String guess = ""; 
        
         
        public main()
        {
            InitializeComponent();
            this.AcceptButton = btnGuess;
            String guess = "";
            
           
        }

        private void main_Load(object sender, EventArgs e)
        {
            lblText.Text = "Guess a number \nbetween 1 and 100";
            
            
        }
        
        private void btnGuess_Click(object sender, EventArgs e)
        {
            guess = textBox1.Text;
            checkWinner(guess);
        }

        public void checkWinner(String userGuess)
        {
            try { 
            int numToGuess = random.Next(1, 100);
            int guessedNum = int.Parse(guess);

            if(guessedNum <1 || guessedNum > 100)
             {
                    MessageBox.Show("That's not a number between 1 and 100", "Error");
                    lblText.Text = "Guess a number \nbetween 1 and 100";
             }
            if(numToGuess < guessedNum)
            {
                //Output message if the number guessed it too high
                lblText.Text = "Your guess was Too High, \nThe Number was: " + numToGuess +"\n Play again?";
                textBox1.Clear();

            }

            if(numToGuess > guessedNum)
            {
                //output message if too low
                lblText.Text = "Your guess was Too low, \nThe Number was: " + numToGuess + "\n Play again?";
                    textBox1.Clear();
            }
            if(numToGuess == guessedNum)
            {

                //output message box if guess is correct
                MessageBox.Show("You Win", "A WINNER IS YOU");
                    int currentScore;
                    currentScore = 0;
                    currentScore++;
                        lblScore.Text = currentScore.ToString();
                textBox1.Clear();
            }
            
          
           }
           catch (Exception e)
            {
                MessageBox.Show("That's not a number between 1 and 100 you dingus", "ERROR!!!");
                 textBox1.Clear();
            }
        }
    }
}
