namespace ClinicManagementLite.Windows.Views
{
    partial class frmPersonList
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
            this.btnSeeDetail = new System.Windows.Forms.Button();
            this.cbxFilter = new System.Windows.Forms.ComboBox();
            this.btnFilter = new System.Windows.Forms.Button();
            this.dtgPersonList = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtgPersonList)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSeeDetail
            // 
            this.btnSeeDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeeDetail.ForeColor = System.Drawing.Color.Black;
            this.btnSeeDetail.Location = new System.Drawing.Point(635, 12);
            this.btnSeeDetail.Margin = new System.Windows.Forms.Padding(3, 3, 3, 40);
            this.btnSeeDetail.Name = "btnSeeDetail";
            this.btnSeeDetail.Padding = new System.Windows.Forms.Padding(24, 6, 24, 6);
            this.btnSeeDetail.Size = new System.Drawing.Size(153, 43);
            this.btnSeeDetail.TabIndex = 6;
            this.btnSeeDetail.Text = "Ver detalle";
            this.btnSeeDetail.UseVisualStyleBackColor = true;
            this.btnSeeDetail.Click += new System.EventHandler(this.btnSeeDetail_Click);
            // 
            // cbxFilter
            // 
            this.cbxFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxFilter.FormattingEnabled = true;
            this.cbxFilter.ItemHeight = 16;
            this.cbxFilter.Location = new System.Drawing.Point(635, 66);
            this.cbxFilter.Name = "cbxFilter";
            this.cbxFilter.Size = new System.Drawing.Size(153, 24);
            this.cbxFilter.TabIndex = 7;
            // 
            // btnFilter
            // 
            this.btnFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFilter.ForeColor = System.Drawing.Color.Black;
            this.btnFilter.Location = new System.Drawing.Point(635, 102);
            this.btnFilter.Margin = new System.Windows.Forms.Padding(3, 3, 3, 40);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Padding = new System.Windows.Forms.Padding(24, 6, 24, 6);
            this.btnFilter.Size = new System.Drawing.Size(153, 43);
            this.btnFilter.TabIndex = 6;
            this.btnFilter.Text = "Filtrar";
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // dtgPersonList
            // 
            this.dtgPersonList.AllowUserToAddRows = false;
            this.dtgPersonList.AllowUserToDeleteRows = false;
            this.dtgPersonList.AllowUserToResizeColumns = false;
            this.dtgPersonList.AllowUserToResizeRows = false;
            this.dtgPersonList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgPersonList.Location = new System.Drawing.Point(12, 12);
            this.dtgPersonList.MultiSelect = false;
            this.dtgPersonList.Name = "dtgPersonList";
            this.dtgPersonList.ReadOnly = true;
            this.dtgPersonList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dtgPersonList.Size = new System.Drawing.Size(607, 330);
            this.dtgPersonList.TabIndex = 8;
            // 
            // frmPersonList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(800, 354);
            this.Controls.Add(this.dtgPersonList);
            this.Controls.Add(this.cbxFilter);
            this.Controls.Add(this.btnFilter);
            this.Controls.Add(this.btnSeeDetail);
            this.Name = "frmPersonList";
            this.Text = "frmPersonDetail";
            this.Load += new System.EventHandler(this.frmPersonList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgPersonList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnSeeDetail;
        private System.Windows.Forms.ComboBox cbxFilter;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.DataGridView dtgPersonList;
    }
}