namespace ServiceGSMApp
{
    partial class Add
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add));
            this.addbtn = new System.Windows.Forms.Button();
            this.cancelbtn = new System.Windows.Forms.Button();
            this.text1 = new System.Windows.Forms.Label();
            this.receipt = new System.Windows.Forms.ComboBox();
            this.imei = new System.Windows.Forms.TextBox();
            this.text2 = new System.Windows.Forms.Label();
            this.model = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataprimb = new System.Windows.Forms.DateTimePicker();
            this.dataprim = new System.Windows.Forms.Label();
            this.price = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.details = new System.Windows.Forms.TextBox();
            this.detalii = new System.Windows.Forms.Label();
            this.problems = new System.Windows.Forms.TextBox();
            this.probleme = new System.Windows.Forms.Label();
            this.scratches = new System.Windows.Forms.CheckBox();
            this.charger = new System.Windows.Forms.CheckBox();
            this.reaction = new System.Windows.Forms.CheckBox();
            this.water = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.sett = new System.Windows.Forms.Button();
            this.contact = new System.Windows.Forms.ComboBox();
            this.clientbtn = new System.Windows.Forms.Button();
            this.modelbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addbtn
            // 
            this.addbtn.Location = new System.Drawing.Point(147, 359);
            this.addbtn.Name = "addbtn";
            this.addbtn.Size = new System.Drawing.Size(118, 23);
            this.addbtn.TabIndex = 0;
            this.addbtn.Text = "Добавить";
            this.addbtn.UseVisualStyleBackColor = true;
            this.addbtn.Click += new System.EventHandler(this.addbtn_Click);
            // 
            // cancelbtn
            // 
            this.cancelbtn.Location = new System.Drawing.Point(393, 359);
            this.cancelbtn.Name = "cancelbtn";
            this.cancelbtn.Size = new System.Drawing.Size(118, 23);
            this.cancelbtn.TabIndex = 1;
            this.cancelbtn.Text = "Отменить";
            this.cancelbtn.UseVisualStyleBackColor = true;
            this.cancelbtn.Click += new System.EventHandler(this.cancelbtn_Click);
            // 
            // text1
            // 
            this.text1.AutoSize = true;
            this.text1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.text1.Location = new System.Drawing.Point(26, 48);
            this.text1.Name = "text1";
            this.text1.Size = new System.Drawing.Size(82, 16);
            this.text1.TabIndex = 7;
            this.text1.Text = "Приемщик";
            // 
            // receipt
            // 
            this.receipt.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.receipt.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.receipt.FormattingEnabled = true;
            this.receipt.Location = new System.Drawing.Point(29, 67);
            this.receipt.Name = "receipt";
            this.receipt.Size = new System.Drawing.Size(159, 21);
            this.receipt.TabIndex = 8;
            // 
            // imei
            // 
            this.imei.Location = new System.Drawing.Point(33, 171);
            this.imei.MaxLength = 5;
            this.imei.Name = "imei";
            this.imei.Size = new System.Drawing.Size(155, 20);
            this.imei.TabIndex = 12;
            this.imei.TextChanged += new System.EventHandler(this.imei_TextChanged);
            // 
            // text2
            // 
            this.text2.AutoSize = true;
            this.text2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.text2.Location = new System.Drawing.Point(30, 152);
            this.text2.Name = "text2";
            this.text2.Size = new System.Drawing.Size(37, 16);
            this.text2.TabIndex = 11;
            this.text2.Text = "IMEI";
            // 
            // model
            // 
            this.model.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.model.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.model.FormattingEnabled = true;
            this.model.Location = new System.Drawing.Point(232, 67);
            this.model.Name = "model";
            this.model.Size = new System.Drawing.Size(155, 21);
            this.model.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(229, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 16);
            this.label1.TabIndex = 13;
            this.label1.Text = "Модель*";
            // 
            // name
            // 
            this.name.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.name.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.name.FormattingEnabled = true;
            this.name.Location = new System.Drawing.Point(232, 120);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(155, 21);
            this.name.TabIndex = 16;
            this.name.SelectedIndexChanged += new System.EventHandler(this.name_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(229, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 16);
            this.label2.TabIndex = 15;
            this.label2.Text = "Имя*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(229, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 16);
            this.label3.TabIndex = 17;
            this.label3.Text = "Контактный номер*";
            // 
            // dataprimb
            // 
            this.dataprimb.CustomFormat = "dd-MM-yyyy HH:mm";
            this.dataprimb.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dataprimb.Location = new System.Drawing.Point(33, 121);
            this.dataprimb.Name = "dataprimb";
            this.dataprimb.Size = new System.Drawing.Size(155, 20);
            this.dataprimb.TabIndex = 20;
            this.dataprimb.ValueChanged += new System.EventHandler(this.dataprimb_ValueChanged);
            // 
            // dataprim
            // 
            this.dataprim.AutoSize = true;
            this.dataprim.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dataprim.Location = new System.Drawing.Point(30, 101);
            this.dataprim.Name = "dataprim";
            this.dataprim.Size = new System.Drawing.Size(102, 16);
            this.dataprim.TabIndex = 19;
            this.dataprim.Text = "Дата приёма";
            // 
            // price
            // 
            this.price.Location = new System.Drawing.Point(455, 67);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(155, 20);
            this.price.TabIndex = 22;
            this.price.TextChanged += new System.EventHandler(this.price_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(452, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 16);
            this.label4.TabIndex = 21;
            this.label4.Text = "Цена";
            // 
            // details
            // 
            this.details.Location = new System.Drawing.Point(33, 232);
            this.details.Multiline = true;
            this.details.Name = "details";
            this.details.Size = new System.Drawing.Size(155, 88);
            this.details.TabIndex = 24;
            // 
            // detalii
            // 
            this.detalii.AutoSize = true;
            this.detalii.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.detalii.Location = new System.Drawing.Point(30, 213);
            this.detalii.Name = "detalii";
            this.detalii.Size = new System.Drawing.Size(129, 16);
            this.detalii.TabIndex = 23;
            this.detalii.Text = "Неисправности*";
            // 
            // problems
            // 
            this.problems.Location = new System.Drawing.Point(232, 232);
            this.problems.Multiline = true;
            this.problems.Name = "problems";
            this.problems.Size = new System.Drawing.Size(155, 88);
            this.problems.TabIndex = 26;
            // 
            // probleme
            // 
            this.probleme.AutoSize = true;
            this.probleme.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.probleme.Location = new System.Drawing.Point(229, 213);
            this.probleme.Name = "probleme";
            this.probleme.Size = new System.Drawing.Size(100, 16);
            this.probleme.TabIndex = 25;
            this.probleme.Text = "Примечание";
            // 
            // scratches
            // 
            this.scratches.AutoSize = true;
            this.scratches.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.scratches.Location = new System.Drawing.Point(455, 198);
            this.scratches.Name = "scratches";
            this.scratches.Size = new System.Drawing.Size(100, 20);
            this.scratches.TabIndex = 41;
            this.scratches.Text = "Царапины";
            this.scratches.UseVisualStyleBackColor = true;
            // 
            // charger
            // 
            this.charger.AutoSize = true;
            this.charger.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.charger.Location = new System.Drawing.Point(455, 172);
            this.charger.Name = "charger";
            this.charger.Size = new System.Drawing.Size(164, 20);
            this.charger.TabIndex = 40;
            this.charger.Text = "Нет Б.П. (Ноутбук)";
            this.charger.UseVisualStyleBackColor = true;
            // 
            // reaction
            // 
            this.reaction.AutoSize = true;
            this.reaction.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.reaction.Location = new System.Drawing.Point(455, 146);
            this.reaction.Name = "reaction";
            this.reaction.Size = new System.Drawing.Size(120, 20);
            this.reaction.TabIndex = 39;
            this.reaction.Text = "Нет реакций";
            this.reaction.UseVisualStyleBackColor = true;
            // 
            // water
            // 
            this.water.AutoSize = true;
            this.water.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.water.Location = new System.Drawing.Point(455, 120);
            this.water.Name = "water";
            this.water.Size = new System.Drawing.Size(156, 20);
            this.water.TabIndex = 38;
            this.water.Text = "Попадание влаги";
            this.water.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(239, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(172, 29);
            this.label5.TabIndex = 42;
            this.label5.Text = "Новый Заказ";
            // 
            // sett
            // 
            this.sett.Location = new System.Drawing.Point(468, 232);
            this.sett.Name = "sett";
            this.sett.Size = new System.Drawing.Size(118, 23);
            this.sett.TabIndex = 43;
            this.sett.Text = "Настройки";
            this.sett.UseVisualStyleBackColor = true;
            this.sett.Click += new System.EventHandler(this.sett_Click);
            // 
            // contact
            // 
            this.contact.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.contact.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.contact.FormattingEnabled = true;
            this.contact.Location = new System.Drawing.Point(232, 171);
            this.contact.Name = "contact";
            this.contact.Size = new System.Drawing.Size(155, 21);
            this.contact.TabIndex = 18;
            this.contact.SelectedIndexChanged += new System.EventHandler(this.contact_SelectedIndexChanged);
            // 
            // clientbtn
            // 
            this.clientbtn.Location = new System.Drawing.Point(425, 261);
            this.clientbtn.Name = "clientbtn";
            this.clientbtn.Size = new System.Drawing.Size(97, 23);
            this.clientbtn.TabIndex = 44;
            this.clientbtn.Text = "Клиенты";
            this.clientbtn.UseVisualStyleBackColor = true;
            this.clientbtn.Visible = false;
            this.clientbtn.Click += new System.EventHandler(this.clientbtn_Click);
            // 
            // modelbtn
            // 
            this.modelbtn.Location = new System.Drawing.Point(528, 261);
            this.modelbtn.Name = "modelbtn";
            this.modelbtn.Size = new System.Drawing.Size(97, 23);
            this.modelbtn.TabIndex = 45;
            this.modelbtn.Text = "Модели";
            this.modelbtn.UseVisualStyleBackColor = true;
            this.modelbtn.Visible = false;
            this.modelbtn.Click += new System.EventHandler(this.modelbtn_Click);
            // 
            // Add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(656, 406);
            this.Controls.Add(this.modelbtn);
            this.Controls.Add(this.clientbtn);
            this.Controls.Add(this.contact);
            this.Controls.Add(this.sett);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.scratches);
            this.Controls.Add(this.charger);
            this.Controls.Add(this.reaction);
            this.Controls.Add(this.water);
            this.Controls.Add(this.problems);
            this.Controls.Add(this.probleme);
            this.Controls.Add(this.details);
            this.Controls.Add(this.detalii);
            this.Controls.Add(this.price);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataprimb);
            this.Controls.Add(this.dataprim);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.model);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.imei);
            this.Controls.Add(this.text2);
            this.Controls.Add(this.receipt);
            this.Controls.Add(this.text1);
            this.Controls.Add(this.cancelbtn);
            this.Controls.Add(this.addbtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "Add";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Add_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addbtn;
        private System.Windows.Forms.Button cancelbtn;
        private System.Windows.Forms.Label text1;
        private System.Windows.Forms.ComboBox receipt;
        private System.Windows.Forms.TextBox imei;
        private System.Windows.Forms.Label text2;
        private System.Windows.Forms.ComboBox model;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dataprimb;
        private System.Windows.Forms.Label dataprim;
        private System.Windows.Forms.TextBox price;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox details;
        private System.Windows.Forms.Label detalii;
        private System.Windows.Forms.TextBox problems;
        private System.Windows.Forms.Label probleme;
        private System.Windows.Forms.CheckBox scratches;
        private System.Windows.Forms.CheckBox charger;
        private System.Windows.Forms.CheckBox reaction;
        private System.Windows.Forms.CheckBox water;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button sett;
        private System.Windows.Forms.ComboBox contact;
        private System.Windows.Forms.Button clientbtn;
        private System.Windows.Forms.Button modelbtn;
    }
}