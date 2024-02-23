namespace TurinoVehicleInventory
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabControl = new TabControl();
            tabNewVehiclePage = new TabPage();
            txbResults = new TextBox();
            btnAdd = new Button();
            cbType = new ComboBox();
            txbVIN = new TextBox();
            txbLicense = new TextBox();
            lblType = new Label();
            lblVIN = new Label();
            lblLicense = new Label();
            lblNewVehicleTitle = new Label();
            tabInventory = new TabPage();
            txbInventoryResults = new TextBox();
            lbInventory = new ListBox();
            tabControl.SuspendLayout();
            tabNewVehiclePage.SuspendLayout();
            tabInventory.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl
            // 
            tabControl.Alignment = TabAlignment.Right;
            tabControl.Controls.Add(tabNewVehiclePage);
            tabControl.Controls.Add(tabInventory);
            tabControl.Location = new Point(1, 1);
            tabControl.Multiline = true;
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(832, 447);
            tabControl.TabIndex = 0;
            // 
            // tabNewVehiclePage
            // 
            tabNewVehiclePage.Controls.Add(txbResults);
            tabNewVehiclePage.Controls.Add(btnAdd);
            tabNewVehiclePage.Controls.Add(cbType);
            tabNewVehiclePage.Controls.Add(txbVIN);
            tabNewVehiclePage.Controls.Add(txbLicense);
            tabNewVehiclePage.Controls.Add(lblType);
            tabNewVehiclePage.Controls.Add(lblVIN);
            tabNewVehiclePage.Controls.Add(lblLicense);
            tabNewVehiclePage.Controls.Add(lblNewVehicleTitle);
            tabNewVehiclePage.Location = new Point(4, 4);
            tabNewVehiclePage.Name = "tabNewVehiclePage";
            tabNewVehiclePage.Padding = new Padding(3);
            tabNewVehiclePage.Size = new Size(798, 439);
            tabNewVehiclePage.TabIndex = 0;
            tabNewVehiclePage.Text = "New Vehicle";
            tabNewVehiclePage.UseVisualStyleBackColor = true;
            // 
            // txbResults
            // 
            txbResults.Location = new Point(144, 316);
            txbResults.Multiline = true;
            txbResults.Name = "txbResults";
            txbResults.ReadOnly = true;
            txbResults.Size = new Size(415, 120);
            txbResults.TabIndex = 8;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(292, 251);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(119, 28);
            btnAdd.TabIndex = 7;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // cbType
            // 
            cbType.FormattingEnabled = true;
            cbType.Items.AddRange(new object[] { "Sedan", "Truck" });
            cbType.Location = new Point(245, 198);
            cbType.Name = "cbType";
            cbType.Size = new Size(210, 28);
            cbType.TabIndex = 6;
            cbType.Text = "Sedan";
            // 
            // txbVIN
            // 
            txbVIN.Location = new Point(245, 146);
            txbVIN.Name = "txbVIN";
            txbVIN.Size = new Size(210, 27);
            txbVIN.TabIndex = 5;
            // 
            // txbLicense
            // 
            txbLicense.Location = new Point(245, 105);
            txbLicense.Name = "txbLicense";
            txbLicense.Size = new Size(210, 27);
            txbLicense.TabIndex = 4;
            // 
            // lblType
            // 
            lblType.AutoSize = true;
            lblType.Location = new Point(134, 200);
            lblType.Name = "lblType";
            lblType.Size = new Size(40, 20);
            lblType.TabIndex = 3;
            lblType.Text = "Type";
            // 
            // lblVIN
            // 
            lblVIN.AutoSize = true;
            lblVIN.Location = new Point(134, 153);
            lblVIN.Name = "lblVIN";
            lblVIN.Size = new Size(33, 20);
            lblVIN.TabIndex = 2;
            lblVIN.Text = "VIN";
            // 
            // lblLicense
            // 
            lblLicense.AutoSize = true;
            lblLicense.Location = new Point(134, 112);
            lblLicense.Name = "lblLicense";
            lblLicense.Size = new Size(57, 20);
            lblLicense.TabIndex = 1;
            lblLicense.Text = "License";
            // 
            // lblNewVehicleTitle
            // 
            lblNewVehicleTitle.AutoSize = true;
            lblNewVehicleTitle.Location = new Point(271, 23);
            lblNewVehicleTitle.Name = "lblNewVehicleTitle";
            lblNewVehicleTitle.Size = new Size(128, 20);
            lblNewVehicleTitle.TabIndex = 0;
            lblNewVehicleTitle.Text = "New Vehicle Form";
            // 
            // tabInventory
            // 
            tabInventory.Controls.Add(txbInventoryResults);
            tabInventory.Controls.Add(lbInventory);
            tabInventory.Location = new Point(4, 4);
            tabInventory.Name = "tabInventory";
            tabInventory.Padding = new Padding(3);
            tabInventory.Size = new Size(798, 439);
            tabInventory.TabIndex = 1;
            tabInventory.Text = "Inventory List";
            tabInventory.UseVisualStyleBackColor = true;
            // 
            // txbInventoryResults
            // 
            txbInventoryResults.Location = new Point(4, 327);
            txbInventoryResults.Multiline = true;
            txbInventoryResults.Name = "txbInventoryResults";
            txbInventoryResults.ReadOnly = true;
            txbInventoryResults.Size = new Size(794, 112);
            txbInventoryResults.TabIndex = 1;
            // 
            // lbInventory
            // 
            lbInventory.FormattingEnabled = true;
            lbInventory.Location = new Point(3, 2);
            lbInventory.Name = "lbInventory";
            lbInventory.Size = new Size(795, 324);
            lbInventory.TabIndex = 0;
            lbInventory.DoubleClick += lbInventory_DoubleClick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(835, 450);
            Controls.Add(tabControl);
            Name = "Form1";
            Text = "Form1";
            tabControl.ResumeLayout(false);
            tabNewVehiclePage.ResumeLayout(false);
            tabNewVehiclePage.PerformLayout();
            tabInventory.ResumeLayout(false);
            tabInventory.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl;
        private TabPage tabNewVehiclePage;
        private TabPage tabInventory;
        private TextBox txbVIN;
        private TextBox txbLicense;
        private Label lblType;
        private Label lblVIN;
        private Label lblLicense;
        private Label lblNewVehicleTitle;
        private ComboBox cbType;
        private TextBox txbResults;
        private Button btnAdd;
        private ListBox lbInventory;
        private TextBox txbInventoryResults;
    }
}
