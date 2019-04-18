using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecapProject1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // single responsibility -- methodları ayırmalıyız -- refactoring !!
            ListCategories();
            ListProducts();            
        }

        private void ListProducts()
        {
            using (NorthWindContext context = new NorthWindContext()) // idisposible format - garbage collector beklemeden memory den bitirmek.
            {
                dgwProduct.DataSource = context.Products.ToList();
            }
        }

        private void ListCategories()
        {
            using (NorthWindContext context = new NorthWindContext()) // idisposible format - garbage collector beklemeden memory den bitirmek.
            {
                cbxCategory.DataSource = context.Categories.ToList();
                cbxCategory.DisplayMember = "CategoryName";
                cbxCategory.ValueMember = "CategoryId";
            }
        }

        private void ListProductsByCategory(int categoryId)
        {
            using (NorthWindContext context = new NorthWindContext())
            {
                dgwProduct.DataSource = context.Products.Where(p => p.CategoryId == categoryId).ToList();
            }
        }

        private void ListProductsByName(string key)
        {
            using (NorthWindContext context = new NorthWindContext())
            {
                dgwProduct.DataSource = context.Products.Where(p => p.ProductName.ToLower().Contains(key)).ToList();
            }
        }

        private void cbxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            //MessageBox.Show(cbxCategory.SelectedValue.ToString());
            try
            {
                ListProductsByCategory(Convert.ToInt32(cbxCategory.SelectedValue));
            }
            catch (Exception)
            {

            }
        }

        private void tbxSearch_TextChanged(object sender, EventArgs e)
        {
            string key = tbxSearch.Text; 

            try
            {
                if (string.IsNullOrEmpty(key))
                {
                    ListProducts();
                }
                else
                {
                    ListProductsByName(key);
                }
            }
            catch (Exception)
            {

            }
        }
    }
}
