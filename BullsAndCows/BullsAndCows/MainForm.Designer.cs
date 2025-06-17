using System.Windows.Forms;

namespace BullsAndCowsGame
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblDigits = new System.Windows.Forms.Label();
            this.nudDigits = new System.Windows.Forms.NumericUpDown();
            this.lblNumber = new System.Windows.Forms.Label();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.lblGuessed = new System.Windows.Forms.Label();
            this.lblGuessedDigits = new System.Windows.Forms.Label();
            this.lblPositions = new System.Windows.Forms.Label();
            this.lblCorrectPositions = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnFinish = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.tsslAttempts = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.nudDigits)).BeginInit();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();

            // lblTitle
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTitle.Location = new System.Drawing.Point(90, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(200, 24);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Угадайте число";

            // lblDigits
            this.lblDigits.AutoSize = true;
            this.lblDigits.Location = new System.Drawing.Point(30, 70);
            this.lblDigits.Name = "lblDigits";
            this.lblDigits.Size = new System.Drawing.Size(85, 13);
            this.lblDigits.TabIndex = 1;
            this.lblDigits.Text = "Число знаков:";

            // nudDigits
            this.nudDigits.Location = new System.Drawing.Point(120, 68);
            this.nudDigits.Minimum = new decimal(new int[] { 3, 0, 0, 0 });
            this.nudDigits.Maximum = new decimal(new int[] { 6, 0, 0, 0 });
            this.nudDigits.Name = "nudDigits";
            this.nudDigits.Size = new System.Drawing.Size(50, 20);
            this.nudDigits.TabIndex = 2;
            this.nudDigits.Value = new decimal(new int[] { 4, 0, 0, 0 });

            // lblNumber
            this.lblNumber.AutoSize = true;
            this.lblNumber.Location = new System.Drawing.Point(30, 100);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(45, 13);
            this.lblNumber.TabIndex = 3;
            this.lblNumber.Text = "Число:";

            // txtInput
            this.txtInput.Enabled = false;
            this.txtInput.Location = new System.Drawing.Point(80, 97);
            this.txtInput.MaxLength = 6;
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(100, 20);
            this.txtInput.TabIndex = 4;
            this.txtInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtInput_KeyDown);

            // lblGuessed
            this.lblGuessed.AutoSize = true;
            this.lblGuessed.Location = new System.Drawing.Point(30, 130);
            this.lblGuessed.Name = "lblGuessed";
            this.lblGuessed.Size = new System.Drawing.Size(93, 13);
            this.lblGuessed.TabIndex = 5;
            this.lblGuessed.Text = "Угадано цифр:";

            // lblGuessedDigits
            this.lblGuessedDigits.AutoSize = true;
            this.lblGuessedDigits.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblGuessedDigits.Location = new System.Drawing.Point(130, 130);
            this.lblGuessedDigits.MinimumSize = new System.Drawing.Size(30, 0);
            this.lblGuessedDigits.Name = "lblGuessedDigits";
            this.lblGuessedDigits.Size = new System.Drawing.Size(30, 15);
            this.lblGuessedDigits.TabIndex = 6;
            this.lblGuessedDigits.Text = "0";

            // lblPositions
            this.lblPositions.AutoSize = true;
            this.lblPositions.Location = new System.Drawing.Point(30, 155);
            this.lblPositions.Name = "lblPositions";
            this.lblPositions.Size = new System.Drawing.Size(150, 13);
            this.lblPositions.TabIndex = 7;
            this.lblPositions.Text = "Из них на своих местах:";

            // lblCorrectPositions
            this.lblCorrectPositions.AutoSize = true;
            this.lblCorrectPositions.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCorrectPositions.Location = new System.Drawing.Point(180, 155);
            this.lblCorrectPositions.MinimumSize = new System.Drawing.Size(30, 0);
            this.lblCorrectPositions.Name = "lblCorrectPositions";
            this.lblCorrectPositions.Size = new System.Drawing.Size(30, 15);
            this.lblCorrectPositions.TabIndex = 8;
            this.lblCorrectPositions.Text = "0";

            // btnStart
            this.btnStart.Location = new System.Drawing.Point(50, 190);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 30);
            this.btnStart.TabIndex = 9;
            this.btnStart.Text = "Старт";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);

            // btnFinish
            this.btnFinish.Enabled = false;
            this.btnFinish.Location = new System.Drawing.Point(130, 190);
            this.btnFinish.Name = "btnFinish";
            this.btnFinish.Size = new System.Drawing.Size(75, 30);
            this.btnFinish.TabIndex = 10;
            this.btnFinish.Text = "Завершить";
            this.btnFinish.UseVisualStyleBackColor = true;
            this.btnFinish.Click += new System.EventHandler(this.btnFinish_Click);

            // btnExit
            this.btnExit.Location = new System.Drawing.Point(210, 190);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 30);
            this.btnExit.TabIndex = 11;
            this.btnExit.Text = "Выход";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);

            // statusStrip
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslAttempts,
            this.tsslTime});
            this.statusStrip.Location = new System.Drawing.Point(0, 239);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(334, 22);
            this.statusStrip.TabIndex = 12;

            // tsslAttempts
            this.tsslAttempts.Name = "tsslAttempts";
            this.tsslAttempts.Size = new System.Drawing.Size(79, 17);
            this.tsslAttempts.Text = "Попыток: 0";

            // tsslTime
            this.tsslTime.Name = "tsslTime";
            this.tsslTime.Size = new System.Drawing.Size(140, 17);
            this.tsslTime.Text = "Затрачено времени: 0";

            // timer
            this.timer.Interval = 100;

            // MainForm
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 261);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnFinish);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lblCorrectPositions);
            this.Controls.Add(this.lblPositions);
            this.Controls.Add(this.lblGuessedDigits);
            this.Controls.Add(this.lblGuessed);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.lblNumber);
            this.Controls.Add(this.nudDigits);
            this.Controls.Add(this.lblDigits);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Быки и коровы";
            ((System.ComponentModel.ISupportInitialize)(this.nudDigits)).EndInit();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private Label lblTitle;
        private Label lblDigits;
        private NumericUpDown nudDigits;
        private Label lblNumber;
        private TextBox txtInput;
        private Label lblGuessed;
        private Label lblGuessedDigits;
        private Label lblPositions;
        private Label lblCorrectPositions;
        private Button btnStart;
        private Button btnFinish;
        private Button btnExit;
        private StatusStrip statusStrip;
        private ToolStripStatusLabel tsslAttempts;
        private ToolStripStatusLabel tsslTime;
        private Timer timer;
    }
}