
namespace GitApi
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
            this.label2 = new System.Windows.Forms.Label();
            this.tokenBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.projectBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.listBox = new System.Windows.Forms.CheckedListBox();
            this.numPage = new System.Windows.Forms.NumericUpDown();
            this.nameLabel = new System.Windows.Forms.Label();
            this.deleteAllBtn = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.addRepoBtn = new System.Windows.Forms.Button();
            this.genRepoName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.genRepoNum = new System.Windows.Forms.NumericUpDown();
            this.bar = new System.Windows.Forms.ProgressBar();
            this.barLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numPage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.genRepoNum)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Token użytkownika";
            // 
            // tokenBox
            // 
            this.tokenBox.Location = new System.Drawing.Point(12, 64);
            this.tokenBox.Name = "tokenBox";
            this.tokenBox.Size = new System.Drawing.Size(254, 20);
            this.tokenBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Lista projektów";
            // 
            // projectBtn
            // 
            this.projectBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.projectBtn.Location = new System.Drawing.Point(12, 321);
            this.projectBtn.Name = "projectBtn";
            this.projectBtn.Size = new System.Drawing.Size(139, 43);
            this.projectBtn.TabIndex = 7;
            this.projectBtn.Text = "Pokaż";
            this.projectBtn.UseVisualStyleBackColor = true;
            this.projectBtn.Click += new System.EventHandler(this.projectBtn_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(272, 61);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(28, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "?";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.deleteBtn.Location = new System.Drawing.Point(157, 321);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(143, 43);
            this.deleteBtn.TabIndex = 9;
            this.deleteBtn.Text = "Usuń";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // listBox
            // 
            this.listBox.CheckOnClick = true;
            this.listBox.FormattingEnabled = true;
            this.listBox.Location = new System.Drawing.Point(12, 116);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(288, 199);
            this.listBox.TabIndex = 10;
            // 
            // numPage
            // 
            this.numPage.Location = new System.Drawing.Point(253, 90);
            this.numPage.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numPage.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numPage.Name = "numPage";
            this.numPage.Size = new System.Drawing.Size(47, 20);
            this.numPage.TabIndex = 11;
            this.numPage.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numPage.ValueChanged += new System.EventHandler(this.numPage_ValueChanged);
            // 
            // nameLabel
            // 
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nameLabel.Location = new System.Drawing.Point(12, 9);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(288, 34);
            this.nameLabel.TabIndex = 12;
            this.nameLabel.Text = "Witaj użytkowniku";
            this.nameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // deleteAllBtn
            // 
            this.deleteAllBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.deleteAllBtn.Location = new System.Drawing.Point(12, 370);
            this.deleteAllBtn.Name = "deleteAllBtn";
            this.deleteAllBtn.Size = new System.Drawing.Size(288, 40);
            this.deleteAllBtn.TabIndex = 13;
            this.deleteAllBtn.Text = "Usuń wszystko";
            this.deleteAllBtn.UseVisualStyleBackColor = true;
            this.deleteAllBtn.Click += new System.EventHandler(this.deleteAllBtn_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(15, 99);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(15, 14);
            this.checkBox1.TabIndex = 14;
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // addRepoBtn
            // 
            this.addRepoBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.addRepoBtn.Location = new System.Drawing.Point(306, 321);
            this.addRepoBtn.Name = "addRepoBtn";
            this.addRepoBtn.Size = new System.Drawing.Size(143, 43);
            this.addRepoBtn.TabIndex = 15;
            this.addRepoBtn.Text = "dodaj";
            this.addRepoBtn.UseVisualStyleBackColor = true;
            this.addRepoBtn.Click += new System.EventHandler(this.addRepoBtn_Click);
            // 
            // genRepoName
            // 
            this.genRepoName.Location = new System.Drawing.Point(306, 256);
            this.genRepoName.Name = "genRepoName";
            this.genRepoName.Size = new System.Drawing.Size(144, 20);
            this.genRepoName.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(306, 240);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Nazwa";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(306, 279);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Ilość";
            // 
            // genRepoNum
            // 
            this.genRepoNum.Location = new System.Drawing.Point(309, 295);
            this.genRepoNum.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.genRepoNum.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.genRepoNum.Name = "genRepoNum";
            this.genRepoNum.Size = new System.Drawing.Size(141, 20);
            this.genRepoNum.TabIndex = 20;
            this.genRepoNum.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // bar
            // 
            this.bar.Location = new System.Drawing.Point(309, 388);
            this.bar.Maximum = 10;
            this.bar.Name = "bar";
            this.bar.Size = new System.Drawing.Size(141, 22);
            this.bar.Step = 1;
            this.bar.TabIndex = 21;
            this.bar.Value = 1;
            this.bar.Visible = false;
            // 
            // barLabel
            // 
            this.barLabel.AutoSize = true;
            this.barLabel.Location = new System.Drawing.Point(306, 372);
            this.barLabel.Name = "barLabel";
            this.barLabel.Size = new System.Drawing.Size(35, 13);
            this.barLabel.TabIndex = 22;
            this.barLabel.Text = "label5";
            this.barLabel.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 415);
            this.Controls.Add(this.barLabel);
            this.Controls.Add(this.bar);
            this.Controls.Add(this.genRepoNum);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.genRepoName);
            this.Controls.Add(this.addRepoBtn);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.deleteAllBtn);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.numPage);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.projectBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tokenBox);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numPage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.genRepoNum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tokenBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button projectBtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.CheckedListBox listBox;
        private System.Windows.Forms.NumericUpDown numPage;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Button deleteAllBtn;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button addRepoBtn;
        private System.Windows.Forms.TextBox genRepoName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown genRepoNum;
        private System.Windows.Forms.ProgressBar bar;
        private System.Windows.Forms.Label barLabel;
    }
}

