namespace Quizy
{
    partial class FormStart
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBoxCustomQuiz = new PictureBox();
            pictureBoxCustomQuizCreator = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCustomQuiz).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCustomQuizCreator).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxCustomQuiz
            // 
            pictureBoxCustomQuiz.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBoxCustomQuiz.BackColor = Color.Transparent;
            pictureBoxCustomQuiz.BackgroundImage = Properties.Resources.Custom_Quiz;
            pictureBoxCustomQuiz.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBoxCustomQuiz.Location = new Point(170, 160);
            pictureBoxCustomQuiz.Margin = new Padding(3, 4, 3, 4);
            pictureBoxCustomQuiz.Name = "pictureBoxCustomQuiz";
            pictureBoxCustomQuiz.Size = new Size(257, 300);
            pictureBoxCustomQuiz.TabIndex = 1;
            pictureBoxCustomQuiz.TabStop = false;
            pictureBoxCustomQuiz.Click += pictureBoxCustomQuiz_Click;
            // 
            // pictureBoxCustomQuizCreator
            // 
            pictureBoxCustomQuizCreator.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            pictureBoxCustomQuizCreator.BackColor = Color.Transparent;
            pictureBoxCustomQuizCreator.BackgroundImage = Properties.Resources.Custom_Quiz_Creator;
            pictureBoxCustomQuizCreator.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBoxCustomQuizCreator.Location = new Point(643, 160);
            pictureBoxCustomQuizCreator.Margin = new Padding(3, 4, 3, 4);
            pictureBoxCustomQuizCreator.Name = "pictureBoxCustomQuizCreator";
            pictureBoxCustomQuizCreator.Size = new Size(257, 300);
            pictureBoxCustomQuizCreator.TabIndex = 2;
            pictureBoxCustomQuizCreator.TabStop = false;
            pictureBoxCustomQuizCreator.Click += pictureBoxCustomQuizCreator_Click;
            // 
            // FormStart
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = Properties.Resources.Background_Start;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1010, 748);
            Controls.Add(pictureBoxCustomQuizCreator);
            Controls.Add(pictureBoxCustomQuiz);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormStart";
            Text = "Quizy";
            ((System.ComponentModel.ISupportInitialize)pictureBoxCustomQuiz).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCustomQuizCreator).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private PictureBox pictureBoxCustomQuiz;
        private PictureBox pictureBoxCustomQuizCreator;
    }
}