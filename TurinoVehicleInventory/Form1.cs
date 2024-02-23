namespace TurinoVehicleInventory
{
    public partial class Form1 : Form
    {
        private List<Vehicle> vehicles = new List<Vehicle>();
        public Form1()
        {
            InitializeComponent();
            lbInventory.DataSource = vehicles;


        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (cbType.Text == "Truck")
            {
                Truck truck = new Truck();
                truck.LicensePlate = txbLicense.Text;
                truck.VIN = txbVIN.Text;
                vehicles.Add(truck);
                lbInventory.DataSource = null;
                lbInventory.DataSource = vehicles;
                txbResults.Text = "Successfully added a truck to the inventory.";

            }
            else if (cbType.Text == "Sedan")
            {
                Sedan sedan = new Sedan();
                sedan.LicensePlate = txbLicense.Text;
                sedan.VIN = txbVIN.Text;
                vehicles.Add(sedan);
                lbInventory.DataSource = null;
                lbInventory.DataSource = vehicles;
                txbResults.Text = "Successfully added a sedan to the inventory.";

            }
        }

        private void lbInventory_DoubleClick(object sender, EventArgs e)
        {
            //unboxing the object from tge listbox into a Vehicle object
            Vehicle vehicle =(Vehicle)lbInventory.SelectedItem;
            txbInventoryResults.Text = vehicle.GetDescription();
        }
    }
}

