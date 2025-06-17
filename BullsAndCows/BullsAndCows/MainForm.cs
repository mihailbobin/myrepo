using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace BullsAndCowsGame
{
    public partial class MainForm : Form
    {
        // Основные компоненты игры
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

        // Настройка начального состояния игры
        private void SetupGame()
        {
            lblGuessedDigits.Text = "0";
            lblCorrectPositions.Text = "0";
            txtInput.Text = "";
            attempts = 0;
            UpdateStatus();
        }

        // Генерация секретного числа
        private string GenerateSecretNumber(int length)
        {
            List<int> digits = Enumerable.Range(0, 10).ToList();
            string number = "";

            // Первая цифра не может быть 0
            int firstDigit = digits[random.Next(1, 10)];
            number += firstDigit;
            digits.Remove(firstDigit);

            // Генерация остальных цифр
            for (int i = 1; i < length; i++)
            {
                int index = random.Next(0, digits.Count);
                number += digits[index];
                digits.RemoveAt(index);
            }

            return number;
        }

        // Проверка введенного числа
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

        // Обработка нажатия кнопки "Старт"
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

        // Обработка нажатия кнопки "Завершить"
        private void btnFinish_Click(object sender, EventArgs e)
        {
            timer.Stop();
            txtInput.Enabled = false;
            btnStart.Enabled = true;
            btnFinish.Enabled = false;
            SetupGame();
        }

        // Обработка ввода числа
        private void txtInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && txtInput.Enabled)
            {
                string guess = txtInput.Text.Trim();

                // Проверка валидности ввода
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

                // Проверка числа
                attempts++;
                var (bulls, cows) = CheckGuess(secretNumber, guess);

                // Обновление интерфейса
                lblGuessedDigits.Text = (bulls + cows).ToString();
                lblCorrectPositions.Text = bulls.ToString();
                txtInput.Text = "";

                UpdateStatus();

                // Проверка победы
                if (bulls == digitsCount)
                {
                    timer.Stop();
                    TimeSpan duration = DateTime.Now - startTime;
                    MessageBox.Show($"Поздравляем! Вы угадали число {secretNumber} за {attempts} попыток и {duration.TotalSeconds:F1} секунд.");
                    btnFinish.PerformClick();
                }
            }
        }

        // Обновление статус-бара
        private void UpdateStatus()
        {
            tsslAttempts.Text = $"Попыток: {attempts}";

            if (timer.Enabled)
            {
                TimeSpan duration = DateTime.Now - startTime;
                tsslTime.Text = $"Затрачено времени: {duration.TotalSeconds:F1} сек.";
            }
        }

        // Обновление таймера
        private void timer_Tick(object sender, EventArgs e)
        {
            UpdateStatus();
        }

        // Выход из программы
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}