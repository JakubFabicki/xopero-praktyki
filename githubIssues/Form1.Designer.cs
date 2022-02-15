
namespace githubIssues
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
            this.ownerBox = new System.Windows.Forms.TextBox();
            this.tokenBox = new System.Windows.Forms.TextBox();
            this.repoBox = new System.Windows.Forms.TextBox();
            this.viewDataBtn = new System.Windows.Forms.Button();
            this.issuesView = new System.Windows.Forms.TextBox();
            this.pullView = new System.Windows.Forms.TextBox();
            this.pullClosedView = new System.Windows.Forms.TextBox();
            this.tokenBtn = new System.Windows.Forms.Button();
            this.viewRepoBtn = new System.Windows.Forms.Button();
            this.viewRepoBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.raportBtn = new System.Windows.Forms.Button();
            this.getRaportBtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.issuesData = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.openPullReqData = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.closedPullReqData = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateData = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // ownerBox
            // 
            this.ownerBox.Location = new System.Drawing.Point(12, 20);
            this.ownerBox.Name = "ownerBox";
            this.ownerBox.Size = new System.Drawing.Size(161, 20);
            this.ownerBox.TabIndex = 1;
            // 
            // tokenBox
            // 
            this.tokenBox.Location = new System.Drawing.Point(330, 20);
            this.tokenBox.Name = "tokenBox";
            this.tokenBox.Size = new System.Drawing.Size(286, 20);
            this.tokenBox.TabIndex = 2;
            // 
            // repoBox
            // 
            this.repoBox.Location = new System.Drawing.Point(179, 20);
            this.repoBox.Name = "repoBox";
            this.repoBox.Size = new System.Drawing.Size(145, 20);
            this.repoBox.TabIndex = 3;
            // 
            // viewDataBtn
            // 
            this.viewDataBtn.Location = new System.Drawing.Point(12, 48);
            this.viewDataBtn.Name = "viewDataBtn";
            this.viewDataBtn.Size = new System.Drawing.Size(312, 31);
            this.viewDataBtn.TabIndex = 4;
            this.viewDataBtn.Text = "pokaz dane";
            this.viewDataBtn.UseVisualStyleBackColor = true;
            this.viewDataBtn.Click += new System.EventHandler(this.repoBtn_Click);
            // 
            // issuesView
            // 
            this.issuesView.Location = new System.Drawing.Point(12, 86);
            this.issuesView.Multiline = true;
            this.issuesView.Name = "issuesView";
            this.issuesView.Size = new System.Drawing.Size(100, 120);
            this.issuesView.TabIndex = 5;
            // 
            // pullView
            // 
            this.pullView.Location = new System.Drawing.Point(118, 85);
            this.pullView.Multiline = true;
            this.pullView.Name = "pullView";
            this.pullView.Size = new System.Drawing.Size(100, 120);
            this.pullView.TabIndex = 6;
            // 
            // pullClosedView
            // 
            this.pullClosedView.Location = new System.Drawing.Point(224, 85);
            this.pullClosedView.Multiline = true;
            this.pullClosedView.Name = "pullClosedView";
            this.pullClosedView.Size = new System.Drawing.Size(100, 120);
            this.pullClosedView.TabIndex = 7;
            // 
            // tokenBtn
            // 
            this.tokenBtn.Location = new System.Drawing.Point(622, 20);
            this.tokenBtn.Name = "tokenBtn";
            this.tokenBtn.Size = new System.Drawing.Size(20, 20);
            this.tokenBtn.TabIndex = 8;
            this.tokenBtn.Text = "?";
            this.tokenBtn.UseVisualStyleBackColor = true;
            this.tokenBtn.Click += new System.EventHandler(this.tokenBtn_Click);
            // 
            // viewRepoBtn
            // 
            this.viewRepoBtn.Location = new System.Drawing.Point(330, 48);
            this.viewRepoBtn.Name = "viewRepoBtn";
            this.viewRepoBtn.Size = new System.Drawing.Size(312, 31);
            this.viewRepoBtn.TabIndex = 9;
            this.viewRepoBtn.Text = "pokaż repozytoria";
            this.viewRepoBtn.UseVisualStyleBackColor = true;
            this.viewRepoBtn.Click += new System.EventHandler(this.viewRepoBtn_Click);
            // 
            // viewRepoBox
            // 
            this.viewRepoBox.Location = new System.Drawing.Point(330, 85);
            this.viewRepoBox.Multiline = true;
            this.viewRepoBox.Name = "viewRepoBox";
            this.viewRepoBox.Size = new System.Drawing.Size(312, 120);
            this.viewRepoBox.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Nazwa użytkownika";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(176, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Nazwa repozytorium";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(327, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Token użytkownika";
            // 
            // raportBtn
            // 
            this.raportBtn.Location = new System.Drawing.Point(12, 212);
            this.raportBtn.Name = "raportBtn";
            this.raportBtn.Size = new System.Drawing.Size(312, 45);
            this.raportBtn.TabIndex = 14;
            this.raportBtn.Text = "Generuj raport!";
            this.raportBtn.UseVisualStyleBackColor = true;
            this.raportBtn.Click += new System.EventHandler(this.raportBtn_Click);
            // 
            // getRaportBtn
            // 
            this.getRaportBtn.Location = new System.Drawing.Point(330, 212);
            this.getRaportBtn.Name = "getRaportBtn";
            this.getRaportBtn.Size = new System.Drawing.Size(313, 45);
            this.getRaportBtn.TabIndex = 15;
            this.getRaportBtn.Text = "Wyświetl raporty";
            this.getRaportBtn.UseVisualStyleBackColor = true;
            this.getRaportBtn.Click += new System.EventHandler(this.getRaportBtn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.issuesData,
            this.openPullReqData,
            this.closedPullReqData,
            this.dateData});
            this.dataGridView1.Location = new System.Drawing.Point(12, 264);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(630, 206);
            this.dataGridView1.TabIndex = 16;
            // 
            // issuesData
            // 
            this.issuesData.HeaderText = "Issues count";
            this.issuesData.Name = "issuesData";
            this.issuesData.ReadOnly = true;
            // 
            // openPullReqData
            // 
            this.openPullReqData.HeaderText = "Open pull request";
            this.openPullReqData.Name = "openPullReqData";
            this.openPullReqData.ReadOnly = true;
            // 
            // closedPullReqData
            // 
            this.closedPullReqData.HeaderText = "Closed pull request";
            this.closedPullReqData.Name = "closedPullReqData";
            this.closedPullReqData.ReadOnly = true;
            // 
            // dateData
            // 
            this.dateData.HeaderText = "Raport created date";
            this.dateData.Name = "dateData";
            this.dateData.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 482);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.getRaportBtn);
            this.Controls.Add(this.raportBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.viewRepoBox);
            this.Controls.Add(this.viewRepoBtn);
            this.Controls.Add(this.tokenBtn);
            this.Controls.Add(this.pullClosedView);
            this.Controls.Add(this.pullView);
            this.Controls.Add(this.issuesView);
            this.Controls.Add(this.viewDataBtn);
            this.Controls.Add(this.repoBox);
            this.Controls.Add(this.tokenBox);
            this.Controls.Add(this.ownerBox);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox ownerBox;
        private System.Windows.Forms.TextBox tokenBox;
        private System.Windows.Forms.TextBox repoBox;
        private System.Windows.Forms.Button viewDataBtn;
        private System.Windows.Forms.TextBox issuesView;
        private System.Windows.Forms.TextBox pullView;
        private System.Windows.Forms.TextBox pullClosedView;
        private System.Windows.Forms.Button tokenBtn;
        private System.Windows.Forms.Button viewRepoBtn;
        private System.Windows.Forms.TextBox viewRepoBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button raportBtn;
        private System.Windows.Forms.Button getRaportBtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn issuesData;
        private System.Windows.Forms.DataGridViewTextBoxColumn openPullReqData;
        private System.Windows.Forms.DataGridViewTextBoxColumn closedPullReqData;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateData;
    }
}

