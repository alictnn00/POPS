namespace POPS_System_Design.UserControls
{
    partial class ProductInventory
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
            this.txtProductSearch = new System.Windows.Forms.TextBox();
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.cmbProductSearchType = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Gainsboro;
            this.panel3.Controls.Add(this.txtProductSearch);
            this.panel3.Controls.Add(this.dgvProducts);
            this.panel3.Controls.Add(this.cmbProductSearchType);
            this.panel3.Controls.Add(this.label13);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(784, 411);
            this.panel3.TabIndex = 4;
            // 
            // txtProductSearch
            // 
            this.txtProductSearch.AccessibleDescription = "";
            this.txtProductSearch.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductSearch.Location = new System.Drawing.Point(270, 22);
            this.txtProductSearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtProductSearch.Name = "txtProductSearch";
            this.txtProductSearch.Size = new System.Drawing.Size(150, 23);
            this.txtProductSearch.TabIndex = 7;
            this.txtProductSearch.TextChanged += new System.EventHandler(this.txtProductSearch_TextChanged);
            // 
            // dgvProducts
            // 
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducts.Location = new System.Drawing.Point(10, 50);
            this.dgvProducts.Margin = new System.Windows.Forms.Padding(4);
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.Size = new System.Drawing.Size(705, 346);
            this.dgvProducts.TabIndex = 8;
            // 
            // cmbProductSearchType
            // 
            this.cmbProductSearchType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProductSearchType.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbProductSearchType.FormattingEnabled = true;
            this.cmbProductSearchType.Location = new System.Drawing.Point(122, 21);
            this.cmbProductSearchType.Margin = new System.Windows.Forms.Padding(4);
            this.cmbProductSearchType.Name = "cmbProductSearchType";
            this.cmbProductSearchType.Size = new System.Drawing.Size(140, 24);
            this.cmbProductSearchType.TabIndex = 6;
            this.cmbProductSearchType.SelectedIndexChanged += new System.EventHandler(this.cmbProductSearchType_SelectedIndexChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(7, 23);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(117, 16);
            this.label13.TabIndex = 5;
            this.label13.Text = "Search Product By:";
            // 
            // ProductInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel3);
            this.Name = "ProductInventory";
            this.Size = new System.Drawing.Size(784, 411);
            this.Load += new System.EventHandler(this.ProductInventory_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtProductSearch;
        private System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.ComboBox cmbProductSearchType;
        private System.Windows.Forms.Label label13;
    }
}
