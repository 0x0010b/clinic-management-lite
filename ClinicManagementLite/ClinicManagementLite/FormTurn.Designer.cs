namespace ClinicManagementLite
{
    partial class FormTurn
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
            this.cbxDay = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAction = new System.Windows.Forms.Button();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.label0 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pickerDepartureHour = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pickerEntryHour = new System.Windows.Forms.DateTimePicker();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbxDay
            // 
            this.cbxDay.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cbxDay.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxDay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxDay.FormattingEnabled = true;
            this.cbxDay.Items.AddRange(new object[] {
            "DOMINGO",
            "LUNES",
            "MARTES",
            "MIERCOLES",
            "JUEVES",
            "VIERNES",
            "SABADO"});
            this.cbxDay.Location = new System.Drawing.Point(29, 121);
            this.cbxDay.Name = "cbxDay";
            this.cbxDay.Size = new System.Drawing.Size(202, 21);
            this.cbxDay.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(26, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Dia:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnAction
            // 
            this.btnAction.Location = new System.Drawing.Point(95, 284);
            this.btnAction.Name = "btnAction";
            this.btnAction.Size = new System.Drawing.Size(75, 23);
            this.btnAction.TabIndex = 6;
            this.btnAction.Text = "Accion";
            this.btnAction.UseVisualStyleBackColor = true;
            this.btnAction.Click += new System.EventHandler(this.BtnAction_Click);
            // 
            // txtDescription
            // 
            this.txtDescription.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDescription.Location = new System.Drawing.Point(29, 51);
            this.txtDescription.MaxLength = 40;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.ShortcutsEnabled = false;
            this.txtDescription.Size = new System.Drawing.Size(202, 20);
            this.txtDescription.TabIndex = 2;
            this.txtDescription.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextField_OnlyTextNumber);
            // 
            // label0
            // 
            this.label0.Location = new System.Drawing.Point(26, 25);
            this.label0.Name = "label0";
            this.label0.Size = new System.Drawing.Size(100, 23);
            this.label0.TabIndex = 1;
            this.label0.Text = "Descripcion:";
            this.label0.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pickerDepartureHour);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.pickerEntryHour);
            this.groupBox1.Location = new System.Drawing.Point(29, 165);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(202, 94);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hora:";
            // 
            // pickerDepartureHour
            // 
            this.pickerDepartureHour.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.pickerDepartureHour.Location = new System.Drawing.Point(66, 56);
            this.pickerDepartureHour.Name = "pickerDepartureHour";
            this.pickerDepartureHour.ShowUpDown = true;
            this.pickerDepartureHour.Size = new System.Drawing.Size(120, 20);
            this.pickerDepartureHour.TabIndex = 4;
            this.pickerDepartureHour.Value = new System.DateTime(2019, 6, 30, 0, 0, 0, 0);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Salida:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Entrada:";
            // 
            // pickerEntryHour
            // 
            this.pickerEntryHour.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.pickerEntryHour.Location = new System.Drawing.Point(66, 30);
            this.pickerEntryHour.Name = "pickerEntryHour";
            this.pickerEntryHour.ShowUpDown = true;
            this.pickerEntryHour.Size = new System.Drawing.Size(120, 20);
            this.pickerEntryHour.TabIndex = 2;
            this.pickerEntryHour.Value = new System.DateTime(2019, 6, 30, 0, 0, 0, 0);
            // 
            // FormTurn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(266, 330);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cbxDay);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAction);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.label0);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormTurn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mantenimiento";
            this.Load += new System.EventHandler(this.FormTurn_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxDay;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button btnAction;
        public System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label label0;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker pickerEntryHour;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker pickerDepartureHour;
    }
}