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
    }
}
