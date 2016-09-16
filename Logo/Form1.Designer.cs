namespace Logo
{
    partial class window1
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
            this.startButton = new System.Windows.Forms.Button();
            this.countdownBox = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // startButton
            // 
            this.startButton.BackColor = System.Drawing.SystemColors.InfoText;
            this.startButton.Font = new System.Drawing.Font("Rockwell", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startButton.ForeColor = System.Drawing.SystemColors.Control;
            this.startButton.Location = new System.Drawing.Point(102, 110);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(177, 95);
            this.startButton.TabIndex = 0;
            this.startButton.Text = "Play Game";
            this.startButton.UseVisualStyleBackColor = false;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // countdownBox
            // 
            this.countdownBox.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countdownBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.countdownBox.Location = new System.Drawing.Point(146, 281);
            this.countdownBox.Name = "countdownBox";
            this.countdownBox.Size = new System.Drawing.Size(224, 28);
            this.countdownBox.TabIndex = 1;
            // 
            // window1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InfoText;
            this.ClientSize = new System.Drawing.Size(382, 318);
            this.Controls.Add(this.countdownBox);
            this.Controls.Add(this.startButton);
            this.Name = "window1";
            this.Text = "Christmas!";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Label countdownBox;
    }
}

