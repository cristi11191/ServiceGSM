namespace ServiceGSMApp
{
    partial class doneform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(doneform));
            this.problems = new System.Windows.Forms.TextBox();
            this.probleme = new System.Windows.Forms.Label();
            this.details = new System.Windows.Forms.TextBox();
            this.detalii = new System.Windows.Forms.Label();
            this.price = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.model = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.mester = new System.Windows.Forms.ComboBox();
            this.text1 = new System.Windows.Forms.Label();
            this.dataprimb = new System.Windows.Forms.DateTimePicker();
            this.dataprim = new System.Windows.Forms.Label();
            this.garantieb = new System.Windows.Forms.TextBox();
            this.garantie = new System.Windows.Forms.Label();
            this.diagn = new System.Windows.Forms.CheckBox();
            this.total = new System.Windows.Forms.TextBox();
            this.totalt = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.save = new System.Windows.Forms.Button();
            this.guarantee = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // problems
            // 
            this.problems.Location = new System.Drawing.Point(205, 139);
            this.problems.Multiline = true;
            this.problems.Name = "problems";
            this.problems.Size = new System.Drawing.Size(155, 88);
            this.problems.TabIndex = 61;
            // 
            // probleme
            // 
            this.probleme.AutoSize = true;
            this.probleme.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.probleme.Location = new System.Drawing.Point(202, 120);
            this.probleme.Name = "probleme";
            this.probleme.Size = new System.Drawing.Size(100, 16);
            this.probleme.TabIndex = 60;
            this.probleme.Text = "Примечание";
            // 
            // details
            // 
            this.details.Location = new System.Drawing.Point(31, 139);
            this.details.Multiline = true;
            this.details.Name = "details";
            this.details.Size = new System.Drawing.Size(155, 88);
            this.details.TabIndex = 59;
            // 
            // detalii
            // 
            this.detalii.AutoSize = true;
            this.detalii.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.detalii.Location = new System.Drawing.Point(28, 120);
            this.detalii.Name = "detalii";
            this.detalii.Size = new System.Drawing.Size(129, 16);
            this.detalii.TabIndex = 58;
            this.detalii.Text = "Неисправности*";
            // 
            // price
            // 
            this.price.Location = new System.Drawing.Point(205, 279);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(155, 20);
            this.price.TabIndex = 57;
            this.price.TextChanged += new System.EventHandler(this.price_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(202, 256);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 16);
            this.label4.TabIndex = 56;
            this.label4.Text = "Цена*";
            // 
            // model
            // 
            this.model.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.model.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.model.Enabled = false;
            this.model.FormattingEnabled = true;
            this.model.Location = new System.Drawing.Point(205, 84);
            this.model.Name = "model";
            this.model.Size = new System.Drawing.Size(155, 21);
            this.model.TabIndex = 49;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(202, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 16);
            this.label1.TabIndex = 48;
            this.label1.Text = "Модель*";
            // 
            // mester
            // 
            this.mester.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.mester.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.mester.FormattingEnabled = true;
            this.mester.Location = new System.Drawing.Point(31, 84);
            this.mester.Name = "mester";
            this.mester.Size = new System.Drawing.Size(155, 21);
            this.mester.TabIndex = 43;
            // 
            // text1
            // 
            this.text1.AutoSize = true;
            this.text1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.text1.Location = new System.Drawing.Point(28, 65);
            this.text1.Name = "text1";
            this.text1.Size = new System.Drawing.Size(68, 16);
            this.text1.TabIndex = 42;
            this.text1.Text = "Мастер*";
            // 
            // dataprimb
            // 
            this.dataprimb.CustomFormat = "dd-MM-yyyy HH:mm";
            this.dataprimb.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dataprimb.Location = new System.Drawing.Point(31, 279);
            this.dataprimb.Name = "dataprimb";
            this.dataprimb.Size = new System.Drawing.Size(122, 20);
            this.dataprimb.TabIndex = 63;
            this.dataprimb.Value = new System.DateTime(2022, 10, 12, 0, 0, 0, 0);
            // 
            // dataprim
            // 
            this.dataprim.AutoSize = true;
            this.dataprim.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dataprim.Location = new System.Drawing.Point(28, 256);
            this.dataprim.Name = "dataprim";
            this.dataprim.Size = new System.Drawing.Size(110, 16);
            this.dataprim.TabIndex = 62;
            this.dataprim.Text = "Дата ремонта";
            // 
            // garantieb
            // 
            this.garantieb.Location = new System.Drawing.Point(31, 341);
            this.garantieb.Name = "garantieb";
            this.garantieb.Size = new System.Drawing.Size(155, 20);
            this.garantieb.TabIndex = 65;
            this.garantieb.Visible = false;
            // 
            // garantie
            // 
            this.garantie.AutoSize = true;
            this.garantie.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.garantie.Location = new System.Drawing.Point(28, 317);
            this.garantie.Name = "garantie";
            this.garantie.Size = new System.Drawing.Size(76, 16);
            this.garantie.TabIndex = 64;
            this.garantie.Text = "Гарантия";
            this.garantie.Visible = false;
            // 
            // diagn
            // 
            this.diagn.AutoSize = true;
            this.diagn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.diagn.Location = new System.Drawing.Point(377, 85);
            this.diagn.Name = "diagn";
            this.diagn.Size = new System.Drawing.Size(121, 20);
            this.diagn.TabIndex = 66;
            this.diagn.Text = "Диагностика";
            this.diagn.UseVisualStyleBackColor = true;
            this.diagn.CheckedChanged += new System.EventHandler(this.diagn_CheckedChanged);
            // 
            // total
            // 
            this.total.Location = new System.Drawing.Point(205, 341);
            this.total.Name = "total";
            this.total.Size = new System.Drawing.Size(155, 20);
            this.total.TabIndex = 68;
            // 
            // totalt
            // 
            this.totalt.AutoSize = true;
            this.totalt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.totalt.Location = new System.Drawing.Point(202, 317);
            this.totalt.Name = "totalt";
            this.totalt.Size = new System.Drawing.Size(51, 16);
            this.totalt.TabIndex = 67;
            this.totalt.Text = "Итого";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(157, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(229, 29);
            this.label5.TabIndex = 69;
            this.label5.Text = "Завершить Заказ";
            // 
            // save
            // 
            this.save.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.save.Location = new System.Drawing.Point(397, 336);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(122, 27);
            this.save.TabIndex = 70;
            this.save.Text = "Завершить";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // guarantee
            // 
            this.guarantee.AutoSize = true;
            this.guarantee.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.guarantee.Location = new System.Drawing.Point(31, 233);
            this.guarantee.Name = "guarantee";
            this.guarantee.Size = new System.Drawing.Size(95, 20);
            this.guarantee.TabIndex = 72;
            this.guarantee.Text = "Гарантия";
            this.guarantee.UseVisualStyleBackColor = true;
            this.guarantee.CheckedChanged += new System.EventHandler(this.guarantee_CheckedChanged);
            // 
            // doneform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 386);
            this.Controls.Add(this.guarantee);
            this.Controls.Add(this.save);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.total);
            this.Controls.Add(this.totalt);
            this.Controls.Add(this.diagn);
            this.Controls.Add(this.garantieb);
            this.Controls.Add(this.garantie);
            this.Controls.Add(this.dataprimb);
            this.Controls.Add(this.dataprim);
            this.Controls.Add(this.problems);
            this.Controls.Add(this.probleme);
            this.Controls.Add(this.details);
            this.Controls.Add(this.detalii);
            this.Controls.Add(this.price);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.model);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mester);
            this.Controls.Add(this.text1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "doneform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "doneform";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.doneform_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label probleme;
        private System.Windows.Forms.Label detalii;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox mester;
        private System.Windows.Forms.Label text1;
        private System.Windows.Forms.DateTimePicker dataprimb;
        private System.Windows.Forms.Label dataprim;
        private System.Windows.Forms.TextBox garantieb;
        private System.Windows.Forms.Label garantie;
        private System.Windows.Forms.CheckBox diagn;
        private System.Windows.Forms.Label totalt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button save;
        public System.Windows.Forms.ComboBox model;
        public System.Windows.Forms.TextBox total;
        public System.Windows.Forms.TextBox problems;
        public System.Windows.Forms.TextBox details;
        public System.Windows.Forms.TextBox price;
        private System.Windows.Forms.CheckBox guarantee;
    }
}