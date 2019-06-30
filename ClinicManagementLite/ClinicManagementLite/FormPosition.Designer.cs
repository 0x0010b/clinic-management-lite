namespace ClinicManagementLite
{
    partial class FormPosition
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
            this.btnAction = new System.Windows.Forms.Button();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxArea = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnAction
            // 
            this.btnAction.Location = new System.Drawing.Point(95, 187);
            this.btnAction.Name = "btnAction";
            this.btnAction.Size = new System.Drawing.Size(75, 23);
            this.btnAction.TabIndex = 7;
            this.btnAction.Text = "Accion";
            this.btnAction.UseVisualStyleBackColor = true;
            this.btnAction.Click += new System.EventHandler(this.BtnAction_Click);
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(32, 55);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(202, 20);
            this.txtDescription.TabIndex = 6;
            // 
            // lblDescription
            // 
            this.lblDescription.Location = new System.Drawing.Point(29, 29);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(100, 23);
            this.lblDescription.TabIndex = 5;
            this.lblDescription.Text = "Descripcion:";
            this.lblDescription.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(29, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 8;
            this.label1.Text = "Area:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbxArea
            // 
            this.cbxArea.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbxArea.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxArea.FormattingEnabled = true;
            this.cbxArea.Location = new System.Drawing.Point(32, 132);
            this.cbxArea.Name = "cbxArea";
            this.cbxArea.Size = new System.Drawing.Size(202, 21);
            this.cbxArea.TabIndex = 9;
            // 
            // FormPosition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(266, 237);
            this.Controls.Add(this.cbxArea);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAction);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.lblDescription);
            this.MaximizeBox = false;
            this.Name = "FormPosition";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mantenimiento";
            this.Load += new System.EventHandler(this.FormPosition_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button btnAction;
        public System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxArea;
    }
}