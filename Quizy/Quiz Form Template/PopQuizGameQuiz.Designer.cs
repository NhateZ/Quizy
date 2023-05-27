namespace Quizy.Quiz_Form_Template
{
    partial class PopQuizGameQuiz
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            textBoxQuestion = new RichTextBox();
            answerRed = new RichTextBox();
            answerGreen = new RichTextBox();
            answerBlue = new RichTextBox();
            answerYellow = new RichTextBox();
            timer = new System.Windows.Forms.Timer(components);
            labelTimerText = new Label();
            labelTimer = new Label();
            SuspendLayout();
            // 
            // textBoxQuestion
            // 
            textBoxQuestion.Font = new Font("Microsoft Tai Le", 25F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxQuestion.ImeMode = ImeMode.On;
            textBoxQuestion.Location = new Point(51, 33);
            textBoxQuestion.Margin = new Padding(3, 4, 3, 4);
            textBoxQuestion.Name = "textBoxQuestion";
            textBoxQuestion.ReadOnly = true;
            textBoxQuestion.Size = new Size(908, 323);
            textBoxQuestion.TabIndex = 0;
            textBoxQuestion.Text = "Question";
            // 
            // answerRed
            // 
            answerRed.BackColor = Color.Red;
            answerRed.BorderStyle = BorderStyle.None;
            answerRed.Font = new Font("Microsoft Tai Le", 20F, FontStyle.Regular, GraphicsUnit.Point);
            answerRed.ForeColor = Color.White;
            answerRed.ImeMode = ImeMode.On;
            answerRed.Location = new Point(114, 400);
            answerRed.Margin = new Padding(3, 4, 3, 4);
            answerRed.Name = "answerRed";
            answerRed.ReadOnly = true;
            answerRed.Size = new Size(320, 147);
            answerRed.TabIndex = 1;
            answerRed.Text = "Answer Red";
            answerRed.Click += answerRed_Click;
            // 
            // answerGreen
            // 
            answerGreen.BackColor = Color.Green;
            answerGreen.BorderStyle = BorderStyle.None;
            answerGreen.Font = new Font("Microsoft Tai Le", 20F, FontStyle.Regular, GraphicsUnit.Point);
            answerGreen.ForeColor = Color.White;
            answerGreen.ImeMode = ImeMode.On;
            answerGreen.Location = new Point(594, 400);
            answerGreen.Margin = new Padding(3, 4, 3, 4);
            answerGreen.Name = "answerGreen";
            answerGreen.ReadOnly = true;
            answerGreen.Size = new Size(320, 147);
            answerGreen.TabIndex = 2;
            answerGreen.Text = "Answer Green";
            answerGreen.Click += answerGreen_Click;
            // 
            // answerBlue
            // 
            answerBlue.BackColor = Color.LightSkyBlue;
            answerBlue.BorderStyle = BorderStyle.None;
            answerBlue.Font = new Font("Microsoft Tai Le", 20F, FontStyle.Regular, GraphicsUnit.Point);
            answerBlue.ForeColor = Color.White;
            answerBlue.ImeMode = ImeMode.On;
            answerBlue.Location = new Point(114, 573);
            answerBlue.Margin = new Padding(3, 4, 3, 4);
            answerBlue.Name = "answerBlue";
            answerBlue.ReadOnly = true;
            answerBlue.Size = new Size(320, 147);
            answerBlue.TabIndex = 3;
            answerBlue.Text = "Answer Blue";
            answerBlue.Click += answerBlue_Click;
            // 
            // answerYellow
            // 
            answerYellow.BackColor = Color.Gold;
            answerYellow.BorderStyle = BorderStyle.None;
            answerYellow.Font = new Font("Microsoft Tai Le", 20F, FontStyle.Regular, GraphicsUnit.Point);
            answerYellow.ForeColor = Color.White;
            answerYellow.ImeMode = ImeMode.On;
            answerYellow.Location = new Point(594, 573);
            answerYellow.Margin = new Padding(3, 4, 3, 4);
            answerYellow.Name = "answerYellow";
            answerYellow.ReadOnly = true;
            answerYellow.Size = new Size(320, 147);
            answerYellow.TabIndex = 4;
            answerYellow.Text = "Answer Yellow";
            answerYellow.Click += answerYellow_Click;
            // 
            // timer
            // 
            timer.Tick += timer_Tick;
            // 
            // labelTimerText
            // 
            labelTimerText.AutoSize = true;
            labelTimerText.BackColor = Color.Transparent;
            labelTimerText.Font = new Font("Microsoft Tai Le", 20F, FontStyle.Regular, GraphicsUnit.Point);
            labelTimerText.ForeColor = Color.White;
            labelTimerText.Location = new Point(462, 361);
            labelTimerText.Name = "labelTimerText";
            labelTimerText.Size = new Size(104, 44);
            labelTimerText.TabIndex = 5;
            labelTimerText.Text = "Timer";
            // 
            // labelTimer
            // 
            labelTimer.AutoSize = true;
            labelTimer.BackColor = Color.Transparent;
            labelTimer.Font = new Font("Microsoft Tai Le", 20F, FontStyle.Regular, GraphicsUnit.Point);
            labelTimer.ForeColor = Color.White;
            labelTimer.Location = new Point(462, 407);
            labelTimer.Name = "labelTimer";
            labelTimer.Size = new Size(124, 44);
            labelTimer.TabIndex = 6;
            labelTimer.Text = "time=?";
            // 
            // PopQuizGameQuiz
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Background_pop_quiz;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1010, 748);
            Controls.Add(labelTimer);
            Controls.Add(labelTimerText);
            Controls.Add(answerYellow);
            Controls.Add(answerBlue);
            Controls.Add(answerGreen);
            Controls.Add(answerRed);
            Controls.Add(textBoxQuestion);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "PopQuizGameQuiz";
            Text = "Quizy - Pop Quiz";
            Load += PopQuizGameQuiz_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox textBoxQuestion;
        private RichTextBox answerRed;
        private RichTextBox answerGreen;
        private RichTextBox answerBlue;
        private RichTextBox answerYellow;
        private System.Windows.Forms.Timer timer;
        private Label labelTimerText;
        private Label labelTimer;
    }
}