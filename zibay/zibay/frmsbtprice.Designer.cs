
namespace zibay
{
    partial class frmsbtprice
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
            this.grdlistkala = new System.Windows.Forms.DataGridView();
            this.grdlistcustomer = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnsbt = new System.Windows.Forms.Button();
            this.txtidcustomer = new System.Windows.Forms.TextBox();
            this.txtdate = new System.Windows.Forms.TextBox();
            this.txtidkala = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.family = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.code_kala = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name_kala = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date_e = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mony = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grdlistkala)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdlistcustomer)).BeginInit();
            this.SuspendLayout();
            // 
            // grdlistkala
            // 
            this.grdlistkala.AllowUserToAddRows = false;
            this.grdlistkala.AllowUserToDeleteRows = false;
            this.grdlistkala.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdlistkala.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.code_kala,
            this.num,
            this.name_kala,
            this.date_e,
            this.mark,
            this.mony});
            this.grdlistkala.Location = new System.Drawing.Point(12, 42);
            this.grdlistkala.Name = "grdlistkala";
            this.grdlistkala.ReadOnly = true;
            this.grdlistkala.RowHeadersWidth = 51;
            this.grdlistkala.RowTemplate.Height = 24;
            this.grdlistkala.Size = new System.Drawing.Size(457, 180);
            this.grdlistkala.TabIndex = 0;
            // 
            // grdlistcustomer
            // 
            this.grdlistcustomer.AllowUserToAddRows = false;
            this.grdlistcustomer.AllowUserToDeleteRows = false;
            this.grdlistcustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdlistcustomer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.name,
            this.family,
            this.fhone});
            this.grdlistcustomer.Location = new System.Drawing.Point(523, 42);
            this.grdlistcustomer.Name = "grdlistcustomer";
            this.grdlistcustomer.ReadOnly = true;
            this.grdlistcustomer.RowHeadersWidth = 51;
            this.grdlistcustomer.RowTemplate.Height = 24;
            this.grdlistcustomer.Size = new System.Drawing.Size(279, 180);
            this.grdlistcustomer.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(414, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "جدول کالا";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(732, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "جدول مشتری";
            // 
            // btnsbt
            // 
            this.btnsbt.Location = new System.Drawing.Point(12, 229);
            this.btnsbt.Name = "btnsbt";
            this.btnsbt.Size = new System.Drawing.Size(192, 75);
            this.btnsbt.TabIndex = 4;
            this.btnsbt.Text = "ثبت";
            this.btnsbt.UseVisualStyleBackColor = true;
            this.btnsbt.Click += new System.EventHandler(this.btnsbt_Click);
            // 
            // txtidcustomer
            // 
            this.txtidcustomer.Location = new System.Drawing.Point(224, 229);
            this.txtidcustomer.Name = "txtidcustomer";
            this.txtidcustomer.Size = new System.Drawing.Size(100, 22);
            this.txtidcustomer.TabIndex = 5;
            // 
            // txtdate
            // 
            this.txtdate.Location = new System.Drawing.Point(574, 282);
            this.txtdate.Name = "txtdate";
            this.txtdate.Size = new System.Drawing.Size(100, 22);
            this.txtdate.TabIndex = 6;
            // 
            // txtidkala
            // 
            this.txtidkala.Location = new System.Drawing.Point(386, 258);
            this.txtidkala.Name = "txtidkala";
            this.txtidkala.Size = new System.Drawing.Size(100, 22);
            this.txtidkala.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(692, 286);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "تاریخ فروش";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(493, 262);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "ایدی کالا";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(331, 229);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "ایدی مشتری";
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 50;
            // 
            // name
            // 
            this.name.DataPropertyName = "name";
            this.name.HeaderText = "نام";
            this.name.MinimumWidth = 6;
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.Width = 60;
            // 
            // family
            // 
            this.family.DataPropertyName = "family";
            this.family.HeaderText = "نام خانوادگی";
            this.family.MinimumWidth = 6;
            this.family.Name = "family";
            this.family.ReadOnly = true;
            this.family.Width = 60;
            // 
            // fhone
            // 
            this.fhone.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.fhone.DataPropertyName = "fhone";
            this.fhone.HeaderText = "تلفن";
            this.fhone.MinimumWidth = 6;
            this.fhone.Name = "fhone";
            this.fhone.ReadOnly = true;
            // 
            // code_kala
            // 
            this.code_kala.DataPropertyName = "code_kala";
            this.code_kala.HeaderText = "کد کالا";
            this.code_kala.MinimumWidth = 6;
            this.code_kala.Name = "code_kala";
            this.code_kala.ReadOnly = true;
            this.code_kala.Width = 50;
            // 
            // num
            // 
            this.num.DataPropertyName = "ID";
            this.num.HeaderText = "ایدی";
            this.num.MinimumWidth = 6;
            this.num.Name = "num";
            this.num.ReadOnly = true;
            this.num.Width = 50;
            // 
            // name_kala
            // 
            this.name_kala.DataPropertyName = "name_kala";
            this.name_kala.HeaderText = "اسم کالا";
            this.name_kala.MinimumWidth = 6;
            this.name_kala.Name = "name_kala";
            this.name_kala.ReadOnly = true;
            this.name_kala.Width = 60;
            // 
            // date_e
            // 
            this.date_e.DataPropertyName = "date_e";
            this.date_e.HeaderText = "تاریخ اعتبار";
            this.date_e.MinimumWidth = 6;
            this.date_e.Name = "date_e";
            this.date_e.ReadOnly = true;
            this.date_e.Width = 80;
            // 
            // mark
            // 
            this.mark.DataPropertyName = "mark";
            this.mark.HeaderText = "مارک";
            this.mark.MinimumWidth = 6;
            this.mark.Name = "mark";
            this.mark.ReadOnly = true;
            this.mark.Width = 60;
            // 
            // mony
            // 
            this.mony.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.mony.DataPropertyName = "mony";
            this.mony.HeaderText = "قیمت";
            this.mony.MinimumWidth = 6;
            this.mony.Name = "mony";
            this.mony.ReadOnly = true;
            // 
            // frmsbtprice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 310);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtidkala);
            this.Controls.Add(this.txtdate);
            this.Controls.Add(this.txtidcustomer);
            this.Controls.Add(this.btnsbt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grdlistcustomer);
            this.Controls.Add(this.grdlistkala);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmsbtprice";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ثبت فروش";
            this.Load += new System.EventHandler(this.frmsbtprice_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdlistkala)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdlistcustomer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grdlistkala;
        private System.Windows.Forms.DataGridView grdlistcustomer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnsbt;
        private System.Windows.Forms.TextBox txtidcustomer;
        private System.Windows.Forms.TextBox txtdate;
        private System.Windows.Forms.TextBox txtidkala;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn family;
        private System.Windows.Forms.DataGridViewTextBoxColumn fhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn code_kala;
        private System.Windows.Forms.DataGridViewTextBoxColumn num;
        private System.Windows.Forms.DataGridViewTextBoxColumn name_kala;
        private System.Windows.Forms.DataGridViewTextBoxColumn date_e;
        private System.Windows.Forms.DataGridViewTextBoxColumn mark;
        private System.Windows.Forms.DataGridViewTextBoxColumn mony;
    }
}