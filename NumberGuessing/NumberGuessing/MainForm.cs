using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace NumberGuessing
{
    public partial class MainForm : Form
    {
        private string secretNumber = "";
        private int attempts = 0;
        private DateTime startTime;
        private int digitsCount = 4;
        private readonly Random random = new Random();

        public MainForm()
        {
            InitializeComponent();
            SetupGame();
        }

        private void SetupGame()
        {
            lblGuessedDigits.Text = "0";
            lblCorrectPositions.Text = "0";
            txtInput.Text = "";
            attempts = 0;
            UpdateStatus();
        }

        private string GenerateSecretNumber(int length)
        {
            List<int> digits = Enumerable.Range(0, 10).ToList();
            string number = "";

            int firstDigit = digits[random.Next(1, 10)];
            number += firstDigit;
            digits.Remove(firstDigit);

            for (int i = 1; i < length; i++)
            {
                int index = random.Next(0, digits.Count);
                number += digits[index];
                digits.RemoveAt(index);
            }

            return number;
        }

        private (int bulls, int cows) CheckGuess(string secret, string guess)
        {
            int bulls = 0;
            int cows = 0;

            for (int i = 0; i < secret.Length; i++)
            {
                if (secret[i] == guess[i])
                {
                    bulls++;
                }
                else if (secret.Contains(guess[i]))
                {
                    cows++;
                }
            }

            return (bulls, cows);
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            digitsCount = (int)nudDigits.Value;
            secretNumber = GenerateSecretNumber(digitsCount);
            startTime = DateTime.Now;
            attempts = 0;
            timer.Start();

            txtInput.Enabled = true;
            txtInput.Focus();
            btnStart.Enabled = false;
            btnFinish.Enabled = true;

            SetupGame();
        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
            timer.Stop();
            txtInput.Enabled = false;
            btnStart.Enabled = true;
            btnFinish.Enabled = false;
            SetupGame();
        }

        private void txtInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && txtInput.Enabled)
            {
                string guess = txtInput.Text.Trim();

                if (guess.Length != digitsCount)
                {
                    MessageBox.Show($"Введите {digitsCount}-значное число!");
                    return;
                }

                if (!guess.All(char.IsDigit))
                {
                    MessageBox.Show("Вводите только цифры!");
                    return;
                }

                if (guess.Distinct().Count() != digitsCount)
                {
                    MessageBox.Show("Цифры не должны повторяться!");
                    return;
                }

                attempts++;
                var (bulls, cows) = CheckGuess(secretNumber, guess);

                lblGuessedDigits.Text = (bulls + cows).ToString();
                lblCorrectPositions.Text = bulls.ToString();
                txtInput.Text = "";

                UpdateStatus();

                if (bulls == digitsCount)
                {
                    timer.Stop();
                    TimeSpan duration = DateTime.Now - startTime;
                    MessageBox.Show($"Поздравляем! Вы угадали число {secretNumber} за {attempts} попыток и {duration.TotalSeconds:F1} секунд.");
                    btnFinish.PerformClick();
                }
            }
        }

        private void UpdateStatus()
        {
            tsslAttempts.Text = $"Попыток: {attempts}";

            if (timer.Enabled)
            {
                TimeSpan duration = DateTime.Now - startTime;
                tsslTime.Text = $"Затрачено времени: {duration.TotalSeconds:F1} сек.";
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            UpdateStatus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}