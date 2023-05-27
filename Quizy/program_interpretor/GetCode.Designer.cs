namespace Quizy.program_interpretor
{
    partial class GetCode
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
            labelCode = new Label();
            textBoxCode = new TextBox();
            buttonOpen = new Button();
            SuspendLayout();
            // 
            // labelCode
            // 
            labelCode.AutoSize = true;
            labelCode.BackColor = Color.Transparent;
            labelCode.Font = new Font("Microsoft Tai Le", 15F, FontStyle.Regular, GraphicsUnit.Point);
            labelCode.Location = new Point(70, 60);
            labelCode.Name = "labelCode";
            labelCode.Size = new Size(165, 31);
            labelCode.TabIndex = 0;
            labelCode.Text = "Introdu codul";
            // 
            // textBoxCode
            // 
            textBoxCode.Font = new Font("Microsoft Tai Le", 15F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxCode.Location = new Point(241, 52);
            textBoxCode.Name = "textBoxCode";
            textBoxCode.Size = new Size(299, 39);
            textBoxCode.TabIndex = 1;
            // 
            // buttonOpen
            // 
            buttonOpen.BackColor = SystemColors.Window;
            buttonOpen.Font = new Font("Microsoft Tai Le", 13F, FontStyle.Regular, GraphicsUnit.Point);
            buttonOpen.Location = new Point(241, 110);
            buttonOpen.Name = "buttonOpen";
            buttonOpen.Size = new Size(163, 56);
            buttonOpen.TabIndex = 2;
            buttonOpen.Text = "Open Quiz";
            buttonOpen.UseVisualStyleBackColor = false;
            buttonOpen.Click += buttonOpen_Click;
            // 
            // Code
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Background_flash_memory_card;
            ClientSize = new Size(652, 203);
            Controls.Add(buttonOpen);
            Controls.Add(textBoxCode);
            Controls.Add(labelCode);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Code";
            Text = "Code";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelCode;
        private TextBox textBoxCode;
        private Button buttonOpen;
    }
}