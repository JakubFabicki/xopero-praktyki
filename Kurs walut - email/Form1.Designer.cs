
namespace Kurs_walut___email
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
            this.mailStartBtn = new System.Windows.Forms.Button();
            this.currencyListBox = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // mailStartBtn
            // 
            this.mailStartBtn.Location = new System.Drawing.Point(549, 12);
            this.mailStartBtn.Name = "mailStartBtn";
            this.mailStartBtn.Size = new System.Drawing.Size(75, 23);
            this.mailStartBtn.TabIndex = 0;
            this.mailStartBtn.Text = "button1";
            this.mailStartBtn.UseVisualStyleBackColor = true;
            this.mailStartBtn.Click += new System.EventHandler(this.mailStartBtn_Click);
            // 
            // currencyListBox
            // 
            this.currencyListBox.CheckOnClick = true;
            this.currencyListBox.FormattingEnabled = true;
            this.currencyListBox.Location = new System.Drawing.Point(12, 12);
            this.currencyListBox.Name = "currencyListBox";
            this.currencyListBox.Size = new System.Drawing.Size(462, 319);
            this.currencyListBox.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.currencyListBox);
            this.Controls.Add(this.mailStartBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button mailStartBtn;
        public System.Windows.Forms.CheckedListBox currencyListBox;
    }
}

