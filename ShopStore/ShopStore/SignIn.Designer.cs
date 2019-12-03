namespace ShopStore
{
    partial class SignIn
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignIn));
            this.btn_SignIn = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.pictureBox_logo = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBox_login = new System.Windows.Forms.TextBox();
            this.txtBox_password = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_logo)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_SignIn
            // 
            this.btn_SignIn.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_SignIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.btn_SignIn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_SignIn.Location = new System.Drawing.Point(68, 301);
            this.btn_SignIn.Name = "btn_SignIn";
            this.btn_SignIn.Size = new System.Drawing.Size(111, 32);
            this.btn_SignIn.TabIndex = 0;
            this.btn_SignIn.Text = "Sign in";
            this.btn_SignIn.UseVisualStyleBackColor = false;
            this.btn_SignIn.Click += new System.EventHandler(this.Btn_SignIn_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // pictureBox_logo
            // 
            this.pictureBox_logo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_logo.Image")));
            this.pictureBox_logo.Location = new System.Drawing.Point(12, 2);
            this.pictureBox_logo.Name = "pictureBox_logo";
            this.pictureBox_logo.Size = new System.Drawing.Size(214, 123);
            this.pictureBox_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_logo.TabIndex = 2;
            this.pictureBox_logo.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.label1.Location = new System.Drawing.Point(12, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Enter login:";
            // 
            // txtBox_login
            // 
            this.txtBox_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.txtBox_login.Location = new System.Drawing.Point(17, 170);
            this.txtBox_login.Name = "txtBox_login";
            this.txtBox_login.Size = new System.Drawing.Size(209, 31);
            this.txtBox_login.TabIndex = 4;
            // 
            // txtBox_password
            // 
            this.txtBox_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.txtBox_password.Location = new System.Drawing.Point(17, 231);
            this.txtBox_password.Name = "txtBox_password";
            this.txtBox_password.Size = new System.Drawing.Size(209, 31);
            this.txtBox_password.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.label2.Location = new System.Drawing.Point(12, 203);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Enter password:";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(14, 278);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(62, 13);
            this.linkLabel1.TabIndex = 7;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Create one!";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 265);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "No account?";
            // 
            // SignIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(232, 344);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.txtBox_password);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBox_login);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox_logo);
            this.Controls.Add(this.btn_SignIn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SignIn";
            this.Text = "Sign in";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_SignIn;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.PictureBox pictureBox_logo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBox_login;
        private System.Windows.Forms.TextBox txtBox_password;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label3;
    }
}