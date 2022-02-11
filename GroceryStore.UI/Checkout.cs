using GroceryStore.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GroceryStore.UI
{
    public partial class Checkout : Form
    {
        private readonly IStore _store;

        public int ItemCount { get; set; }
        public Checkout(IStore store)
        {
            InitializeComponent();
            ItemCount = 0;
            ItemCount_Label.Text = ItemCount.ToString();
            _store = store;
        }

        private void Item_txtbox_TextChanged(object sender, EventArgs e)
        {
            ItemCount = 1;
            ItemCount_Label.Text = ItemCount.ToString();
        }

        private void Enter_Btn_Click(object sender, EventArgs e)
        {
            string productId = Item_txtbox.Text;
            Product product = _store.GetProduct(productId);
            if (product == null)
                return;

            decimal totalPrice = product.Price * ItemCount;
            DisplayScreen.Text += $"{product.Name} @ {product.Price} X {ItemCount} = {totalPrice}\n";

            Reset();
        }

        private void Reset()
        {
            ItemCount = 0;
            ItemCount_Label.Text = ItemCount.ToString();
            Item_txtbox.Text = "";
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

        private void Checkout_Load(object sender, EventArgs e)
        {

        }

        private void ItemCount_Label_Click(object sender, EventArgs e)
        {

        }
    }
}
