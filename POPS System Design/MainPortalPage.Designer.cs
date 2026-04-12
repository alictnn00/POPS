namespace POPS_System_Design
{
    partial class MainPortalPage
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
            this.btnOpenSale = new System.Windows.Forms.Button();
            this.btnOpenFact = new System.Windows.Forms.Button();
            this.btnOpenWare = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnOpenSale
            // 
            this.btnOpenSale.BackColor = System.Drawing.Color.PeachPuff;
            this.btnOpenSale.Location = new System.Drawing.Point(65, 98);
            this.btnOpenSale.Name = "btnOpenSale";
            this.btnOpenSale.Size = new System.Drawing.Size(97, 97);
            this.btnOpenSale.TabIndex = 0;
            this.btnOpenSale.Text = "SALES PORTAL";
            this.btnOpenSale.UseVisualStyleBackColor = false;
            this.btnOpenSale.Click += new System.EventHandler(this.btnOpenSale_Click);
            // 
            // btnOpenFact
            // 
            this.btnOpenFact.BackColor = System.Drawing.Color.PeachPuff;
            this.btnOpenFact.Location = new System.Drawing.Point(214, 98);
            this.btnOpenFact.Name = "btnOpenFact";
            this.btnOpenFact.Size = new System.Drawing.Size(97, 97);
            this.btnOpenFact.TabIndex = 1;
            this.btnOpenFact.Text = "FACTORY PORTAL";
            this.btnOpenFact.UseVisualStyleBackColor = false;
            this.btnOpenFact.Click += new System.EventHandler(this.btnOpenFact_Click);
            // 
            // btnOpenWare
            // 
            this.btnOpenWare.BackColor = System.Drawing.Color.PeachPuff;
            this.btnOpenWare.Location = new System.Drawing.Point(363, 98);
            this.btnOpenWare.Name = "btnOpenWare";
            this.btnOpenWare.Size = new System.Drawing.Size(97, 97);
            this.btnOpenWare.TabIndex = 2;
            this.btnOpenWare.Text = "WAREHOUSE PORTAL";
            this.btnOpenWare.UseVisualStyleBackColor = false;
            this.btnOpenWare.Click += new System.EventHandler(this.btnOpenWare_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(185, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "WBS MAIN PORTAL";
            // 
            // MainPortalPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(500, 270);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnOpenWare);
            this.Controls.Add(this.btnOpenFact);
            this.Controls.Add(this.btnOpenSale);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainPortalPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home Page";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainPortalPage_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOpenSale;
        private System.Windows.Forms.Button btnOpenFact;
        private System.Windows.Forms.Button btnOpenWare;
        private System.Windows.Forms.Label label1;
    }
}