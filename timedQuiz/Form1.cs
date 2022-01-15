using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace timedQuiz
{
    public partial class timedQuiz : Form
    {
        // randomizer generates random numbers
        Random randomizer = new Random();

        // remaining time
        int timeLeft;

        // for addition problem
        int addEnd1, addEnd2;
        // for subtraction problem
        int minuEnd, subtrahEnd;
        // for muliplication problem
        int multiplicand, multiplier;
        // for division problem
        int dividend, divisor;

        public void StartQuiz()
        {
            
            // generate two random numbers to add
            addEnd1 = randomizer.Next(51);
            addEnd2 = randomizer.Next(51);
            // generate two random numbers to subtract
            minuEnd = randomizer.Next(1, 101);
            subtrahEnd = randomizer.Next(1, minuEnd);
            // generate two random numbers to muliply
            multiplicand = randomizer.Next(2, 11);
            multiplier = randomizer.Next(2, 11);
            // generate two random numbers to divide
            divisor = randomizer.Next(2, 11);
            int temporaryQuotient = randomizer.Next(2, 11);
            dividend = divisor * temporaryQuotient;


            //display the numbers
            plusLeftLabel.Text = addEnd1.ToString();
            plusRightLabel.Text = addEnd2.ToString();
            minusLeftLabel.Text = minuEnd.ToString();
            minusRightLabel.Text = subtrahEnd.ToString();
            timesLeftLabel.Text = multiplicand.ToString();
            timesRightLabel.Text = multiplier.ToString();
            dividedLeftLabel.Text = dividend.ToString();
            dividedRightLabel.Text = divisor.ToString();

            sum.Value = 0;
            difference.Value = 0;
            product.Value = 0;
            quotient.Value = 0;

            // Start the timer.
            timeLeft = 60;
            timeLabel.Text = "60 seconds";
            timer.Start();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            StartQuiz();
            startButton.Enabled = false;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (checkAnswer())
            {
                // If CheckTheAnswer() returns true, then the user 
                // got the answer right. Stop the timer  
                // and show a MessageBox.
                timer.Stop();
                MessageBox.Show("You got all the answers right!",
                                "Congratulations!");
                startButton.Enabled = true;
            }
            else if (timeLeft > 0)
            {
                // update and display the time left
                timeLeft = timeLeft - 1;
                timeLabel.Text = timeLeft + " seconds";
            }
            else
            {
                // if the user ran out of time:
                // strop th timer, show a messageBox
                // and fill in the answers
                timer.Stop();
                timeLabel.Text = "Time's up!";
                MessageBox.Show("You didn't finish in time.", "Sorry!");
                sum.Value = addEnd1 + addEnd2;
                difference.Value = minuEnd - subtrahEnd;
                startButton.Enabled = true;
            }
        }

        private bool checkAnswer()
        {
            if ((addEnd1 + addEnd2 == sum.Value)
                && (minuEnd - subtrahEnd == difference.Value)
                && (multiplicand * multiplier == product.Value)
                && (dividend / divisor == quotient.Value)
               )
                return true;
            else 
                return false;
        }

        private void answer_Enter(object sender, EventArgs e)
        {
            NumericUpDown answerBox = sender as NumericUpDown;

            if (answerBox != null)
            {
                int lenghtOfAnswer = answerBox.Value.ToString().Length;
                answerBox.Select(0, lenghtOfAnswer);
            }
        }

        public timedQuiz()
        {
            InitializeComponent();
        }
    }
}
