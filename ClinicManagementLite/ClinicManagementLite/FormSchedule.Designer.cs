namespace ClinicManagementLite
{
    partial class FormSchedule
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
            this.cbxEmployee = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAction = new System.Windows.Forms.Button();
            this.cbxTurn = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbxEmployee
            // 
            this.cbxEmployee.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cbxEmployee.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxEmployee.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxEmployee.FormattingEnabled = true;
            this.cbxEmployee.Location = new System.Drawing.Point(33, 58);
            this.cbxEmployee.Name = "cbxEmployee";
            this.cbxEmployee.Size = new System.Drawing.Size(202, 21);
            this.cbxEmployee.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(30, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Empleado:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnAction
            // 
            this.btnAction.Location = new System.Drawing.Point(94, 179);
            this.btnAction.Name = "btnAction";
            this.btnAction.Size = new System.Drawing.Size(75, 23);
            this.btnAction.TabIndex = 5;
            this.btnAction.Text = "Asignar";
            this.btnAction.UseVisualStyleBackColor = true;
            this.btnAction.Click += new System.EventHandler(this.BtnAction_Click);
            // 
            // cbxTurn
            // 
            this.cbxTurn.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cbxTurn.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxTurn.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTurn.FormattingEnabled = true;
            this.cbxTurn.Location = new System.Drawing.Point(33, 129);
            this.cbxTurn.Name = "cbxTurn";
            this.cbxTurn.Size = new System.Drawing.Size(202, 21);
            this.cbxTurn.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(30, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Turno:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FormSchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(266, 228);
            this.Controls.Add(this.cbxTurn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbxEmployee);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAction);
            this.MaximizeBox = false;
            this.Name = "FormSchedule";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Asignar Horario";
            this.Load += new System.EventHandler(this.FormSchedule_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxEmployee;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button btnAction;
        private System.Windows.Forms.ComboBox cbxTurn;
        private System.Windows.Forms.Label label2;
    }
}