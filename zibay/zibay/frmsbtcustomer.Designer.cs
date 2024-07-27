
namespace zibay
{
    partial class frmsbtcustomer
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnsbt = new System.Windows.Forms.Button();
            this.txtfhone = new System.Windows.Forms.TextBox();
            this.txtfamil = new System.Windows.Forms.TextBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(135, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 17);
            this.label3.TabIndex = 15;
            this.label3.Text = "تلفن";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(135, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "نام خانوادگی";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(135, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "نام";
            // 
            // btnsbt
            // 
            this.btnsbt.Location = new System.Drawing.Point(12, 137);
            this.btnsbt.Name = "btnsbt";
            this.btnsbt.Size = new System.Drawing.Size(183, 50);
            this.btnsbt.TabIndex = 12;
            this.btnsbt.Text = "ثبت";
            this.btnsbt.UseVisualStyleBackColor = true;
            this.btnsbt.Click += new System.EventHandler(this.btnsbt_Click);
            // 
            // txtfhone
            // 
            this.txtfhone.Location = new System.Drawing.Point(12, 95);
            this.txtfhone.Name = "txtfhone";
            this.txtfhone.Size = new System.Drawing.Size(100, 22);
            this.txtfhone.TabIndex = 11;
            // 
            // txtfamil
            // 
            this.txtfamil.Location = new System.Drawing.Point(12, 52);
            this.txtfamil.Name = "txtfamil";
            this.txtfamil.Size = new System.Drawing.Size(100, 22);
            this.txtfamil.TabIndex = 10;
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(12, 12);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(100, 22);
            this.txtname.TabIndex = 9;
            // 
            // frmsbtcustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(217, 205);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnsbt);
            this.Controls.Add(this.txtfhone);
            this.Controls.Add(this.txtfamil);
            this.Controls.Add(this.txtname);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmsbtcustomer";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ثبت مشتری";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnsbt;
        private System.Windows.Forms.TextBox txtfhone;
        private System.Windows.Forms.TextBox txtfamil;
        private System.Windows.Forms.TextBox txtname;
    }
}