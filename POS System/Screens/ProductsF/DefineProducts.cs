using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using POS_System.General;

namespace POS_System.Screens.ProductsF
{
    public partial class DefineProducts : MetroFramework.Forms.MetroForm
    {
        public DefineProducts()
        {
            InitializeComponent();
        }
        public bool IsUpdate { get; set; }

        private void DefineProducts_Load(object sender, EventArgs e)
        {
            if (!this.IsUpdate)
            {

            }
            LoadAllSizesIntoGrid();
            LoadDataIntoCombobox();

        }

        private void LoadDataIntoCombobox()
        {
            txtCategory.DataSource = GetComboBoxData(3);
            txtCategory.DisplayMember = "Decsription";
            txtCategory.ValueMember = "ID";

            txtSupplier.DataSource = GetComboBoxData(2);
            txtSupplier.DisplayMember = "Decsription";
            txtSupplier.ValueMember = "ID";
        }

        private DataTable GetComboBoxData(int listTypeID)
        {
            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection(Application_Settings.ConnectionString()))
            {
                using (SqlCommand cmd = new SqlCommand("MSP_LoadDataIntoCombo", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ListTypeID", 1);
                    con.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    dt.Load(dr);
                }
            }
            return dt;
        }

        private void LoadAllSizesIntoGrid()
        {
            using (SqlConnection con = new SqlConnection(Application_Settings.ConnectionString()))
            {
                using (SqlCommand cmd = new SqlCommand("MSP_LoadDataIntoGrid", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    if (con.State != ConnectionState.Open)
                        con.Open();

                    DataTable dt = new DataTable();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.HasRows)
                        {
                            dt.Load(dr);
                            SizesdataGridView1.DataSource = dt;
                            SizesdataGridView1.Columns[0].Visible = false;
                        }
                    }
                }

            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDefineNew_Click(object sender, EventArgs e)
        {
            txtProductName.Clear();
            txtCategory.SelectedIndex = -1;
            txtSupplier.SelectedIndex = -1;
            txtPurchasePrice.Clear();
            txtSalesPrice.Clear();

            foreach (DataGridViewRow row in SizesdataGridView1.Rows)
            {
                row.Cells["Select"].Value = false;
            }

            txtProductName.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (IsValid())
            {

            }
        }

        private bool IsValid()
        {
            if (txtProductName.Text.Trim() == String.Empty)
            {
                MessageBox.Show("Product Name is required!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtProductName.Focus();
                return false;
            }
            if (txtPurchasePrice.Text.Trim() == String.Empty)
            {
                MessageBox.Show("Purchase Price is required!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPurchasePrice.Focus();
                return false;
            }
            if (txtSalesPrice.Text.Trim() == String.Empty)
            {
                MessageBox.Show("Sales Price is required!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSalesPrice.Focus();
                return false;
            }
            return true;
        }

        private void btnSelectAllSizes_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in SizesdataGridView1.Rows)
            {
                row.Cells["Select"].Value = true;
            }
        }

        private void btnDeselectAllSizes_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in SizesdataGridView1.Rows)
            {
                row.Cells["Select"].Value = false;
            }
        }
    }
}
