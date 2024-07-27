
namespace zibay
{
    partial class frm1
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
            this.btnkala = new System.Windows.Forms.Button();
            this.btncustomer = new System.Windows.Forms.Button();
            this.btnfactor = new System.Windows.Forms.Button();
            this.btnsbtkharid = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnkala
            // 
            this.btnkala.Location = new System.Drawing.Point(27, 65);
            this.btnkala.Name = "btnkala";
            this.btnkala.Size = new System.Drawing.Size(75, 343);
            this.btnkala.TabIndex = 0;
            this.btnkala.Text = "کالاها";
            this.btnkala.UseVisualStyleBackColor = true;
            this.btnkala.Click += new System.EventHandler(this.btnkala_Click);
            // 
            // btncustomer
            // 
            this.btncustomer.Location = new System.Drawing.Point(119, 122);
            this.btncustomer.Name = "btncustomer";
            this.btncustomer.Size = new System.Drawing.Size(75, 231);
            this.btncustomer.TabIndex = 1;
            this.btncustomer.Text = "مشتری";
            this.btncustomer.UseVisualStyleBackColor = true;
            this.btncustomer.Click += new System.EventHandler(this.btncustomer_Click);
            // 
            // btnfactor
            // 
            this.btnfactor.Location = new System.Drawing.Point(212, 169);
            this.btnfactor.Name = "btnfactor";
            this.btnfactor.Size = new System.Drawing.Size(75, 133);
            this.btnfactor.TabIndex = 2;
            this.btnfactor.Text = "فاکتور";
            this.btnfactor.UseVisualStyleBackColor = true;
            this.btnfactor.Click += new System.EventHandler(this.btnfactor_Click);
            // 
            // btnsbtkharid
            // 
            this.btnsbtkharid.Location = new System.Drawing.Point(27, 12);
            this.btnsbtkharid.Name = "btnsbtkharid";
            this.btnsbtkharid.Size = new System.Drawing.Size(260, 36);
            this.btnsbtkharid.TabIndex = 3;
            this.btnsbtkharid.Text = "ثبت خرید";
            this.btnsbtkharid.UseVisualStyleBackColor = true;
            this.btnsbtkharid.Click += new System.EventHandler(this.btnsbtkharid_Click);
            // 
            // frm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 427);
            this.Controls.Add(this.btnsbtkharid);
            this.Controls.Add(this.btnfactor);
            this.Controls.Add(this.btncustomer);
            this.Controls.Add(this.btnkala);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "الوازم ارایشی";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnkala;
        private System.Windows.Forms.Button btncustomer;
        private System.Windows.Forms.Button btnfactor;
        private System.Windows.Forms.Button btnsbtkharid;
    }
}

