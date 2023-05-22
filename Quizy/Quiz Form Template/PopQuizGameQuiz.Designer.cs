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
            this.components = new System.ComponentModel.Container();
            this.textBoxQuestion = new System.Windows.Forms.RichTextBox();
            this.answerRed = new System.Windows.Forms.RichTextBox();
            this.answerGreen = new System.Windows.Forms.RichTextBox();
            this.answerBlue = new System.Windows.Forms.RichTextBox();
            this.answerYellow = new System.Windows.Forms.RichTextBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.labelTimerText = new System.Windows.Forms.Label();
            this.labelTimer = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxQuestion
            // 
            this.textBoxQuestion.Font = new System.Drawing.Font("Microsoft Tai Le", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxQuestion.ImeMode = System.Windows.Forms.ImeMode.On;
            this.textBoxQuestion.Location = new System.Drawing.Point(45, 25);
            this.textBoxQuestion.Name = "textBoxQuestion";
            this.textBoxQuestion.ReadOnly = true;
            this.textBoxQuestion.Size = new System.Drawing.Size(795, 243);
            this.textBoxQuestion.TabIndex = 0;
            this.textBoxQuestion.Text = "Question";
            // 
            // answerRed
            // 
            this.answerRed.BackColor = System.Drawing.Color.Red;
            this.answerRed.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.answerRed.Font = new System.Drawing.Font("Microsoft Tai Le", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.answerRed.ForeColor = System.Drawing.Color.White;
            this.answerRed.ImeMode = System.Windows.Forms.ImeMode.On;
            this.answerRed.Location = new System.Drawing.Point(100, 300);
            this.answerRed.Name = "answerRed";
            this.answerRed.ReadOnly = true;
            this.answerRed.Size = new System.Drawing.Size(280, 110);
            this.answerRed.TabIndex = 1;
            this.answerRed.Text = "Answer Red";
            this.answerRed.Click += new System.EventHandler(this.answerRed_Click);
            // 
            // answerGreen
            // 
            this.answerGreen.BackColor = System.Drawing.Color.Green;
            this.answerGreen.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.answerGreen.Font = new System.Drawing.Font("Microsoft Tai Le", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.answerGreen.ForeColor = System.Drawing.Color.White;
            this.answerGreen.ImeMode = System.Windows.Forms.ImeMode.On;
            this.answerGreen.Location = new System.Drawing.Point(520, 300);
            this.answerGreen.Name = "answerGreen";
            this.answerGreen.ReadOnly = true;
            this.answerGreen.Size = new System.Drawing.Size(280, 110);
            this.answerGreen.TabIndex = 2;
            this.answerGreen.Text = "Answer Green";
            this.answerGreen.Click += new System.EventHandler(this.answerGreen_Click);
            // 
            // answerBlue
            // 
            this.answerBlue.BackColor = System.Drawing.Color.LightSkyBlue;
            this.answerBlue.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.answerBlue.Font = new System.Drawing.Font("Microsoft Tai Le", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.answerBlue.ForeColor = System.Drawing.Color.White;
            this.answerBlue.ImeMode = System.Windows.Forms.ImeMode.On;
            this.answerBlue.Location = new System.Drawing.Point(100, 430);
            this.answerBlue.Name = "answerBlue";
            this.answerBlue.ReadOnly = true;
            this.answerBlue.Size = new System.Drawing.Size(280, 110);
            this.answerBlue.TabIndex = 3;
            this.answerBlue.Text = "Answer Blue";
            this.answerBlue.Click += new System.EventHandler(this.answerBlue_Click);
            // 
            // answerYellow
            // 
            this.answerYellow.BackColor = System.Drawing.Color.Gold;
            this.answerYellow.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.answerYellow.Font = new System.Drawing.Font("Microsoft Tai Le", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.answerYellow.ForeColor = System.Drawing.Color.White;
            this.answerYellow.ImeMode = System.Windows.Forms.ImeMode.On;
            this.answerYellow.Location = new System.Drawing.Point(520, 430);
            this.answerYellow.Name = "answerYellow";
            this.answerYellow.ReadOnly = true;
            this.answerYellow.Size = new System.Drawing.Size(280, 110);
            this.answerYellow.TabIndex = 4;
            this.answerYellow.Text = "Answer Yellow";
            this.answerYellow.Click += new System.EventHandler(this.answerYellow_Click);
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // labelTimerText
            // 
            this.labelTimerText.AutoSize = true;
            this.labelTimerText.BackColor = System.Drawing.Color.Transparent;
            this.labelTimerText.Font = new System.Drawing.Font("Microsoft Tai Le", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTimerText.ForeColor = System.Drawing.Color.White;
            this.labelTimerText.Location = new System.Drawing.Point(404, 271);
            this.labelTimerText.Name = "labelTimerText";
            this.labelTimerText.Size = new System.Drawing.Size(82, 34);
            this.labelTimerText.TabIndex = 5;
            this.labelTimerText.Text = "Timer";
            // 
            // labelTimer
            // 
            this.labelTimer.AutoSize = true;
            this.labelTimer.BackColor = System.Drawing.Color.Transparent;
            this.labelTimer.Font = new System.Drawing.Font("Microsoft Tai Le", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTimer.ForeColor = System.Drawing.Color.White;
            this.labelTimer.Location = new System.Drawing.Point(404, 305);
            this.labelTimer.Name = "labelTimer";
            this.labelTimer.Size = new System.Drawing.Size(98, 34);
            this.labelTimer.TabIndex = 6;
            this.labelTimer.Text = "time=?";
            // 
            // PopQuizGameQuiz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Quizy.Properties.Resources.Background_pop_quiz;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.labelTimer);
            this.Controls.Add(this.labelTimerText);
            this.Controls.Add(this.answerYellow);
            this.Controls.Add(this.answerBlue);
            this.Controls.Add(this.answerGreen);
            this.Controls.Add(this.answerRed);
            this.Controls.Add(this.textBoxQuestion);
            this.Name = "PopQuizGameQuiz";
            this.Text = "Quizy - Pop Quiz";
            this.ResumeLayout(false);
            this.PerformLayout();

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