using System.Drawing;
using System.Windows.Forms;

namespace UDQLThietBiCongNghe
{
    partial class Form1
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

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.menuExportCsv = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuExit = new System.Windows.Forms.ToolStripMenuItem();

            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();

            this.tableLayoutPanelMain = new System.Windows.Forms.TableLayoutPanel();
            this.gbInput = new System.Windows.Forms.GroupBox();
            this.layoutInput = new System.Windows.Forms.TableLayoutPanel();
            this.lblProductId = new System.Windows.Forms.Label();
            this.txtProductId = new System.Windows.Forms.TextBox();
            this.lblProductName = new System.Windows.Forms.Label();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.cboCategory = new System.Windows.Forms.ComboBox();
            this.lblUnitPrice = new System.Windows.Forms.Label();
            this.txtUnitPrice = new System.Windows.Forms.TextBox();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.lblImage = new System.Windows.Forms.Label();
            this.panelImage = new System.Windows.Forms.FlowLayoutPanel();
            this.picAvatar = new System.Windows.Forms.PictureBox();
            this.btnChooseImage = new System.Windows.Forms.Button();
            this.panelActionButtons = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();

            this.gbData = new System.Windows.Forms.GroupBox();
            this.layoutRight = new System.Windows.Forms.TableLayoutPanel();
            this.panelSearch = new System.Windows.Forms.FlowLayoutPanel();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.colProductId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnExportCsv = new System.Windows.Forms.Button();

            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);

            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.tableLayoutPanelMain.SuspendLayout();
            this.gbInput.SuspendLayout();
            this.layoutInput.SuspendLayout();
            this.panelImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).BeginInit();
            this.panelActionButtons.SuspendLayout();
            this.gbData.SuspendLayout();
            this.layoutRight.SuspendLayout();
            this.panelSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();

            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { this.menuFile });
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1100, 24);
            this.menuStrip1.TabIndex = 0;

            // menuFile
            this.menuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { this.menuExportCsv, this.toolStripSeparator1, this.menuExit });
            this.menuFile.Name = "menuFile";
            this.menuFile.Size = new System.Drawing.Size(37, 20);
            this.menuFile.Text = "File";

            // menuExportCsv
            this.menuExportCsv.Name = "menuExportCsv";
            this.menuExportCsv.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.menuExportCsv.Size = new System.Drawing.Size(173, 22);
            this.menuExportCsv.Text = "Export CSV";
            this.menuExportCsv.Click += new System.EventHandler(this.btnExportCsv_Click);

            // menuExit
            this.menuExit.Name = "menuExit";
            this.menuExit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.menuExit.Size = new System.Drawing.Size(173, 22);
            this.menuExit.Text = "Exit";
            this.menuExit.Click += new System.EventHandler(this.menuExit_Click);

            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { this.lblStatus });
            this.statusStrip1.Location = new System.Drawing.Point(0, 628);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1100, 22);
            this.statusStrip1.TabIndex = 1;

            // lblStatus
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(118, 17);
            this.lblStatus.Text = "Tổng số sản phẩm: 0";

            // 
            // tableLayoutPanelMain
            // 
            this.tableLayoutPanelMain.ColumnCount = 2;
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.tableLayoutPanelMain.Controls.Add(this.gbInput, 0, 0);
            this.tableLayoutPanelMain.Controls.Add(this.gbData, 1, 0);
            this.tableLayoutPanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelMain.Location = new System.Drawing.Point(0, 24);
            this.tableLayoutPanelMain.Name = "tableLayoutPanelMain";
            this.tableLayoutPanelMain.RowCount = 1;
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelMain.Size = new System.Drawing.Size(1100, 604);
            this.tableLayoutPanelMain.TabIndex = 2;

            // 
            // gbInput
            // 
            this.gbInput.Controls.Add(this.layoutInput);
            this.gbInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbInput.Location = new System.Drawing.Point(3, 3);
            this.gbInput.Name = "gbInput";
            this.gbInput.Padding = new System.Windows.Forms.Padding(10);
            this.gbInput.Size = new System.Drawing.Size(379, 598);
            this.gbInput.TabIndex = 0;
            this.gbInput.TabStop = false;
            this.gbInput.Text = "Thông Tin Sản Phẩm";

            // layoutInput
            this.layoutInput.ColumnCount = 2;
            this.layoutInput.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.layoutInput.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layoutInput.Controls.Add(this.lblProductId, 0, 0);
            this.layoutInput.Controls.Add(this.txtProductId, 1, 0);
            this.layoutInput.Controls.Add(this.lblProductName, 0, 1);
            this.layoutInput.Controls.Add(this.txtProductName, 1, 1);
            this.layoutInput.Controls.Add(this.lblCategory, 0, 2);
            this.layoutInput.Controls.Add(this.cboCategory, 1, 2);
            this.layoutInput.Controls.Add(this.lblUnitPrice, 0, 3);
            this.layoutInput.Controls.Add(this.txtUnitPrice, 1, 3);
            this.layoutInput.Controls.Add(this.lblQuantity, 0, 4);
            this.layoutInput.Controls.Add(this.txtQuantity, 1, 4);
            this.layoutInput.Controls.Add(this.lblImage, 0, 5);
            this.layoutInput.Controls.Add(this.panelImage, 1, 5);
            this.layoutInput.Controls.Add(this.panelActionButtons, 1, 6);
            this.layoutInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutInput.Location = new System.Drawing.Point(10, 23);
            this.layoutInput.Name = "layoutInput";
            this.layoutInput.RowCount = 7;
            this.layoutInput.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.layoutInput.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.layoutInput.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.layoutInput.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.layoutInput.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.layoutInput.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 110F));
            this.layoutInput.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layoutInput.Size = new System.Drawing.Size(359, 565);

            // Controls nhập liệu cụ thể
            this.lblProductId.AutoSize = true;
            this.lblProductId.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblProductId.Text = "Mã SP:";

            this.txtProductId.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtProductId.ReadOnly = false;

            this.lblProductName.AutoSize = true;
            this.lblProductName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblProductName.Text = "Tên SP:";

            this.txtProductName.Dock = System.Windows.Forms.DockStyle.Fill;

            this.lblCategory.AutoSize = true;
            this.lblCategory.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblCategory.Text = "Danh mục:";

            this.cboCategory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;

            this.lblUnitPrice.AutoSize = true;
            this.lblUnitPrice.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblUnitPrice.Text = "Đơn giá:";

            this.txtUnitPrice.Dock = System.Windows.Forms.DockStyle.Fill;

            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblQuantity.Text = "Số lượng:";

            this.txtQuantity.Dock = System.Windows.Forms.DockStyle.Fill;

            this.lblImage.AutoSize = true;
            this.lblImage.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblImage.Text = "Ảnh SP:";

            // panelImage
            this.panelImage.Controls.Add(this.picAvatar);
            this.panelImage.Controls.Add(this.btnChooseImage);
            this.panelImage.Dock = System.Windows.Forms.DockStyle.Fill;

            this.picAvatar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picAvatar.Size = new System.Drawing.Size(100, 100);
            this.picAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;

            this.btnChooseImage.AutoSize = true;
            this.btnChooseImage.Text = "Chọn Ảnh...";
            this.btnChooseImage.Click += new System.EventHandler(this.btnChooseImage_Click);

            // panelActionButtons
            this.panelActionButtons.Controls.Add(this.btnAdd);
            this.panelActionButtons.Controls.Add(this.btnUpdate);
            this.panelActionButtons.Controls.Add(this.btnDelete);
            this.panelActionButtons.Dock = System.Windows.Forms.DockStyle.Fill;

            this.btnAdd.AutoSize = true;
            this.btnAdd.Text = "Thêm Mới";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);

            this.btnUpdate.AutoSize = true;
            this.btnUpdate.Text = "Cập Nhật";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);

            this.btnDelete.AutoSize = true;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);

            // 
            // gbData
            // 
            this.gbData.Controls.Add(this.layoutRight);
            this.gbData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbData.Location = new System.Drawing.Point(388, 3);
            this.gbData.Name = "gbData";
            this.gbData.Padding = new System.Windows.Forms.Padding(10);
            this.gbData.Size = new System.Drawing.Size(709, 598);
            this.gbData.Text = "Danh Sách Sản Phẩm";

            // layoutRight
            this.layoutRight.ColumnCount = 1;
            this.layoutRight.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layoutRight.Controls.Add(this.panelSearch, 0, 0);
            this.layoutRight.Controls.Add(this.dgvProducts, 0, 1);
            this.layoutRight.Controls.Add(this.btnExportCsv, 0, 2);
            this.layoutRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutRight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.layoutRight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layoutRight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));

            // panelSearch
            this.panelSearch.Controls.Add(this.lblSearch);
            this.panelSearch.Controls.Add(this.txtSearch);
            this.panelSearch.Dock = System.Windows.Forms.DockStyle.Fill;

            this.lblSearch.AutoSize = true;
            this.lblSearch.Padding = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.lblSearch.Text = "Tìm kiếm tên SP:";

            this.txtSearch.Width = 250;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);

            // dgvProducts
            this.dgvProducts.AllowUserToAddRows = false;
            this.dgvProducts.AutoGenerateColumns = false;
            this.dgvProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colProductId,
            this.colProductName,
            this.colCategory,
            this.colUnitPrice,
            this.colQuantity});
            this.dgvProducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProducts.ReadOnly = true;
            this.dgvProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProducts.MultiSelect = false;
            this.dgvProducts.SelectionChanged += new System.EventHandler(this.dgvProducts_SelectionChanged);

            // DataGridView Columns
            this.colProductId.DataPropertyName = "ProductId";
            this.colProductId.HeaderText = "Mã SP";
            this.colProductId.Width = 90;

            this.colProductName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colProductName.DataPropertyName = "ProductName";
            this.colProductName.HeaderText = "Tên Sản Phẩm";

            this.colCategory.DataPropertyName = "Category";
            this.colCategory.HeaderText = "Danh Mục";
            this.colCategory.Width = 110;

            this.colUnitPrice.DataPropertyName = "UnitPrice";
            this.colUnitPrice.DefaultCellStyle.Format = "N0";
            this.colUnitPrice.HeaderText = "Đơn Giá";
            this.colUnitPrice.Width = 110;

            this.colQuantity.DataPropertyName = "Quantity";
            this.colQuantity.HeaderText = "Số Lượng";
            this.colQuantity.Width = 90;

            // btnExportCsv
            this.btnExportCsv.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnExportCsv.AutoSize = true;
            this.btnExportCsv.Text = "Xuất danh sách ra CSV";
            this.btnExportCsv.Click += new System.EventHandler(this.btnExportCsv_Click);

            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 650);
            this.Controls.Add(this.tableLayoutPanelMain);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TechMart Product Manager";

            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tableLayoutPanelMain.ResumeLayout(false);
            this.gbInput.ResumeLayout(false);
            this.layoutInput.ResumeLayout(false);
            this.layoutInput.PerformLayout();
            this.panelImage.ResumeLayout(false);
            this.panelImage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).EndInit();
            this.panelActionButtons.ResumeLayout(false);
            this.panelActionButtons.PerformLayout();
            this.gbData.ResumeLayout(false);
            this.layoutRight.ResumeLayout(false);
            this.panelSearch.ResumeLayout(false);
            this.panelSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuFile;
        private System.Windows.Forms.ToolStripMenuItem menuExportCsv;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem menuExit;

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelMain;
        private System.Windows.Forms.GroupBox gbInput;
        private System.Windows.Forms.TableLayoutPanel layoutInput;
        private System.Windows.Forms.Label lblProductId, lblProductName, lblCategory, lblUnitPrice, lblQuantity, lblImage;
        private System.Windows.Forms.TextBox txtProductId, txtProductName, txtUnitPrice, txtQuantity;
        private System.Windows.Forms.ComboBox cboCategory;
        private System.Windows.Forms.FlowLayoutPanel panelImage;
        private System.Windows.Forms.PictureBox picAvatar;
        private System.Windows.Forms.Button btnChooseImage;
        private System.Windows.Forms.FlowLayoutPanel panelActionButtons;
        private System.Windows.Forms.Button btnAdd, btnUpdate, btnDelete;

        private System.Windows.Forms.GroupBox gbData;
        private System.Windows.Forms.TableLayoutPanel layoutRight;
        private System.Windows.Forms.FlowLayoutPanel panelSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProductId, colProductName, colCategory, colUnitPrice, colQuantity;
        private System.Windows.Forms.Button btnExportCsv;

        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}