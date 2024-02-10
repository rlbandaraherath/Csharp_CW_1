namespace CW_1
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.administrator_loginbtn = new System.Windows.Forms.Button();
            this.customer_loginbtn = new System.Windows.Forms.Button();
            this.customer_signupbtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.linkourfeet = new System.Windows.Forms.LinkLabel();
            this.lnkcustomerd = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // administrator_loginbtn
            // 
            this.administrator_loginbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.administrator_loginbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.administrator_loginbtn.Location = new System.Drawing.Point(10, 219);
            this.administrator_loginbtn.Name = "administrator_loginbtn";
            this.administrator_loginbtn.Size = new System.Drawing.Size(167, 32);
            this.administrator_loginbtn.TabIndex = 0;
            this.administrator_loginbtn.Text = "Administrator Login";
            this.administrator_loginbtn.UseVisualStyleBackColor = false;
            this.administrator_loginbtn.Click += new System.EventHandler(this.administrator_loginbtn_Click);
            // 
            // customer_loginbtn
            // 
            this.customer_loginbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.customer_loginbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customer_loginbtn.Location = new System.Drawing.Point(10, 257);
            this.customer_loginbtn.Name = "customer_loginbtn";
            this.customer_loginbtn.Size = new System.Drawing.Size(167, 33);
            this.customer_loginbtn.TabIndex = 1;
            this.customer_loginbtn.Text = "Customer Login";
            this.customer_loginbtn.UseVisualStyleBackColor = false;
            this.customer_loginbtn.Click += new System.EventHandler(this.customer_loginbtn_Click);
            // 
            // customer_signupbtn
            // 
            this.customer_signupbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.customer_signupbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customer_signupbtn.Location = new System.Drawing.Point(10, 296);
            this.customer_signupbtn.Name = "customer_signupbtn";
            this.customer_signupbtn.Size = new System.Drawing.Size(167, 30);
            this.customer_signupbtn.TabIndex = 2;
            this.customer_signupbtn.Text = "New Customer Signup";
            this.customer_signupbtn.UseVisualStyleBackColor = false;
            this.customer_signupbtn.Click += new System.EventHandler(this.button3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(52, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 50);
            this.label2.TabIndex = 4;
            this.label2.Text = "E-Shift";
            // 
            // linkourfeet
            // 
            this.linkourfeet.AutoSize = true;
            this.linkourfeet.BackColor = System.Drawing.Color.PowderBlue;
            this.linkourfeet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkourfeet.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.linkourfeet.Location = new System.Drawing.Point(520, 270);
            this.linkourfeet.Name = "linkourfeet";
            this.linkourfeet.Size = new System.Drawing.Size(149, 16);
            this.linkourfeet.TabIndex = 6;
            this.linkourfeet.TabStop = true;
            this.linkourfeet.Text = "Our Fleet and Discounts";
            this.linkourfeet.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkourfeet_LinkClicked);
            // 
            // lnkcustomerd
            // 
            this.lnkcustomerd.AutoSize = true;
            this.lnkcustomerd.BackColor = System.Drawing.Color.PowderBlue;
            this.lnkcustomerd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkcustomerd.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lnkcustomerd.Location = new System.Drawing.Point(555, 303);
            this.lnkcustomerd.Name = "lnkcustomerd";
            this.lnkcustomerd.Size = new System.Drawing.Size(112, 16);
            this.lnkcustomerd.TabIndex = 7;
            this.lnkcustomerd.TabStop = true;
            this.lnkcustomerd.Text = " Customer Details";
            this.lnkcustomerd.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkcustomerd_LinkClicked);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Myanmar Text", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(6, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(232, 46);
            this.label3.TabIndex = 10;
            this.label3.Text = "             The Most Affodable\r\nHouseHold Goods Transfering service";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(54, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 50);
            this.label4.TabIndex = 4;
            this.label4.Text = "E-Shift";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Myanmar Text", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(8, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(232, 46);
            this.label5.TabIndex = 10;
            this.label5.Text = "             The Most Affodable\r\nHouseHold Goods Transfering service";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Monotype Corsiva", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(558, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 28);
            this.label6.TabIndex = 11;
            this.label6.Text = "Please Login to Apply\r\nFor a New Job Request";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.Color.PowderBlue;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.linkLabel1.Location = new System.Drawing.Point(563, 235);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(104, 16);
            this.linkLabel1.TabIndex = 12;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Packing Experts";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cyan;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(679, 344);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lnkcustomerd);
            this.Controls.Add(this.linkourfeet);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.customer_signupbtn);
            this.Controls.Add(this.customer_loginbtn);
            this.Controls.Add(this.administrator_loginbtn);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Welcome To  E-Shift";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button administrator_loginbtn;
        private System.Windows.Forms.Button customer_loginbtn;
        private System.Windows.Forms.Button customer_signupbtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel linkourfeet;
        private System.Windows.Forms.LinkLabel lnkcustomerd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}

