namespace CO453_WindowsFormLiamPartC.Unit_6
{
    partial class PickGraphicForm
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
            this.DisplayInfoLabel = new System.Windows.Forms.Label();
            this.ReadInputTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // DisplayInfoLabel
            // 
            this.DisplayInfoLabel.AutoSize = true;
            this.DisplayInfoLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DisplayInfoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DisplayInfoLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.DisplayInfoLabel.Location = new System.Drawing.Point(14, 9);
            this.DisplayInfoLabel.Name = "DisplayInfoLabel";
            this.DisplayInfoLabel.Size = new System.Drawing.Size(306, 27);
            this.DisplayInfoLabel.TabIndex = 1;
            this.DisplayInfoLabel.Text = "Enter Either L, R, E, C, S, or M";
            // 
            // ReadInputTextBox
            // 
            this.ReadInputTextBox.Location = new System.Drawing.Point(63, 56);
            this.ReadInputTextBox.Name = "ReadInputTextBox";
            this.ReadInputTextBox.Size = new System.Drawing.Size(198, 20);
            this.ReadInputTextBox.TabIndex = 0;
            // 
            // PickGraphicForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(332, 320);
            this.Controls.Add(this.DisplayInfoLabel);
            this.Controls.Add(this.ReadInputTextBox);
            this.Name = "PickGraphicForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PickGraphicForm";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.PickGraphicForm_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label DisplayInfoLabel;
        private System.Windows.Forms.TextBox ReadInputTextBox;
    }
}