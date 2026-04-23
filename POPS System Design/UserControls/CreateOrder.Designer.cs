namespace POPS_System_Design.UserControls
{
    partial class CreateOrder
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnResetOrder = new System.Windows.Forms.Button();
            this.btnCompleteOrder = new System.Windows.Forms.Button();
            this.lvwOrderDetails = new System.Windows.Forms.ListView();
            this.label14 = new System.Windows.Forms.Label();
            this.btnRemoveProduct = new System.Windows.Forms.Button();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.cmbProduct = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbCustomerID = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbSalesman = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Controls.Add(this.cmbSalesman);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lblTotal);
            this.panel1.Controls.Add(this.txtCustomerName);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnResetOrder);
            this.panel1.Controls.Add(this.btnCompleteOrder);
            this.panel1.Controls.Add(this.lvwOrderDetails);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.btnRemoveProduct);
            this.panel1.Controls.Add(this.btnAddProduct);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.txtQuantity);
            this.panel1.Controls.Add(this.cmbProduct);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.cmbCustomerID);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(648, 509);
            this.panel1.TabIndex = 1;
            // 
            // btnResetOrder
            // 
            this.btnResetOrder.Location = new System.Drawing.Point(195, 366);
            this.btnResetOrder.Margin = new System.Windows.Forms.Padding(4);
            this.btnResetOrder.Name = "btnResetOrder";
            this.btnResetOrder.Size = new System.Drawing.Size(169, 28);
            this.btnResetOrder.TabIndex = 22;
            this.btnResetOrder.Text = "Reset Order";
            this.btnResetOrder.UseVisualStyleBackColor = true;
            this.btnResetOrder.Click += new System.EventHandler(this.btnResetOrder_Click);
            // 
            // btnCompleteOrder
            // 
            this.btnCompleteOrder.Location = new System.Drawing.Point(19, 366);
            this.btnCompleteOrder.Margin = new System.Windows.Forms.Padding(4);
            this.btnCompleteOrder.Name = "btnCompleteOrder";
            this.btnCompleteOrder.Size = new System.Drawing.Size(169, 28);
            this.btnCompleteOrder.TabIndex = 21;
            this.btnCompleteOrder.Text = "Complete Order";
            this.btnCompleteOrder.UseVisualStyleBackColor = true;
            this.btnCompleteOrder.Click += new System.EventHandler(this.btnCompleteOrder_Click);
            // 
            // lvwOrderDetails
            // 
            this.lvwOrderDetails.HideSelection = false;
            this.lvwOrderDetails.Location = new System.Drawing.Point(19, 145);
            this.lvwOrderDetails.Margin = new System.Windows.Forms.Padding(4);
            this.lvwOrderDetails.Name = "lvwOrderDetails";
            this.lvwOrderDetails.Size = new System.Drawing.Size(586, 201);
            this.lvwOrderDetails.TabIndex = 20;
            this.lvwOrderDetails.UseCompatibleStateImageBehavior = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(16, 128);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(68, 13);
            this.label14.TabIndex = 19;
            this.label14.Text = "Order Details";
            // 
            // btnRemoveProduct
            // 
            this.btnRemoveProduct.Location = new System.Drawing.Point(440, 90);
            this.btnRemoveProduct.Margin = new System.Windows.Forms.Padding(4);
            this.btnRemoveProduct.Name = "btnRemoveProduct";
            this.btnRemoveProduct.Size = new System.Drawing.Size(141, 28);
            this.btnRemoveProduct.TabIndex = 18;
            this.btnRemoveProduct.Text = "Remove Products";
            this.btnRemoveProduct.UseVisualStyleBackColor = true;
            this.btnRemoveProduct.Click += new System.EventHandler(this.btnRemoveProduct_Click);
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Location = new System.Drawing.Point(291, 90);
            this.btnAddProduct.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(141, 28);
            this.btnAddProduct.TabIndex = 17;
            this.btnAddProduct.Text = "Add Products";
            this.btnAddProduct.UseVisualStyleBackColor = true;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(16, 98);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(46, 13);
            this.label13.TabIndex = 16;
            this.label13.Text = "Quantity";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(16, 64);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(44, 13);
            this.label12.TabIndex = 15;
            this.label12.Text = "Product";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(99, 95);
            this.txtQuantity.Margin = new System.Windows.Forms.Padding(4);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(181, 20);
            this.txtQuantity.TabIndex = 14;
            // 
            // cmbProduct
            // 
            this.cmbProduct.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProduct.FormattingEnabled = true;
            this.cmbProduct.Location = new System.Drawing.Point(99, 60);
            this.cmbProduct.Margin = new System.Windows.Forms.Padding(4);
            this.cmbProduct.Name = "cmbProduct";
            this.cmbProduct.Size = new System.Drawing.Size(181, 21);
            this.cmbProduct.TabIndex = 13;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(16, 31);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 13);
            this.label10.TabIndex = 11;
            this.label10.Text = "Customer ID";
            // 
            // cmbCustomerID
            // 
            this.cmbCustomerID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCustomerID.FormattingEnabled = true;
            this.cmbCustomerID.Location = new System.Drawing.Point(99, 27);
            this.cmbCustomerID.Margin = new System.Windows.Forms.Padding(4);
            this.cmbCustomerID.Name = "cmbCustomerID";
            this.cmbCustomerID.Size = new System.Drawing.Size(181, 21);
            this.cmbCustomerID.TabIndex = 10;
            this.cmbCustomerID.SelectedIndexChanged += new System.EventHandler(this.cmbCustomerID_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(288, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "Customer Name";
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Enabled = false;
            this.txtCustomerName.Location = new System.Drawing.Point(378, 27);
            this.txtCustomerName.Margin = new System.Windows.Forms.Padding(4);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(167, 20);
            this.txtCustomerName.TabIndex = 24;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(403, 370);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(122, 19);
            this.lblTotal.TabIndex = 25;
            this.lblTotal.Text = "Order Total: $0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(288, 64);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "Salesman";
            // 
            // cmbSalesman
            // 
            this.cmbSalesman.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSalesman.FormattingEnabled = true;
            this.cmbSalesman.Location = new System.Drawing.Point(378, 61);
            this.cmbSalesman.Margin = new System.Windows.Forms.Padding(4);
            this.cmbSalesman.Name = "cmbSalesman";
            this.cmbSalesman.Size = new System.Drawing.Size(167, 21);
            this.cmbSalesman.TabIndex = 27;
            // 
            // CreateOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "CreateOrder";
            this.Size = new System.Drawing.Size(648, 509);
            this.Load += new System.EventHandler(this.CreateOrder_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnResetOrder;
        private System.Windows.Forms.Button btnCompleteOrder;
        private System.Windows.Forms.ListView lvwOrderDetails;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnRemoveProduct;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.ComboBox cmbProduct;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmbCustomerID;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.ComboBox cmbSalesman;
        private System.Windows.Forms.Label label2;
    }
}
