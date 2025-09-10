namespace Simple_Project___Food_Menu
{
    partial class Food_Price_Restuarant
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Food_Price_Restuarant));
            pictureBox1 = new PictureBox();
            NameFoodOneTacos = new Label();
            PriceFoodacos = new Label();
            PriceTacos = new Label();
            label1 = new Label();
            TotalPrice = new Label();
            buttonAddCart = new Button();
            button1 = new Button();
            pictureBox2 = new PictureBox();
            label2 = new Label();
            NameFoodRamen = new Label();
            label3 = new Label();
            PriceRamen = new Label();
            buttonAddCartRamen = new Button();
            pictureBox3 = new PictureBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            PriceBuddha = new Label();
            AddCartBuudha = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(172, 68, 37);
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.ErrorImage = Properties.Resources.Carrot_Free_PNG_Image;
            pictureBox1.Image = Properties.Resources.Carrot_Free_PNG_Image;
            pictureBox1.Location = new Point(390, 268);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(214, 237);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // NameFoodOneTacos
            // 
            NameFoodOneTacos.AutoSize = true;
            NameFoodOneTacos.BackColor = Color.FromArgb(250, 247, 234);
            NameFoodOneTacos.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            NameFoodOneTacos.ForeColor = Color.Black;
            NameFoodOneTacos.Location = new Point(390, 536);
            NameFoodOneTacos.Name = "NameFoodOneTacos";
            NameFoodOneTacos.Size = new Size(152, 21);
            NameFoodOneTacos.TabIndex = 1;
            NameFoodOneTacos.Text = "Name Food : Tacos";
            NameFoodOneTacos.Click += label1_Click;
            // 
            // PriceFoodacos
            // 
            PriceFoodacos.AutoSize = true;
            PriceFoodacos.BackColor = Color.FromArgb(250, 247, 234);
            PriceFoodacos.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PriceFoodacos.Location = new Point(390, 572);
            PriceFoodacos.Name = "PriceFoodacos";
            PriceFoodacos.Size = new Size(106, 21);
            PriceFoodacos.TabIndex = 2;
            PriceFoodacos.Text = "Price Food  : ";
            PriceFoodacos.Click += PriceFoodacos_Click;
            // 
            // PriceTacos
            // 
            PriceTacos.AutoSize = true;
            PriceTacos.BackColor = Color.FromArgb(250, 247, 234);
            PriceTacos.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PriceTacos.Location = new Point(492, 572);
            PriceTacos.Name = "PriceTacos";
            PriceTacos.Size = new Size(28, 21);
            PriceTacos.TabIndex = 3;
            PriceTacos.Text = "20";
            PriceTacos.Click += PriceTacos_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(250, 247, 234);
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(1106, 779);
            label1.Name = "label1";
            label1.Size = new Size(267, 32);
            label1.TabIndex = 4;
            label1.Text = "Total Price Order ($) : ";
            // 
            // TotalPrice
            // 
            TotalPrice.AutoSize = true;
            TotalPrice.BackColor = Color.FromArgb(250, 247, 234);
            TotalPrice.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TotalPrice.Location = new Point(1367, 781);
            TotalPrice.Name = "TotalPrice";
            TotalPrice.Size = new Size(25, 30);
            TotalPrice.TabIndex = 5;
            TotalPrice.Text = "0";
            TotalPrice.Click += TotalPrice_Click;
            // 
            // buttonAddCart
            // 
            buttonAddCart.BackColor = Color.FromArgb(250, 247, 234);
            buttonAddCart.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonAddCart.Location = new Point(390, 615);
            buttonAddCart.Name = "buttonAddCart";
            buttonAddCart.Size = new Size(122, 35);
            buttonAddCart.TabIndex = 6;
            buttonAddCart.Text = "Add To Cart";
            buttonAddCart.UseVisualStyleBackColor = false;
            buttonAddCart.Click += buttonAddCart_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(250, 247, 234);
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(146, 774);
            button1.Name = "button1";
            button1.Size = new Size(93, 37);
            button1.TabIndex = 7;
            button1.Text = "Back ";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Location = new Point(702, 268);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(229, 237);
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(250, 247, 234);
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(702, 536);
            label2.Name = "label2";
            label2.Size = new Size(110, 21);
            label2.TabIndex = 9;
            label2.Text = "Name Food : ";
            // 
            // NameFoodRamen
            // 
            NameFoodRamen.AutoSize = true;
            NameFoodRamen.BackColor = Color.FromArgb(250, 247, 234);
            NameFoodRamen.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            NameFoodRamen.Location = new Point(808, 536);
            NameFoodRamen.Name = "NameFoodRamen";
            NameFoodRamen.Size = new Size(67, 21);
            NameFoodRamen.TabIndex = 10;
            NameFoodRamen.Text = "Ramen ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(250, 247, 234);
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(702, 572);
            label3.Name = "label3";
            label3.Size = new Size(110, 21);
            label3.TabIndex = 11;
            label3.Text = "Price Food   : ";
            // 
            // PriceRamen
            // 
            PriceRamen.AutoSize = true;
            PriceRamen.BackColor = Color.FromArgb(250, 247, 234);
            PriceRamen.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PriceRamen.Location = new Point(810, 572);
            PriceRamen.Name = "PriceRamen";
            PriceRamen.Size = new Size(28, 21);
            PriceRamen.TabIndex = 12;
            PriceRamen.Text = "35";
            // 
            // buttonAddCartRamen
            // 
            buttonAddCartRamen.BackColor = Color.FromArgb(250, 247, 234);
            buttonAddCartRamen.Cursor = Cursors.Hand;
            buttonAddCartRamen.FlatAppearance.BorderColor = Color.White;
            buttonAddCartRamen.FlatAppearance.BorderSize = 0;
            buttonAddCartRamen.FlatAppearance.MouseDownBackColor = Color.White;
            buttonAddCartRamen.FlatAppearance.MouseOverBackColor = Color.White;
            buttonAddCartRamen.FlatStyle = FlatStyle.Popup;
            buttonAddCartRamen.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonAddCartRamen.ForeColor = Color.Black;
            buttonAddCartRamen.Location = new Point(702, 615);
            buttonAddCartRamen.Name = "buttonAddCartRamen";
            buttonAddCartRamen.Size = new Size(111, 35);
            buttonAddCartRamen.TabIndex = 13;
            buttonAddCartRamen.Text = "Add To Cart";
            buttonAddCartRamen.UseVisualStyleBackColor = false;
            buttonAddCartRamen.Click += buttonAddCartRamen_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.FromArgb(250, 247, 234);
            pictureBox3.BackgroundImage = (Image)resources.GetObject("pictureBox3.BackgroundImage");
            pictureBox3.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox3.Location = new Point(1032, 268);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(251, 237);
            pictureBox3.TabIndex = 14;
            pictureBox3.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(250, 247, 234);
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(1032, 536);
            label4.Name = "label4";
            label4.Size = new Size(114, 21);
            label4.TabIndex = 15;
            label4.Text = "Nmae Food  : ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.FromArgb(250, 247, 234);
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(1032, 577);
            label5.Name = "label5";
            label5.Size = new Size(114, 21);
            label5.TabIndex = 16;
            label5.Text = "Price Food    : ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.FromArgb(250, 247, 234);
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(1143, 536);
            label6.Name = "label6";
            label6.Size = new Size(111, 21);
            label6.TabIndex = 17;
            label6.Text = "Buddha Bowl";
            // 
            // PriceBuddha
            // 
            PriceBuddha.AutoSize = true;
            PriceBuddha.BackColor = Color.FromArgb(250, 247, 234);
            PriceBuddha.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PriceBuddha.Location = new Point(1152, 577);
            PriceBuddha.Name = "PriceBuddha";
            PriceBuddha.Size = new Size(28, 21);
            PriceBuddha.TabIndex = 18;
            PriceBuddha.Text = "25";
            // 
            // AddCartBuudha
            // 
            AddCartBuudha.BackColor = Color.FromArgb(250, 247, 234);
            AddCartBuudha.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AddCartBuudha.Location = new Point(1032, 615);
            AddCartBuudha.Name = "AddCartBuudha";
            AddCartBuudha.Size = new Size(122, 35);
            AddCartBuudha.TabIndex = 19;
            AddCartBuudha.Text = "Add To Cart";
            AddCartBuudha.UseVisualStyleBackColor = false;
            AddCartBuudha.Click += AddCartBuudha_Click;
            // 
            // Food_Price_Restuarant
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources._2;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(1512, 847);
            ControlBox = false;
            Controls.Add(AddCartBuudha);
            Controls.Add(PriceBuddha);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(pictureBox3);
            Controls.Add(buttonAddCartRamen);
            Controls.Add(PriceRamen);
            Controls.Add(label3);
            Controls.Add(NameFoodRamen);
            Controls.Add(label2);
            Controls.Add(pictureBox2);
            Controls.Add(button1);
            Controls.Add(buttonAddCart);
            Controls.Add(TotalPrice);
            Controls.Add(label1);
            Controls.Add(PriceTacos);
            Controls.Add(PriceFoodacos);
            Controls.Add(NameFoodOneTacos);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Food_Price_Restuarant";
            Text = "Food Price Restuarant";
            Load += Food_Price_Restuarant_Load;
            Move += Food_Price_Restuarant_Move;
            Resize += Food_Price_Restuarant_Resize;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label NameFoodOneTacos;
        private Label PriceFoodacos;
        private Label PriceTacos;
        private Label label1;
        private Label TotalPrice;
        private Button buttonAddCart;
        private Button button1;
        private PictureBox pictureBox2;
        private Label label2;
        private Label NameFoodRamen;
        private Label label3;
        private Label PriceRamen;
        private Button buttonAddCartRamen;
        private PictureBox pictureBox3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label PriceBuddha;
        private Button AddCartBuudha;
    }
}