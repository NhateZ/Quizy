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
            this.components = new System.ComponentModel.Container();
            this.pictureBoxGame = new System.Windows.Forms.PictureBox();
            this.labelScore = new System.Windows.Forms.Label();
            this.Score = new System.Windows.Forms.Label();
            this.timerTick = new System.Windows.Forms.Timer(this.components);
            this.RequiredScore = new System.Windows.Forms.Label();
            this.labelRequiredScore = new System.Windows.Forms.Label();
            this.pictureBoxSnake = new System.Windows.Forms.PictureBox();
            this.labelTime = new System.Windows.Forms.Label();
            this.labelTextTimer = new System.Windows.Forms.Label();
            this.timerTime = new System.Windows.Forms.Timer(this.components);
            this.timerMovement = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGame)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSnake)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxGame
            // 
            this.pictureBoxGame.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.pictureBoxGame.BackgroundImage = global::Quizy.Properties.Resources.background_main_quiz;
            this.pictureBoxGame.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxGame.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxGame.Name = "pictureBoxGame";
            this.pictureBoxGame.Size = new System.Drawing.Size(658, 545);
            this.pictureBoxGame.TabIndex = 0;
            this.pictureBoxGame.TabStop = false;
            this.pictureBoxGame.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBoxGame_Paint);
            // 
            // labelScore
            // 
            this.labelScore.AutoSize = true;
            this.labelScore.BackColor = System.Drawing.Color.Transparent;
            this.labelScore.Font = new System.Drawing.Font("Microsoft Tai Le", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelScore.Location = new System.Drawing.Point(676, 48);
            this.labelScore.Name = "labelScore";
            this.labelScore.Size = new System.Drawing.Size(61, 23);
            this.labelScore.TabIndex = 1;
            this.labelScore.Text = "Score:";
            // 
            // Score
            // 
            this.Score.AutoSize = true;
            this.Score.BackColor = System.Drawing.Color.Transparent;
            this.Score.Font = new System.Drawing.Font("Microsoft Tai Le", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Score.Location = new System.Drawing.Point(743, 48);
            this.Score.Name = "Score";
            this.Score.Size = new System.Drawing.Size(20, 23);
            this.Score.TabIndex = 2;
            this.Score.Text = "0";
            // 
            // timerTick
            // 
            this.timerTick.Interval = 65;
            this.timerTick.Tick += new System.EventHandler(this.timerTick_Tick);
            // 
            // RequiredScore
            // 
            this.RequiredScore.AutoSize = true;
            this.RequiredScore.BackColor = System.Drawing.Color.Transparent;
            this.RequiredScore.Font = new System.Drawing.Font("Microsoft Tai Le", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RequiredScore.Location = new System.Drawing.Point(824, 78);
            this.RequiredScore.Name = "RequiredScore";
            this.RequiredScore.Size = new System.Drawing.Size(20, 23);
            this.RequiredScore.TabIndex = 4;
            this.RequiredScore.Text = "0";
            // 
            // labelRequiredScore
            // 
            this.labelRequiredScore.AutoSize = true;
            this.labelRequiredScore.BackColor = System.Drawing.Color.Transparent;
            this.labelRequiredScore.Font = new System.Drawing.Font("Microsoft Tai Le", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelRequiredScore.Location = new System.Drawing.Point(676, 78);
            this.labelRequiredScore.Name = "labelRequiredScore";
            this.labelRequiredScore.Size = new System.Drawing.Size(142, 23);
            this.labelRequiredScore.TabIndex = 3;
            this.labelRequiredScore.Text = "Required Score:";
            // 
            // pictureBoxSnake
            // 
            this.pictureBoxSnake.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxSnake.BackgroundImage = global::Quizy.Properties.Resources.Snake;
            this.pictureBoxSnake.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxSnake.Location = new System.Drawing.Point(676, 218);
            this.pictureBoxSnake.Name = "pictureBoxSnake";
            this.pictureBoxSnake.Size = new System.Drawing.Size(196, 252);
            this.pictureBoxSnake.TabIndex = 5;
            this.pictureBoxSnake.TabStop = false;
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.BackColor = System.Drawing.Color.Transparent;
            this.labelTime.Font = new System.Drawing.Font("Microsoft Tai Le", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTime.Location = new System.Drawing.Point(737, 112);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(20, 23);
            this.labelTime.TabIndex = 7;
            this.labelTime.Text = "0";
            // 
            // labelTextTimer
            // 
            this.labelTextTimer.AutoSize = true;
            this.labelTextTimer.BackColor = System.Drawing.Color.Transparent;
            this.labelTextTimer.Font = new System.Drawing.Font("Microsoft Tai Le", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTextTimer.Location = new System.Drawing.Point(676, 112);
            this.labelTextTimer.Name = "labelTextTimer";
            this.labelTextTimer.Size = new System.Drawing.Size(55, 23);
            this.labelTextTimer.TabIndex = 6;
            this.labelTextTimer.Text = "Time:";
            // 
            // timerTime
            // 
            this.timerTime.Interval = 1000;
            this.timerTime.Tick += new System.EventHandler(this.timerTime_Tick);
            // 
            // timerMovement
            // 
            this.timerMovement.Interval = 65;
            this.timerMovement.Tick += new System.EventHandler(this.timerMovement_Tick);
            // 
            // SnakeGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Quizy.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.labelTime);
            this.Controls.Add(this.labelTextTimer);
            this.Controls.Add(this.pictureBoxSnake);
            this.Controls.Add(this.RequiredScore);
            this.Controls.Add(this.labelRequiredScore);
            this.Controls.Add(this.Score);
            this.Controls.Add(this.labelScore);
            this.Controls.Add(this.pictureBoxGame);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "SnakeGame";
            this.Text = "Snake";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyIsDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyIsUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGame)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSnake)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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