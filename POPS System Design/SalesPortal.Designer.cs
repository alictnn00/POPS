namespace POPS_System_Design
{
    partial class SalesPortal
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnOpenCustHub = new System.Windows.Forms.Button();
            this.btnOpenOrderHub = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(203, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "SALES HUB";
            // 
            // btnOpenCustHub
            // 
            this.btnOpenCustHub.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnOpenCustHub.BackColor = System.Drawing.Color.PeachPuff;
            this.btnOpenCustHub.Location = new System.Drawing.Point(149, 90);
            this.btnOpenCustHub.Name = "btnOpenCustHub";
            this.btnOpenCustHub.Size = new System.Drawing.Size(97, 97);
            this.btnOpenCustHub.TabIndex = 5;
            this.btnOpenCustHub.Text = "CUSTOMERS";
            this.btnOpenCustHub.UseVisualStyleBackColor = false;
            this.btnOpenCustHub.Click += new System.EventHandler(this.btnOpenCustHub_Click);
            // 
            // btnOpenOrderHub
            // 
            this.btnOpenOrderHub.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnOpenOrderHub.BackColor = System.Drawing.Color.PeachPuff;
            this.btnOpenOrderHub.Location = new System.Drawing.Point(252, 90);
            this.btnOpenOrderHub.Name = "btnOpenOrderHub";
            this.btnOpenOrderHub.Size = new System.Drawing.Size(97, 97);
            this.btnOpenOrderHub.TabIndex = 6;
            this.btnOpenOrderHub.Text = "ORDERS";
            this.btnOpenOrderHub.UseVisualStyleBackColor = false;
            this.btnOpenOrderHub.Click += new System.EventHandler(this.btnOpenOrderHub_Click);
            // 
            // SalesPortal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(500, 270);
            this.Controls.Add(this.btnOpenOrderHub);
            this.Controls.Add(this.btnOpenCustHub);
            this.Controls.Add(this.label1);
            this.Name = "SalesPortal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SalesPortal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOpenCustHub;
        private System.Windows.Forms.Button btnOpenOrderHub;
    }
}