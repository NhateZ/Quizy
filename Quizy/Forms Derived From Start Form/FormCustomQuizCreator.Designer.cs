namespace Quizy.Forms_Derived_From_Start_Form
{
    partial class FormCustomQuizCreator
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
            this.tabControlCustomQuizCreator = new System.Windows.Forms.TabControl();
            this.tabPagePopQuiz = new System.Windows.Forms.TabPage();
            this.tabPageGhicitoarea = new System.Windows.Forms.TabPage();
            this.tabPageFlashMemoryCard = new System.Windows.Forms.TabPage();
            this.tabPageSnake = new System.Windows.Forms.TabPage();
            this.labelRequiredScore = new System.Windows.Forms.Label();
            this.textBoxRequiredScore = new System.Windows.Forms.TextBox();
            this.textBoxIncrement = new System.Windows.Forms.TextBox();
            this.labelIncrement = new System.Windows.Forms.Label();
            this.textBoxTime = new System.Windows.Forms.TextBox();
            this.labelTime = new System.Windows.Forms.Label();
            this.tabControlCustomQuizCreator.SuspendLayout();
            this.tabPageSnake.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlCustomQuizCreator
            // 
            this.tabControlCustomQuizCreator.Controls.Add(this.tabPagePopQuiz);
            this.tabControlCustomQuizCreator.Controls.Add(this.tabPageGhicitoarea);
            this.tabControlCustomQuizCreator.Controls.Add(this.tabPageFlashMemoryCard);
            this.tabControlCustomQuizCreator.Controls.Add(this.tabPageSnake);
            this.tabControlCustomQuizCreator.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlCustomQuizCreator.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tabControlCustomQuizCreator.Location = new System.Drawing.Point(0, 0);
            this.tabControlCustomQuizCreator.Name = "tabControlCustomQuizCreator";
            this.tabControlCustomQuizCreator.SelectedIndex = 0;
            this.tabControlCustomQuizCreator.Size = new System.Drawing.Size(884, 501);
            this.tabControlCustomQuizCreator.TabIndex = 0;
            // 
            // tabPagePopQuiz
            // 
            this.tabPagePopQuiz.BackgroundImage = global::Quizy.Properties.Resources.Background_flash_memory_card;
            this.tabPagePopQuiz.Location = new System.Drawing.Point(4, 30);
            this.tabPagePopQuiz.Name = "tabPagePopQuiz";
            this.tabPagePopQuiz.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePopQuiz.Size = new System.Drawing.Size(876, 467);
            this.tabPagePopQuiz.TabIndex = 0;
            this.tabPagePopQuiz.Text = "Pop Quiz";
            this.tabPagePopQuiz.UseVisualStyleBackColor = true;
            // 
            // tabPageGhicitoarea
            // 
            this.tabPageGhicitoarea.BackgroundImage = global::Quizy.Properties.Resources.Background_flash_memory_card;
            this.tabPageGhicitoarea.Location = new System.Drawing.Point(4, 30);
            this.tabPageGhicitoarea.Name = "tabPageGhicitoarea";
            this.tabPageGhicitoarea.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageGhicitoarea.Size = new System.Drawing.Size(876, 467);
            this.tabPageGhicitoarea.TabIndex = 1;
            this.tabPageGhicitoarea.Text = "Ghicitoarea";
            this.tabPageGhicitoarea.UseVisualStyleBackColor = true;
            // 
            // tabPageFlashMemoryCard
            // 
            this.tabPageFlashMemoryCard.BackgroundImage = global::Quizy.Properties.Resources.Background_flash_memory_card;
            this.tabPageFlashMemoryCard.Location = new System.Drawing.Point(4, 30);
            this.tabPageFlashMemoryCard.Name = "tabPageFlashMemoryCard";
            this.tabPageFlashMemoryCard.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageFlashMemoryCard.Size = new System.Drawing.Size(876, 467);
            this.tabPageFlashMemoryCard.TabIndex = 2;
            this.tabPageFlashMemoryCard.Text = "Flash Memory Card";
            this.tabPageFlashMemoryCard.UseVisualStyleBackColor = true;
            // 
            // tabPageSnake
            // 
            this.tabPageSnake.BackgroundImage = global::Quizy.Properties.Resources.Background_flash_memory_card;
            this.tabPageSnake.Controls.Add(this.textBoxTime);
            this.tabPageSnake.Controls.Add(this.labelTime);
            this.tabPageSnake.Controls.Add(this.textBoxIncrement);
            this.tabPageSnake.Controls.Add(this.labelIncrement);
            this.tabPageSnake.Controls.Add(this.textBoxRequiredScore);
            this.tabPageSnake.Controls.Add(this.labelRequiredScore);
            this.tabPageSnake.Location = new System.Drawing.Point(4, 30);
            this.tabPageSnake.Name = "tabPageSnake";
            this.tabPageSnake.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSnake.Size = new System.Drawing.Size(876, 467);
            this.tabPageSnake.TabIndex = 3;
            this.tabPageSnake.Text = "Snake";
            this.tabPageSnake.UseVisualStyleBackColor = true;
            // 
            // labelRequiredScore
            // 
            this.labelRequiredScore.AutoSize = true;
            this.labelRequiredScore.Font = new System.Drawing.Font("Microsoft Tai Le", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelRequiredScore.ForeColor = System.Drawing.Color.White;
            this.labelRequiredScore.Location = new System.Drawing.Point(131, 50);
            this.labelRequiredScore.Name = "labelRequiredScore";
            this.labelRequiredScore.Size = new System.Drawing.Size(168, 30);
            this.labelRequiredScore.TabIndex = 0;
            this.labelRequiredScore.Text = "Required Score";
            // 
            // textBoxRequiredScore
            // 
            this.textBoxRequiredScore.Location = new System.Drawing.Point(305, 50);
            this.textBoxRequiredScore.Name = "textBoxRequiredScore";
            this.textBoxRequiredScore.Size = new System.Drawing.Size(240, 28);
            this.textBoxRequiredScore.TabIndex = 1;
            // 
            // textBoxIncrement
            // 
            this.textBoxIncrement.Location = new System.Drawing.Point(305, 110);
            this.textBoxIncrement.Name = "textBoxIncrement";
            this.textBoxIncrement.Size = new System.Drawing.Size(240, 28);
            this.textBoxIncrement.TabIndex = 3;
            // 
            // labelIncrement
            // 
            this.labelIncrement.AutoSize = true;
            this.labelIncrement.Font = new System.Drawing.Font("Microsoft Tai Le", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelIncrement.ForeColor = System.Drawing.Color.White;
            this.labelIncrement.Location = new System.Drawing.Point(183, 110);
            this.labelIncrement.Name = "labelIncrement";
            this.labelIncrement.Size = new System.Drawing.Size(116, 30);
            this.labelIncrement.TabIndex = 2;
            this.labelIncrement.Text = "Increment";
            // 
            // textBoxTime
            // 
            this.textBoxTime.Location = new System.Drawing.Point(305, 170);
            this.textBoxTime.Name = "textBoxTime";
            this.textBoxTime.Size = new System.Drawing.Size(240, 28);
            this.textBoxTime.TabIndex = 5;
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Font = new System.Drawing.Font("Microsoft Tai Le", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTime.ForeColor = System.Drawing.Color.White;
            this.labelTime.Location = new System.Drawing.Point(236, 170);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(63, 30);
            this.labelTime.TabIndex = 4;
            this.labelTime.Text = "Time";
            // 
            // FormCustomQuizCreator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Quizy.Properties.Resources.Background_flash_memory_card;
            this.ClientSize = new System.Drawing.Size(884, 501);
            this.Controls.Add(this.tabControlCustomQuizCreator);
            this.Font = new System.Drawing.Font("Microsoft Tai Le", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FormCustomQuizCreator";
            this.Text = "Quizy - Custom Quiz Creator";
            this.tabControlCustomQuizCreator.ResumeLayout(false);
            this.tabPageSnake.ResumeLayout(false);
            this.tabPageSnake.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControlCustomQuizCreator;
        private TabPage tabPagePopQuiz;
        private TabPage tabPageGhicitoarea;
        private TabPage tabPageFlashMemoryCard;
        private TabPage tabPageSnake;
        private TextBox textBoxIncrement;
        private Label labelIncrement;
        private TextBox textBoxRequiredScore;
        private Label labelRequiredScore;
        private TextBox textBoxTime;
        private Label labelTime;
    }
}