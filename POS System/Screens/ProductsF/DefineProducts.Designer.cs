
namespace POS_System.Screens.ProductsF
{
    partial class DefineProducts
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.btnSave = new MetroFramework.Controls.MetroButton();
            this.SizesdataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnSelectAllSizes = new MetroFramework.Controls.MetroButton();
            this.txtPurchasePrice = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnClose = new MetroFramework.Controls.MetroButton();
            this.btnDefineNew = new MetroFramework.Controls.MetroButton();
            this.txtSalesPrice = new System.Windows.Forms.TextBox();
            this.btnDeselectAllSizes = new MetroFramework.Controls.MetroButton();
            this.txtCategory = new System.Windows.Forms.ComboBox();
            this.txtSupplier = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.SizesdataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Crimson;
            this.panel2.Location = new System.Drawing.Point(-1, -1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(78, 187);
            this.panel2.TabIndex = 30;
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(418, 94);
            this.txtProductName.Multiline = true;
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtProductName.Size = new System.Drawing.Size(276, 32);
            this.txtProductName.TabIndex = 0;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Crimson;
            this.btnSave.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(635, 388);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(206, 41);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save";
            this.btnSave.UseCustomBackColor = true;
            this.btnSave.UseCustomForeColor = true;
            this.btnSave.UseSelectable = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // SizesdataGridView1
            // 
            this.SizesdataGridView1.AllowUserToAddRows = false;
            this.SizesdataGridView1.AllowUserToDeleteRows = false;
            this.SizesdataGridView1.AllowUserToResizeColumns = false;
            this.SizesdataGridView1.AllowUserToResizeRows = false;
            this.SizesdataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.SizesdataGridView1.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.SizesdataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SizesdataGridView1.Location = new System.Drawing.Point(143, 94);
            this.SizesdataGridView1.Name = "SizesdataGridView1";
            this.SizesdataGridView1.ReadOnly = true;
            this.SizesdataGridView1.RowHeadersVisible = false;
            this.SizesdataGridView1.RowHeadersWidth = 51;
            this.SizesdataGridView1.RowTemplate.Height = 24;
            this.SizesdataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.SizesdataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.SizesdataGridView1.Size = new System.Drawing.Size(251, 335);
            this.SizesdataGridView1.TabIndex = 5;
            // 
            // btnSelectAllSizes
            // 
            this.btnSelectAllSizes.BackColor = System.Drawing.Color.Pink;
            this.btnSelectAllSizes.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnSelectAllSizes.ForeColor = System.Drawing.Color.Black;
            this.btnSelectAllSizes.Location = new System.Drawing.Point(99, 94);
            this.btnSelectAllSizes.Name = "btnSelectAllSizes";
            this.btnSelectAllSizes.Size = new System.Drawing.Size(38, 33);
            this.btnSelectAllSizes.TabIndex = 33;
            this.btnSelectAllSizes.Text = "S";
            this.btnSelectAllSizes.UseCustomBackColor = true;
            this.btnSelectAllSizes.UseCustomForeColor = true;
            this.btnSelectAllSizes.UseSelectable = true;
            this.btnSelectAllSizes.Click += new System.EventHandler(this.btnSelectAllSizes_Click);
            // 
            // txtPurchasePrice
            // 
            this.txtPurchasePrice.Location = new System.Drawing.Point(556, 261);
            this.txtPurchasePrice.Multiline = true;
            this.txtPurchasePrice.Name = "txtPurchasePrice";
            this.txtPurchasePrice.Size = new System.Drawing.Size(138, 30);
            this.txtPurchasePrice.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(700, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 25);
            this.label1.TabIndex = 35;
            this.label1.Text = "Product Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(700, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 25);
            this.label2.TabIndex = 35;
            this.label2.Text = "Category";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(700, 210);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 25);
            this.label3.TabIndex = 35;
            this.label3.Text = "Supplier";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(700, 266);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 25);
            this.label4.TabIndex = 35;
            this.label4.Text = "Purchase Price";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(700, 323);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 25);
            this.label5.TabIndex = 35;
            this.label5.Text = "Sales Price";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Crimson;
            this.btnClose.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(635, 462);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(206, 41);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "Close";
            this.btnClose.UseCustomBackColor = true;
            this.btnClose.UseCustomForeColor = true;
            this.btnClose.UseSelectable = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnDefineNew
            // 
            this.btnDefineNew.BackColor = System.Drawing.Color.Crimson;
            this.btnDefineNew.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnDefineNew.ForeColor = System.Drawing.Color.White;
            this.btnDefineNew.Location = new System.Drawing.Point(143, 462);
            this.btnDefineNew.Name = "btnDefineNew";
            this.btnDefineNew.Size = new System.Drawing.Size(251, 41);
            this.btnDefineNew.TabIndex = 8;
            this.btnDefineNew.Text = "Define New";
            this.btnDefineNew.UseCustomBackColor = true;
            this.btnDefineNew.UseCustomForeColor = true;
            this.btnDefineNew.UseSelectable = true;
            this.btnDefineNew.Click += new System.EventHandler(this.btnDefineNew_Click);
            // 
            // txtSalesPrice
            // 
            this.txtSalesPrice.Location = new System.Drawing.Point(556, 318);
            this.txtSalesPrice.Multiline = true;
            this.txtSalesPrice.Name = "txtSalesPrice";
            this.txtSalesPrice.Size = new System.Drawing.Size(138, 30);
            this.txtSalesPrice.TabIndex = 4;
            // 
            // btnDeselectAllSizes
            // 
            this.btnDeselectAllSizes.BackColor = System.Drawing.Color.Pink;
            this.btnDeselectAllSizes.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnDeselectAllSizes.ForeColor = System.Drawing.Color.Black;
            this.btnDeselectAllSizes.Location = new System.Drawing.Point(99, 133);
            this.btnDeselectAllSizes.Name = "btnDeselectAllSizes";
            this.btnDeselectAllSizes.Size = new System.Drawing.Size(38, 33);
            this.btnDeselectAllSizes.TabIndex = 33;
            this.btnDeselectAllSizes.Text = "D";
            this.btnDeselectAllSizes.UseCustomBackColor = true;
            this.btnDeselectAllSizes.UseCustomForeColor = true;
            this.btnDeselectAllSizes.UseSelectable = true;
            this.btnDeselectAllSizes.Click += new System.EventHandler(this.btnDeselectAllSizes_Click);
            // 
            // txtCategory
            // 
            this.txtCategory.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtCategory.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.txtCategory.BackColor = System.Drawing.Color.White;
            this.txtCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtCategory.ForeColor = System.Drawing.Color.Black;
            this.txtCategory.FormattingEnabled = true;
            this.txtCategory.Location = new System.Drawing.Point(489, 151);
            this.txtCategory.Name = "txtCategory";
            this.txtCategory.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtCategory.Size = new System.Drawing.Size(205, 24);
            this.txtCategory.Sorted = true;
            this.txtCategory.TabIndex = 36;
            // 
            // txtSupplier
            // 
            this.txtSupplier.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtSupplier.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.txtSupplier.BackColor = System.Drawing.Color.White;
            this.txtSupplier.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtSupplier.ForeColor = System.Drawing.Color.Black;
            this.txtSupplier.FormattingEnabled = true;
            this.txtSupplier.Location = new System.Drawing.Point(489, 210);
            this.txtSupplier.Name = "txtSupplier";
            this.txtSupplier.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtSupplier.Size = new System.Drawing.Size(205, 24);
            this.txtSupplier.TabIndex = 37;
            // 
            // DefineProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 608);
            this.Controls.Add(this.txtSupplier);
            this.Controls.Add(this.txtCategory);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SizesdataGridView1);
            this.Controls.Add(this.btnDeselectAllSizes);
            this.Controls.Add(this.btnSelectAllSizes);
            this.Controls.Add(this.btnDefineNew);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtSalesPrice);
            this.Controls.Add(this.txtPurchasePrice);
            this.Controls.Add(this.txtProductName);
            this.Controls.Add(this.panel2);
            this.DisplayHeader = false;
            this.MaximizeBox = false;
            this.Name = "DefineProducts";
            this.Padding = new System.Windows.Forms.Padding(20, 30, 20, 20);
            this.Resizable = false;
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ShowInTaskbar = false;
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Text = "DefineProducts";
            this.Load += new System.EventHandler(this.DefineProducts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SizesdataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtProductName;
        private MetroFramework.Controls.MetroButton btnSave;
        private System.Windows.Forms.DataGridView SizesdataGridView1;
        private MetroFramework.Controls.MetroButton btnSelectAllSizes;
        private System.Windows.Forms.TextBox txtPurchasePrice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private MetroFramework.Controls.MetroButton btnClose;
        private MetroFramework.Controls.MetroButton btnDefineNew;
        private System.Windows.Forms.TextBox txtSalesPrice;
        private MetroFramework.Controls.MetroButton btnDeselectAllSizes;
        private System.Windows.Forms.ComboBox txtCategory;
        private System.Windows.Forms.ComboBox txtSupplier;
    }
}