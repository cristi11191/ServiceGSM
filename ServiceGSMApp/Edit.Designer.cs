namespace ServiceGSMApp
{
    partial class Edit
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
            this.contact = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.scratches = new System.Windows.Forms.CheckBox();
            this.charger = new System.Windows.Forms.CheckBox();
            this.reaction = new System.Windows.Forms.CheckBox();
            this.water = new System.Windows.Forms.CheckBox();
            this.problems = new System.Windows.Forms.TextBox();
            this.probleme = new System.Windows.Forms.Label();
            this.details = new System.Windows.Forms.TextBox();
            this.detalii = new System.Windows.Forms.Label();
            this.price = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dataprimb = new System.Windows.Forms.DateTimePicker();
            this.dataprim = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.model = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.imei = new System.Windows.Forms.TextBox();
            this.text2 = new System.Windows.Forms.Label();
            this.receipt = new System.Windows.Forms.ComboBox();
            this.text1 = new System.Windows.Forms.Label();
            this.cancelbtn = new System.Windows.Forms.Button();
            this.editbtn = new System.Windows.Forms.Button();
            this.mester = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.donetime = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // contact
            // 
            this.contact.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.contact.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.contact.FormattingEnabled = true;
            this.contact.Location = new System.Drawing.Point(427, 179);
            this.contact.MaxLength = 9;
            this.contact.Name = "contact";
            this.contact.Size = new System.Drawing.Size(155, 21);
            this.contact.TabIndex = 57;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(169, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(279, 29);
            this.label5.TabIndex = 70;
            this.label5.Text = "Редактировать Заказ";
            // 
            // scratches
            // 
            this.scratches.AutoSize = true;
            this.scratches.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.scratches.Location = new System.Drawing.Point(427, 306);
            this.scratches.Name = "scratches";
            this.scratches.Size = new System.Drawing.Size(100, 20);
            this.scratches.TabIndex = 69;
            this.scratches.Text = "Царапины";
            this.scratches.UseVisualStyleBackColor = true;
            // 
            // charger
            // 
            this.charger.AutoSize = true;
            this.charger.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.charger.Location = new System.Drawing.Point(427, 280);
            this.charger.Name = "charger";
            this.charger.Size = new System.Drawing.Size(164, 20);
            this.charger.TabIndex = 68;
            this.charger.Text = "Нет Б.П. (Ноутбук)";
            this.charger.UseVisualStyleBackColor = true;
            // 
            // reaction
            // 
            this.reaction.AutoSize = true;
            this.reaction.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.reaction.Location = new System.Drawing.Point(427, 254);
            this.reaction.Name = "reaction";
            this.reaction.Size = new System.Drawing.Size(120, 20);
            this.reaction.TabIndex = 67;
            this.reaction.Text = "Нет реакций";
            this.reaction.UseVisualStyleBackColor = true;
            // 
            // water
            // 
            this.water.AutoSize = true;
            this.water.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.water.Location = new System.Drawing.Point(427, 228);
            this.water.Name = "water";
            this.water.Size = new System.Drawing.Size(156, 20);
            this.water.TabIndex = 66;
            this.water.Text = "Попадание влаги";
            this.water.UseVisualStyleBackColor = true;
            // 
            // problems
            // 
            this.problems.Location = new System.Drawing.Point(226, 238);
            this.problems.Multiline = true;
            this.problems.Name = "problems";
            this.problems.Size = new System.Drawing.Size(155, 88);
            this.problems.TabIndex = 65;
            // 
            // probleme
            // 
            this.probleme.AutoSize = true;
            this.probleme.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.probleme.Location = new System.Drawing.Point(223, 219);
            this.probleme.Name = "probleme";
            this.probleme.Size = new System.Drawing.Size(100, 16);
            this.probleme.TabIndex = 64;
            this.probleme.Text = "Примечание";
            // 
            // details
            // 
            this.details.Location = new System.Drawing.Point(27, 238);
            this.details.Multiline = true;
            this.details.Name = "details";
            this.details.Size = new System.Drawing.Size(155, 88);
            this.details.TabIndex = 63;
            // 
            // detalii
            // 
            this.detalii.AutoSize = true;
            this.detalii.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.detalii.Location = new System.Drawing.Point(24, 219);
            this.detalii.Name = "detalii";
            this.detalii.Size = new System.Drawing.Size(123, 16);
            this.detalii.TabIndex = 62;
            this.detalii.Text = "Неисправности";
            // 
            // price
            // 
            this.price.Location = new System.Drawing.Point(427, 126);
            this.price.MaxLength = 5;
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(155, 20);
            this.price.TabIndex = 61;
            this.price.TextChanged += new System.EventHandler(this.price_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(424, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 16);
            this.label4.TabIndex = 60;
            this.label4.Text = "Цена";
            // 
            // dataprimb
            // 
            this.dataprimb.CustomFormat = "dd-MM-yyyy HH:mm";
            this.dataprimb.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dataprimb.Location = new System.Drawing.Point(27, 127);
            this.dataprimb.Name = "dataprimb";
            this.dataprimb.Size = new System.Drawing.Size(155, 20);
            this.dataprimb.TabIndex = 59;
            // 
            // dataprim
            // 
            this.dataprim.AutoSize = true;
            this.dataprim.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dataprim.Location = new System.Drawing.Point(24, 107);
            this.dataprim.Name = "dataprim";
            this.dataprim.Size = new System.Drawing.Size(102, 16);
            this.dataprim.TabIndex = 58;
            this.dataprim.Text = "Дата приёма";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(424, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 16);
            this.label3.TabIndex = 56;
            this.label3.Text = "Контактный номер";
            // 
            // name
            // 
            this.name.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.name.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.name.FormattingEnabled = true;
            this.name.Location = new System.Drawing.Point(226, 177);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(155, 21);
            this.name.TabIndex = 55;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(223, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 16);
            this.label2.TabIndex = 54;
            this.label2.Text = "Имя";
            // 
            // model
            // 
            this.model.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.model.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.model.FormattingEnabled = true;
            this.model.Location = new System.Drawing.Point(226, 73);
            this.model.Name = "model";
            this.model.Size = new System.Drawing.Size(155, 21);
            this.model.TabIndex = 53;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(223, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 16);
            this.label1.TabIndex = 52;
            this.label1.Text = "Модель";
            // 
            // imei
            // 
            this.imei.Location = new System.Drawing.Point(27, 177);
            this.imei.MaxLength = 5;
            this.imei.Name = "imei";
            this.imei.Size = new System.Drawing.Size(155, 20);
            this.imei.TabIndex = 51;
            this.imei.TextChanged += new System.EventHandler(this.imei_TextChanged);
            // 
            // text2
            // 
            this.text2.AutoSize = true;
            this.text2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.text2.Location = new System.Drawing.Point(24, 158);
            this.text2.Name = "text2";
            this.text2.Size = new System.Drawing.Size(37, 16);
            this.text2.TabIndex = 50;
            this.text2.Text = "IMEI";
            // 
            // receipt
            // 
            this.receipt.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.receipt.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.receipt.FormattingEnabled = true;
            this.receipt.Location = new System.Drawing.Point(23, 73);
            this.receipt.Name = "receipt";
            this.receipt.Size = new System.Drawing.Size(159, 21);
            this.receipt.TabIndex = 49;
            // 
            // text1
            // 
            this.text1.AutoSize = true;
            this.text1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.text1.Location = new System.Drawing.Point(20, 54);
            this.text1.Name = "text1";
            this.text1.Size = new System.Drawing.Size(82, 16);
            this.text1.TabIndex = 48;
            this.text1.Text = "Приемщик";
            // 
            // cancelbtn
            // 
            this.cancelbtn.Location = new System.Drawing.Point(387, 365);
            this.cancelbtn.Name = "cancelbtn";
            this.cancelbtn.Size = new System.Drawing.Size(118, 23);
            this.cancelbtn.TabIndex = 47;
            this.cancelbtn.Text = "Отменить";
            this.cancelbtn.UseVisualStyleBackColor = true;
            this.cancelbtn.Click += new System.EventHandler(this.cancelbtn_Click);
            // 
            // editbtn
            // 
            this.editbtn.Location = new System.Drawing.Point(141, 365);
            this.editbtn.Name = "editbtn";
            this.editbtn.Size = new System.Drawing.Size(118, 23);
            this.editbtn.TabIndex = 46;
            this.editbtn.Text = "Редактировать";
            this.editbtn.UseVisualStyleBackColor = true;
            this.editbtn.Click += new System.EventHandler(this.editbtn_Click);
            // 
            // mester
            // 
            this.mester.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.mester.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.mester.FormattingEnabled = true;
            this.mester.Location = new System.Drawing.Point(427, 73);
            this.mester.Name = "mester";
            this.mester.Size = new System.Drawing.Size(155, 21);
            this.mester.TabIndex = 72;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(424, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 16);
            this.label6.TabIndex = 71;
            this.label6.Text = "Мастер";
            // 
            // donetime
            // 
            this.donetime.CustomFormat = "dd-MM-yyyy HH:mm";
            this.donetime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.donetime.Location = new System.Drawing.Point(226, 127);
            this.donetime.Name = "donetime";
            this.donetime.Size = new System.Drawing.Size(155, 20);
            this.donetime.TabIndex = 74;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(223, 107);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(137, 16);
            this.label7.TabIndex = 73;
            this.label7.Text = "Дата завершения";
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // Edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 419);
            this.Controls.Add(this.donetime);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.mester);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.contact);
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
            this.Controls.Add(this.editbtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Edit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Edit_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox scratches;
        private System.Windows.Forms.CheckBox charger;
        private System.Windows.Forms.CheckBox reaction;
        private System.Windows.Forms.CheckBox water;
        private System.Windows.Forms.TextBox problems;
        private System.Windows.Forms.Label probleme;
        private System.Windows.Forms.TextBox details;
        private System.Windows.Forms.Label detalii;
        private System.Windows.Forms.TextBox price;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label dataprim;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox imei;
        private System.Windows.Forms.Label text2;
        private System.Windows.Forms.Label text1;
        private System.Windows.Forms.Button cancelbtn;
        private System.Windows.Forms.Button editbtn;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.DateTimePicker dataprimb;
        public System.Windows.Forms.ComboBox model;
        public System.Windows.Forms.ComboBox receipt;
        public System.Windows.Forms.ComboBox mester;
        public System.Windows.Forms.ComboBox contact;
        public System.Windows.Forms.ComboBox name;
        public System.Windows.Forms.DateTimePicker donetime;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.Timer timer;
    }
}