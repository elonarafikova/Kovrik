namespace kovrik
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.играToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.новаяИграToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.перемешатьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.описаниеПасьянсаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.играToolStripMenuItem,
            this.справкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(930, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // играToolStripMenuItem
            // 
            this.играToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.новаяИграToolStripMenuItem,
            this.перемешатьToolStripMenuItem});
            this.играToolStripMenuItem.Name = "играToolStripMenuItem";
            this.играToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.играToolStripMenuItem.Text = "Игра";
            this.играToolStripMenuItem.Click += new System.EventHandler(this.играToolStripMenuItem_Click);
            // 
            // новаяИграToolStripMenuItem
            // 
            this.новаяИграToolStripMenuItem.Name = "новаяИграToolStripMenuItem";
            this.новаяИграToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.новаяИграToolStripMenuItem.Text = "Новая игра";
            this.новаяИграToolStripMenuItem.Click += new System.EventHandler(this.новаяИграToolStripMenuItem_Click);
            this.новаяИграToolStripMenuItem.Paint += new System.Windows.Forms.PaintEventHandler(this.новаяИграToolStripMenuItem_Paint);
            // 
            // перемешатьToolStripMenuItem
            // 
            this.перемешатьToolStripMenuItem.Name = "перемешатьToolStripMenuItem";
            this.перемешатьToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.перемешатьToolStripMenuItem.Text = "Перемешать";
            this.перемешатьToolStripMenuItem.Click += new System.EventHandler(this.перемешатьToolStripMenuItem_Click);
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.описаниеПасьянсаToolStripMenuItem});
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.справкаToolStripMenuItem.Text = "Справка";
            // 
            // описаниеПасьянсаToolStripMenuItem
            // 
            this.описаниеПасьянсаToolStripMenuItem.Name = "описаниеПасьянсаToolStripMenuItem";
            this.описаниеПасьянсаToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.описаниеПасьянсаToolStripMenuItem.Text = "Описание пасьянса";
            this.описаниеПасьянсаToolStripMenuItem.Click += new System.EventHandler(this.описаниеПасьянсаToolStripMenuItem_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "0.bmp");
            this.imageList1.Images.SetKeyName(1, "1.bmp");
            this.imageList1.Images.SetKeyName(2, "2.bmp");
            this.imageList1.Images.SetKeyName(3, "3.bmp");
            this.imageList1.Images.SetKeyName(4, "4.bmp");
            this.imageList1.Images.SetKeyName(5, "5.bmp");
            this.imageList1.Images.SetKeyName(6, "6.bmp");
            this.imageList1.Images.SetKeyName(7, "7.bmp");
            this.imageList1.Images.SetKeyName(8, "8.bmp");
            this.imageList1.Images.SetKeyName(9, "9.bmp");
            this.imageList1.Images.SetKeyName(10, "10.bmp");
            this.imageList1.Images.SetKeyName(11, "11.bmp");
            this.imageList1.Images.SetKeyName(12, "12.bmp");
            this.imageList1.Images.SetKeyName(13, "13.bmp");
            this.imageList1.Images.SetKeyName(14, "14.bmp");
            this.imageList1.Images.SetKeyName(15, "15.bmp");
            this.imageList1.Images.SetKeyName(16, "16.bmp");
            this.imageList1.Images.SetKeyName(17, "17.bmp");
            this.imageList1.Images.SetKeyName(18, "18.bmp");
            this.imageList1.Images.SetKeyName(19, "19.bmp");
            this.imageList1.Images.SetKeyName(20, "20.bmp");
            this.imageList1.Images.SetKeyName(21, "21.bmp");
            this.imageList1.Images.SetKeyName(22, "22.bmp");
            this.imageList1.Images.SetKeyName(23, "23.bmp");
            this.imageList1.Images.SetKeyName(24, "24.bmp");
            this.imageList1.Images.SetKeyName(25, "25.bmp");
            this.imageList1.Images.SetKeyName(26, "26.bmp");
            this.imageList1.Images.SetKeyName(27, "27.bmp");
            this.imageList1.Images.SetKeyName(28, "28.bmp");
            this.imageList1.Images.SetKeyName(29, "29.bmp");
            this.imageList1.Images.SetKeyName(30, "30.bmp");
            this.imageList1.Images.SetKeyName(31, "31.bmp");
            this.imageList1.Images.SetKeyName(32, "32.bmp");
            this.imageList1.Images.SetKeyName(33, "33.bmp");
            this.imageList1.Images.SetKeyName(34, "34.bmp");
            this.imageList1.Images.SetKeyName(35, "35.bmp");
            this.imageList1.Images.SetKeyName(36, "36.bmp");
            this.imageList1.Images.SetKeyName(37, "37.bmp");
            this.imageList1.Images.SetKeyName(38, "38.bmp");
            this.imageList1.Images.SetKeyName(39, "39.bmp");
            this.imageList1.Images.SetKeyName(40, "40.bmp");
            this.imageList1.Images.SetKeyName(41, "41.bmp");
            this.imageList1.Images.SetKeyName(42, "42.bmp");
            this.imageList1.Images.SetKeyName(43, "43.bmp");
            this.imageList1.Images.SetKeyName(44, "44.bmp");
            this.imageList1.Images.SetKeyName(45, "45.bmp");
            this.imageList1.Images.SetKeyName(46, "46.bmp");
            this.imageList1.Images.SetKeyName(47, "47.bmp");
            this.imageList1.Images.SetKeyName(48, "48.bmp");
            this.imageList1.Images.SetKeyName(49, "49.bmp");
            this.imageList1.Images.SetKeyName(50, "50.bmp");
            this.imageList1.Images.SetKeyName(51, "51.bmp");
            this.imageList1.Images.SetKeyName(52, "52.bmp");
            this.imageList1.Images.SetKeyName(53, "53.bmp");
            this.imageList1.Images.SetKeyName(54, "54.bmp");
            this.imageList1.Images.SetKeyName(55, "55.bmp");
            this.imageList1.Images.SetKeyName(56, "56.bmp");
            this.imageList1.Images.SetKeyName(57, "57.bmp");
            this.imageList1.Images.SetKeyName(58, "58.bmp");
            this.imageList1.Images.SetKeyName(59, "59.bmp");
            this.imageList1.Images.SetKeyName(60, "60.bmp");
            this.imageList1.Images.SetKeyName(61, "61.bmp");
            this.imageList1.Images.SetKeyName(62, "62.bmp");
            this.imageList1.Images.SetKeyName(63, "63.bmp");
            this.imageList1.Images.SetKeyName(64, "64.bmp");
            this.imageList1.Images.SetKeyName(65, "65.bmp");
            this.imageList1.Images.SetKeyName(66, "66.bmp");
            this.imageList1.Images.SetKeyName(67, "67.bmp");
            this.imageList1.Images.SetKeyName(68, "68.bmp");
            this.imageList1.Images.SetKeyName(69, "69.bmp");
            this.imageList1.Images.SetKeyName(70, "70.bmp");
            this.imageList1.Images.SetKeyName(71, "71.bmp");
            this.imageList1.Images.SetKeyName(72, "72.bmp");
            this.imageList1.Images.SetKeyName(73, "73.bmp");
            this.imageList1.Images.SetKeyName(74, "74.bmp");
            this.imageList1.Images.SetKeyName(75, "75.bmp");
            this.imageList1.Images.SetKeyName(76, "76.bmp");
            this.imageList1.Images.SetKeyName(77, "77.bmp");
            this.imageList1.Images.SetKeyName(78, "78.bmp");
            this.imageList1.Images.SetKeyName(79, "79.bmp");
            this.imageList1.Images.SetKeyName(80, "80.bmp");
            this.imageList1.Images.SetKeyName(81, "81.bmp");
            this.imageList1.Images.SetKeyName(82, "82.bmp");
            this.imageList1.Images.SetKeyName(83, "83.bmp");
            this.imageList1.Images.SetKeyName(84, "84.bmp");
            this.imageList1.Images.SetKeyName(85, "85.bmp");
            this.imageList1.Images.SetKeyName(86, "86.bmp");
            this.imageList1.Images.SetKeyName(87, "87.bmp");
            this.imageList1.Images.SetKeyName(88, "88.bmp");
            this.imageList1.Images.SetKeyName(89, "89.bmp");
            this.imageList1.Images.SetKeyName(90, "90.bmp");
            this.imageList1.Images.SetKeyName(91, "91.bmp");
            this.imageList1.Images.SetKeyName(92, "92.bmp");
            this.imageList1.Images.SetKeyName(93, "93.bmp");
            this.imageList1.Images.SetKeyName(94, "94.bmp");
            this.imageList1.Images.SetKeyName(95, "95.bmp");
            this.imageList1.Images.SetKeyName(96, "96.bmp");
            this.imageList1.Images.SetKeyName(97, "97.bmp");
            this.imageList1.Images.SetKeyName(98, "98.bmp");
            this.imageList1.Images.SetKeyName(99, "99.bmp");
            this.imageList1.Images.SetKeyName(100, "100.bmp");
            this.imageList1.Images.SetKeyName(101, "101.bmp");
            this.imageList1.Images.SetKeyName(102, "102.bmp");
            this.imageList1.Images.SetKeyName(103, "103.bmp");
            this.imageList1.Images.SetKeyName(104, "104.bmp");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LimeGreen;
            this.ClientSize = new System.Drawing.Size(930, 379);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Пасьянс";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem играToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem новаяИграToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem описаниеПасьянсаToolStripMenuItem;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ToolStripMenuItem перемешатьToolStripMenuItem;
    }
}

