namespace ShopStore
{
    partial class Main
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.label1 = new System.Windows.Forms.Label();
            this.linkLable_login = new System.Windows.Forms.LinkLabel();
            this.dataGridView_Books = new System.Windows.Forms.DataGridView();
            this.cmbBox_SortBy = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_SignOut = new System.Windows.Forms.Button();
            this.btn_Buy = new System.Windows.Forms.Button();
            this.btn_AddToCart = new System.Windows.Forms.Button();
            this.dataGridView_Cart = new System.Windows.Forms.DataGridView();
            this.pictureBox_Cart = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtBox_Phone = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lbl_Price = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBox_Post = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBox_City = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_BookForBuy = new System.Windows.Forms.Label();
            this.btn_MakeOrder = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Books)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Cart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Cart)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(844, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sign in as";
            // 
            // linkLable_login
            // 
            this.linkLable_login.AutoSize = true;
            this.linkLable_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.linkLable_login.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkLable_login.LinkColor = System.Drawing.Color.Blue;
            this.linkLable_login.Location = new System.Drawing.Point(844, 25);
            this.linkLable_login.Name = "linkLable_login";
            this.linkLable_login.Size = new System.Drawing.Size(0, 16);
            this.linkLable_login.TabIndex = 1;
            // 
            // dataGridView_Books
            // 
            this.dataGridView_Books.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Books.Location = new System.Drawing.Point(15, 242);
            this.dataGridView_Books.Name = "dataGridView_Books";
            this.dataGridView_Books.Size = new System.Drawing.Size(895, 304);
            this.dataGridView_Books.TabIndex = 2;
            // 
            // cmbBox_SortBy
            // 
            this.cmbBox_SortBy.FormattingEnabled = true;
            this.cmbBox_SortBy.Location = new System.Drawing.Point(789, 204);
            this.cmbBox_SortBy.Name = "cmbBox_SortBy";
            this.cmbBox_SortBy.Size = new System.Drawing.Size(121, 21);
            this.cmbBox_SortBy.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(733, 205);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Sort by";
            // 
            // btn_SignOut
            // 
            this.btn_SignOut.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btn_SignOut.Location = new System.Drawing.Point(844, 44);
            this.btn_SignOut.Name = "btn_SignOut";
            this.btn_SignOut.Size = new System.Drawing.Size(75, 23);
            this.btn_SignOut.TabIndex = 5;
            this.btn_SignOut.Text = "Sign out";
            this.btn_SignOut.UseVisualStyleBackColor = true;
            this.btn_SignOut.Click += new System.EventHandler(this.btn_SignOut_Click);
            // 
            // btn_Buy
            // 
            this.btn_Buy.BackColor = System.Drawing.Color.Green;
            this.btn_Buy.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_Buy.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_Buy.Location = new System.Drawing.Point(591, 196);
            this.btn_Buy.Name = "btn_Buy";
            this.btn_Buy.Size = new System.Drawing.Size(135, 40);
            this.btn_Buy.TabIndex = 6;
            this.btn_Buy.Text = "Buy";
            this.btn_Buy.UseVisualStyleBackColor = false;
            this.btn_Buy.Visible = false;
            this.btn_Buy.Click += new System.EventHandler(this.btn_Buy_Click);
            // 
            // btn_AddToCart
            // 
            this.btn_AddToCart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_AddToCart.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_AddToCart.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_AddToCart.Location = new System.Drawing.Point(12, 190);
            this.btn_AddToCart.Name = "btn_AddToCart";
            this.btn_AddToCart.Size = new System.Drawing.Size(135, 40);
            this.btn_AddToCart.TabIndex = 7;
            this.btn_AddToCart.Text = "Add to cart";
            this.btn_AddToCart.UseVisualStyleBackColor = false;
            this.btn_AddToCart.Click += new System.EventHandler(this.btn_AddToCart_Click);
            // 
            // dataGridView_Cart
            // 
            this.dataGridView_Cart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Cart.Location = new System.Drawing.Point(12, 44);
            this.dataGridView_Cart.Name = "dataGridView_Cart";
            this.dataGridView_Cart.Size = new System.Drawing.Size(218, 140);
            this.dataGridView_Cart.TabIndex = 8;
            this.dataGridView_Cart.Visible = false;
            // 
            // pictureBox_Cart
            // 
            this.pictureBox_Cart.Image = global::ShopStore.Properties.Resources.cart;
            this.pictureBox_Cart.Location = new System.Drawing.Point(15, 5);
            this.pictureBox_Cart.Name = "pictureBox_Cart";
            this.pictureBox_Cart.Size = new System.Drawing.Size(38, 36);
            this.pictureBox_Cart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Cart.TabIndex = 10;
            this.pictureBox_Cart.TabStop = false;
            this.pictureBox_Cart.Click += new System.EventHandler(this.pictureBox_Cart_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Silver;
            this.groupBox1.Controls.Add(this.txtBox_Phone);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.lbl_Price);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtBox_Post);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtBox_City);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lbl_BookForBuy);
            this.groupBox1.Location = new System.Drawing.Point(249, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(478, 178);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Checkout";
            this.groupBox1.Visible = false;
            // 
            // txtBox_Phone
            // 
            this.txtBox_Phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtBox_Phone.Location = new System.Drawing.Point(10, 144);
            this.txtBox_Phone.Name = "txtBox_Phone";
            this.txtBox_Phone.Size = new System.Drawing.Size(193, 26);
            this.txtBox_Phone.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(6, 121);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = "Phone number";
            // 
            // lbl_Price
            // 
            this.lbl_Price.AutoSize = true;
            this.lbl_Price.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_Price.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lbl_Price.Location = new System.Drawing.Point(349, 141);
            this.lbl_Price.Name = "lbl_Price";
            this.lbl_Price.Size = new System.Drawing.Size(0, 31);
            this.lbl_Price.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(238, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 31);
            this.label5.TabIndex = 5;
            this.label5.Text = "Price: ";
            // 
            // txtBox_Post
            // 
            this.txtBox_Post.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtBox_Post.Location = new System.Drawing.Point(10, 92);
            this.txtBox_Post.Name = "txtBox_Post";
            this.txtBox_Post.Size = new System.Drawing.Size(193, 26);
            this.txtBox_Post.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(6, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(160, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Post office number";
            // 
            // txtBox_City
            // 
            this.txtBox_City.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtBox_City.Location = new System.Drawing.Point(6, 40);
            this.txtBox_City.Name = "txtBox_City";
            this.txtBox_City.Size = new System.Drawing.Size(193, 26);
            this.txtBox_City.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(2, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "City";
            // 
            // lbl_BookForBuy
            // 
            this.lbl_BookForBuy.AutoSize = true;
            this.lbl_BookForBuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_BookForBuy.Location = new System.Drawing.Point(240, 112);
            this.lbl_BookForBuy.Name = "lbl_BookForBuy";
            this.lbl_BookForBuy.Size = new System.Drawing.Size(57, 20);
            this.lbl_BookForBuy.TabIndex = 0;
            this.lbl_BookForBuy.Text = "label3";
            // 
            // btn_MakeOrder
            // 
            this.btn_MakeOrder.BackColor = System.Drawing.Color.Green;
            this.btn_MakeOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_MakeOrder.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_MakeOrder.Location = new System.Drawing.Point(74, 5);
            this.btn_MakeOrder.Name = "btn_MakeOrder";
            this.btn_MakeOrder.Size = new System.Drawing.Size(135, 36);
            this.btn_MakeOrder.TabIndex = 12;
            this.btn_MakeOrder.Text = "Order";
            this.btn_MakeOrder.UseVisualStyleBackColor = false;
            this.btn_MakeOrder.Visible = false;
            this.btn_MakeOrder.Click += new System.EventHandler(this.btn_MakeOrder_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 558);
            this.Controls.Add(this.btn_MakeOrder);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox_Cart);
            this.Controls.Add(this.dataGridView_Cart);
            this.Controls.Add(this.btn_AddToCart);
            this.Controls.Add(this.btn_Buy);
            this.Controls.Add(this.btn_SignOut);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbBox_SortBy);
            this.Controls.Add(this.dataGridView_Books);
            this.Controls.Add(this.linkLable_login);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.Text = "Book Store";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Books)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Cart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Cart)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkLable_login;
        private System.Windows.Forms.DataGridView dataGridView_Books;
        private System.Windows.Forms.ComboBox cmbBox_SortBy;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_SignOut;
        private System.Windows.Forms.Button btn_Buy;
        private System.Windows.Forms.Button btn_AddToCart;
        private System.Windows.Forms.DataGridView dataGridView_Cart;
        private System.Windows.Forms.PictureBox pictureBox_Cart;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbl_Price;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBox_Post;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBox_City;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_BookForBuy;
        private System.Windows.Forms.TextBox txtBox_Phone;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_MakeOrder;
    }
}

