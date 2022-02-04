
namespace Ul
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
            this.raportBox = new System.Windows.Forms.TextBox();
            this.shiftBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.shiftsNum = new System.Windows.Forms.NumericUpDown();
            this.workBtn = new System.Windows.Forms.Button();
            this.workBeeBox = new System.Windows.Forms.ComboBox();
            this.moneyBox = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.shiftsNum)).BeginInit();
            this.SuspendLayout();
            // 
            // raportBox
            // 
            this.raportBox.Location = new System.Drawing.Point(12, 104);
            this.raportBox.Multiline = true;
            this.raportBox.Name = "raportBox";
            this.raportBox.Size = new System.Drawing.Size(373, 188);
            this.raportBox.TabIndex = 0;
            // 
            // shiftBtn
            // 
            this.shiftBtn.Font = new System.Drawing.Font("Impact", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.shiftBtn.Location = new System.Drawing.Point(261, 26);
            this.shiftBtn.Name = "shiftBtn";
            this.shiftBtn.Size = new System.Drawing.Size(124, 72);
            this.shiftBtn.TabIndex = 1;
            this.shiftBtn.Text = "Przepracuj następną zmianę";
            this.shiftBtn.UseVisualStyleBackColor = true;
            this.shiftBtn.Click += new System.EventHandler(this.shiftBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.workBeeBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.shiftsNum);
            this.groupBox1.Controls.Add(this.workBtn);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(227, 86);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Przydział prac robotnicom";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(160, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Zmiany";
            // 
            // shiftsNum
            // 
            this.shiftsNum.Location = new System.Drawing.Point(163, 30);
            this.shiftsNum.Name = "shiftsNum";
            this.shiftsNum.Size = new System.Drawing.Size(58, 20);
            this.shiftsNum.TabIndex = 3;
            this.shiftsNum.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // workBtn
            // 
            this.workBtn.Location = new System.Drawing.Point(6, 56);
            this.workBtn.Name = "workBtn";
            this.workBtn.Size = new System.Drawing.Size(215, 24);
            this.workBtn.TabIndex = 3;
            this.workBtn.Text = "Przypisz tę pracę pszczole";
            this.workBtn.UseVisualStyleBackColor = true;
            this.workBtn.Click += new System.EventHandler(this.workBtn_Click);
            // 
            // workBeeBox
            // 
            this.workBeeBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.workBeeBox.FormattingEnabled = true;
            this.workBeeBox.Items.AddRange(new object[] {
            "Nauczanie pszczółek",
            "Pielęgnacja jaj",
            "Utrzymanie ula",
            "Wytwarzanie miodu",
            "Zbieranie nektaru",
            "Patrol z żądłami"});
            this.workBeeBox.Location = new System.Drawing.Point(6, 29);
            this.workBeeBox.Name = "workBeeBox";
            this.workBeeBox.Size = new System.Drawing.Size(151, 21);
            this.workBeeBox.TabIndex = 5;
            // 
            // moneyBox
            // 
            this.moneyBox.AutoSize = true;
            this.moneyBox.Location = new System.Drawing.Point(300, 9);
            this.moneyBox.Name = "moneyBox";
            this.moneyBox.Size = new System.Drawing.Size(41, 13);
            this.moneyBox.TabIndex = 6;
            this.moneyBox.Text = "Zmiany";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 304);
            this.Controls.Add(this.moneyBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.shiftBtn);
            this.Controls.Add(this.raportBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.shiftsNum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox raportBox;
        private System.Windows.Forms.Button shiftBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown shiftsNum;
        private System.Windows.Forms.Button workBtn;
        private System.Windows.Forms.ComboBox workBeeBox;
        private System.Windows.Forms.Label moneyBox;
    }
}

