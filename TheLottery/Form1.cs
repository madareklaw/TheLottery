using System;
using System.Windows.Forms;

namespace TheLottery
{
    public partial class Form1 : Form
    {
        private readonly Lottery _lotto = new Lottery();

        public Form1()
        {
            InitializeComponent();
            // prepopulate with numbers
            RandomNumbersBtn_Click(this, EventArgs.Empty);
        }
        /// <summary>
        /// Play the lotto
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void playBtn_Click(object sender, EventArgs e)
        {

            var playCount = 0u;
            do
            {

                try
                {
                    var isWon = Play();
                    playCount++;
                    if (isWon)
                    {
                        results.Text += $"\rWon after {playCount} trys";
                        break;
                    }
                }
                catch (ArgumentException)
                {
                    // numbers were not right...
                    break;
                }
                Application.DoEvents();

            } while (PlayUntilWinCheckBox.Checked); // keep going if checkbox selected
        }

        /// <summary>
        /// Get random numbers for the player
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RandomNumbersBtn_Click(object sender, EventArgs e)
        {
            textBox1.Text = _lotto.GenerateLotteryNumber().ToString();
            textBox2.Text = _lotto.GenerateLotteryNumber().ToString();
            textBox3.Text = _lotto.GenerateLotteryNumber().ToString();
            textBox4.Text = _lotto.GenerateLotteryNumber().ToString();
            textBox5.Text = _lotto.GenerateLotteryNumber().ToString();
        }
        /// <summary>
        /// Play the lotto!
        /// </summary>
        /// <returns></returns>
        private bool Play()
        {
            var ticketNumbers = GetTheTicketNumbers();

            WinningNumbersLable.Text = "";
            // use the numbers to check if the ticket is a winner
            var winningNumbers = _lotto.GetWinningNumbers();
            foreach (var winNum in winningNumbers)
            {
                WinningNumbersLable.Text += $@"{winNum} ";
            }
            // check to see if we won
            var result = _lotto.CheckTicket(winningNumbers, ticketNumbers);

            if (result > 0)
            {
                // a match!
                results.Text = $"Congratulations! You matched {result} numbers.";
            }

            else
            {
                results.Text = "Sorry, you didn't win.";
            }
            // return true if all numbers matched
            return result == 5;
        }
        /// <summary>
        /// Get the tick numbers from the user
        /// </summary>
        /// <returns>the ticket numbers</returns>
        /// <exception cref="ArgumentException">Invalid numbers pciked</exception>
        private int[] GetTheTicketNumbers()
        {
            int number1;
            int number2;
            int number3;
            int number4;
            int number5;
            try
            {
                // get the numbers to player has used
                number1 = int.Parse(textBox1.Text);
                number2 = int.Parse(textBox2.Text);
                number3 = int.Parse(textBox3.Text);
                number4 = int.Parse(textBox4.Text);
                number5 = int.Parse(textBox5.Text);
            }
            catch
            {
                results.Text = "Invalid numbers, try again...";
                throw new ArgumentException();
            }

            var ticketNumbers = new[] { number1, number2, number3, number4, number5 };
            // check to see if there are any repeated numbers
            if (!_lotto.AreTicketNumbersOk(ticketNumbers))
            {
                results.Text = "Invalid numbers, try again...";
                throw new ArgumentException();
            }
            return ticketNumbers;
        }
    }
}