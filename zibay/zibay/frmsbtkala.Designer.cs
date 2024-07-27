
namespace zibay
{
    partial class frmsbtkala
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
            this.txtnamekala = new System.Windows.Forms.TextBox();
            this.txtdatee = new System.Windows.Forms.TextBox();
            this.txtmark = new System.Windows.Forms.TextBox();
            this.txtmony = new System.Windows.Forms.TextBox();
            this.txtcodkala = new System.Windows.Forms.TextBox();
            this.btnsbt = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtnamekala
            // 
            this.txtnamekala.Location = new System.Drawing.Point(13, 13);
            this.txtnamekala.Name = "txtnamekala";
            this.txtnamekala.Size = new System.Drawing.Size(100, 22);
            this.txtnamekala.TabIndex = 0;
            // 
            // txtdatee
            // 
            this.txtdatee.Location = new System.Drawing.Point(13, 53);
            this.txtdatee.Name = "txtdatee";
            this.txtdatee.Size = new System.Drawing.Size(100, 22);
            this.txtdatee.TabIndex = 1;
            // 
            // txtmark
            // 
            this.txtmark.Location = new System.Drawing.Point(13, 96);
            this.txtmark.Name = "txtmark";
            this.txtmark.Size = new System.Drawing.Size(100, 22);
            this.txtmark.TabIndex = 2;
            // 
            // txtmony
            // 
            this.txtmony.Location = new System.Drawing.Point(13, 139);
            this.txtmony.Name = "txtmony";
            this.txtmony.Size = new System.Drawing.Size(100, 22);
            this.txtmony.TabIndex = 3;
            // 
            // txtcodkala
            // 
            this.txtcodkala.Location = new System.Drawing.Point(13, 184);
            this.txtcodkala.Name = "txtcodkala";
            this.txtcodkala.Size = new System.Drawing.Size(100, 22);
            this.txtcodkala.TabIndex = 4;
            // 
            // btnsbt
            // 
            this.btnsbt.Location = new System.Drawing.Point(13, 221);
            this.btnsbt.Name = "btnsbt";
            this.btnsbt.Size = new System.Drawing.Size(183, 50);
            this.btnsbt.TabIndex = 5;
            this.btnsbt.Text = "ثبت";
            this.btnsbt.UseVisualStyleBackColor = true;
            this.btnsbt.Click += new System.EventHandler(this.btnsbt_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(136, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "اسم کالا";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(136, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "تاریخ اعتبار";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(136, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "مارک";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(136, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "قیمت";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(136, 189);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "کد کالا";
            // 
            // frmsbtkala
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(213, 291);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnsbt);
            this.Controls.Add(this.txtcodkala);
            this.Controls.Add(this.txtmony);
            this.Controls.Add(this.txtmark);
            this.Controls.Add(this.txtdatee);
            this.Controls.Add(this.txtnamekala);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmsbtkala";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ثبت کالا";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtnamekala;
        private System.Windows.Forms.TextBox txtdatee;
        private System.Windows.Forms.TextBox txtmark;
        private System.Windows.Forms.TextBox txtmony;
        private System.Windows.Forms.TextBox txtcodkala;
        private System.Windows.Forms.Button btnsbt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}