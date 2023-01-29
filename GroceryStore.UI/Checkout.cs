using GroceryStore.Commons.Utilities;
using GroceryStore.Core;
using GroceryStore.Models.DTOs;
using System;
using System.Globalization;
using System.Text;
using System.Windows.Forms;

namespace GroceryStore.UI
{
    public partial class Checkout : Form
    {
        private readonly IStoreKeeper _store;
        private readonly FileIO _fileIO;

        public decimal TotalPrice { get; set; } = 0m;

        public int ItemCount { get; set; }
        public Checkout(IStoreKeeper store)
        {
            _fileIO = new FileIO(@"C:\Users\hp\source\repos\GroceryStore\GroceryStore.Docs");
            InitializeComponent();
            ItemCount = 0;
            ItemCount_Label.Text = ItemCount.ToString();
            _store = store;
            DisplayProducts();
            Enter_Btn.Enabled = false;
            Confirm_btn.Enabled = false;
            Print_btn.Enabled = false;
        }

        private void DisplayTotal()
        {
            Total_label.Text = $"Total: {TotalPrice:c2}";
        }

        private void DisplayProducts()
        {
            var products = _store.GetAllProducts();
            var builder = new StringBuilder();

            foreach (var product in products)
            {
                builder.Append($"{product.Name} - {product.Id}\n");
            }
            AvailblProd_display.Text = builder.ToString();
        }

        private void Item_txtbox_TextChanged(object sender, EventArgs e)
        {
            ItemCount = 1;
            ItemCount_Label.Text = ItemCount.ToString();
            Enter_Btn.Enabled = _store.GetProduct(Item_txtbox.Text) != null;
        }

        private void Enter_Btn_Click(object sender, EventArgs e)
        {
            string productId = Item_txtbox.Text;
            ProductDTO product = _store.GetProduct(productId);
            if (product == null)
                return;

            decimal totalPrice = _store.GetProductPrice(product, ItemCount, CalculateDiscountedPrice);
            DisplayScreen.Text += $"{product.Name} @ {product.Price} X {ItemCount} = {totalPrice}\n";

            _store.RemoveFromProduct(productId, ItemCount);
            TotalPrice += totalPrice;

            Confirm_btn.Enabled = true;
            Reset();
            DisplayProducts();
            DisplayTotal();
        }

        private decimal CalculateDiscountedPrice(int quantity, decimal price)
        {
            if (quantity >= 10)
            {
                return quantity * price * 0.85m;
            }
            else
                return quantity * price;
        }

        private void Reset()
        {
            ItemCount = 0;
            ItemCount_Label.Text = ItemCount.ToString();
            Item_txtbox.Text = "";
            Confirm_btn.Enabled = true;
        }

        private void ResetAll()
        {
            ItemCount = 0;
            ItemCount_Label.Text = ItemCount.ToString();
            Item_txtbox.Text = "";
            DisplayScreen.Text = "";
            Enter_Btn.Enabled = false;
            Confirm_btn.Enabled = false;
            Print_btn.Enabled = false;
        }

        private void Add_Btn_Click(object sender, EventArgs e)
        {
            ItemCount++;
            ItemCount_Label.Text = ItemCount.ToString();
        }

        private void Minus_Btn_Click(object sender, EventArgs e)
        {
            ItemCount--;
            ItemCount_Label.Text = ItemCount.ToString();
        }

        private void Confirm_btn_Click(object sender, EventArgs e)
        {
            var VAT = _store.GetVATOnPurchase(TotalPrice);
            DisplayScreen.Text += $"\n\n" +
                $"Total : {string.Format(new CultureInfo("en-NG"), "{0:c2}", TotalPrice)}\n" +
                $"VAT : {string.Format(new CultureInfo("en-NG"), "{0:c2}", VAT)}\n" +
                $"Sub-Total : {string.Format(new CultureInfo("en-NG"), "{0:c2}", TotalPrice + VAT )}";
            Print_btn.Enabled = true;
        }

        private void Print_btn_Click(object sender, EventArgs e)
        {
            _fileIO.GenerateReceipt(DisplayScreen.Text);
            ResetAll();
        }
    }
}
