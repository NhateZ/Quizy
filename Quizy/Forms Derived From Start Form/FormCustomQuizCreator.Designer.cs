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
            this.tabControlCustomQuizCreator.SuspendLayout();
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
            this.tabPageSnake.Location = new System.Drawing.Point(4, 30);
            this.tabPageSnake.Name = "tabPageSnake";
            this.tabPageSnake.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSnake.Size = new System.Drawing.Size(876, 467);
            this.tabPageSnake.TabIndex = 3;
            this.tabPageSnake.Text = "Snake";
            this.tabPageSnake.UseVisualStyleBackColor = true;
            // 
            // FormCustomQuizCreator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 501);
            this.Controls.Add(this.tabControlCustomQuizCreator);
            this.Font = new System.Drawing.Font("Microsoft Tai Le", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "FormCustomQuizCreator";
            this.Text = "Quizy - Custom Quiz Creator";
            this.tabControlCustomQuizCreator.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControlCustomQuizCreator;
        private TabPage tabPagePopQuiz;
        private TabPage tabPageGhicitoarea;
        private TabPage tabPageFlashMemoryCard;
        private TabPage tabPageSnake;
    }
}