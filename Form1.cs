using System.Data;

namespace AppInventory
{
    public partial class InventoryManagement : Form
    {
        DataTable inventory = new DataTable();  
        public InventoryManagement()
        {
            InitializeComponent();
        }

        private void newBtn_Click(object sender, EventArgs e)
        {
            // Clears all input fields 
            skuTb.Text = "";
            nameTb.Text = "";
            priceTb.Text = "";
            descriptionTb.Text = "";
            quantityTb.Text = "";
            categoryCB.SelectedIndex = -1;

        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            // Save all the values from fields into variables
            string sku = skuTb.Text;
            string name = nameTb.Text;
            string price = priceTb.Text;
            string quantity = quantityTb.Text;
            string description = descriptionTb.Text;
            string category = (string)categoryCB.SelectedItem;

            // Add values to the datatable
            inventory.Rows.Add(sku, name, category, price, description, quantity);

            // Clears input fields after saving
            newBtn_Click(sender, e);
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            // Deletes row user has selected
            try
            {
                inventory.Rows[inventoryDGV.CurrentCell.RowIndex].Delete();
            }
            catch (Exception err)
            {
                Console.WriteLine("Error" + err);
            }
        }

        private void inventoryDGV_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Allow user to click any field and display data in proper fields.
            // Also shows error if an empty column is selected
            try
            {
                skuTb.Text = inventory.Rows[inventoryDGV.CurrentCell.RowIndex].ItemArray[0].ToString();
                nameTb.Text = inventory.Rows[inventoryDGV.CurrentCell.RowIndex].ItemArray[1].ToString();
                priceTb.Text = inventory.Rows[inventoryDGV.CurrentCell.RowIndex].ItemArray[3].ToString();
                descriptionTb.Text = inventory.Rows[inventoryDGV.CurrentCell.RowIndex].ItemArray[4].ToString();
                quantityTb.Text = inventory.Rows[inventoryDGV.CurrentCell.RowIndex].ItemArray[5].ToString();
                string itemToLookFor = inventory.Rows[inventoryDGV.CurrentCell.RowIndex].ItemArray[2].ToString();
                categoryCB.SelectedIndex = categoryCB.Items.IndexOf(itemToLookFor);
            }
            catch (Exception err) 
            {
                Console.WriteLine("There has been an error" + err);
            }
        }

        private void InventoryManagement_Load(object sender, EventArgs e)
        {
            inventory.Columns.Add("SKU");
            inventory.Columns.Add("Name");
            inventory.Columns.Add("Category");
            inventory.Columns.Add("Price");
            inventory.Columns.Add("Description");
            inventory.Columns.Add("Quantity");

            inventoryDGV.DataSource = inventory;
        }
    }
}