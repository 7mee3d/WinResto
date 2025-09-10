using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Simple_Project___Food_Menu
{
    public partial class Food_Price_Restuarant : Form
    {
        public Food_Price_Restuarant()
        {
            InitializeComponent();
        }

        private void setFormSizeAndMoveFixed()
        {

            this.Size = new Size(1528, 886);
            int xWidth = (Screen.PrimaryScreen.Bounds.Width - this.Width) / 2;
            int yHeight = (Screen.PrimaryScreen.Bounds.Height - this.Height) / 2;

            this.Location = new Point(xWidth, yHeight);


        }

        private void Food_Price_Restuarant_Load(object sender, EventArgs e)
        {

        }

        private void Food_Price_Restuarant_Move(object sender, EventArgs e)
        {
            setFormSizeAndMoveFixed();
        }

        private void Food_Price_Restuarant_Resize(object sender, EventArgs e)
        {
            setFormSizeAndMoveFixed();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void PriceTacos_Click(object sender, EventArgs e)
        {

        }


        private void TotalPrice_Click(object sender, EventArgs e)
        {
        }
        int totalPrice = 0;

        private void buttonAddCart_Click(object sender, EventArgs e)
        {

            totalPrice = int.Parse(TotalPrice.Text);
            int priceTacos = int.Parse(PriceTacos.Text);

            totalPrice += priceTacos;

            TotalPrice.Text = totalPrice.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.OpenForms[0].Show();

            this.Close();
        }

        private void PriceFoodacos_Click(object sender, EventArgs e)
        {

        }

        private void buttonAddCartRamen_Click(object sender, EventArgs e)
        {
            totalPrice += int.Parse(PriceRamen.Text);

            TotalPrice.Text = totalPrice.ToString();

        }

        private void AddCartBuudha_Click(object sender, EventArgs e)
        {
            totalPrice += int.Parse(PriceBuddha.Text);

            TotalPrice.Text = totalPrice.ToString();

        }
    }
}
