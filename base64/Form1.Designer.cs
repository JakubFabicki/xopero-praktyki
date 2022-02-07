
namespace base64
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
            this.normalTextBox = new System.Windows.Forms.TextBox();
            this.base64TextBox = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // normalTextBox
            // 
            this.normalTextBox.Location = new System.Drawing.Point(29, 22);
            this.normalTextBox.Multiline = true;
            this.normalTextBox.Name = "normalTextBox";
            this.normalTextBox.Size = new System.Drawing.Size(165, 143);
            this.normalTextBox.TabIndex = 0;
            this.normalTextBox.TextChanged += new System.EventHandler(this.normalTextBox_TextChanged);
            // 
            // base64TextBox
            // 
            this.base64TextBox.Location = new System.Drawing.Point(217, 22);
            this.base64TextBox.Multiline = true;
            this.base64TextBox.Name = "base64TextBox";
            this.base64TextBox.Size = new System.Drawing.Size(165, 143);
            this.base64TextBox.TabIndex = 1;
            this.base64TextBox.TextChanged += new System.EventHandler(this.base64TextBox_TextChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(301, 172);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(80, 17);
            this.checkBox1.TabIndex = 2;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.base64TextBox);
            this.Controls.Add(this.normalTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox normalTextBox;
        private System.Windows.Forms.TextBox base64TextBox;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}

