
namespace Guy
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
            this.reciveBtn = new System.Windows.Forms.Button();
            this.giveBtn = new System.Windows.Forms.Button();
            this.josh = new System.Windows.Forms.Label();
            this.bosh = new System.Windows.Forms.Label();
            this.bank = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // reciveBtn
            // 
            this.reciveBtn.Location = new System.Drawing.Point(42, 238);
            this.reciveBtn.Name = "reciveBtn";
            this.reciveBtn.Size = new System.Drawing.Size(75, 23);
            this.reciveBtn.TabIndex = 0;
            this.reciveBtn.Text = "button1";
            this.reciveBtn.UseVisualStyleBackColor = true;
            this.reciveBtn.Click += new System.EventHandler(this.reciveBtn_Click);
            // 
            // giveBtn
            // 
            this.giveBtn.Location = new System.Drawing.Point(152, 238);
            this.giveBtn.Name = "giveBtn";
            this.giveBtn.Size = new System.Drawing.Size(75, 23);
            this.giveBtn.TabIndex = 1;
            this.giveBtn.Text = "button2";
            this.giveBtn.UseVisualStyleBackColor = true;
            this.giveBtn.Click += new System.EventHandler(this.giveBtn_Click);
            // 
            // josh
            // 
            this.josh.AutoSize = true;
            this.josh.Location = new System.Drawing.Point(48, 37);
            this.josh.Name = "josh";
            this.josh.Size = new System.Drawing.Size(35, 13);
            this.josh.TabIndex = 2;
            this.josh.Text = "label1";
            // 
            // bosh
            // 
            this.bosh.AutoSize = true;
            this.bosh.Location = new System.Drawing.Point(48, 62);
            this.bosh.Name = "bosh";
            this.bosh.Size = new System.Drawing.Size(35, 13);
            this.bosh.TabIndex = 3;
            this.bosh.Text = "label2";
            // 
            // bank
            // 
            this.bank.AutoSize = true;
            this.bank.Location = new System.Drawing.Point(48, 85);
            this.bank.Name = "bank";
            this.bank.Size = new System.Drawing.Size(35, 13);
            this.bank.TabIndex = 4;
            this.bank.Text = "label3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(265, 292);
            this.Controls.Add(this.bank);
            this.Controls.Add(this.bosh);
            this.Controls.Add(this.josh);
            this.Controls.Add(this.giveBtn);
            this.Controls.Add(this.reciveBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button reciveBtn;
        private System.Windows.Forms.Button giveBtn;
        private System.Windows.Forms.Label josh;
        private System.Windows.Forms.Label bosh;
        private System.Windows.Forms.Label bank;
    }
}

