
namespace zibay
{
    partial class frmprice
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtserch = new System.Windows.Forms.TextBox();
            this.grdlist = new System.Windows.Forms.DataGridView();
            this.btnsbt = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdlist)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(406, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "جستجو";
            // 
            // txtserch
            // 
            this.txtserch.Location = new System.Drawing.Point(12, 8);
            this.txtserch.Name = "txtserch";
            this.txtserch.Size = new System.Drawing.Size(387, 22);
            this.txtserch.TabIndex = 5;
            this.txtserch.TextChanged += new System.EventHandler(this.txtserch_TextChanged);
            // 
            // grdlist
            // 
            this.grdlist.AllowUserToAddRows = false;
            this.grdlist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdlist.Location = new System.Drawing.Point(12, 36);
            this.grdlist.Name = "grdlist";
            this.grdlist.RowHeadersWidth = 51;
            this.grdlist.RowTemplate.Height = 24;
            this.grdlist.Size = new System.Drawing.Size(466, 352);
            this.grdlist.TabIndex = 4;
            // 
            // btnsbt
            // 
            this.btnsbt.Location = new System.Drawing.Point(12, 394);
            this.btnsbt.Name = "btnsbt";
            this.btnsbt.Size = new System.Drawing.Size(466, 45);
            this.btnsbt.TabIndex = 7;
            this.btnsbt.Text = "ثبت";
            this.btnsbt.UseVisualStyleBackColor = true;
            this.btnsbt.Click += new System.EventHandler(this.btnsbt_Click);
            // 
            // frmprice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 443);
            this.Controls.Add(this.btnsbt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtserch);
            this.Controls.Add(this.grdlist);
            this.Name = "frmprice";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "فروش";
            this.Load += new System.EventHandler(this.frmprice_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdlist)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtserch;
        private System.Windows.Forms.DataGridView grdlist;
        private System.Windows.Forms.Button btnsbt;
    }
}