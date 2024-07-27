
namespace zibay
{
    partial class frmcustomer
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
            this.btnsbtcustomer = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtserch = new System.Windows.Forms.TextBox();
            this.grdlist = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.family = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grdlist)).BeginInit();
            this.SuspendLayout();
            // 
            // btnsbtcustomer
            // 
            this.btnsbtcustomer.Location = new System.Drawing.Point(12, 12);
            this.btnsbtcustomer.Name = "btnsbtcustomer";
            this.btnsbtcustomer.Size = new System.Drawing.Size(615, 88);
            this.btnsbtcustomer.TabIndex = 7;
            this.btnsbtcustomer.Text = "ثبت مشتری";
            this.btnsbtcustomer.UseVisualStyleBackColor = true;
            this.btnsbtcustomer.Click += new System.EventHandler(this.btnsbtcustomer_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(573, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "جستجو";
            // 
            // txtserch
            // 
            this.txtserch.Location = new System.Drawing.Point(12, 106);
            this.txtserch.Name = "txtserch";
            this.txtserch.Size = new System.Drawing.Size(536, 22);
            this.txtserch.TabIndex = 5;
            this.txtserch.TextChanged += new System.EventHandler(this.txtserch_TextChanged);
            // 
            // grdlist
            // 
            this.grdlist.AllowUserToAddRows = false;
            this.grdlist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdlist.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.name,
            this.family,
            this.fhone});
            this.grdlist.Location = new System.Drawing.Point(12, 134);
            this.grdlist.Name = "grdlist";
            this.grdlist.RowHeadersWidth = 51;
            this.grdlist.RowTemplate.Height = 24;
            this.grdlist.Size = new System.Drawing.Size(615, 304);
            this.grdlist.TabIndex = 4;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ایدی";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.Width = 60;
            // 
            // name
            // 
            this.name.DataPropertyName = "name";
            this.name.HeaderText = "نام";
            this.name.MinimumWidth = 6;
            this.name.Name = "name";
            this.name.Width = 70;
            // 
            // family
            // 
            this.family.DataPropertyName = "family";
            this.family.HeaderText = "نام خانوادگی";
            this.family.MinimumWidth = 6;
            this.family.Name = "family";
            this.family.Width = 90;
            // 
            // fhone
            // 
            this.fhone.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.fhone.DataPropertyName = "fhone";
            this.fhone.HeaderText = "تلفن";
            this.fhone.MinimumWidth = 6;
            this.fhone.Name = "fhone";
            // 
            // frmcustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 450);
            this.Controls.Add(this.btnsbtcustomer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtserch);
            this.Controls.Add(this.grdlist);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmcustomer";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "مشتری";
            this.Load += new System.EventHandler(this.frmcustomer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdlist)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnsbtcustomer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtserch;
        private System.Windows.Forms.DataGridView grdlist;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn family;
        private System.Windows.Forms.DataGridViewTextBoxColumn fhone;
    }
}