namespace Quizy
{
    partial class FormMainQuiz
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
            this.pictureBoxComputerScience = new System.Windows.Forms.PictureBox();
            this.pictureBoxAlgebra = new System.Windows.Forms.PictureBox();
            this.pictureBoxGeometry = new System.Windows.Forms.PictureBox();
            this.pictureBoxPhysics = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxComputerScience)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAlgebra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGeometry)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPhysics)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxComputerScience
            // 
            this.pictureBoxComputerScience.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxComputerScience.BackgroundImage = global::Quizy.Properties.Resources.Computer_Science_Quiz;
            this.pictureBoxComputerScience.Location = new System.Drawing.Point(175, 40);
            this.pictureBoxComputerScience.Name = "pictureBoxComputerScience";
            this.pictureBoxComputerScience.Size = new System.Drawing.Size(225, 225);
            this.pictureBoxComputerScience.TabIndex = 0;
            this.pictureBoxComputerScience.TabStop = false;
            // 
            // pictureBoxAlgebra
            // 
            this.pictureBoxAlgebra.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxAlgebra.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxAlgebra.BackgroundImage = global::Quizy.Properties.Resources.Algebra_Quiz;
            this.pictureBoxAlgebra.Location = new System.Drawing.Point(500, 40);
            this.pictureBoxAlgebra.Name = "pictureBoxAlgebra";
            this.pictureBoxAlgebra.Size = new System.Drawing.Size(225, 225);
            this.pictureBoxAlgebra.TabIndex = 1;
            this.pictureBoxAlgebra.TabStop = false;
            // 
            // pictureBoxGeometry
            // 
            this.pictureBoxGeometry.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBoxGeometry.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxGeometry.BackgroundImage = global::Quizy.Properties.Resources.Geometry_Quiz;
            this.pictureBoxGeometry.Location = new System.Drawing.Point(175, 300);
            this.pictureBoxGeometry.Name = "pictureBoxGeometry";
            this.pictureBoxGeometry.Size = new System.Drawing.Size(225, 225);
            this.pictureBoxGeometry.TabIndex = 2;
            this.pictureBoxGeometry.TabStop = false;
            // 
            // pictureBoxPhysics
            // 
            this.pictureBoxPhysics.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxPhysics.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxPhysics.BackgroundImage = global::Quizy.Properties.Resources.Physics_Quiz;
            this.pictureBoxPhysics.Location = new System.Drawing.Point(500, 300);
            this.pictureBoxPhysics.Name = "pictureBoxPhysics";
            this.pictureBoxPhysics.Size = new System.Drawing.Size(225, 225);
            this.pictureBoxPhysics.TabIndex = 3;
            this.pictureBoxPhysics.TabStop = false;
            // 
            // FormMainQuiz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Quizy.Properties.Resources.background_main_quiz;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.pictureBoxPhysics);
            this.Controls.Add(this.pictureBoxGeometry);
            this.Controls.Add(this.pictureBoxAlgebra);
            this.Controls.Add(this.pictureBoxComputerScience);
            this.Name = "FormMainQuiz";
            this.Text = "Quizy";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxComputerScience)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAlgebra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGeometry)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPhysics)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox pictureBoxComputerScience;
        private PictureBox pictureBoxAlgebra;
        private PictureBox pictureBoxGeometry;
        private PictureBox pictureBoxPhysics;
    }
}