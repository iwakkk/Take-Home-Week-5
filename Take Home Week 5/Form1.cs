using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Take_Home_Week_5
{
    public partial class Form1 : Form
    {
        DataTable dtproduct = new DataTable();
        DataTable dtcategory = new DataTable();

        public List<string> productID = new List<string>();
        public List<string> productname = new List<string>();
        public List<Int64> price = new List<Int64>();
        public List<Int32> stock = new List<Int32>();
        public List<string> categoryIDinproduct = new List<string>();

        public List<string> categoryIDincategory = new List<string>();
        public List<string> categoryname = new List<string>();

        

        int counterID = 6;
        bool checkduplicate = true;
        bool checkfilter = true;
        int nextproductid = 1;
        string newproductid = "";
        string jumlah0 = "00";
        string selectedcell = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            dtcategory.Columns.Add("Category ID");
            dtcategory.Columns.Add("Category Name");

            categoryIDincategory.Add("C1");
            categoryIDincategory.Add("C2");
            categoryIDincategory.Add("C3");
            categoryIDincategory.Add("C4");
            categoryIDincategory.Add("C5");
            categoryname.Add("Light Stick");
            categoryname.Add("T-Shirt");
            categoryname.Add("Crewneck");
            categoryname.Add("Crop Top");
            categoryname.Add("Key Chain");


            dtproduct.Columns.Add("Product ID");
            dtproduct.Columns.Add("Product Name");
            dtproduct.Columns.Add("Price");
            dtproduct.Columns.Add("Stock");
            dtproduct.Columns.Add("Category ID");

            productID.Add("T001");
            productID.Add("L001");
            productID.Add("C001");
            productID.Add("C002");
            productID.Add("L002");
            productID.Add("K001");
            productname.Add("T-Shirt Blackpink Jennie");
            productname.Add("Lightstick Blackpink ver 1");
            productname.Add("Crewneck Blackpink Jennie");
            productname.Add("Crop Top Blackpink Jennie");
            productname.Add("Lightstick Blackpink ver 2");
            productname.Add("Key Chain Blackpink Jennie");
            price.Add(100000);
            price.Add(650000);
            price.Add(900000);
            price.Add(600000);
            price.Add(800000);
            price.Add(120000);
            stock.Add(28);
            stock.Add(30);
            stock.Add(18);
            stock.Add(16);
            stock.Add(32);
            stock.Add(24);
            categoryIDinproduct.Add("C2");
            categoryIDinproduct.Add("C1");
            categoryIDinproduct.Add("C3");
            categoryIDinproduct.Add("C4");
            categoryIDinproduct.Add("C1");
            categoryIDinproduct.Add("C5");

            for (int i = 0; i < categoryIDincategory.Count; i++)
            {
                dtcategory.Rows.Add(categoryIDincategory[i], categoryname[i]);
                combo_category.Items.Add(categoryname[i]);
                combo_filter.Items.Add(categoryname[i]);
            }
            for (int i = 0; i < categoryIDinproduct.Count; i++)
            {

                dtproduct.Rows.Add(productID[i], productname[i], price[i], stock[i], categoryIDinproduct[i]);
            }

            

            dgv_category.DataSource = dtcategory;
            dgv_product.DataSource = dtproduct;
            dgv_category.ClearSelection();
            dgv_product.ClearSelection();
            dgv_category.CurrentCell = null;
            dgv_product.CurrentCell = null;

            foreach (DataGridViewColumn column in dgv_product.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            foreach (DataGridViewColumn column in dgv_category.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            btn_showall.Select();
            this.BackColor = Color.HotPink;
            btn_addproduct.BackColor = Color.DeepPink;
            btn_editproduct.BackColor = Color.Yellow;
            btn_removeproduct.BackColor = Color.Red;
            btn_removecategory.BackColor = Color.Red;
            btn_addcategory.BackColor = Color.DeepPink;
        }

        private void btn_addproduct_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_namabaru.Text) || string.IsNullOrEmpty(txt_hargabaru.Text) || string.IsNullOrEmpty(txt_stockbaru.Text) || string.IsNullOrEmpty(combo_category.Text))
            {
                MessageBox.Show("Please fill all the required fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                string firsletter = txt_namabaru.Text.Substring(0, 1).ToUpper();

                for (int i = 0; i < productID.Count; i++)
                {
                    if (txt_namabaru.Text == productname[i])
                    {
                        checkduplicate = false;
                    }

                }

                for (int i = 0; i < productID.Count; i++)
                {
                    if (txt_namabaru.Text.Substring(0, 1).ToUpper() == productID[i].Substring(0, 1).ToUpper())
                    {
                        nextproductid = Convert.ToInt32(productID[i].Substring(1)) + 1;
                    }
                }
                if (nextproductid > 99)
                {
                    jumlah0 = "";
                }
                else if (nextproductid > 9)
                {
                    jumlah0 = "0";
                }

                productID.Add(txt_namabaru.Text.Substring(0, 1).ToUpper() + jumlah0 + nextproductid);
                productname.Add(txt_namabaru.Text);
                price.Add(Convert.ToInt64(txt_hargabaru.Text));
                stock.Add(Convert.ToInt32(txt_stockbaru.Text));
                categoryIDinproduct.Add(categoryIDincategory[combo_category.SelectedIndex]);
                updatedtproduct();
                txt_namabaru.Text = null;
                txt_hargabaru.Text = null;
                txt_stockbaru.Text = null;
                combo_category.Text = null;

            }
        }

        public void updatecombofilter()
        {
            combo_filter.Items.Clear();
            for (int i = 0; i < categoryname.Count; i++)
            {
                combo_filter.Items.Add(categoryname[i]);
            }
        }
        public void updatecombocategory()
        {
            combo_category.Items.Clear();
            for (int i = 0; i < categoryname.Count; i++)
            {
                combo_category.Items.Add(categoryname[i]);
            }
        }

        public void updatedtproduct()
        {
            dtproduct.Rows.Clear();
            for (int i = 0; i < productname.Count; i++)
            {
                dtproduct.Rows.Add(productID[i], productname[i], price[i], stock[i], categoryIDinproduct[i]);
            }
        }

        private void btn_addcategory_Click(object sender, EventArgs e)
        {
            string tampung = "";
            checkduplicate = true;



            if (string.IsNullOrEmpty(txt_namacategory.Text))
            {
                MessageBox.Show("Please fill all the required fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                for (int i = 0; i < categoryIDincategory.Count; i++)
                {
                    tampung = categoryIDincategory[i].Substring(1);
                }
                string catname = txt_namacategory.Text;
                string catID = "C" + (Convert.ToInt32(tampung) + 1);

                for (int i = 0; i < categoryIDincategory.Count; i++)
                {
                    if (catname == categoryname[i])
                    {
                        checkduplicate = false;
                    }

                }
                if (checkduplicate == false)
                {
                    MessageBox.Show("Category name already exist", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    dtcategory.Rows.Add(catID, catname);
                    categoryIDincategory.Add("C" + Convert.ToInt32(tampung) + 1);
                    categoryname.Add(txt_namacategory.Text);
                    updatecombofilter();
                    updatecombocategory();
                }
                txt_namacategory.Clear();
            }
        }

        private void btn_removecategory_Click(object sender, EventArgs e)
        {
            if (dgv_category.CurrentCell == null)
            {
                MessageBox.Show("Select dulu bang", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                string selecteditem = categoryIDincategory[dgv_category.CurrentCell.RowIndex];
                categoryIDincategory.RemoveAt(dgv_category.CurrentCell.RowIndex);
                categoryname.RemoveAt(dgv_category.CurrentCell.RowIndex);
                dtcategory.Rows.RemoveAt(dgv_category.CurrentCell.RowIndex);

                for (int i = categoryIDinproduct.Count - 1; i >= 0; i--)
                {
                    if (selecteditem == categoryIDinproduct[i])
                    {
                        dtproduct.Rows.RemoveAt((int)i);
                        categoryIDinproduct.RemoveAt(i);
                        productname.RemoveAt(i);
                        price.RemoveAt(i);
                        stock.RemoveAt(i);
                        productID.RemoveAt(i);

                    }
                }
                updatecombocategory();
                updatecombofilter();
                dgv_category.ClearSelection();
                dgv_category.CurrentCell = null;
            }
        }
        private void txt_hargabaru_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txt_stockbaru_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void btn_editproduct_Click(object sender, EventArgs e)
        {
            if (dgv_product.CurrentCell == null)
            {
                MessageBox.Show("Select dulu bang", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                if (txt_namabaru.Text == "" || txt_hargabaru.Text == "" || txt_stockbaru.Text == "" || combo_category.Text == "")
                {
                    MessageBox.Show("Please fill all the required fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    for (int i = 0; i < productID.Count; i++)
                    {
                        if (selectedcell == productID[i])
                        {
                            productname[i] = txt_namabaru.Text;
                            price[i] = Convert.ToInt64(txt_hargabaru.Text);
                            stock[i] = Convert.ToInt32(txt_stockbaru.Text);
                            categoryIDinproduct[i] = categoryIDincategory[combo_category.SelectedIndex];

                            if (Convert.ToInt32(txt_stockbaru.Text) == 0)
                            {
                                productID.RemoveAt(i);
                                productname.RemoveAt(i);
                                price.RemoveAt(i);
                                stock.RemoveAt(i);
                                categoryIDinproduct.RemoveAt(i);

                            }
                            txt_namabaru.Text = null;
                            txt_hargabaru.Text = null;
                            txt_stockbaru.Text = null;
                            combo_category.Text = null;
                            updatedtproduct();
                        }
                    }
                    
                }
            }
            dgv_product.ClearSelection();
            dgv_product.CurrentCell = null;
        }

        private void dgv_product_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            selectedcell = dgv_product.SelectedCells[0].Value.ToString();
            if (dgv_product.CurrentCell == null)
            {
                MessageBox.Show("Select dulu bang", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                for (int i = 0; i < productID.Count; i++)
                {
                    if (selectedcell == productID[i])
                    {
                        txt_namabaru.Text = productname[i];
                        txt_hargabaru.Text = price[i].ToString();
                        txt_stockbaru.Text = stock[i].ToString();
                        foreach (DataRow a in dtcategory.Rows)
                        {
                            if (categoryIDinproduct[i] == a[0].ToString())
                            {
                                combo_category.Text = a[1].ToString();
                            }
                        }
                    }
                }
               
                
            }
        }

        private void btn_removeproduct_Click(object sender, EventArgs e)
        {
            if (dgv_product.CurrentCell == null)
            {
                MessageBox.Show("Please select dulu yh bang", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                for (int i= 0; i < productID.Count; i++)
                {
                    if (selectedcell== productID[i])
                    {
                        productID.RemoveAt(i);
                        productname.RemoveAt(i);
                        price.RemoveAt(i);
                        stock.RemoveAt(i);
                        categoryIDinproduct.RemoveAt(i);
                        txt_namabaru.Text = null;
                        txt_hargabaru.Text = null;
                        txt_stockbaru.Text = null;
                        combo_category.Text = null;
                        updatedtproduct();
                        dgv_product.ClearSelection();
                        dgv_product.CurrentCell = null;
                        selectedcell = "";
                    }
                }
            }
        }
        private void btn_showall_Click(object sender, EventArgs e)
        {
            updatedtproduct();
            combo_filter.Text = "";
            combo_filter.Enabled = false;
        }
        private void btn_showfilter_Click(object sender, EventArgs e)
        {
            combo_filter.Enabled = true;
        }
        private void combo_filter_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
        private void combo_filter_SelectionChangeCommitted(object sender, EventArgs e)
        {
            dtproduct.Rows.Clear();
            for (int i = 0; i < categoryIDinproduct.Count; i++)
            {
                if (categoryIDincategory[combo_filter.SelectedIndex] == categoryIDinproduct[i])
                {
                    dtproduct.Rows.Add(productID[i], productname[i], price[i], stock[i], categoryIDinproduct[i]);
                }
            }
        }
    }
}



