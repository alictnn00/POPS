namespace POPS_System_Design
{
    partial class SearchCustomer
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.dgvCustomer = new System.Windows.Forms.DataGridView();
            this.cmbSearchType = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomer)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Gainsboro;
            this.panel3.Controls.Add(this.txtSearch);
            this.panel3.Controls.Add(this.dgvCustomer);
            this.panel3.Controls.Add(this.cmbSearchType);
            this.panel3.Controls.Add(this.label13);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(750, 450);
            this.panel3.TabIndex = 3;
            // 
            // txtSearch
            // 
            this.txtSearch.AccessibleDescription = "";
            this.txtSearch.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(292, 21);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(150, 23);
            this.txtSearch.TabIndex = 3;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // dgvCustomer
            // 
            this.dgvCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomer.Location = new System.Drawing.Point(10, 50);
            this.dgvCustomer.Margin = new System.Windows.Forms.Padding(4);
            this.dgvCustomer.Name = "dgvCustomer";
            this.dgvCustomer.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvCustomer.Size = new System.Drawing.Size(736, 346);
            this.dgvCustomer.TabIndex = 4;
            // 
            // cmbSearchType
            // 
            this.cmbSearchType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSearchType.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSearchType.FormattingEnabled = true;
            this.cmbSearchType.Location = new System.Drawing.Point(144, 20);
            this.cmbSearchType.Margin = new System.Windows.Forms.Padding(4);
            this.cmbSearchType.Name = "cmbSearchType";
            this.cmbSearchType.Size = new System.Drawing.Size(140, 24);
            this.cmbSearchType.TabIndex = 2;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(7, 23);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(129, 16);
            this.label13.TabIndex = 1;
            this.label13.Text = "Search Customer By:";
            // 
            // SearchCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel3);
            this.Name = "SearchCustomer";
            this.Size = new System.Drawing.Size(750, 450);
            this.Load += new System.EventHandler(this.SearchCustomer_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridView dgvCustomer;
        private System.Windows.Forms.ComboBox cmbSearchType;
        private System.Windows.Forms.Label label13;
    }
}
