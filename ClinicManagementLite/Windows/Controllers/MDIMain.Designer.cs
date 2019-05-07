namespace ClinicManagementLite.Windows.Controllers
{
    partial class MDIMain
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
            this.menuStripMain = new System.Windows.Forms.MenuStrip();
            this.stripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.stripLogout = new System.Windows.Forms.ToolStripMenuItem();
            this.stripUsers = new System.Windows.Forms.ToolStripMenuItem();
            this.stripEmployees = new System.Windows.Forms.ToolStripMenuItem();
            this.stripPositions = new System.Windows.Forms.ToolStripMenuItem();
            this.stripAreas = new System.Windows.Forms.ToolStripMenuItem();
            this.stripClients = new System.Windows.Forms.ToolStripMenuItem();
            this.stripTurns = new System.Windows.Forms.ToolStripMenuItem();
            this.stripHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.stripAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusStripMain = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStripMain.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripMain
            // 
            this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stripMenu,
            this.stripUsers,
            this.stripEmployees,
            this.stripClients,
            this.stripTurns,
            this.stripHelp});
            this.menuStripMain.Location = new System.Drawing.Point(0, 0);
            this.menuStripMain.Name = "menuStripMain";
            this.menuStripMain.Size = new System.Drawing.Size(800, 24);
            this.menuStripMain.TabIndex = 1;
            this.menuStripMain.Text = "menuStrip1";
            // 
            // stripMenu
            // 
            this.stripMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stripLogout});
            this.stripMenu.Name = "stripMenu";
            this.stripMenu.Size = new System.Drawing.Size(50, 20);
            this.stripMenu.Text = "Menu";
            // 
            // stripLogout
            // 
            this.stripLogout.Name = "stripLogout";
            this.stripLogout.Size = new System.Drawing.Size(142, 22);
            this.stripLogout.Text = "Cerrar sesión";
            this.stripLogout.Click += new System.EventHandler(this.stripLogout_Click);
            // 
            // stripUsers
            // 
            this.stripUsers.Name = "stripUsers";
            this.stripUsers.Size = new System.Drawing.Size(64, 20);
            this.stripUsers.Text = "Usuarios";
            this.stripUsers.Click += new System.EventHandler(this.stripUsers_Click);
            // 
            // stripEmployees
            // 
            this.stripEmployees.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stripPositions,
            this.stripAreas});
            this.stripEmployees.Name = "stripEmployees";
            this.stripEmployees.Size = new System.Drawing.Size(77, 20);
            this.stripEmployees.Text = "Empleados";
            this.stripEmployees.Click += new System.EventHandler(this.stripEmployees_Click);
            // 
            // stripPositions
            // 
            this.stripPositions.Name = "stripPositions";
            this.stripPositions.Size = new System.Drawing.Size(180, 22);
            this.stripPositions.Text = "Cargos";
            this.stripPositions.Click += new System.EventHandler(this.stripPositions_Click);
            // 
            // stripAreas
            // 
            this.stripAreas.Name = "stripAreas";
            this.stripAreas.Size = new System.Drawing.Size(180, 22);
            this.stripAreas.Text = "Areas";
            this.stripAreas.Click += new System.EventHandler(this.stripAreas_Click);
            // 
            // stripClients
            // 
            this.stripClients.Name = "stripClients";
            this.stripClients.Size = new System.Drawing.Size(61, 20);
            this.stripClients.Text = "Clientes";
            this.stripClients.Click += new System.EventHandler(this.stripClients_Click);
            // 
            // stripTurns
            // 
            this.stripTurns.Name = "stripTurns";
            this.stripTurns.Size = new System.Drawing.Size(56, 20);
            this.stripTurns.Text = "Turnos";
            this.stripTurns.Click += new System.EventHandler(this.stripTurns_Click);
            // 
            // stripHelp
            // 
            this.stripHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stripAbout});
            this.stripHelp.Name = "stripHelp";
            this.stripHelp.Size = new System.Drawing.Size(53, 20);
            this.stripHelp.Text = "Ayuda";
            this.stripHelp.Click += new System.EventHandler(this.stripHelp_Click);
            // 
            // stripAbout
            // 
            this.stripAbout.Name = "stripAbout";
            this.stripAbout.Size = new System.Drawing.Size(180, 22);
            this.stripAbout.Text = "Acerca de...";
            this.stripAbout.Click += new System.EventHandler(this.stripAbout_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusStripMain});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statusStripMain
            // 
            this.statusStripMain.Name = "statusStripMain";
            this.statusStripMain.Size = new System.Drawing.Size(103, 17);
            this.statusStripMain.Text = "stripUserLoggedin";
            // 
            // MDIMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStripMain);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStripMain;
            this.Name = "MDIMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Centro de atención";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MDIMain_Load);
            this.menuStripMain.ResumeLayout(false);
            this.menuStripMain.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripMain;
        private System.Windows.Forms.ToolStripMenuItem stripMenu;
        private System.Windows.Forms.ToolStripMenuItem stripLogout;
        private System.Windows.Forms.ToolStripMenuItem stripUsers;
        private System.Windows.Forms.ToolStripMenuItem stripEmployees;
        private System.Windows.Forms.ToolStripMenuItem stripPositions;
        private System.Windows.Forms.ToolStripMenuItem stripAreas;
        private System.Windows.Forms.ToolStripMenuItem stripClients;
        private System.Windows.Forms.ToolStripMenuItem stripTurns;
        private System.Windows.Forms.ToolStripMenuItem stripHelp;
        private System.Windows.Forms.ToolStripMenuItem stripAbout;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel statusStripMain;
    }
}