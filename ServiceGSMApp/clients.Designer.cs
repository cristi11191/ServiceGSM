namespace ServiceGSMApp
{
    partial class clients
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(clients));
            this.clientsgrid = new System.Windows.Forms.DataGridView();
            this.delete = new System.Windows.Forms.Button();
            this.adding = new System.Windows.Forms.Button();
            this.client = new System.Windows.Forms.TextBox();
            this.text2 = new System.Windows.Forms.Label();
            this.number = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.clearlist = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.clientsgrid)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // clientsgrid
            // 
            this.clientsgrid.AllowUserToAddRows = false;
            this.clientsgrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.clientsgrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.clientsgrid.Location = new System.Drawing.Point(6, 6);
            this.clientsgrid.Name = "clientsgrid";
            this.clientsgrid.Size = new System.Drawing.Size(343, 440);
            this.clientsgrid.TabIndex = 2;
            this.clientsgrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.clientsgrid_CellClick);
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(37, 172);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(128, 24);
            this.delete.TabIndex = 90;
            this.delete.Text = "Удалить";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // adding
            // 
            this.adding.Location = new System.Drawing.Point(37, 140);
            this.adding.Name = "adding";
            this.adding.Size = new System.Drawing.Size(128, 26);
            this.adding.TabIndex = 20;
            this.adding.Text = "Добавить";
            this.adding.UseVisualStyleBackColor = true;
            this.adding.Click += new System.EventHandler(this.adding_Click);
            // 
            // client
            // 
            this.client.Location = new System.Drawing.Point(10, 50);
            this.client.Name = "client";
            this.client.Size = new System.Drawing.Size(176, 20);
            this.client.TabIndex = 18;
            // 
            // text2
            // 
            this.text2.AutoSize = true;
            this.text2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.text2.Location = new System.Drawing.Point(67, 31);
            this.text2.Name = "text2";
            this.text2.Size = new System.Drawing.Size(60, 16);
            this.text2.TabIndex = 17;
            this.text2.Text = "Клиент";
            // 
            // number
            // 
            this.number.Location = new System.Drawing.Point(10, 101);
            this.number.Name = "number";
            this.number.Size = new System.Drawing.Size(176, 20);
            this.number.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(60, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 16);
            this.label1.TabIndex = 21;
            this.label1.Text = "Телефон";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.BurlyWood;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.clearlist);
            this.panel1.Controls.Add(this.delete);
            this.panel1.Controls.Add(this.number);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.text2);
            this.panel1.Controls.Add(this.client);
            this.panel1.Controls.Add(this.adding);
            this.panel1.Location = new System.Drawing.Point(345, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(206, 439);
            this.panel1.TabIndex = 91;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(58, 417);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 9);
            this.label3.TabIndex = 92;
            this.label3.Text = "Только для Администраций";
            // 
            // clearlist
            // 
            this.clearlist.Location = new System.Drawing.Point(57, 396);
            this.clearlist.Name = "clearlist";
            this.clearlist.Size = new System.Drawing.Size(108, 22);
            this.clearlist.TabIndex = 91;
            this.clearlist.Text = "Очистить список";
            this.clearlist.UseVisualStyleBackColor = true;
            this.clearlist.Click += new System.EventHandler(this.clearlist_Click);
            // 
            // clients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.ClientSize = new System.Drawing.Size(558, 452);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.clientsgrid);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "clients";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "clients";
            this.Load += new System.EventHandler(this.clients_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.clients_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.clientsgrid)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView clientsgrid;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button adding;
        private System.Windows.Forms.TextBox client;
        private System.Windows.Forms.Label text2;
        private System.Windows.Forms.TextBox number;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button clearlist;
        private System.Windows.Forms.Label label3;
    }
}