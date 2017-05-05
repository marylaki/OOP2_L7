namespace OOP_Laba_7
{
    partial class Form1
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
            this.bday = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.fam = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nam = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.otch = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.grup = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tel = new System.Windows.Forms.MaskedTextBox();
            this.avg_note = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.city = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.strit = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.index = new System.Windows.Forms.MaskedTextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.house = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.flat = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.inf = new System.Windows.Forms.DataGridView();
            this.fio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genger = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cours = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grupp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.note = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.avg_note)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inf)).BeginInit();
            this.SuspendLayout();
            // 
            // bday
            // 
            this.bday.Location = new System.Drawing.Point(12, 103);
            this.bday.MaxDate = new System.DateTime(2017, 5, 25, 23, 59, 59, 0);
            this.bday.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.bday.Name = "bday";
            this.bday.Size = new System.Drawing.Size(200, 20);
            this.bday.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Фамилия";
            // 
            // fam
            // 
            this.fam.Location = new System.Drawing.Point(12, 29);
            this.fam.Name = "fam";
            this.fam.Size = new System.Drawing.Size(132, 20);
            this.fam.TabIndex = 2;
            this.fam.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.fam_KeyPress);
            this.fam.Validating += new System.ComponentModel.CancelEventHandler(this.fam_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(158, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Имя";
            // 
            // nam
            // 
            this.nam.Location = new System.Drawing.Point(161, 29);
            this.nam.Name = "nam";
            this.nam.Size = new System.Drawing.Size(110, 20);
            this.nam.TabIndex = 4;
            this.nam.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nam_KeyPress);
            this.nam.Validating += new System.ComponentModel.CancelEventHandler(this.nam_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(285, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Отчество";
            // 
            // otch
            // 
            this.otch.Location = new System.Drawing.Point(288, 29);
            this.otch.Name = "otch";
            this.otch.Size = new System.Drawing.Size(110, 20);
            this.otch.TabIndex = 6;
            this.otch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.otch_KeyPress);
            this.otch.Validating += new System.ComponentModel.CancelEventHandler(this.otch_Validating);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Дата рождения";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Курс";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(12, 142);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(31, 17);
            this.radioButton1.TabIndex = 9;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "1";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(49, 142);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(31, 17);
            this.radioButton2.TabIndex = 10;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "2";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(86, 142);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(31, 17);
            this.radioButton3.TabIndex = 11;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "3";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(123, 142);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(31, 17);
            this.radioButton4.TabIndex = 12;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "4";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(160, 142);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(31, 17);
            this.radioButton5.TabIndex = 13;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "5";
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 162);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Специальность";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "ИСиТ",
            "ДЭиВИ",
            "ПОИБМС",
            "ПОИТ",
            "ЛХ",
            "ХТиТ",
            "ПиМ",
            "ИЭФ"});
            this.listBox1.Location = new System.Drawing.Point(12, 178);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(149, 43);
            this.listBox1.TabIndex = 15;
            this.listBox1.Validating += new System.ComponentModel.CancelEventHandler(this.listBox1_Validating);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 234);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Группа";
            // 
            // grup
            // 
            this.grup.Location = new System.Drawing.Point(60, 227);
            this.grup.MaxLength = 2;
            this.grup.Name = "grup";
            this.grup.Size = new System.Drawing.Size(30, 20);
            this.grup.TabIndex = 17;
            this.grup.TextChanged += new System.EventHandler(this.grup_TextChanged);
            this.grup.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.grup_KeyPress);
            this.grup.Validating += new System.ComponentModel.CancelEventHandler(this.grup_Validating);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 256);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Средний балл";
            // 
            // tel
            // 
            this.tel.Location = new System.Drawing.Point(111, 275);
            this.tel.Mask = "(999) 000-0000";
            this.tel.Name = "tel";
            this.tel.Size = new System.Drawing.Size(80, 20);
            this.tel.TabIndex = 19;
            this.tel.Validating += new System.ComponentModel.CancelEventHandler(this.tel_Validating);
            // 
            // avg_note
            // 
            this.avg_note.DecimalPlaces = 1;
            this.avg_note.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.avg_note.Location = new System.Drawing.Point(96, 249);
            this.avg_note.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.avg_note.Name = "avg_note";
            this.avg_note.Size = new System.Drawing.Size(38, 20);
            this.avg_note.TabIndex = 20;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 282);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "Номер телефона";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(13, 61);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(27, 13);
            this.label10.TabIndex = 22;
            this.label10.Text = "Пол";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(17, 306);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(37, 13);
            this.label11.TabIndex = 24;
            this.label11.Text = "Город";
            // 
            // city
            // 
            this.city.Location = new System.Drawing.Point(17, 330);
            this.city.Name = "city";
            this.city.Size = new System.Drawing.Size(106, 20);
            this.city.TabIndex = 25;
            this.city.Validating += new System.ComponentModel.CancelEventHandler(this.city_Validating);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(15, 353);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(39, 13);
            this.label12.TabIndex = 26;
            this.label12.Text = "Улица";
            // 
            // strit
            // 
            this.strit.Location = new System.Drawing.Point(16, 373);
            this.strit.Name = "strit";
            this.strit.Size = new System.Drawing.Size(100, 20);
            this.strit.TabIndex = 27;
            this.strit.Validating += new System.ComponentModel.CancelEventHandler(this.strit_Validating);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(142, 306);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(45, 13);
            this.label13.TabIndex = 28;
            this.label13.Text = "Индекс";
            // 
            // index
            // 
            this.index.Location = new System.Drawing.Point(145, 330);
            this.index.Mask = "00000";
            this.index.Name = "index";
            this.index.Size = new System.Drawing.Size(42, 20);
            this.index.TabIndex = 29;
            this.index.ValidatingType = typeof(int);
            this.index.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.index_KeyPress);
            this.index.Validating += new System.ComponentModel.CancelEventHandler(this.index_Validating);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(146, 353);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(30, 13);
            this.label14.TabIndex = 30;
            this.label14.Text = "Дом";
            // 
            // house
            // 
            this.house.Location = new System.Drawing.Point(143, 369);
            this.house.Name = "house";
            this.house.Size = new System.Drawing.Size(44, 20);
            this.house.TabIndex = 31;
            this.house.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.house_KeyPress);
            this.house.Validating += new System.ComponentModel.CancelEventHandler(this.house_Validating);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(204, 353);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(55, 13);
            this.label15.TabIndex = 32;
            this.label15.Text = "Квартира";
            // 
            // flat
            // 
            this.flat.Location = new System.Drawing.Point(203, 369);
            this.flat.Name = "flat";
            this.flat.Size = new System.Drawing.Size(56, 20);
            this.flat.TabIndex = 33;
            this.flat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.flat_KeyPress);
            this.flat.Validating += new System.ComponentModel.CancelEventHandler(this.flat_Validating);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(60, 400);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 29);
            this.button1.TabIndex = 34;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.MouseEnter += new System.EventHandler(this.button1_MouseEnter);
            // 
            // inf
            // 
            this.inf.AllowUserToDeleteRows = false;
            this.inf.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.inf.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.inf.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fio,
            this.genger,
            this.bdate,
            this.cours,
            this.sec,
            this.grupp,
            this.note,
            this.number,
            this.adress});
            this.inf.Location = new System.Drawing.Point(279, 62);
            this.inf.Name = "inf";
            this.inf.ReadOnly = true;
            this.inf.Size = new System.Drawing.Size(702, 346);
            this.inf.TabIndex = 35;
            // 
            // fio
            // 
            this.fio.HeaderText = "ФИО";
            this.fio.Name = "fio";
            this.fio.ReadOnly = true;
            this.fio.Width = 59;
            // 
            // genger
            // 
            this.genger.HeaderText = "Пол";
            this.genger.Name = "genger";
            this.genger.ReadOnly = true;
            this.genger.Width = 52;
            // 
            // bdate
            // 
            this.bdate.HeaderText = "Дата рождения";
            this.bdate.Name = "bdate";
            this.bdate.ReadOnly = true;
            this.bdate.Width = 102;
            // 
            // cours
            // 
            this.cours.HeaderText = "Курс";
            this.cours.Name = "cours";
            this.cours.ReadOnly = true;
            this.cours.Width = 56;
            // 
            // sec
            // 
            this.sec.HeaderText = "Специальность";
            this.sec.Name = "sec";
            this.sec.ReadOnly = true;
            this.sec.Width = 110;
            // 
            // grupp
            // 
            this.grupp.HeaderText = "Группа";
            this.grupp.Name = "grupp";
            this.grupp.ReadOnly = true;
            this.grupp.Width = 67;
            // 
            // note
            // 
            this.note.HeaderText = "ср. балл";
            this.note.Name = "note";
            this.note.ReadOnly = true;
            this.note.Width = 69;
            // 
            // number
            // 
            this.number.HeaderText = "Телефон";
            this.number.Name = "number";
            this.number.ReadOnly = true;
            this.number.Width = 77;
            // 
            // adress
            // 
            this.adress.HeaderText = "Адресс";
            this.adress.Name = "adress";
            this.adress.ReadOnly = true;
            this.adress.Width = 69;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(453, 25);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(133, 23);
            this.button2.TabIndex = 36;
            this.button2.Text = "Запись в xml";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(639, 26);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(145, 22);
            this.button3.TabIndex = 37;
            this.button3.Text = "Чтение из xml";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.comboBox1.Items.AddRange(new object[] {
            "Женский",
            "Мужской"});
            this.comboBox1.Location = new System.Drawing.Point(47, 61);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 38;
            this.comboBox1.Validating += new System.ComponentModel.CancelEventHandler(this.comboBox1_Validating);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(990, 431);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.inf);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.flat);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.house);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.index);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.strit);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.city);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.avg_note);
            this.Controls.Add(this.tel);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.grup);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.radioButton5);
            this.Controls.Add(this.radioButton4);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.otch);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nam);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.fam);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bday);
            this.Name = "Form1";
            this.Text = "Университет";
            ((System.ComponentModel.ISupportInitialize)(this.avg_note)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inf)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker bday;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox fam;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nam;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox otch;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox grup;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MaskedTextBox tel;
        public System.Windows.Forms.NumericUpDown avg_note;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox city;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox strit;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.MaskedTextBox index;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox house;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox flat;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView inf;
        private System.Windows.Forms.DataGridViewTextBoxColumn fio;
        private System.Windows.Forms.DataGridViewTextBoxColumn genger;
        private System.Windows.Forms.DataGridViewTextBoxColumn bdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn cours;
        private System.Windows.Forms.DataGridViewTextBoxColumn sec;
        private System.Windows.Forms.DataGridViewTextBoxColumn grupp;
        private System.Windows.Forms.DataGridViewTextBoxColumn note;
        private System.Windows.Forms.DataGridViewTextBoxColumn number;
        private System.Windows.Forms.DataGridViewTextBoxColumn adress;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

