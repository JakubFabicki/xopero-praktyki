
namespace Algorytmy
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
            this.answerBtn1 = new System.Windows.Forms.Button();
            this.answerBtn2 = new System.Windows.Forms.Button();
            this.answerBtn3 = new System.Windows.Forms.Button();
            this.randomNum = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.randomAlg = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.rightBox = new System.Windows.Forms.TextBox();
            this.failBoxLabel = new System.Windows.Forms.Label();
            this.failBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // answerBtn1
            // 
            this.answerBtn1.Location = new System.Drawing.Point(12, 62);
            this.answerBtn1.Name = "answerBtn1";
            this.answerBtn1.Size = new System.Drawing.Size(149, 92);
            this.answerBtn1.TabIndex = 0;
            this.answerBtn1.Text = "button1";
            this.answerBtn1.UseVisualStyleBackColor = true;
            this.answerBtn1.Click += new System.EventHandler(this.answerBtn1_Click);
            // 
            // answerBtn2
            // 
            this.answerBtn2.Location = new System.Drawing.Point(167, 62);
            this.answerBtn2.Name = "answerBtn2";
            this.answerBtn2.Size = new System.Drawing.Size(149, 92);
            this.answerBtn2.TabIndex = 1;
            this.answerBtn2.Text = "button2";
            this.answerBtn2.UseVisualStyleBackColor = true;
            this.answerBtn2.Click += new System.EventHandler(this.answerBtn2_Click);
            // 
            // answerBtn3
            // 
            this.answerBtn3.Location = new System.Drawing.Point(322, 62);
            this.answerBtn3.Name = "answerBtn3";
            this.answerBtn3.Size = new System.Drawing.Size(149, 92);
            this.answerBtn3.TabIndex = 2;
            this.answerBtn3.Text = "button3";
            this.answerBtn3.UseVisualStyleBackColor = true;
            this.answerBtn3.Click += new System.EventHandler(this.answerBtn3_Click);
            // 
            // randomNum
            // 
            this.randomNum.Location = new System.Drawing.Point(12, 25);
            this.randomNum.Name = "randomNum";
            this.randomNum.ReadOnly = true;
            this.randomNum.Size = new System.Drawing.Size(139, 20);
            this.randomNum.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ilość wylosowanych liczb:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(164, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Wylosowany algorytm:";
            // 
            // randomAlg
            // 
            this.randomAlg.Location = new System.Drawing.Point(164, 25);
            this.randomAlg.Name = "randomAlg";
            this.randomAlg.ReadOnly = true;
            this.randomAlg.Size = new System.Drawing.Size(125, 20);
            this.randomAlg.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(299, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Udane próby";
            // 
            // rightBox
            // 
            this.rightBox.Location = new System.Drawing.Point(299, 25);
            this.rightBox.Name = "rightBox";
            this.rightBox.ReadOnly = true;
            this.rightBox.Size = new System.Drawing.Size(76, 20);
            this.rightBox.TabIndex = 7;
            this.rightBox.Text = "0";
            // 
            // failBoxLabel
            // 
            this.failBoxLabel.AutoSize = true;
            this.failBoxLabel.Location = new System.Drawing.Point(387, 9);
            this.failBoxLabel.Name = "failBoxLabel";
            this.failBoxLabel.Size = new System.Drawing.Size(82, 13);
            this.failBoxLabel.TabIndex = 10;
            this.failBoxLabel.Text = "Nieudane próby";
            // 
            // failBox
            // 
            this.failBox.Location = new System.Drawing.Point(387, 25);
            this.failBox.Name = "failBox";
            this.failBox.ReadOnly = true;
            this.failBox.Size = new System.Drawing.Size(76, 20);
            this.failBox.TabIndex = 9;
            this.failBox.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 166);
            this.Controls.Add(this.failBoxLabel);
            this.Controls.Add(this.failBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rightBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.randomAlg);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.randomNum);
            this.Controls.Add(this.answerBtn3);
            this.Controls.Add(this.answerBtn2);
            this.Controls.Add(this.answerBtn1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button answerBtn1;
        private System.Windows.Forms.Button answerBtn2;
        private System.Windows.Forms.Button answerBtn3;
        private System.Windows.Forms.TextBox randomNum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox randomAlg;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox rightBox;
        private System.Windows.Forms.Label failBoxLabel;
        private System.Windows.Forms.TextBox failBox;
    }
}

