
namespace Krystyna
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
            this.NumUp = new System.Windows.Forms.NumericUpDown();
            this.decCbx = new System.Windows.Forms.CheckBox();
            this.healtCbx = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.NumUp)).BeginInit();
            this.SuspendLayout();
            // 
            // NumUp
            // 
            this.NumUp.Location = new System.Drawing.Point(15, 26);
            this.NumUp.Name = "NumUp";
            this.NumUp.Size = new System.Drawing.Size(120, 20);
            this.NumUp.TabIndex = 0;
            this.NumUp.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.NumUp.ValueChanged += new System.EventHandler(this.NumUp_ValueChanged);
            // 
            // decCbx
            // 
            this.decCbx.AutoSize = true;
            this.decCbx.Checked = true;
            this.decCbx.CheckState = System.Windows.Forms.CheckState.Checked;
            this.decCbx.Location = new System.Drawing.Point(15, 52);
            this.decCbx.Name = "decCbx";
            this.decCbx.Size = new System.Drawing.Size(126, 17);
            this.decCbx.TabIndex = 1;
            this.decCbx.Text = "Dekoracje fantazyjne";
            this.decCbx.UseVisualStyleBackColor = true;
            this.decCbx.CheckedChanged += new System.EventHandler(this.decCbx_CheckedChanged);
            // 
            // healtCbx
            // 
            this.healtCbx.AutoSize = true;
            this.healtCbx.Location = new System.Drawing.Point(15, 75);
            this.healtCbx.Name = "healtCbx";
            this.healtCbx.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.healtCbx.Size = new System.Drawing.Size(91, 17);
            this.healtCbx.TabIndex = 2;
            this.healtCbx.Text = "Opcja zdrowa";
            this.healtCbx.UseVisualStyleBackColor = true;
            this.healtCbx.CheckedChanged += new System.EventHandler(this.healtCbx_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ilość osób:";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label2.Location = new System.Drawing.Point(15, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "label2";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(155, 171);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.healtCbx);
            this.Controls.Add(this.decCbx);
            this.Controls.Add(this.NumUp);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Planista przyjęć";
            ((System.ComponentModel.ISupportInitialize)(this.NumUp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown NumUp;
        private System.Windows.Forms.CheckBox decCbx;
        private System.Windows.Forms.CheckBox healtCbx;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

