
namespace zibay
{
    partial class frmkala
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
            this.grdlist = new System.Windows.Forms.DataGridView();
            this.txtserch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnsbtkala = new System.Windows.Forms.Button();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.code_kala = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name_kala = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date_e = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mony = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grdlist)).BeginInit();
            this.SuspendLayout();
            // 
            // grdlist
            // 
            this.grdlist.AllowUserToAddRows = false;
            this.grdlist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdlist.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.code_kala,
            this.name_kala,
            this.date_e,
            this.mark,
            this.mony});
            this.grdlist.Location = new System.Drawing.Point(13, 134);
            this.grdlist.Name = "grdlist";
            this.grdlist.RowHeadersWidth = 51;
            this.grdlist.RowTemplate.Height = 24;
            this.grdlist.Size = new System.Drawing.Size(639, 304);
            this.grdlist.TabIndex = 0;
            // 
            // txtserch
            // 
            this.txtserch.Location = new System.Drawing.Point(13, 106);
            this.txtserch.Name = "txtserch";
            this.txtserch.Size = new System.Drawing.Size(557, 22);
            this.txtserch.TabIndex = 1;
            this.txtserch.TextChanged += new System.EventHandler(this.txtserch_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(595, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "جستجو";
            // 
            // btnsbtkala
            // 
            this.btnsbtkala.Location = new System.Drawing.Point(13, 12);
            this.btnsbtkala.Name = "btnsbtkala";
            this.btnsbtkala.Size = new System.Drawing.Size(639, 88);
            this.btnsbtkala.TabIndex = 3;
            this.btnsbtkala.Text = "ثبت کالا";
            this.btnsbtkala.UseVisualStyleBackColor = true;
            this.btnsbtkala.Click += new System.EventHandler(this.btnsbtkala_Click);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ایدی";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.Width = 60;
            // 
            // code_kala
            // 
            this.code_kala.DataPropertyName = "code_kala";
            this.code_kala.HeaderText = "کد کالا";
            this.code_kala.MinimumWidth = 6;
            this.code_kala.Name = "code_kala";
            this.code_kala.Width = 60;
            // 
            // name_kala
            // 
            this.name_kala.DataPropertyName = "name_kala";
            this.name_kala.HeaderText = "اسم کالا";
            this.name_kala.MinimumWidth = 6;
            this.name_kala.Name = "name_kala";
            this.name_kala.Width = 70;
            // 
            // date_e
            // 
            this.date_e.DataPropertyName = "date_e";
            this.date_e.HeaderText = "تاریخ اعتبار";
            this.date_e.MinimumWidth = 6;
            this.date_e.Name = "date_e";
            // 
            // mark
            // 
            this.mark.DataPropertyName = "mark";
            this.mark.HeaderText = "مارک";
            this.mark.MinimumWidth = 6;
            this.mark.Name = "mark";
            this.mark.Width = 70;
            // 
            // mony
            // 
            this.mony.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.mony.DataPropertyName = "mony";
            this.mony.HeaderText = "قیمت";
            this.mony.MinimumWidth = 6;
            this.mony.Name = "mony";
            // 
            // frmkala
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 450);
            this.Controls.Add(this.btnsbtkala);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtserch);
            this.Controls.Add(this.grdlist);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmkala";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "کالا";
            this.Load += new System.EventHandler(this.frmkala_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdlist)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grdlist;
        private System.Windows.Forms.TextBox txtserch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnsbtkala;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn code_kala;
        private System.Windows.Forms.DataGridViewTextBoxColumn name_kala;
        private System.Windows.Forms.DataGridViewTextBoxColumn date_e;
        private System.Windows.Forms.DataGridViewTextBoxColumn mark;
        private System.Windows.Forms.DataGridViewTextBoxColumn mony;
    }
}