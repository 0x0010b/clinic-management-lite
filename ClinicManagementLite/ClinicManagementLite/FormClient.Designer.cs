namespace ClinicManagementLite
{
    partial class FormClient
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAction = new System.Windows.Forms.Button();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.pickerDateTime = new System.Windows.Forms.DateTimePicker();
            this.btnUploadImage = new System.Windows.Forms.Button();
            this.imgPerson = new System.Windows.Forms.PictureBox();
            this.cbxGender = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtPathologies = new System.Windows.Forms.TextBox();
            this.txtDiabetes = new System.Windows.Forms.TextBox();
            this.txtSeizures = new System.Windows.Forms.TextBox();
            this.txtAids = new System.Windows.Forms.TextBox();
            this.txtCancer = new System.Windows.Forms.TextBox();
            this.txtMedicines = new System.Windows.Forms.TextBox();
            this.txtAllergies = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtBloodPressure = new System.Windows.Forms.TextBox();
            this.txtBloodType = new System.Windows.Forms.TextBox();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.txtWheight = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgPerson)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.btnAction);
            this.groupBox1.Controls.Add(this.txtLastName);
            this.groupBox1.Controls.Add(this.pickerDateTime);
            this.groupBox1.Controls.Add(this.btnUploadImage);
            this.groupBox1.Controls.Add(this.imgPerson);
            this.groupBox1.Controls.Add(this.cbxGender);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtAddress);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtPhone);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtDni);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(490, 334);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informacion personal:";
            // 
            // btnAction
            // 
            this.btnAction.Location = new System.Drawing.Point(20, 275);
            this.btnAction.Name = "btnAction";
            this.btnAction.Size = new System.Drawing.Size(178, 23);
            this.btnAction.TabIndex = 16;
            this.btnAction.Text = "Action";
            this.btnAction.UseVisualStyleBackColor = true;
            this.btnAction.Click += new System.EventHandler(this.BtnAction_Click);
            // 
            // txtLastName
            // 
            this.txtLastName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtLastName.Location = new System.Drawing.Point(222, 166);
            this.txtLastName.MaxLength = 40;
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.ShortcutsEnabled = false;
            this.txtLastName.Size = new System.Drawing.Size(247, 20);
            this.txtLastName.TabIndex = 3;
            this.txtLastName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextField_OnlyText);
            // 
            // pickerDateTime
            // 
            this.pickerDateTime.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.pickerDateTime.Location = new System.Drawing.Point(354, 221);
            this.pickerDateTime.Name = "pickerDateTime";
            this.pickerDateTime.Size = new System.Drawing.Size(115, 20);
            this.pickerDateTime.TabIndex = 5;
            this.pickerDateTime.Value = new System.DateTime(2019, 6, 30, 4, 46, 34, 0);
            // 
            // btnUploadImage
            // 
            this.btnUploadImage.Enabled = false;
            this.btnUploadImage.Location = new System.Drawing.Point(20, 218);
            this.btnUploadImage.Name = "btnUploadImage";
            this.btnUploadImage.Size = new System.Drawing.Size(178, 23);
            this.btnUploadImage.TabIndex = 10;
            this.btnUploadImage.Text = "Cargar imagen";
            this.btnUploadImage.UseVisualStyleBackColor = true;
            // 
            // imgPerson
            // 
            this.imgPerson.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imgPerson.Location = new System.Drawing.Point(20, 31);
            this.imgPerson.Name = "imgPerson";
            this.imgPerson.Size = new System.Drawing.Size(178, 164);
            this.imgPerson.TabIndex = 15;
            this.imgPerson.TabStop = false;
            // 
            // cbxGender
            // 
            this.cbxGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxGender.FormattingEnabled = true;
            this.cbxGender.Items.AddRange(new object[] {
            "MASCULINO",
            "FEMENINO"});
            this.cbxGender.Location = new System.Drawing.Point(354, 50);
            this.cbxGender.Name = "cbxGender";
            this.cbxGender.Size = new System.Drawing.Size(115, 21);
            this.cbxGender.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(351, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Genero:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(222, 258);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Direccion:";
            // 
            // txtAddress
            // 
            this.txtAddress.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtAddress.Location = new System.Drawing.Point(222, 277);
            this.txtAddress.MaxLength = 80;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.ShortcutsEnabled = false;
            this.txtAddress.Size = new System.Drawing.Size(247, 20);
            this.txtAddress.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(351, 202);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Fecha de nacimiento:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(222, 202);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Celular:";
            // 
            // txtPhone
            // 
            this.txtPhone.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPhone.Location = new System.Drawing.Point(222, 221);
            this.txtPhone.MaxLength = 9;
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.ShortcutsEnabled = false;
            this.txtPhone.Size = new System.Drawing.Size(111, 20);
            this.txtPhone.TabIndex = 4;
            this.txtPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextField_OnlyNumber);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(222, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Apellidos:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(222, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nombres:";
            // 
            // txtName
            // 
            this.txtName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtName.Location = new System.Drawing.Point(222, 107);
            this.txtName.MaxLength = 40;
            this.txtName.Name = "txtName";
            this.txtName.ShortcutsEnabled = false;
            this.txtName.Size = new System.Drawing.Size(247, 20);
            this.txtName.TabIndex = 2;
            this.txtName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextField_OnlyText);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(222, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "DNI:";
            // 
            // txtDni
            // 
            this.txtDni.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDni.Location = new System.Drawing.Point(222, 50);
            this.txtDni.MaxLength = 8;
            this.txtDni.Name = "txtDni";
            this.txtDni.ShortcutsEnabled = false;
            this.txtDni.Size = new System.Drawing.Size(111, 20);
            this.txtDni.TabIndex = 0;
            this.txtDni.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextField_OnlyNumber);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtPathologies);
            this.groupBox2.Controls.Add(this.txtDiabetes);
            this.groupBox2.Controls.Add(this.txtSeizures);
            this.groupBox2.Controls.Add(this.txtAids);
            this.groupBox2.Controls.Add(this.txtCancer);
            this.groupBox2.Controls.Add(this.txtMedicines);
            this.groupBox2.Controls.Add(this.txtAllergies);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtBloodPressure);
            this.groupBox2.Controls.Add(this.txtBloodType);
            this.groupBox2.Controls.Add(this.txtHeight);
            this.groupBox2.Controls.Add(this.txtWheight);
            this.groupBox2.Location = new System.Drawing.Point(522, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(474, 333);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Historial medico";
            // 
            // txtPathologies
            // 
            this.txtPathologies.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPathologies.Location = new System.Drawing.Point(256, 106);
            this.txtPathologies.MaxLength = 140;
            this.txtPathologies.Multiline = true;
            this.txtPathologies.Name = "txtPathologies";
            this.txtPathologies.ShortcutsEnabled = false;
            this.txtPathologies.Size = new System.Drawing.Size(206, 51);
            this.txtPathologies.TabIndex = 5;
            // 
            // txtDiabetes
            // 
            this.txtDiabetes.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDiabetes.Location = new System.Drawing.Point(256, 233);
            this.txtDiabetes.MaxLength = 30;
            this.txtDiabetes.Name = "txtDiabetes";
            this.txtDiabetes.ShortcutsEnabled = false;
            this.txtDiabetes.Size = new System.Drawing.Size(206, 20);
            this.txtDiabetes.TabIndex = 8;
            // 
            // txtSeizures
            // 
            this.txtSeizures.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSeizures.Location = new System.Drawing.Point(256, 189);
            this.txtSeizures.MaxLength = 40;
            this.txtSeizures.Name = "txtSeizures";
            this.txtSeizures.ShortcutsEnabled = false;
            this.txtSeizures.Size = new System.Drawing.Size(206, 20);
            this.txtSeizures.TabIndex = 7;
            // 
            // txtAids
            // 
            this.txtAids.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtAids.Location = new System.Drawing.Point(256, 276);
            this.txtAids.MaxLength = 140;
            this.txtAids.Multiline = true;
            this.txtAids.Name = "txtAids";
            this.txtAids.ShortcutsEnabled = false;
            this.txtAids.Size = new System.Drawing.Size(206, 51);
            this.txtAids.TabIndex = 10;
            // 
            // txtCancer
            // 
            this.txtCancer.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCancer.Location = new System.Drawing.Point(15, 276);
            this.txtCancer.MaxLength = 140;
            this.txtCancer.Multiline = true;
            this.txtCancer.Name = "txtCancer";
            this.txtCancer.ShortcutsEnabled = false;
            this.txtCancer.Size = new System.Drawing.Size(201, 51);
            this.txtCancer.TabIndex = 9;
            // 
            // txtMedicines
            // 
            this.txtMedicines.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtMedicines.Location = new System.Drawing.Point(15, 189);
            this.txtMedicines.MaxLength = 140;
            this.txtMedicines.Multiline = true;
            this.txtMedicines.Name = "txtMedicines";
            this.txtMedicines.ShortcutsEnabled = false;
            this.txtMedicines.Size = new System.Drawing.Size(201, 64);
            this.txtMedicines.TabIndex = 6;
            // 
            // txtAllergies
            // 
            this.txtAllergies.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtAllergies.Location = new System.Drawing.Point(15, 106);
            this.txtAllergies.MaxLength = 140;
            this.txtAllergies.Multiline = true;
            this.txtAllergies.Name = "txtAllergies";
            this.txtAllergies.ShortcutsEnabled = false;
            this.txtAllergies.Size = new System.Drawing.Size(201, 51);
            this.txtAllergies.TabIndex = 4;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(361, 30);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(79, 13);
            this.label11.TabIndex = 17;
            this.label11.Text = "Presion arterial:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(250, 30);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(81, 13);
            this.label10.TabIndex = 17;
            this.label10.Text = "Tipo de sangre:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(122, 30);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Estatura:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(250, 217);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(52, 13);
            this.label16.TabIndex = 17;
            this.label16.Text = "Diabetes:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(253, 256);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(31, 13);
            this.label18.TabIndex = 17;
            this.label18.Text = "Sida:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(253, 87);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(78, 13);
            this.label13.TabIndex = 17;
            this.label13.Text = "Enfermedades:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(12, 257);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(44, 13);
            this.label17.TabIndex = 17;
            this.label17.Text = "Cancer:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(253, 168);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(73, 13);
            this.label15.TabIndex = 17;
            this.label15.Text = "Convulsiones:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(12, 168);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(58, 13);
            this.label14.TabIndex = 17;
            this.label14.Text = "Medicinas:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(12, 87);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(47, 13);
            this.label12.TabIndex = 17;
            this.label12.Text = "Alergias:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 30);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Peso:";
            // 
            // txtBloodPressure
            // 
            this.txtBloodPressure.Location = new System.Drawing.Point(364, 49);
            this.txtBloodPressure.MaxLength = 20;
            this.txtBloodPressure.Name = "txtBloodPressure";
            this.txtBloodPressure.ShortcutsEnabled = false;
            this.txtBloodPressure.Size = new System.Drawing.Size(98, 20);
            this.txtBloodPressure.TabIndex = 3;
            // 
            // txtBloodType
            // 
            this.txtBloodType.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtBloodType.Location = new System.Drawing.Point(256, 49);
            this.txtBloodType.MaxLength = 20;
            this.txtBloodType.Name = "txtBloodType";
            this.txtBloodType.ShortcutsEnabled = false;
            this.txtBloodType.Size = new System.Drawing.Size(100, 20);
            this.txtBloodType.TabIndex = 2;
            // 
            // txtHeight
            // 
            this.txtHeight.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtHeight.Location = new System.Drawing.Point(125, 49);
            this.txtHeight.MaxLength = 3;
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.ShortcutsEnabled = false;
            this.txtHeight.Size = new System.Drawing.Size(91, 20);
            this.txtHeight.TabIndex = 1;
            this.txtHeight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextField_OnlyNumber);
            // 
            // txtWheight
            // 
            this.txtWheight.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtWheight.Location = new System.Drawing.Point(15, 49);
            this.txtWheight.MaxLength = 3;
            this.txtWheight.Name = "txtWheight";
            this.txtWheight.ShortcutsEnabled = false;
            this.txtWheight.Size = new System.Drawing.Size(104, 20);
            this.txtWheight.TabIndex = 0;
            this.txtWheight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextField_OnlyNumber);
            // 
            // FormClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1003, 357);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormClient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mantenimiento";
            this.Load += new System.EventHandler(this.FormClient_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgPerson)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.DateTimePicker pickerDateTime;
        private System.Windows.Forms.Button btnUploadImage;
        private System.Windows.Forms.PictureBox imgPerson;
        private System.Windows.Forms.ComboBox cbxGender;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtPathologies;
        private System.Windows.Forms.TextBox txtDiabetes;
        private System.Windows.Forms.TextBox txtSeizures;
        private System.Windows.Forms.TextBox txtMedicines;
        private System.Windows.Forms.TextBox txtAllergies;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtBloodPressure;
        private System.Windows.Forms.TextBox txtBloodType;
        private System.Windows.Forms.TextBox txtHeight;
        private System.Windows.Forms.TextBox txtWheight;
        private System.Windows.Forms.TextBox txtAids;
        private System.Windows.Forms.TextBox txtCancer;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button btnAction;
    }
}