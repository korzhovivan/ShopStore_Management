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
            this.Cart = new System.Windows.Forms.Label();
            this.pictureBox_Cart = new System.Windows.Forms.PictureBox();
            this.btn_BuyFromCart = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Books)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Cart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Cart)).BeginInit();
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
            this.btn_Buy.Location = new System.Drawing.Point(592, 196);
            this.btn_Buy.Name = "btn_Buy";
            this.btn_Buy.Size = new System.Drawing.Size(135, 40);
            this.btn_Buy.TabIndex = 6;
            this.btn_Buy.Text = "Buy";
            this.btn_Buy.UseVisualStyleBackColor = false;
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
            // 
            // Cart
            // 
            this.Cart.AutoSize = true;
            this.Cart.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Cart.Location = new System.Drawing.Point(44, 2);
            this.Cart.Name = "Cart";
            this.Cart.Size = new System.Drawing.Size(83, 39);
            this.Cart.TabIndex = 9;
            this.Cart.Text = "Cart";
            // 
            // pictureBox_Cart
            // 
            this.pictureBox_Cart.Image = global::ShopStore.Properties.Resources.cart;
            this.pictureBox_Cart.Location = new System.Drawing.Point(122, 5);
            this.pictureBox_Cart.Name = "pictureBox_Cart";
            this.pictureBox_Cart.Size = new System.Drawing.Size(38, 36);
            this.pictureBox_Cart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Cart.TabIndex = 10;
            this.pictureBox_Cart.TabStop = false;
            // 
            // btn_BuyFromCart
            // 
            this.btn_BuyFromCart.BackColor = System.Drawing.Color.Green;
            this.btn_BuyFromCart.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_BuyFromCart.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_BuyFromCart.Location = new System.Drawing.Point(236, 44);
            this.btn_BuyFromCart.Name = "btn_BuyFromCart";
            this.btn_BuyFromCart.Size = new System.Drawing.Size(135, 40);
            this.btn_BuyFromCart.TabIndex = 11;
            this.btn_BuyFromCart.Text = "Buy";
            this.btn_BuyFromCart.UseVisualStyleBackColor = false;
            this.btn_BuyFromCart.Click += new System.EventHandler(this.btn_BuyFromCart_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 558);
            this.Controls.Add(this.btn_BuyFromCart);
            this.Controls.Add(this.pictureBox_Cart);
            this.Controls.Add(this.Cart);
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
        private System.Windows.Forms.Label Cart;
        private System.Windows.Forms.PictureBox pictureBox_Cart;
        private System.Windows.Forms.Button btn_BuyFromCart;
    }
}

