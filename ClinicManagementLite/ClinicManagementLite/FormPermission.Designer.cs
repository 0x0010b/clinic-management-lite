namespace ClinicManagementLite
{
    partial class FormPermission
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
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.btnAction = new System.Windows.Forms.Button();
            this.gbPermission = new System.Windows.Forms.GroupBox();
            this.cbxWrite = new System.Windows.Forms.CheckBox();
            this.cbxRead = new System.Windows.Forms.CheckBox();
            this.gbPermission.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDescription
            // 
            this.lblDescription.Location = new System.Drawing.Point(28, 32);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(100, 23);
            this.lblDescription.TabIndex = 0;
            this.lblDescription.Text = "Descripcion:";
            this.lblDescription.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(31, 58);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(202, 20);
            this.txtDescription.TabIndex = 1;
            // 
            // btnAction
            // 
            this.btnAction.Location = new System.Drawing.Point(97, 255);
            this.btnAction.Name = "btnAction";
            this.btnAction.Size = new System.Drawing.Size(75, 23);
            this.btnAction.TabIndex = 2;
            this.btnAction.Text = "Accion";
            this.btnAction.UseVisualStyleBackColor = true;
            this.btnAction.Click += new System.EventHandler(this.BtnAction_Click);
            // 
            // gbPermission
            // 
            this.gbPermission.Controls.Add(this.cbxWrite);
            this.gbPermission.Controls.Add(this.cbxRead);
            this.gbPermission.Location = new System.Drawing.Point(31, 112);
            this.gbPermission.Name = "gbPermission";
            this.gbPermission.Size = new System.Drawing.Size(202, 100);
            this.gbPermission.TabIndex = 3;
            this.gbPermission.TabStop = false;
            this.gbPermission.Text = "Permisos:";
            // 
            // cbxWrite
            // 
            this.cbxWrite.AutoSize = true;
            this.cbxWrite.Location = new System.Drawing.Point(112, 48);
            this.cbxWrite.Name = "cbxWrite";
            this.cbxWrite.Size = new System.Drawing.Size(67, 17);
            this.cbxWrite.TabIndex = 1;
            this.cbxWrite.Text = "Escritura";
            this.cbxWrite.UseVisualStyleBackColor = true;
            // 
            // cbxRead
            // 
            this.cbxRead.AutoSize = true;
            this.cbxRead.Location = new System.Drawing.Point(26, 48);
            this.cbxRead.Name = "cbxRead";
            this.cbxRead.Size = new System.Drawing.Size(62, 17);
            this.cbxRead.TabIndex = 0;
            this.cbxRead.Text = "Lectura";
            this.cbxRead.UseVisualStyleBackColor = true;
            // 
            // FormPermission
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(266, 320);
            this.Controls.Add(this.gbPermission);
            this.Controls.Add(this.btnAction);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.lblDescription);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormPermission";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mantenimiento";
            this.Load += new System.EventHandler(this.FormMaintenance01_Load);
            this.gbPermission.ResumeLayout(false);
            this.gbPermission.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.TextBox txtDescription;
        public System.Windows.Forms.Button btnAction;
        public System.Windows.Forms.GroupBox gbPermission;
        public System.Windows.Forms.CheckBox cbxWrite;
        public System.Windows.Forms.CheckBox cbxRead;
        private System.Windows.Forms.Label lblDescription;
    }
}