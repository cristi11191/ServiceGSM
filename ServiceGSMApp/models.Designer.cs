namespace ServiceGSMApp
{
    partial class models
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(models));
            this.modelsgrid = new System.Windows.Forms.DataGridView();
            this.model = new System.Windows.Forms.TextBox();
            this.text2 = new System.Windows.Forms.Label();
            this.adding = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.clearlist = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.modelsgrid)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // modelsgrid
            // 
            this.modelsgrid.AllowUserToAddRows = false;
            this.modelsgrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.modelsgrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.modelsgrid.Location = new System.Drawing.Point(5, 6);
            this.modelsgrid.Name = "modelsgrid";
            this.modelsgrid.Size = new System.Drawing.Size(223, 331);
            this.modelsgrid.TabIndex = 1;
            this.modelsgrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.modelsgrid_CellClick);
            // 
            // model
            // 
            this.model.Location = new System.Drawing.Point(4, 33);
            this.model.Name = "model";
            this.model.Size = new System.Drawing.Size(203, 20);
            this.model.TabIndex = 14;
            // 
            // text2
            // 
            this.text2.AutoSize = true;
            this.text2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.text2.Location = new System.Drawing.Point(74, 14);
            this.text2.Name = "text2";
            this.text2.Size = new System.Drawing.Size(63, 16);
            this.text2.TabIndex = 13;
            this.text2.Text = "Модель";
            // 
            // adding
            // 
            this.adding.Location = new System.Drawing.Point(51, 65);
            this.adding.Name = "adding";
            this.adding.Size = new System.Drawing.Size(108, 22);
            this.adding.TabIndex = 15;
            this.adding.Text = "Добавить";
            this.adding.UseVisualStyleBackColor = true;
            this.adding.Click += new System.EventHandler(this.adding_Click);
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(51, 93);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(108, 22);
            this.delete.TabIndex = 16;
            this.delete.Text = "Удалить";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.clearlist);
            this.panel1.Controls.Add(this.delete);
            this.panel1.Controls.Add(this.text2);
            this.panel1.Controls.Add(this.adding);
            this.panel1.Controls.Add(this.model);
            this.panel1.Location = new System.Drawing.Point(230, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(210, 331);
            this.panel1.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(52, 311);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 9);
            this.label3.TabIndex = 94;
            this.label3.Text = "Только для Администраций";
            // 
            // clearlist
            // 
            this.clearlist.Location = new System.Drawing.Point(51, 290);
            this.clearlist.Name = "clearlist";
            this.clearlist.Size = new System.Drawing.Size(108, 22);
            this.clearlist.TabIndex = 93;
            this.clearlist.Text = "Очистить список";
            this.clearlist.UseVisualStyleBackColor = true;
            this.clearlist.Click += new System.EventHandler(this.clearlist_Click);
            // 
            // models
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.ClientSize = new System.Drawing.Size(446, 342);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.modelsgrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "models";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "modelsandnames";
            this.Load += new System.EventHandler(this.models_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.models_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.modelsgrid)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView modelsgrid;
        private System.Windows.Forms.TextBox model;
        private System.Windows.Forms.Label text2;
        private System.Windows.Forms.Button adding;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button clearlist;
    }
}