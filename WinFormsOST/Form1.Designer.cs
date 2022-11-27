namespace OST_Labs
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.CpuText = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.DeviceText1 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.RamSize = new System.Windows.Forms.ComboBox();
            this.ProcessIntensivityNumeric = new System.Windows.Forms.NumericUpDown();
            this.MinWorkTimeNumeric = new System.Windows.Forms.NumericUpDown();
            this.MaxWorkTimeNumeric = new System.Windows.Forms.NumericUpDown();
            this.MinAddrSpaceNumeric = new System.Windows.Forms.NumericUpDown();
            this.MaxAddrSpaceNumeric = new System.Windows.Forms.NumericUpDown();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.FreeRamText = new System.Windows.Forms.TextBox();
            this.OccupiedRamText = new System.Windows.Forms.TextBox();
            this.TacktsText = new System.Windows.Forms.TextBox();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.SaveSettingsButton = new System.Windows.Forms.Button();
            this.WorkCycleButton = new System.Windows.Forms.Button();
            this.EndSeanseButton = new System.Windows.Forms.Button();
            this.CpuQueueList = new System.Windows.Forms.ListBox();
            this.DeviceQueueList1 = new System.Windows.Forms.ListBox();
            this.SettingsPanel = new System.Windows.Forms.Panel();
            this.textBox15 = new System.Windows.Forms.TextBox();
            this.timer = new System.Timers.Timer();
            this.DeviceQueueList2 = new System.Windows.Forms.ListBox();
            this.textBox16 = new System.Windows.Forms.TextBox();
            this.DeviceText2 = new System.Windows.Forms.TextBox();
            this.textBox18 = new System.Windows.Forms.TextBox();
            this.DeviceQueueList3 = new System.Windows.Forms.ListBox();
            this.textBox19 = new System.Windows.Forms.TextBox();
            this.DeviceText3 = new System.Windows.Forms.TextBox();
            this.textBox21 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.ProcessIntensivityNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinWorkTimeNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaxWorkTimeNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinAddrSpaceNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaxAddrSpaceNumeric)).BeginInit();
            this.SettingsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.timer)).BeginInit();
            this.SuspendLayout();
            // 
            // CpuText
            // 
            this.CpuText.Location = new System.Drawing.Point(12, 120);
            this.CpuText.Name = "CpuText";
            this.CpuText.ReadOnly = true;
            this.CpuText.Size = new System.Drawing.Size(604, 20);
            this.CpuText.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(3, 0);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(117, 82);
            this.textBox2.TabIndex = 1;
            this.textBox2.Text = "Интенсивность поступления процессов";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(123, 0);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(117, 82);
            this.textBox3.TabIndex = 2;
            this.textBox3.Text = "Минимальное значение промежутка работы на ЦП";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(246, 0);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(117, 82);
            this.textBox4.TabIndex = 3;
            this.textBox4.Text = "Максимальное значение промежутка работы на ЦП";
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(369, 0);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(117, 82);
            this.textBox5.TabIndex = 4;
            this.textBox5.Text = "Размер оперативной памяти";
            this.textBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(492, 0);
            this.textBox6.Multiline = true;
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.Size = new System.Drawing.Size(117, 82);
            this.textBox6.TabIndex = 5;
            this.textBox6.Text = "Минимальный размер адресного пространства процесса";
            this.textBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(615, 0);
            this.textBox7.Multiline = true;
            this.textBox7.Name = "textBox7";
            this.textBox7.ReadOnly = true;
            this.textBox7.Size = new System.Drawing.Size(117, 82);
            this.textBox7.TabIndex = 6;
            this.textBox7.Text = "Максимальный размер адресного пространства процесса";
            this.textBox7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(12, 100);
            this.textBox8.Multiline = true;
            this.textBox8.Name = "textBox8";
            this.textBox8.ReadOnly = true;
            this.textBox8.Size = new System.Drawing.Size(604, 20);
            this.textBox8.TabIndex = 7;
            this.textBox8.Text = "Центральный процессор";
            this.textBox8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(627, 100);
            this.textBox9.Multiline = true;
            this.textBox9.Name = "textBox9";
            this.textBox9.ReadOnly = true;
            this.textBox9.Size = new System.Drawing.Size(604, 20);
            this.textBox9.TabIndex = 8;
            this.textBox9.Text = "Внешнее устройство 1";
            this.textBox9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // DeviceText1
            // 
            this.DeviceText1.Location = new System.Drawing.Point(627, 120);
            this.DeviceText1.Name = "DeviceText1";
            this.DeviceText1.ReadOnly = true;
            this.DeviceText1.Size = new System.Drawing.Size(604, 20);
            this.DeviceText1.TabIndex = 9;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(627, 140);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(604, 20);
            this.textBox1.TabIndex = 11;
            this.textBox1.Text = "Очередь к внешнему устройству";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(12, 140);
            this.textBox10.Multiline = true;
            this.textBox10.Name = "textBox10";
            this.textBox10.ReadOnly = true;
            this.textBox10.Size = new System.Drawing.Size(604, 20);
            this.textBox10.TabIndex = 10;
            this.textBox10.Text = "Очередь к ЦП";
            this.textBox10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // RamSize
            // 
            this.RamSize.FormattingEnabled = true;
            this.RamSize.Items.AddRange(new object[] { "1000", "2000", "4000", "8000", "16000", "32000" });
            this.RamSize.Location = new System.Drawing.Point(369, 58);
            this.RamSize.Name = "RamSize";
            this.RamSize.Size = new System.Drawing.Size(117, 21);
            this.RamSize.TabIndex = 14;
            // 
            // ProcessIntensivityNumeric
            // 
            this.ProcessIntensivityNumeric.DecimalPlaces = 1;
            this.ProcessIntensivityNumeric.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            this.ProcessIntensivityNumeric.Location = new System.Drawing.Point(3, 59);
            this.ProcessIntensivityNumeric.Maximum = new decimal(new int[] { 1, 0, 0, 0 });
            this.ProcessIntensivityNumeric.Name = "ProcessIntensivityNumeric";
            this.ProcessIntensivityNumeric.Size = new System.Drawing.Size(117, 20);
            this.ProcessIntensivityNumeric.TabIndex = 15;
            // 
            // MinWorkTimeNumeric
            // 
            this.MinWorkTimeNumeric.Location = new System.Drawing.Point(123, 59);
            this.MinWorkTimeNumeric.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            this.MinWorkTimeNumeric.Name = "MinWorkTimeNumeric";
            this.MinWorkTimeNumeric.Size = new System.Drawing.Size(117, 20);
            this.MinWorkTimeNumeric.TabIndex = 16;
            this.MinWorkTimeNumeric.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // MaxWorkTimeNumeric
            // 
            this.MaxWorkTimeNumeric.Location = new System.Drawing.Point(246, 59);
            this.MaxWorkTimeNumeric.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            this.MaxWorkTimeNumeric.Name = "MaxWorkTimeNumeric";
            this.MaxWorkTimeNumeric.Size = new System.Drawing.Size(117, 20);
            this.MaxWorkTimeNumeric.TabIndex = 17;
            this.MaxWorkTimeNumeric.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // MinAddrSpaceNumeric
            // 
            this.MinAddrSpaceNumeric.Location = new System.Drawing.Point(492, 59);
            this.MinAddrSpaceNumeric.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            this.MinAddrSpaceNumeric.Name = "MinAddrSpaceNumeric";
            this.MinAddrSpaceNumeric.Size = new System.Drawing.Size(117, 20);
            this.MinAddrSpaceNumeric.TabIndex = 18;
            this.MinAddrSpaceNumeric.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // MaxAddrSpaceNumeric
            // 
            this.MaxAddrSpaceNumeric.Location = new System.Drawing.Point(615, 58);
            this.MaxAddrSpaceNumeric.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            this.MaxAddrSpaceNumeric.Name = "MaxAddrSpaceNumeric";
            this.MaxAddrSpaceNumeric.Size = new System.Drawing.Size(117, 20);
            this.MaxAddrSpaceNumeric.TabIndex = 19;
            this.MaxAddrSpaceNumeric.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(11, 376);
            this.textBox11.Name = "textBox11";
            this.textBox11.ReadOnly = true;
            this.textBox11.Size = new System.Drawing.Size(363, 20);
            this.textBox11.TabIndex = 20;
            this.textBox11.Text = "Оперативная память";
            this.textBox11.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox12
            // 
            this.textBox12.Location = new System.Drawing.Point(11, 428);
            this.textBox12.Name = "textBox12";
            this.textBox12.ReadOnly = true;
            this.textBox12.Size = new System.Drawing.Size(240, 20);
            this.textBox12.TabIndex = 21;
            this.textBox12.Text = "Размер свободной памяти";
            // 
            // textBox13
            // 
            this.textBox13.Location = new System.Drawing.Point(12, 402);
            this.textBox13.Name = "textBox13";
            this.textBox13.ReadOnly = true;
            this.textBox13.Size = new System.Drawing.Size(240, 20);
            this.textBox13.TabIndex = 22;
            this.textBox13.Text = "Размер занятой памяти";
            // 
            // FreeRamText
            // 
            this.FreeRamText.Location = new System.Drawing.Point(257, 428);
            this.FreeRamText.Name = "FreeRamText";
            this.FreeRamText.ReadOnly = true;
            this.FreeRamText.Size = new System.Drawing.Size(117, 20);
            this.FreeRamText.TabIndex = 23;
            // 
            // OccupiedRamText
            // 
            this.OccupiedRamText.Location = new System.Drawing.Point(257, 402);
            this.OccupiedRamText.Name = "OccupiedRamText";
            this.OccupiedRamText.ReadOnly = true;
            this.OccupiedRamText.Size = new System.Drawing.Size(117, 20);
            this.OccupiedRamText.TabIndex = 24;
            // 
            // TacktsText
            // 
            this.TacktsText.Location = new System.Drawing.Point(257, 350);
            this.TacktsText.Name = "TacktsText";
            this.TacktsText.ReadOnly = true;
            this.TacktsText.Size = new System.Drawing.Size(117, 20);
            this.TacktsText.TabIndex = 25;
            // 
            // textBox14
            // 
            this.textBox14.Location = new System.Drawing.Point(11, 454);
            this.textBox14.Name = "textBox14";
            this.textBox14.ReadOnly = true;
            this.textBox14.Size = new System.Drawing.Size(117, 20);
            this.textBox14.TabIndex = 26;
            this.textBox14.Text = "Режим работы";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(11, 480);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(60, 17);
            this.radioButton1.TabIndex = 27;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Ручной";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(11, 503);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(109, 17);
            this.radioButton2.TabIndex = 28;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Автоматический";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // SaveSettingsButton
            // 
            this.SaveSettingsButton.Location = new System.Drawing.Point(135, 532);
            this.SaveSettingsButton.Name = "SaveSettingsButton";
            this.SaveSettingsButton.Size = new System.Drawing.Size(113, 45);
            this.SaveSettingsButton.TabIndex = 29;
            this.SaveSettingsButton.Text = "Сохранение настроек";
            this.SaveSettingsButton.UseVisualStyleBackColor = true;
            this.SaveSettingsButton.Click += new System.EventHandler(this.SaveSettingsButton_Click);
            // 
            // WorkCycleButton
            // 
            this.WorkCycleButton.Location = new System.Drawing.Point(258, 532);
            this.WorkCycleButton.Name = "WorkCycleButton";
            this.WorkCycleButton.Size = new System.Drawing.Size(113, 45);
            this.WorkCycleButton.TabIndex = 30;
            this.WorkCycleButton.Text = "Рабочий такт";
            this.WorkCycleButton.UseVisualStyleBackColor = true;
            this.WorkCycleButton.Click += new System.EventHandler(this.WorkCycleButton_Click);
            // 
            // EndSeanseButton
            // 
            this.EndSeanseButton.Location = new System.Drawing.Point(381, 532);
            this.EndSeanseButton.Name = "EndSeanseButton";
            this.EndSeanseButton.Size = new System.Drawing.Size(113, 45);
            this.EndSeanseButton.TabIndex = 31;
            this.EndSeanseButton.Text = "Завершение сеанса";
            this.EndSeanseButton.UseVisualStyleBackColor = true;
            this.EndSeanseButton.Click += new System.EventHandler(this.EndSeanseButton_Click);
            // 
            // CpuQueueList
            // 
            this.CpuQueueList.FormattingEnabled = true;
            this.CpuQueueList.Location = new System.Drawing.Point(12, 160);
            this.CpuQueueList.Name = "CpuQueueList";
            this.CpuQueueList.Size = new System.Drawing.Size(604, 173);
            this.CpuQueueList.TabIndex = 33;
            // 
            // DeviceQueueList1
            // 
            this.DeviceQueueList1.FormattingEnabled = true;
            this.DeviceQueueList1.Location = new System.Drawing.Point(627, 160);
            this.DeviceQueueList1.Name = "DeviceQueueList1";
            this.DeviceQueueList1.Size = new System.Drawing.Size(604, 95);
            this.DeviceQueueList1.TabIndex = 34;
            // 
            // SettingsPanel
            // 
            this.SettingsPanel.Controls.Add(this.MinAddrSpaceNumeric);
            this.SettingsPanel.Controls.Add(this.RamSize);
            this.SettingsPanel.Controls.Add(this.MaxWorkTimeNumeric);
            this.SettingsPanel.Controls.Add(this.MinWorkTimeNumeric);
            this.SettingsPanel.Controls.Add(this.textBox5);
            this.SettingsPanel.Controls.Add(this.textBox6);
            this.SettingsPanel.Controls.Add(this.ProcessIntensivityNumeric);
            this.SettingsPanel.Controls.Add(this.MaxAddrSpaceNumeric);
            this.SettingsPanel.Controls.Add(this.textBox7);
            this.SettingsPanel.Controls.Add(this.textBox4);
            this.SettingsPanel.Controls.Add(this.textBox3);
            this.SettingsPanel.Controls.Add(this.textBox2);
            this.SettingsPanel.Location = new System.Drawing.Point(12, 12);
            this.SettingsPanel.Name = "SettingsPanel";
            this.SettingsPanel.Size = new System.Drawing.Size(1219, 82);
            this.SettingsPanel.TabIndex = 35;
            // 
            // textBox15
            // 
            this.textBox15.Location = new System.Drawing.Point(12, 350);
            this.textBox15.Name = "textBox15";
            this.textBox15.ReadOnly = true;
            this.textBox15.Size = new System.Drawing.Size(240, 20);
            this.textBox15.TabIndex = 36;
            this.textBox15.Text = "Такт";
            // 
            // timer
            // 
            this.timer.Interval = 1000D;
            this.timer.SynchronizingObject = this;
            this.timer.Elapsed += new System.Timers.ElapsedEventHandler(this.timer_Elapsed);
            // 
            // DeviceQueueList2
            // 
            this.DeviceQueueList2.FormattingEnabled = true;
            this.DeviceQueueList2.Location = new System.Drawing.Point(627, 321);
            this.DeviceQueueList2.Name = "DeviceQueueList2";
            this.DeviceQueueList2.Size = new System.Drawing.Size(604, 95);
            this.DeviceQueueList2.TabIndex = 40;
            // 
            // textBox16
            // 
            this.textBox16.Location = new System.Drawing.Point(627, 301);
            this.textBox16.Multiline = true;
            this.textBox16.Name = "textBox16";
            this.textBox16.ReadOnly = true;
            this.textBox16.Size = new System.Drawing.Size(604, 20);
            this.textBox16.TabIndex = 39;
            this.textBox16.Text = "Очередь к внешнему устройству";
            this.textBox16.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // DeviceText2
            // 
            this.DeviceText2.Location = new System.Drawing.Point(627, 281);
            this.DeviceText2.Name = "DeviceText2";
            this.DeviceText2.ReadOnly = true;
            this.DeviceText2.Size = new System.Drawing.Size(604, 20);
            this.DeviceText2.TabIndex = 38;
            // 
            // textBox18
            // 
            this.textBox18.Location = new System.Drawing.Point(627, 261);
            this.textBox18.Multiline = true;
            this.textBox18.Name = "textBox18";
            this.textBox18.ReadOnly = true;
            this.textBox18.Size = new System.Drawing.Size(604, 20);
            this.textBox18.TabIndex = 37;
            this.textBox18.Text = "Внешнее устройство 2";
            this.textBox18.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // DeviceQueueList3
            // 
            this.DeviceQueueList3.FormattingEnabled = true;
            this.DeviceQueueList3.Location = new System.Drawing.Point(627, 482);
            this.DeviceQueueList3.Name = "DeviceQueueList3";
            this.DeviceQueueList3.Size = new System.Drawing.Size(604, 95);
            this.DeviceQueueList3.TabIndex = 44;
            // 
            // textBox19
            // 
            this.textBox19.Location = new System.Drawing.Point(627, 462);
            this.textBox19.Multiline = true;
            this.textBox19.Name = "textBox19";
            this.textBox19.ReadOnly = true;
            this.textBox19.Size = new System.Drawing.Size(604, 20);
            this.textBox19.TabIndex = 43;
            this.textBox19.Text = "Очередь к внешнему устройству";
            this.textBox19.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // DeviceText3
            // 
            this.DeviceText3.Location = new System.Drawing.Point(627, 442);
            this.DeviceText3.Name = "DeviceText3";
            this.DeviceText3.ReadOnly = true;
            this.DeviceText3.Size = new System.Drawing.Size(604, 20);
            this.DeviceText3.TabIndex = 42;
            // 
            // textBox21
            // 
            this.textBox21.Location = new System.Drawing.Point(627, 422);
            this.textBox21.Multiline = true;
            this.textBox21.Name = "textBox21";
            this.textBox21.ReadOnly = true;
            this.textBox21.Size = new System.Drawing.Size(604, 20);
            this.textBox21.TabIndex = 41;
            this.textBox21.Text = "Внешнее устройство 3";
            this.textBox21.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1239, 589);
            this.Controls.Add(this.DeviceQueueList3);
            this.Controls.Add(this.textBox19);
            this.Controls.Add(this.DeviceText3);
            this.Controls.Add(this.textBox21);
            this.Controls.Add(this.DeviceQueueList2);
            this.Controls.Add(this.textBox16);
            this.Controls.Add(this.DeviceText2);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.textBox18);
            this.Controls.Add(this.textBox15);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.SettingsPanel);
            this.Controls.Add(this.DeviceQueueList1);
            this.Controls.Add(this.textBox14);
            this.Controls.Add(this.CpuQueueList);
            this.Controls.Add(this.EndSeanseButton);
            this.Controls.Add(this.SaveSettingsButton);
            this.Controls.Add(this.WorkCycleButton);
            this.Controls.Add(this.TacktsText);
            this.Controls.Add(this.OccupiedRamText);
            this.Controls.Add(this.FreeRamText);
            this.Controls.Add(this.textBox13);
            this.Controls.Add(this.textBox12);
            this.Controls.Add(this.textBox11);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBox10);
            this.Controls.Add(this.DeviceText1);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.CpuText);
            this.Location = new System.Drawing.Point(15, 15);
            this.Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.ProcessIntensivityNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinWorkTimeNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaxWorkTimeNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinAddrSpaceNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaxAddrSpaceNumeric)).EndInit();
            this.SettingsPanel.ResumeLayout(false);
            this.SettingsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.timer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        public System.Windows.Forms.ListBox DeviceQueueList2;
        private System.Windows.Forms.TextBox textBox16;
        public System.Windows.Forms.TextBox DeviceText2;
        private System.Windows.Forms.TextBox textBox18;
        public System.Windows.Forms.ListBox DeviceQueueList3;
        private System.Windows.Forms.TextBox textBox19;
        public System.Windows.Forms.TextBox DeviceText3;
        private System.Windows.Forms.TextBox textBox21;

        public System.Timers.Timer timer;

        #endregion

        public System.Windows.Forms.TextBox CpuText;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox9;
        public System.Windows.Forms.TextBox DeviceText1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.TextBox textBox13;
        private System.Windows.Forms.TextBox textBox14;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Button WorkCycleButton;
        private System.Windows.Forms.Button EndSeanseButton;
        public System.Windows.Forms.TextBox FreeRamText;
        public System.Windows.Forms.TextBox OccupiedRamText;
        public System.Windows.Forms.TextBox TacktsText;
        public System.Windows.Forms.ComboBox RamSize;
        public System.Windows.Forms.NumericUpDown ProcessIntensivityNumeric;
        public System.Windows.Forms.NumericUpDown MinWorkTimeNumeric;
        public System.Windows.Forms.NumericUpDown MaxWorkTimeNumeric;
        public System.Windows.Forms.NumericUpDown MinAddrSpaceNumeric;
        public System.Windows.Forms.NumericUpDown MaxAddrSpaceNumeric;
        public System.Windows.Forms.ListBox CpuQueueList;
        public System.Windows.Forms.ListBox DeviceQueueList1;
        private System.Windows.Forms.Panel SettingsPanel;
        public System.Windows.Forms.Button SaveSettingsButton;
        private System.Windows.Forms.TextBox textBox15;
    }
}

