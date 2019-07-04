namespace ClinicManagementLite
{
    partial class FormMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cerrarSesionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mantenimientoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cuentasToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.permisosToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.clientesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.empleadosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.areasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cargosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.turnosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.horariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.acercaDeClinicManagementLiteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cerrarSesionToolStripMenuItem,
            this.mantenimientoToolStripMenuItem1,
            this.ayudaToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cerrarSesionToolStripMenuItem
            // 
            this.cerrarSesionToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.cerrarSesionToolStripMenuItem.Name = "cerrarSesionToolStripMenuItem";
            this.cerrarSesionToolStripMenuItem.Size = new System.Drawing.Size(88, 20);
            this.cerrarSesionToolStripMenuItem.Text = "Cerrar Sesion";
            this.cerrarSesionToolStripMenuItem.Click += new System.EventHandler(this.CerrarSesionToolStripMenuItem_Click);
            // 
            // mantenimientoToolStripMenuItem1
            // 
            this.mantenimientoToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cuentasToolStripMenuItem2,
            this.permisosToolStripMenuItem2,
            this.toolStripSeparator2,
            this.clientesToolStripMenuItem1,
            this.empleadosToolStripMenuItem1,
            this.toolStripSeparator3,
            this.areasToolStripMenuItem,
            this.cargosToolStripMenuItem1,
            this.toolStripSeparator4,
            this.turnosToolStripMenuItem1,
            this.horariosToolStripMenuItem});
            this.mantenimientoToolStripMenuItem1.Name = "mantenimientoToolStripMenuItem1";
            this.mantenimientoToolStripMenuItem1.Size = new System.Drawing.Size(101, 20);
            this.mantenimientoToolStripMenuItem1.Text = "Mantenimiento";
            // 
            // cuentasToolStripMenuItem2
            // 
            this.cuentasToolStripMenuItem2.Name = "cuentasToolStripMenuItem2";
            this.cuentasToolStripMenuItem2.Size = new System.Drawing.Size(127, 22);
            this.cuentasToolStripMenuItem2.Tag = "0";
            this.cuentasToolStripMenuItem2.Text = "Cuenta";
            this.cuentasToolStripMenuItem2.Click += new System.EventHandler(this.MenuMaintenanceItem_Click);
            // 
            // permisosToolStripMenuItem2
            // 
            this.permisosToolStripMenuItem2.Name = "permisosToolStripMenuItem2";
            this.permisosToolStripMenuItem2.Size = new System.Drawing.Size(127, 22);
            this.permisosToolStripMenuItem2.Tag = "1";
            this.permisosToolStripMenuItem2.Text = "Permiso";
            this.permisosToolStripMenuItem2.Click += new System.EventHandler(this.MenuMaintenanceItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(124, 6);
            // 
            // clientesToolStripMenuItem1
            // 
            this.clientesToolStripMenuItem1.Name = "clientesToolStripMenuItem1";
            this.clientesToolStripMenuItem1.Size = new System.Drawing.Size(127, 22);
            this.clientesToolStripMenuItem1.Tag = "2";
            this.clientesToolStripMenuItem1.Text = "Cliente";
            this.clientesToolStripMenuItem1.Click += new System.EventHandler(this.MenuMaintenanceItem_Click);
            // 
            // empleadosToolStripMenuItem1
            // 
            this.empleadosToolStripMenuItem1.Name = "empleadosToolStripMenuItem1";
            this.empleadosToolStripMenuItem1.Size = new System.Drawing.Size(127, 22);
            this.empleadosToolStripMenuItem1.Tag = "3";
            this.empleadosToolStripMenuItem1.Text = "Empleado";
            this.empleadosToolStripMenuItem1.Click += new System.EventHandler(this.MenuMaintenanceItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(124, 6);
            // 
            // areasToolStripMenuItem
            // 
            this.areasToolStripMenuItem.Name = "areasToolStripMenuItem";
            this.areasToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.areasToolStripMenuItem.Tag = "4";
            this.areasToolStripMenuItem.Text = "Area";
            this.areasToolStripMenuItem.Click += new System.EventHandler(this.MenuMaintenanceItem_Click);
            // 
            // cargosToolStripMenuItem1
            // 
            this.cargosToolStripMenuItem1.Name = "cargosToolStripMenuItem1";
            this.cargosToolStripMenuItem1.Size = new System.Drawing.Size(127, 22);
            this.cargosToolStripMenuItem1.Tag = "5";
            this.cargosToolStripMenuItem1.Text = "Cargo";
            this.cargosToolStripMenuItem1.Click += new System.EventHandler(this.MenuMaintenanceItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(124, 6);
            // 
            // turnosToolStripMenuItem1
            // 
            this.turnosToolStripMenuItem1.Name = "turnosToolStripMenuItem1";
            this.turnosToolStripMenuItem1.Size = new System.Drawing.Size(127, 22);
            this.turnosToolStripMenuItem1.Tag = "6";
            this.turnosToolStripMenuItem1.Text = "Turno";
            this.turnosToolStripMenuItem1.Click += new System.EventHandler(this.MenuMaintenanceItem_Click);
            // 
            // horariosToolStripMenuItem
            // 
            this.horariosToolStripMenuItem.Name = "horariosToolStripMenuItem";
            this.horariosToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.horariosToolStripMenuItem.Tag = "7";
            this.horariosToolStripMenuItem.Text = "Horario";
            this.horariosToolStripMenuItem.Click += new System.EventHandler(this.MenuMaintenanceItem_Click);
            // 
            // ayudaToolStripMenuItem1
            // 
            this.ayudaToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.acercaDeClinicManagementLiteToolStripMenuItem});
            this.ayudaToolStripMenuItem1.Name = "ayudaToolStripMenuItem1";
            this.ayudaToolStripMenuItem1.Size = new System.Drawing.Size(53, 20);
            this.ayudaToolStripMenuItem1.Text = "Ayuda";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(252, 6);
            // 
            // acercaDeClinicManagementLiteToolStripMenuItem
            // 
            this.acercaDeClinicManagementLiteToolStripMenuItem.Name = "acercaDeClinicManagementLiteToolStripMenuItem";
            this.acercaDeClinicManagementLiteToolStripMenuItem.Size = new System.Drawing.Size(255, 22);
            this.acercaDeClinicManagementLiteToolStripMenuItem.Text = "Acerca de Clinic Management Lite";
            this.acercaDeClinicManagementLiteToolStripMenuItem.Click += new System.EventHandler(this.AcercaDeClinicManagementLiteToolStripMenuItem_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clinic Management Lite";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem acercaDeClinicManagementLiteToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem cerrarSesionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mantenimientoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem cuentasToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem permisosToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem empleadosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem areasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cargosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem turnosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem horariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
    }
}