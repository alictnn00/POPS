namespace POPS_System_Design
{
    partial class MainFormProduction
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
            this.SideBarPanel = new System.Windows.Forms.Panel();
            this.btnProductionUpdateNav = new System.Windows.Forms.Button();
            this.btnProductionHomePageNav = new System.Windows.Forms.Button();
            this.MainViewPanel = new System.Windows.Forms.Panel();
            this.SideBarPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // SideBarPanel
            // 
            this.SideBarPanel.BackColor = System.Drawing.Color.DarkSlateGray;
            this.SideBarPanel.Controls.Add(this.btnProductionUpdateNav);
            this.SideBarPanel.Controls.Add(this.btnProductionHomePageNav);
            this.SideBarPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.SideBarPanel.Location = new System.Drawing.Point(0, 0);
            this.SideBarPanel.Name = "SideBarPanel";
            this.SideBarPanel.Size = new System.Drawing.Size(200, 411);
            this.SideBarPanel.TabIndex = 0;
            // 
            // btnProductionUpdateNav
            // 
            this.btnProductionUpdateNav.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnProductionUpdateNav.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProductionUpdateNav.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnProductionUpdateNav.FlatAppearance.BorderSize = 0;
            this.btnProductionUpdateNav.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnProductionUpdateNav.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProductionUpdateNav.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnProductionUpdateNav.ForeColor = System.Drawing.Color.White;
            this.btnProductionUpdateNav.Location = new System.Drawing.Point(0, 70);
            this.btnProductionUpdateNav.Margin = new System.Windows.Forms.Padding(2);
            this.btnProductionUpdateNav.Name = "btnProductionUpdateNav";
            this.btnProductionUpdateNav.Size = new System.Drawing.Size(200, 70);
            this.btnProductionUpdateNav.TabIndex = 1;
            this.btnProductionUpdateNav.Text = "Production Update";
            this.btnProductionUpdateNav.UseVisualStyleBackColor = false;
            // 
            // btnProductionHomePageNav
            // 
            this.btnProductionHomePageNav.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnProductionHomePageNav.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProductionHomePageNav.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnProductionHomePageNav.FlatAppearance.BorderSize = 0;
            this.btnProductionHomePageNav.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnProductionHomePageNav.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProductionHomePageNav.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnProductionHomePageNav.ForeColor = System.Drawing.Color.White;
            this.btnProductionHomePageNav.Location = new System.Drawing.Point(0, 0);
            this.btnProductionHomePageNav.Margin = new System.Windows.Forms.Padding(2);
            this.btnProductionHomePageNav.Name = "btnProductionHomePageNav";
            this.btnProductionHomePageNav.Size = new System.Drawing.Size(200, 70);
            this.btnProductionHomePageNav.TabIndex = 0;
            this.btnProductionHomePageNav.Text = "Home Page";
            this.btnProductionHomePageNav.UseVisualStyleBackColor = false;
            // 
            // MainViewPanel
            // 
            this.MainViewPanel.BackColor = System.Drawing.Color.SlateGray;
            this.MainViewPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainViewPanel.Location = new System.Drawing.Point(200, 0);
            this.MainViewPanel.Name = "MainViewPanel";
            this.MainViewPanel.Size = new System.Drawing.Size(784, 411);
            this.MainViewPanel.TabIndex = 1;
            // 
            // MainFormProduction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(984, 411);
            this.Controls.Add(this.MainViewPanel);
            this.Controls.Add(this.SideBarPanel);
            this.Name = "MainFormProduction";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.SideBarPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel SideBarPanel;
        private System.Windows.Forms.Button btnProductionHomePageNav;
        private System.Windows.Forms.Panel MainViewPanel;
        private System.Windows.Forms.Button btnProductionUpdateNav;
    }
}