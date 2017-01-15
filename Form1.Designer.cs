namespace Cmr5Killer
{
    partial class Form1
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
            this.FileTextBox = new System.Windows.Forms.TextBox();
            this.decBTN = new System.Windows.Forms.Button();
            this.infoListBox = new System.Windows.Forms.ListBox();
            this.ofdButton = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // FileTextBox
            // 
            this.FileTextBox.Location = new System.Drawing.Point(2, 12);
            this.FileTextBox.Name = "FileTextBox";
            this.FileTextBox.Size = new System.Drawing.Size(425, 20);
            this.FileTextBox.TabIndex = 0;
            // 
            // decBTN
            // 
            this.decBTN.Location = new System.Drawing.Point(433, 115);
            this.decBTN.Name = "decBTN";
            this.decBTN.Size = new System.Drawing.Size(71, 28);
            this.decBTN.TabIndex = 1;
            this.decBTN.Text = "Decompile";
            this.decBTN.UseVisualStyleBackColor = true;
            this.decBTN.Click += new System.EventHandler(this.decBTN_Click);
            // 
            // infoListBox
            // 
            this.infoListBox.FormattingEnabled = true;
            this.infoListBox.Location = new System.Drawing.Point(2, 35);
            this.infoListBox.Name = "infoListBox";
            this.infoListBox.Size = new System.Drawing.Size(425, 108);
            this.infoListBox.TabIndex = 2;
            // 
            // ofdButton
            // 
            this.ofdButton.Location = new System.Drawing.Point(433, 12);
            this.ofdButton.Name = "ofdButton";
            this.ofdButton.Size = new System.Drawing.Size(27, 20);
            this.ofdButton.TabIndex = 3;
            this.ofdButton.Text = "...";
            this.ofdButton.UseVisualStyleBackColor = true;
            this.ofdButton.Click += new System.EventHandler(this.ofdButton_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 149);
            this.Controls.Add(this.ofdButton);
            this.Controls.Add(this.infoListBox);
            this.Controls.Add(this.decBTN);
            this.Controls.Add(this.FileTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox FileTextBox;
        private System.Windows.Forms.Button decBTN;
        private System.Windows.Forms.ListBox infoListBox;
        private System.Windows.Forms.Button ofdButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

