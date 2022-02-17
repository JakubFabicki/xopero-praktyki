
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
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.delAllGrpBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.grpBtn = new System.Windows.Forms.Button();
            this.grpNumPage = new System.Windows.Forms.NumericUpDown();
            this.grpListBox = new System.Windows.Forms.CheckedListBox();
            this.delGrpBtn = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.genGrpName = new System.Windows.Forms.TextBox();
            this.addGrpBtn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numPage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.genRepoNum)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpNumPage)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Token użytkownika";
            // 
            // tokenBox
            // 
            this.tokenBox.Location = new System.Drawing.Point(12, 61);
            this.tokenBox.Name = "tokenBox";
            this.tokenBox.Size = new System.Drawing.Size(306, 20);
            this.tokenBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Lista projektów";
            // 
            // projectBtn
            // 
            this.projectBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.projectBtn.Location = new System.Drawing.Point(6, 241);
            this.projectBtn.Name = "projectBtn";
            this.projectBtn.Size = new System.Drawing.Size(160, 43);
            this.projectBtn.TabIndex = 7;
            this.projectBtn.Text = "Pokaż";
            this.projectBtn.UseVisualStyleBackColor = true;
            this.projectBtn.Click += new System.EventHandler(this.projectBtn_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(324, 58);
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
            this.deleteBtn.Location = new System.Drawing.Point(170, 241);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(160, 43);
            this.deleteBtn.TabIndex = 9;
            this.deleteBtn.Text = "Usuń";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // listBox
            // 
            this.listBox.CheckOnClick = true;
            this.listBox.FormattingEnabled = true;
            this.listBox.Location = new System.Drawing.Point(6, 36);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(324, 199);
            this.listBox.TabIndex = 10;
            // 
            // numPage
            // 
            this.numPage.Location = new System.Drawing.Point(283, 10);
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
            this.nameLabel.Size = new System.Drawing.Size(340, 34);
            this.nameLabel.TabIndex = 12;
            this.nameLabel.Text = "Witaj użytkowniku";
            this.nameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // deleteAllBtn
            // 
            this.deleteAllBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.deleteAllBtn.Location = new System.Drawing.Point(6, 290);
            this.deleteAllBtn.Name = "deleteAllBtn";
            this.deleteAllBtn.Size = new System.Drawing.Size(324, 40);
            this.deleteAllBtn.TabIndex = 13;
            this.deleteAllBtn.Text = "Usuń wszystko";
            this.deleteAllBtn.UseVisualStyleBackColor = true;
            this.deleteAllBtn.Click += new System.EventHandler(this.deleteAllBtn_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(9, 19);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(15, 14);
            this.checkBox1.TabIndex = 14;
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // addRepoBtn
            // 
            this.addRepoBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.addRepoBtn.Location = new System.Drawing.Point(6, 95);
            this.addRepoBtn.Name = "addRepoBtn";
            this.addRepoBtn.Size = new System.Drawing.Size(324, 43);
            this.addRepoBtn.TabIndex = 15;
            this.addRepoBtn.Text = "dodaj";
            this.addRepoBtn.UseVisualStyleBackColor = true;
            this.addRepoBtn.Click += new System.EventHandler(this.addRepoBtn_Click);
            // 
            // genRepoName
            // 
            this.genRepoName.Location = new System.Drawing.Point(6, 30);
            this.genRepoName.Name = "genRepoName";
            this.genRepoName.Size = new System.Drawing.Size(324, 20);
            this.genRepoName.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Nazwa";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Ilość";
            // 
            // genRepoNum
            // 
            this.genRepoNum.Location = new System.Drawing.Point(9, 69);
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
            this.genRepoNum.Size = new System.Drawing.Size(321, 20);
            this.genRepoNum.TabIndex = 20;
            this.genRepoNum.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // bar
            // 
            this.bar.Location = new System.Drawing.Point(9, 162);
            this.bar.Maximum = 10;
            this.bar.Name = "bar";
            this.bar.Size = new System.Drawing.Size(321, 22);
            this.bar.Step = 1;
            this.bar.TabIndex = 21;
            this.bar.Value = 1;
            this.bar.Visible = false;
            // 
            // barLabel
            // 
            this.barLabel.AutoSize = true;
            this.barLabel.Location = new System.Drawing.Point(6, 146);
            this.barLabel.Name = "barLabel";
            this.barLabel.Size = new System.Drawing.Size(35, 13);
            this.barLabel.TabIndex = 22;
            this.barLabel.Text = "label5";
            this.barLabel.Visible = false;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.checkBox2);
            this.tabPage3.Controls.Add(this.delAllGrpBtn);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.grpBtn);
            this.tabPage3.Controls.Add(this.grpNumPage);
            this.tabPage3.Controls.Add(this.grpListBox);
            this.tabPage3.Controls.Add(this.delGrpBtn);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(336, 340);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Przeglądaj grupy";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(9, 19);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(15, 14);
            this.checkBox2.TabIndex = 21;
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // delAllGrpBtn
            // 
            this.delAllGrpBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.delAllGrpBtn.Location = new System.Drawing.Point(6, 290);
            this.delAllGrpBtn.Name = "delAllGrpBtn";
            this.delAllGrpBtn.Size = new System.Drawing.Size(324, 40);
            this.delAllGrpBtn.TabIndex = 20;
            this.delAllGrpBtn.Text = "Usuń wszystko";
            this.delAllGrpBtn.UseVisualStyleBackColor = true;
            this.delAllGrpBtn.Click += new System.EventHandler(this.delAllGrpBtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Lista grup";
            // 
            // grpBtn
            // 
            this.grpBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.grpBtn.Location = new System.Drawing.Point(6, 241);
            this.grpBtn.Name = "grpBtn";
            this.grpBtn.Size = new System.Drawing.Size(160, 43);
            this.grpBtn.TabIndex = 16;
            this.grpBtn.Text = "Pokaż";
            this.grpBtn.UseVisualStyleBackColor = true;
            this.grpBtn.Click += new System.EventHandler(this.grpBtn_Click);
            // 
            // grpNumPage
            // 
            this.grpNumPage.Location = new System.Drawing.Point(283, 10);
            this.grpNumPage.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.grpNumPage.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.grpNumPage.Name = "grpNumPage";
            this.grpNumPage.Size = new System.Drawing.Size(47, 20);
            this.grpNumPage.TabIndex = 19;
            this.grpNumPage.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // grpListBox
            // 
            this.grpListBox.CheckOnClick = true;
            this.grpListBox.FormattingEnabled = true;
            this.grpListBox.Location = new System.Drawing.Point(6, 36);
            this.grpListBox.Name = "grpListBox";
            this.grpListBox.Size = new System.Drawing.Size(324, 199);
            this.grpListBox.TabIndex = 18;
            // 
            // delGrpBtn
            // 
            this.delGrpBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.delGrpBtn.Location = new System.Drawing.Point(170, 241);
            this.delGrpBtn.Name = "delGrpBtn";
            this.delGrpBtn.Size = new System.Drawing.Size(160, 43);
            this.delGrpBtn.TabIndex = 17;
            this.delGrpBtn.Text = "Usuń";
            this.delGrpBtn.UseVisualStyleBackColor = true;
            this.delGrpBtn.Click += new System.EventHandler(this.delGrpBtn_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.genRepoName);
            this.tabPage2.Controls.Add(this.barLabel);
            this.tabPage2.Controls.Add(this.addRepoBtn);
            this.tabPage2.Controls.Add(this.bar);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.genRepoNum);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(336, 340);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Dodaj projekty";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(12, 87);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(344, 366);
            this.tabControl1.TabIndex = 23;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.checkBox1);
            this.tabPage1.Controls.Add(this.deleteAllBtn);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.projectBtn);
            this.tabPage1.Controls.Add(this.numPage);
            this.tabPage1.Controls.Add(this.listBox);
            this.tabPage1.Controls.Add(this.deleteBtn);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(336, 340);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Przeglądaj projekty";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.genGrpName);
            this.tabPage4.Controls.Add(this.addGrpBtn);
            this.tabPage4.Controls.Add(this.label6);
            this.tabPage4.Controls.Add(this.numericUpDown1);
            this.tabPage4.Controls.Add(this.label7);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(336, 340);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Dodaj grupę";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // genGrpName
            // 
            this.genGrpName.Location = new System.Drawing.Point(6, 19);
            this.genGrpName.Name = "genGrpName";
            this.genGrpName.Size = new System.Drawing.Size(324, 20);
            this.genGrpName.TabIndex = 22;
            // 
            // addGrpBtn
            // 
            this.addGrpBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.addGrpBtn.Location = new System.Drawing.Point(6, 84);
            this.addGrpBtn.Name = "addGrpBtn";
            this.addGrpBtn.Size = new System.Drawing.Size(324, 43);
            this.addGrpBtn.TabIndex = 21;
            this.addGrpBtn.Text = "dodaj";
            this.addGrpBtn.UseVisualStyleBackColor = true;
            this.addGrpBtn.Click += new System.EventHandler(this.addGrpBtn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "Nazwa subgrupy";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 42);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 13);
            this.label7.TabIndex = 24;
            this.label7.Text = "Ilość";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(9, 58);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(321, 20);
            this.numericUpDown1.TabIndex = 25;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 465);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.tokenBox);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numPage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.genRepoNum)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpNumPage)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
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
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Button delAllGrpBtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button grpBtn;
        private System.Windows.Forms.NumericUpDown grpNumPage;
        private System.Windows.Forms.CheckedListBox grpListBox;
        private System.Windows.Forms.Button delGrpBtn;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TextBox genGrpName;
        private System.Windows.Forms.Button addGrpBtn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label7;
    }
}

