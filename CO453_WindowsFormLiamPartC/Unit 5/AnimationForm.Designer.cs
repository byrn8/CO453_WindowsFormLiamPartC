namespace CO453_WindowsFormLiamPartC.Unit_5
{
    partial class AnimationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnimationForm));
            this.MovePictureBox = new System.Windows.Forms.PictureBox();
            this.Panel = new System.Windows.Forms.Panel();
            this.StopRadioButton = new System.Windows.Forms.RadioButton();
            this.StartRadioButton = new System.Windows.Forms.RadioButton();
            this.ClickQuitButton = new System.Windows.Forms.Button();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.ChangeSpeedBar = new System.Windows.Forms.HScrollBar();
            this.MovePictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.MovePictureBox)).BeginInit();
            this.Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MovePictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // MovePictureBox
            // 
            this.MovePictureBox.Location = new System.Drawing.Point(92, 12);
            this.MovePictureBox.Name = "MovePictureBox";
            this.MovePictureBox.Size = new System.Drawing.Size(139, 110);
            this.MovePictureBox.TabIndex = 0;
            this.MovePictureBox.TabStop = false;
            // 
            // Panel
            // 
            this.Panel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Panel.Controls.Add(this.StopRadioButton);
            this.Panel.Controls.Add(this.StartRadioButton);
            this.Panel.Location = new System.Drawing.Point(12, 238);
            this.Panel.Name = "Panel";
            this.Panel.Size = new System.Drawing.Size(255, 44);
            this.Panel.TabIndex = 1;
            // 
            // StopRadioButton
            // 
            this.StopRadioButton.AutoSize = true;
            this.StopRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StopRadioButton.ForeColor = System.Drawing.Color.Red;
            this.StopRadioButton.Location = new System.Drawing.Point(120, 12);
            this.StopRadioButton.Name = "StopRadioButton";
            this.StopRadioButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StopRadioButton.Size = new System.Drawing.Size(61, 24);
            this.StopRadioButton.TabIndex = 1;
            this.StopRadioButton.TabStop = true;
            this.StopRadioButton.Text = "Stop";
            this.StopRadioButton.UseVisualStyleBackColor = true;
            this.StopRadioButton.CheckedChanged += new System.EventHandler(this.StopRadioButton_CheckedChanged);
            // 
            // StartRadioButton
            // 
            this.StartRadioButton.AutoSize = true;
            this.StartRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartRadioButton.ForeColor = System.Drawing.Color.Red;
            this.StartRadioButton.Location = new System.Drawing.Point(3, 12);
            this.StartRadioButton.Name = "StartRadioButton";
            this.StartRadioButton.Size = new System.Drawing.Size(62, 24);
            this.StartRadioButton.TabIndex = 0;
            this.StartRadioButton.TabStop = true;
            this.StartRadioButton.Text = "Start";
            this.StartRadioButton.UseVisualStyleBackColor = true;
            this.StartRadioButton.CheckedChanged += new System.EventHandler(this.StartRadioButton_CheckedChanged);
            // 
            // ClickQuitButton
            // 
            this.ClickQuitButton.Location = new System.Drawing.Point(379, 259);
            this.ClickQuitButton.Name = "ClickQuitButton";
            this.ClickQuitButton.Size = new System.Drawing.Size(75, 23);
            this.ClickQuitButton.TabIndex = 2;
            this.ClickQuitButton.Text = "Quit";
            this.ClickQuitButton.UseVisualStyleBackColor = true;
            this.ClickQuitButton.Click += new System.EventHandler(this.ClickQuitButton_Click);
            // 
            // Timer
            // 
            this.Timer.Interval = 50;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // ChangeSpeedBar
            // 
            this.ChangeSpeedBar.Location = new System.Drawing.Point(12, 218);
            this.ChangeSpeedBar.Name = "ChangeSpeedBar";
            this.ChangeSpeedBar.Size = new System.Drawing.Size(255, 17);
            this.ChangeSpeedBar.TabIndex = 3;
            this.ChangeSpeedBar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.ChangeSpeedBar_Scroll);
            // 
            // MovePictureBox2
            // 
            this.MovePictureBox2.Location = new System.Drawing.Point(267, 58);
            this.MovePictureBox2.Name = "MovePictureBox2";
            this.MovePictureBox2.Size = new System.Drawing.Size(85, 64);
            this.MovePictureBox2.TabIndex = 4;
            this.MovePictureBox2.TabStop = false;
            // 
            // AnimationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(466, 294);
            this.Controls.Add(this.MovePictureBox2);
            this.Controls.Add(this.ChangeSpeedBar);
            this.Controls.Add(this.ClickQuitButton);
            this.Controls.Add(this.Panel);
            this.Controls.Add(this.MovePictureBox);
            this.DoubleBuffered = true;
            this.Name = "AnimationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AnimationForm";
            this.Load += new System.EventHandler(this.AnimationForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MovePictureBox)).EndInit();
            this.Panel.ResumeLayout(false);
            this.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MovePictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox MovePictureBox;
        private System.Windows.Forms.Panel Panel;
        private System.Windows.Forms.RadioButton StopRadioButton;
        private System.Windows.Forms.RadioButton StartRadioButton;
        private System.Windows.Forms.Button ClickQuitButton;
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.HScrollBar ChangeSpeedBar;
        private System.Windows.Forms.PictureBox MovePictureBox2;
    }
}