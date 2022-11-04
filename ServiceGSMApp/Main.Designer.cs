namespace ServiceGSMApp
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
            this.dbconnection = new System.Windows.Forms.Label();
            this.orderspic = new System.Windows.Forms.PictureBox();
            this.generalpic = new System.Windows.Forms.PictureBox();
            this.settingspic = new System.Windows.Forms.PictureBox();
            this.exit = new System.Windows.Forms.PictureBox();
            this.exit_txt = new System.Windows.Forms.Label();
            this.testings = new System.Windows.Forms.Button();
            this.orders = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.settings = new System.Windows.Forms.Button();
            this.dbselect = new System.Windows.Forms.Button();
            this.test1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.orderspic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.generalpic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.settingspic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exit)).BeginInit();
            this.SuspendLayout();
            // 
            // dbconnection
            // 
            this.dbconnection.AutoSize = true;
            this.dbconnection.BackColor = System.Drawing.Color.Transparent;
            this.dbconnection.ForeColor = System.Drawing.Color.Black;
            this.dbconnection.Location = new System.Drawing.Point(12, 9);
            this.dbconnection.Name = "dbconnection";
            this.dbconnection.Size = new System.Drawing.Size(29, 13);
            this.dbconnection.TabIndex = 2;
            this.dbconnection.Text = "БД: ";
            this.dbconnection.Click += new System.EventHandler(this.dbconnection_Click);
            // 
            // orderspic
            // 
            this.orderspic.Image = ((System.Drawing.Image)(resources.GetObject("orderspic.Image")));
            this.orderspic.Location = new System.Drawing.Point(15, 25);
            this.orderspic.Name = "orderspic";
            this.orderspic.Size = new System.Drawing.Size(48, 37);
            this.orderspic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.orderspic.TabIndex = 10;
            this.orderspic.TabStop = false;
            this.orderspic.Click += new System.EventHandler(this.orderspic_Click);
            // 
            // generalpic
            // 
            this.generalpic.Image = ((System.Drawing.Image)(resources.GetObject("generalpic.Image")));
            this.generalpic.Location = new System.Drawing.Point(15, 112);
            this.generalpic.Name = "generalpic";
            this.generalpic.Size = new System.Drawing.Size(48, 37);
            this.generalpic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.generalpic.TabIndex = 13;
            this.generalpic.TabStop = false;
            // 
            // settingspic
            // 
            this.settingspic.Image = ((System.Drawing.Image)(resources.GetObject("settingspic.Image")));
            this.settingspic.Location = new System.Drawing.Point(15, 69);
            this.settingspic.Name = "settingspic";
            this.settingspic.Size = new System.Drawing.Size(48, 37);
            this.settingspic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.settingspic.TabIndex = 14;
            this.settingspic.TabStop = false;
            this.settingspic.Click += new System.EventHandler(this.settingspic_Click);
            // 
            // exit
            // 
            this.exit.Image = ((System.Drawing.Image)(resources.GetObject("exit.Image")));
            this.exit.Location = new System.Drawing.Point(240, 169);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(34, 24);
            this.exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.exit.TabIndex = 15;
            this.exit.TabStop = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            this.exit.MouseEnter += new System.EventHandler(this.exit_MouseEnter);
            this.exit.MouseLeave += new System.EventHandler(this.exit_MouseLeave);
            // 
            // exit_txt
            // 
            this.exit_txt.AutoSize = true;
            this.exit_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exit_txt.Location = new System.Drawing.Point(237, 193);
            this.exit_txt.Name = "exit_txt";
            this.exit_txt.Size = new System.Drawing.Size(39, 13);
            this.exit_txt.TabIndex = 16;
            this.exit_txt.Text = "Выйти";
            this.exit_txt.Visible = false;
            // 
            // testings
            // 
            this.testings.Location = new System.Drawing.Point(2, 178);
            this.testings.Name = "testings";
            this.testings.Size = new System.Drawing.Size(80, 28);
            this.testings.TabIndex = 19;
            this.testings.Text = "Админ тест";
            this.testings.UseVisualStyleBackColor = true;
            this.testings.Click += new System.EventHandler(this.testings_Click);
            // 
            // orders
            // 
            this.orders.Location = new System.Drawing.Point(73, 34);
            this.orders.Name = "orders";
            this.orders.Size = new System.Drawing.Size(136, 28);
            this.orders.TabIndex = 20;
            this.orders.Text = "Заказы";
            this.orders.UseVisualStyleBackColor = true;
            this.orders.Click += new System.EventHandler(this.orders_Click);
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(73, 121);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 28);
            this.button1.TabIndex = 21;
            this.button1.Text = "Отчёты";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // settings
            // 
            this.settings.Location = new System.Drawing.Point(73, 78);
            this.settings.Name = "settings";
            this.settings.Size = new System.Drawing.Size(136, 28);
            this.settings.TabIndex = 22;
            this.settings.Text = "Настройки";
            this.settings.UseVisualStyleBackColor = true;
            this.settings.Click += new System.EventHandler(this.settings_Click);
            // 
            // dbselect
            // 
            this.dbselect.Location = new System.Drawing.Point(152, 4);
            this.dbselect.Name = "dbselect";
            this.dbselect.Size = new System.Drawing.Size(43, 23);
            this.dbselect.TabIndex = 23;
            this.dbselect.Text = "button2";
            this.dbselect.UseVisualStyleBackColor = true;
            this.dbselect.Visible = false;
            this.dbselect.Click += new System.EventHandler(this.dbselect_Click);
            // 
            // test1
            // 
            this.test1.AutoSize = true;
            this.test1.Location = new System.Drawing.Point(111, 9);
            this.test1.Name = "test1";
            this.test1.Size = new System.Drawing.Size(35, 13);
            this.test1.TabIndex = 24;
            this.test1.Text = "label1";
            this.test1.Visible = false;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(282, 211);
            this.Controls.Add(this.test1);
            this.Controls.Add(this.dbselect);
            this.Controls.Add(this.settings);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.orders);
            this.Controls.Add(this.testings);
            this.Controls.Add(this.exit_txt);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.settingspic);
            this.Controls.Add(this.generalpic);
            this.Controls.Add(this.orderspic);
            this.Controls.Add(this.dbconnection);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.Load += new System.EventHandler(this.Main_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Main_KeyDown);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Main_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Main_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.orderspic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.generalpic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.settingspic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label dbconnection;
        private System.Windows.Forms.PictureBox orderspic;
        private System.Windows.Forms.PictureBox generalpic;
        private System.Windows.Forms.PictureBox settingspic;
        private System.Windows.Forms.PictureBox exit;
        private System.Windows.Forms.Label exit_txt;
        private System.Windows.Forms.Button testings;
        private System.Windows.Forms.Button orders;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button settings;
        private System.Windows.Forms.Button dbselect;
        private System.Windows.Forms.Label test1;
    }
}

