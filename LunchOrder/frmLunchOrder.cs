namespace LunchOrder
{
    /*
     * Interface to calculate price of food order
     * Author: Mackenzie
     * July 2024. updated: September 2024
     */
    public partial class frmLunchOrder : Form
    {
        private Menu _menu;
        private decimal TAX_RATE = 0.05m;

        public frmLunchOrder()
        {
            InitializeComponent();
            _menu = new Menu();
        }

        private void frmLunchOrder_Load(object sender, EventArgs e)
        {
            PopulateInitialLayout();
        }

        private void PopulateInitialLayout()
        {
            // Populate radio buttons dynamically from the menu items
            var menuItems = _menu.Items;
            radMainFirst.Text = $"{menuItems[0].Name} {menuItems[0].Price:c}";
            radMainSecond.Text = $"{menuItems[1].Name} {menuItems[1].Price:c}";
            radMainThird.Text = $"{menuItems[2].Name} {menuItems[2].Price:c}";
            radMainFirst.Checked = true;
        }

        private void btnPlaceOrder_Click(object sender, EventArgs e)
        {
            decimal subtotal;
            decimal tax;
            decimal orderTotal;

            string? selectedMainCourse = grpMainCourse.Controls.OfType<RadioButton>()
                                            ?.FirstOrDefault(r => r.Checked)?.Text.Split(' ')[0];
            if (selectedMainCourse != null)
            {
                var selectedItem = _menu.GetItemByName(selectedMainCourse);
                int numSelectedSides = grpAddOns.Controls.OfType<CheckBox>().Where(r => r.Checked).Count();
                subtotal = selectedItem.Price + (numSelectedSides * selectedItem.SidePrice);
                CalculateTaxAndOrderTotal(subtotal, out tax, out orderTotal);

                txtSubtotal.Text = subtotal.ToString("c");
                txtTax.Text = tax.ToString("c");
                txtOrderTotal.Text = orderTotal.ToString("c");
            }
        }

        private void CalculateTaxAndOrderTotal(decimal subtotal, out decimal tax, out decimal orderTotal)
        {
            tax = subtotal * TAX_RATE;
            orderTotal = subtotal + tax;
        }

        private void RadMain_CheckChanged(object sender, EventArgs e)
        {
            var radioButton = sender as RadioButton;
            if (radioButton != null && radioButton.Checked)
            {
                string mainCourseName = radioButton.Text.Split(' ')[0];
                var selectedItem = _menu.GetItemByName(mainCourseName);

                if (selectedItem != null)
                {
                    ResetFormExceptMainCourseSelection();
                    PopulateFormSidesSelections(selectedItem.SidePrice, selectedItem.Sides);
                }
            }
        }

        private void PopulateFormSidesSelections(decimal sidePrice, List<string> sides)
        {
            grpAddOns.Text = $"Add-on Items ({sidePrice:c}/each)";
            chkAddOn1.Text = sides[0];
            chkAddOn2.Text = sides[1];
            chkAddOn3.Text = sides[2];
        }

        private void ResetFormExceptMainCourseSelection()
        {
            txtSubtotal.Clear();
            txtTax.Clear();
            txtOrderTotal.Clear();
            foreach (CheckBox item in grpAddOns.Controls.OfType<CheckBox>())
                item.Checked = false;
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetFormExceptMainCourseSelection();
            radMainFirst.Checked = true;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}