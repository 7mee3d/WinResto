namespace Simple_Project___Food_Menu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void setFormSizeAndMoveFixed()
        {
            this.Size = new Size(1528, 886);
            int xWidth = (Screen.PrimaryScreen.Bounds.Width - this.Width) / 2;
            int yHeight = (Screen.PrimaryScreen.Bounds.Height - this.Height) / 2;

            this.Location = new Point(xWidth, yHeight);


        }
        private void Form1_Move(object sender, EventArgs e)
        {
            setFormSizeAndMoveFixed();
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            setFormSizeAndMoveFixed();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Food_Price_Restuarant formFoodPrice = new Food_Price_Restuarant();
            formFoodPrice.Show(); 

        }
    }
}
