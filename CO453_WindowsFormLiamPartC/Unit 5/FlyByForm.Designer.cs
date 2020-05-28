namespace CO453_WindowsFormLiamPartC.Unit_5
{
    partial class FlyByForm
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
            this.StartButton = new System.Windows.Forms.Button();
            this.StopButton = new System.Windows.Forms.Button();
            this.QuitButton = new System.Windows.Forms.Button();
            this.PictureBox = new System.Windows.Forms.PictureBox();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.Panel = new System.Windows.Forms.Panel();
            this.DisplayDateLabel = new System.Windows.Forms.Label();
            this.DisplayTimeLabel = new System.Windows.Forms.Label();
            this.Timer2 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).BeginInit();
            this.Panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(12, 282);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(75, 23);
            this.StartButton.TabIndex = 0;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // StopButton
            // 
            this.StopButton.Location = new System.Drawing.Point(93, 282);
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(75, 23);
            this.StopButton.TabIndex = 1;
            this.StopButton.Text = "Stop";
            this.StopButton.UseVisualStyleBackColor = true;
            this.StopButton.Click += new System.EventHandler(this.StopButton_Click);
            // 
            // QuitButton
            // 
            this.QuitButton.Location = new System.Drawing.Point(174, 282);
            this.QuitButton.Name = "QuitButton";
            this.QuitButton.Size = new System.Drawing.Size(75, 23);
            this.QuitButton.TabIndex = 2;
            this.QuitButton.Text = "Quit";
            this.QuitButton.UseVisualStyleBackColor = true;
            this.QuitButton.Click += new System.EventHandler(this.QuitButton_Click);
            // 
            // PictureBox
            // 
            this.PictureBox.Location = new System.Drawing.Point(43, 71);
            this.PictureBox.Name = "PictureBox";
            this.PictureBox.Size = new System.Drawing.Size(180, 135);
            this.PictureBox.TabIndex = 3;
            this.PictureBox.TabStop = false;
            // 
            // Timer
            // 
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // Panel
            // 
            this.Panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Panel.Controls.Add(this.DisplayTimeLabel);
            this.Panel.Controls.Add(this.DisplayDateLabel);
            this.Panel.Location = new System.Drawing.Point(254, 12);
            this.Panel.Name = "Panel";
            this.Panel.Size = new System.Drawing.Size(142, 63);
            this.Panel.TabIndex = 4;
            // 
            // DisplayDateLabel
            // 
            this.DisplayDateLabel.AutoSize = true;
            this.DisplayDateLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DisplayDateLabel.Location = new System.Drawing.Point(3, 10);
            this.DisplayDateLabel.Name = "DisplayDateLabel";
            this.DisplayDateLabel.Size = new System.Drawing.Size(2, 15);
            this.DisplayDateLabel.TabIndex = 0;
            // 
            // DisplayTimeLabel
            // 
            this.DisplayTimeLabel.AutoSize = true;
            this.DisplayTimeLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DisplayTimeLabel.Location = new System.Drawing.Point(3, 38);
            this.DisplayTimeLabel.Name = "DisplayTimeLabel";
            this.DisplayTimeLabel.Size = new System.Drawing.Size(2, 15);
            this.DisplayTimeLabel.TabIndex = 1;
            // 
            // Timer2
            // 
            this.Timer2.Enabled = true;
            this.Timer2.Tick += new System.EventHandler(this.Timer2_Tick);
            // 
            // FlyByForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(408, 317);
            this.Controls.Add(this.Panel);
            this.Controls.Add(this.PictureBox);
            this.Controls.Add(this.QuitButton);
            this.Controls.Add(this.StopButton);
            this.Controls.Add(this.StartButton);
            this.Name = "FlyByForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FlyByForm";
            this.Load += new System.EventHandler(this.FlyByForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).EndInit();
            this.Panel.ResumeLayout(false);
            this.Panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Button StopButton;
        private System.Windows.Forms.Button QuitButton;
        private System.Windows.Forms.PictureBox PictureBox;
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.Panel Panel;
        private System.Windows.Forms.Label DisplayTimeLabel;
        private System.Windows.Forms.Label DisplayDateLabel;
        private System.Windows.Forms.Timer Timer2;
    }
}