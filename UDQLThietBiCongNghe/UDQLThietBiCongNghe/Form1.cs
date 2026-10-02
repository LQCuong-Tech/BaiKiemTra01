using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace UDQLThietBiCongNghe
{
    // Class DTO Sản phẩm
    public class Product
    {
        public string ProductId { get; set; }
        public string ProductName { get; set; }
        public string Category { get; set; }
        public decimal UnitPrice { get; set; }
        public int Quantity { get; set; }
        public string ImagePath { get; set; }

        public Product() { }

        public Product(string productId, string productName, string category, decimal unitPrice, int quantity, string imagePath)
        {
            ProductId = productId;
            ProductName = productName;
            Category = category;
            UnitPrice = unitPrice;
            Quantity = quantity;
            ImagePath = imagePath;
        }
    }

    // Class binding ComboBox Danh mục
    public class CategoryItem
    {
        public string Id { get; set; }
        public string Name { get; set; }

        public CategoryItem(string id, string name)
        {
            Id = id;
            Name = name;
        }
    }

    public partial class Form1 : Form
    {
        private BindingList<Product> _originalList = new BindingList<Product>();
        private BindingSource _bindingSource = new BindingSource();

        public Form1()
        {
            InitializeComponent();
            InitDataBinding();
            LoadCategories();
            LoadSampleData();
            ClearInputFields();
        }

        #region Khởi tạo & Data Binding

        private void InitDataBinding()
        {
            _bindingSource.DataSource = _originalList;
            dgvProducts.DataSource = _bindingSource;
            _originalList.ListChanged += (s, e) => UpdateStatusCount();
        }

        private void LoadCategories()
        {
            var categories = new BindingList<CategoryItem>
            {
                new CategoryItem("Điện thoại", "Điện thoại"),
                new CategoryItem("Laptop", "Laptop"),
                new CategoryItem("Phụ kiện", "Phụ kiện")
            };
            cboCategory.DataSource = categories;
            cboCategory.DisplayMember = "Name";
            cboCategory.ValueMember = "Id";
        }

        private void LoadSampleData()
        {
            UpdateStatusCount();
        }

        private void UpdateStatusCount()
        {
            lblStatus.Text = $"Tổng số sản phẩm: {_originalList.Count}";
        }

        #endregion

        #region Xử lý Sự kiện & Validation

        private void btnChooseImage_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog { Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp" })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    picAvatar.ImageLocation = ofd.FileName;
                }
            }
        }

        private bool ValidateInput()
        {
            errorProvider1.Clear();
            bool isValid = true;

            // Check Tên SP
            if (string.IsNullOrWhiteSpace(txtProductName.Text))
            {
                errorProvider1.SetError(txtProductName, "Tên sản phẩm không được để trống!");
                isValid = false;
            }

            // Check Đơn giá > 0
            if (!decimal.TryParse(txtUnitPrice.Text, out decimal price) || price <= 0)
            {
                errorProvider1.SetError(txtUnitPrice, "Đơn giá phải là số hợp lệ và > 0!");
                isValid = false;
            }

            // Check Số lượng >= 0
            if (!int.TryParse(txtQuantity.Text, out int qty) || qty < 0)
            {
                errorProvider1.SetError(txtQuantity, "Số lượng phải là số nguyên >= 0!");
                isValid = false;
            }

            return isValid;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!ValidateInput()) return;

            string currentId = txtProductId.Text.Trim();
            Product p = new Product
            {
                ProductId = currentId,
                ProductName = txtProductName.Text.Trim(),
                Category = cboCategory.SelectedValue?.ToString(),
                UnitPrice = decimal.Parse(txtUnitPrice.Text),
                Quantity = int.Parse(txtQuantity.Text),
                ImagePath = picAvatar.ImageLocation ?? ""
            };

            _originalList.Add(p);
            txtSearch.Clear();
            ClearInputFields();
            MessageBox.Show("Thêm sản phẩm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvProducts.CurrentRow == null) return;
            if (!ValidateInput()) return;

            Product selectedProduct = dgvProducts.CurrentRow.DataBoundItem as Product;
            if (selectedProduct != null)
            {
                selectedProduct.ProductName = txtProductName.Text.Trim();
                selectedProduct.Category = cboCategory.SelectedValue?.ToString();
                selectedProduct.UnitPrice = decimal.Parse(txtUnitPrice.Text);
                selectedProduct.Quantity = int.Parse(txtQuantity.Text);
                selectedProduct.ImagePath = picAvatar.ImageLocation ?? "";

                _bindingSource.ResetCurrentItem();
                MessageBox.Show("Cập nhật thông tin thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvProducts.CurrentRow == null) return;

            Product selectedProduct = dgvProducts.CurrentRow.DataBoundItem as Product;
            if (selectedProduct != null)
            {
                var dialogResult = MessageBox.Show(
                    $"Bạn có chắc chắn muốn xóa sản phẩm [{selectedProduct.ProductName}]?",
                    "Xác nhận xóa",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (dialogResult == DialogResult.Yes)
                {
                    _originalList.Remove(selectedProduct);
                    ClearInputFields();
                    MessageBox.Show("Đã xóa sản phẩm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void dgvProducts_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvProducts.CurrentRow != null)
            {
                Product p = dgvProducts.CurrentRow.DataBoundItem as Product;
                if (p != null)
                {
                    txtProductId.Text = p.ProductId;
                    txtProductName.Text = p.ProductName;
                    cboCategory.SelectedValue = p.Category;
                    txtUnitPrice.Text = p.UnitPrice.ToString("0");
                    txtQuantity.Text = p.Quantity.ToString();

                    if (!string.IsNullOrEmpty(p.ImagePath) && File.Exists(p.ImagePath))
                    {
                        picAvatar.ImageLocation = p.ImagePath;
                    }
                    else
                    {
                        picAvatar.Image = null;
                        picAvatar.ImageLocation = null;
                    }
                }
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text.Trim().ToLower();
            if (string.IsNullOrEmpty(keyword))
            {
                _bindingSource.DataSource = _originalList;
            }
            else
            {
                var filtered = _originalList.Where(p => p.ProductName.ToLower().Contains(keyword)).ToList();
                _bindingSource.DataSource = new BindingList<Product>(filtered);
            }
        }

        private void btnExportCsv_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "CSV Files (*.csv)|*.csv|All Files (*.*)|*.*";
                sfd.DefaultExt = "csv";
                sfd.FileName = "DSSanPham.csv";
                sfd.CheckFileExists = false;
                sfd.CheckPathExists = true;

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        StringBuilder sb = new StringBuilder();
                        sb.AppendLine("Mã SP,Tên Sản Phẩm,Danh Mục,Đơn Giá,Số Lượng");

                        foreach (var item in _originalList)
                        {
                            sb.AppendLine($"\"{item.ProductId}\",\"{item.ProductName}\",\"{item.Category}\",{item.UnitPrice},{item.Quantity}");
                        }

                        File.WriteAllText(sfd.FileName, sb.ToString(), Encoding.UTF8);

                        MessageBox.Show("Xuất danh sách ra CSV thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Lỗi khi ghi file: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void menuExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ClearInputFields()
        {
            txtProductId.Clear();
            txtProductName.Clear();
            txtUnitPrice.Clear();
            txtQuantity.Clear();
            picAvatar.Image = null;
            picAvatar.ImageLocation = null;
            errorProvider1.Clear();
        }
        #endregion
    }
}