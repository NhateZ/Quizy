namespace Quizy.Quiz_Form_Template.Snake
{
    partial class SnakeGame
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
            pictureBoxGame = new PictureBox();
            labelScore = new Label();
            Score = new Label();
            timerTick = new System.Windows.Forms.Timer(components);
            RequiredScore = new Label();
            labelRequiredScore = new Label();
            pictureBoxSnake = new PictureBox();
            labelTime = new Label();
            labelTextTimer = new Label();
            timerTime = new System.Windows.Forms.Timer(components);
            timerMovement = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pictureBoxGame).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxSnake).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxGame
            // 
            pictureBoxGame.BackColor = SystemColors.ButtonShadow;
            pictureBoxGame.BackgroundImage = Properties.Resources.background_main_quiz;
            pictureBoxGame.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBoxGame.Location = new Point(14, 16);
            pictureBoxGame.Margin = new Padding(3, 4, 3, 4);
            pictureBoxGame.Name = "pictureBoxGame";
            pictureBoxGame.Size = new Size(752, 727);
            pictureBoxGame.TabIndex = 0;
            pictureBoxGame.TabStop = false;
            pictureBoxGame.Paint += pictureBoxGame_Paint;
            // 
            // labelScore
            // 
            labelScore.AutoSize = true;
            labelScore.BackColor = Color.Transparent;
            labelScore.Font = new Font("Microsoft Tai Le", 14F, FontStyle.Regular, GraphicsUnit.Point);
            labelScore.Location = new Point(773, 64);
            labelScore.Name = "labelScore";
            labelScore.Size = new Size(77, 30);
            labelScore.TabIndex = 1;
            labelScore.Text = "Score:";
            // 
            // Score
            // 
            Score.AutoSize = true;
            Score.BackColor = Color.Transparent;
            Score.Font = new Font("Microsoft Tai Le", 14F, FontStyle.Regular, GraphicsUnit.Point);
            Score.Location = new Point(849, 64);
            Score.Name = "Score";
            Score.Size = new Size(26, 30);
            Score.TabIndex = 2;
            Score.Text = "0";
            // 
            // timerTick
            // 
            timerTick.Interval = 65;
            timerTick.Tick += timerTick_Tick;
            // 
            // RequiredScore
            // 
            RequiredScore.AutoSize = true;
            RequiredScore.BackColor = Color.Transparent;
            RequiredScore.Font = new Font("Microsoft Tai Le", 14F, FontStyle.Regular, GraphicsUnit.Point);
            RequiredScore.Location = new Point(942, 104);
            RequiredScore.Name = "RequiredScore";
            RequiredScore.Size = new Size(26, 30);
            RequiredScore.TabIndex = 4;
            RequiredScore.Text = "0";
            // 
            // labelRequiredScore
            // 
            labelRequiredScore.AutoSize = true;
            labelRequiredScore.BackColor = Color.Transparent;
            labelRequiredScore.Font = new Font("Microsoft Tai Le", 14F, FontStyle.Regular, GraphicsUnit.Point);
            labelRequiredScore.Location = new Point(773, 104);
            labelRequiredScore.Name = "labelRequiredScore";
            labelRequiredScore.Size = new Size(180, 30);
            labelRequiredScore.TabIndex = 3;
            labelRequiredScore.Text = "Required Score:";
            // 
            // pictureBoxSnake
            // 
            pictureBoxSnake.BackColor = Color.Transparent;
            pictureBoxSnake.BackgroundImage = Properties.Resources.Snake;
            pictureBoxSnake.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBoxSnake.Location = new Point(773, 291);
            pictureBoxSnake.Margin = new Padding(3, 4, 3, 4);
            pictureBoxSnake.Name = "pictureBoxSnake";
            pictureBoxSnake.Size = new Size(224, 336);
            pictureBoxSnake.TabIndex = 5;
            pictureBoxSnake.TabStop = false;
            // 
            // labelTime
            // 
            labelTime.AutoSize = true;
            labelTime.BackColor = Color.Transparent;
            labelTime.Font = new Font("Microsoft Tai Le", 14F, FontStyle.Regular, GraphicsUnit.Point);
            labelTime.Location = new Point(842, 149);
            labelTime.Name = "labelTime";
            labelTime.Size = new Size(26, 30);
            labelTime.TabIndex = 7;
            labelTime.Text = "0";
            // 
            // labelTextTimer
            // 
            labelTextTimer.AutoSize = true;
            labelTextTimer.BackColor = Color.Transparent;
            labelTextTimer.Font = new Font("Microsoft Tai Le", 14F, FontStyle.Regular, GraphicsUnit.Point);
            labelTextTimer.Location = new Point(773, 149);
            labelTextTimer.Name = "labelTextTimer";
            labelTextTimer.Size = new Size(71, 30);
            labelTextTimer.TabIndex = 6;
            labelTextTimer.Text = "Time:";
            // 
            // timerTime
            // 
            timerTime.Interval = 1000;
            timerTime.Tick += timerTime_Tick;
            // 
            // timerMovement
            // 
            timerMovement.Interval = 65;
            timerMovement.Tick += timerMovement_Tick;
            // 
            // SnakeGame
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.background;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1010, 748);
            Controls.Add(labelTime);
            Controls.Add(labelTextTimer);
            Controls.Add(pictureBoxSnake);
            Controls.Add(RequiredScore);
            Controls.Add(labelRequiredScore);
            Controls.Add(Score);
            Controls.Add(labelScore);
            Controls.Add(pictureBoxGame);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "SnakeGame";
            Text = "Snake";
            Load += SnakeGame_Load;
            KeyDown += KeyIsDown;
            KeyUp += KeyIsUp;
            ((System.ComponentModel.ISupportInitialize)pictureBoxGame).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxSnake).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBoxGame;
        private Label labelScore;
        private Label Score;
        private System.Windows.Forms.Timer timerTick;
        private Label RequiredScore;
        private Label labelRequiredScore;
        private PictureBox pictureBoxSnake;
        private Label labelTime;
        private Label labelTextTimer;
        private System.Windows.Forms.Timer timerTime;
        private System.Windows.Forms.Timer timerMovement;
    }
}