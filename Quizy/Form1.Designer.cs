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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormStart));
            this.pictureBoxMainQuiz = new System.Windows.Forms.PictureBox();
            this.pictureBoxCustomQuiz = new System.Windows.Forms.PictureBox();
            this.pictureBoxCustomQuizCreator = new System.Windows.Forms.PictureBox();
            this.pictureBoxTutorialCustomQuiz = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMainQuiz)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCustomQuiz)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCustomQuizCreator)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTutorialCustomQuiz)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxMainQuiz
            // 
            this.pictureBoxMainQuiz.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxMainQuiz.BackgroundImage = global::Quizy.Properties.Resources.Main_Quiz;
            this.pictureBoxMainQuiz.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxMainQuiz.Location = new System.Drawing.Point(175, 40);
            this.pictureBoxMainQuiz.Name = "pictureBoxMainQuiz";
            this.pictureBoxMainQuiz.Size = new System.Drawing.Size(225, 225);
            this.pictureBoxMainQuiz.TabIndex = 0;
            this.pictureBoxMainQuiz.TabStop = false;
            this.pictureBoxMainQuiz.Click += new System.EventHandler(this.pictureBoxMainQuiz_Click);
            // 
            // pictureBoxCustomQuiz
            // 
            this.pictureBoxCustomQuiz.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxCustomQuiz.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxCustomQuiz.BackgroundImage = global::Quizy.Properties.Resources.Custom_Quiz;
            this.pictureBoxCustomQuiz.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxCustomQuiz.Location = new System.Drawing.Point(500, 40);
            this.pictureBoxCustomQuiz.Name = "pictureBoxCustomQuiz";
            this.pictureBoxCustomQuiz.Size = new System.Drawing.Size(225, 225);
            this.pictureBoxCustomQuiz.TabIndex = 1;
            this.pictureBoxCustomQuiz.TabStop = false;
            this.pictureBoxCustomQuiz.Click += new System.EventHandler(this.pictureBoxCustomQuiz_Click);
            // 
            // pictureBoxCustomQuizCreator
            // 
            this.pictureBoxCustomQuizCreator.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBoxCustomQuizCreator.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxCustomQuizCreator.BackgroundImage = global::Quizy.Properties.Resources.Custom_Quiz_Creator;
            this.pictureBoxCustomQuizCreator.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxCustomQuizCreator.Location = new System.Drawing.Point(175, 300);
            this.pictureBoxCustomQuizCreator.Name = "pictureBoxCustomQuizCreator";
            this.pictureBoxCustomQuizCreator.Size = new System.Drawing.Size(225, 225);
            this.pictureBoxCustomQuizCreator.TabIndex = 2;
            this.pictureBoxCustomQuizCreator.TabStop = false;
            this.pictureBoxCustomQuizCreator.Click += new System.EventHandler(this.pictureBoxCustomQuizCreator_Click);
            // 
            // pictureBoxTutorialCustomQuiz
            // 
            this.pictureBoxTutorialCustomQuiz.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxTutorialCustomQuiz.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxTutorialCustomQuiz.BackgroundImage = global::Quizy.Properties.Resources.Creator_Tutorial;
            this.pictureBoxTutorialCustomQuiz.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxTutorialCustomQuiz.Location = new System.Drawing.Point(500, 300);
            this.pictureBoxTutorialCustomQuiz.Name = "pictureBoxTutorialCustomQuiz";
            this.pictureBoxTutorialCustomQuiz.Size = new System.Drawing.Size(225, 225);
            this.pictureBoxTutorialCustomQuiz.TabIndex = 3;
            this.pictureBoxTutorialCustomQuiz.TabStop = false;
            this.pictureBoxTutorialCustomQuiz.Click += new System.EventHandler(this.pictureBoxTutorialCustomQuiz_Click);
            // 
            // FormStart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::Quizy.Properties.Resources.Background_Start;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.pictureBoxTutorialCustomQuiz);
            this.Controls.Add(this.pictureBoxCustomQuizCreator);
            this.Controls.Add(this.pictureBoxCustomQuiz);
            this.Controls.Add(this.pictureBoxMainQuiz);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormStart";
            this.Text = "Quizy";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMainQuiz)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCustomQuiz)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCustomQuizCreator)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTutorialCustomQuiz)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox pictureBoxMainQuiz;
        private PictureBox pictureBoxCustomQuiz;
        private PictureBox pictureBoxCustomQuizCreator;
        private PictureBox pictureBoxTutorialCustomQuiz;
    }
}