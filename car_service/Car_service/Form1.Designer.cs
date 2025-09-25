namespace Car_service
{
    partial class Form1
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Name_s = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tools = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.скинутиФільтриToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.очитиститиСписокToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.додатиПослугуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.пошукПослугиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сортуванняToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.назваToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.аЯToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.яАToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.цінаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.відкиритиЗФайлуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.зберегтиУФайлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вихідToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.Service_name = new System.Windows.Forms.TextBox();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.очиститиУсіПоляToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Material_for_service = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Price_for_service = new System.Windows.Forms.TextBox();
            this.змінитиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Name_s,
            this.Tools,
            this.Price});
            this.dataGridView1.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridView1.Location = new System.Drawing.Point(12, 34);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(483, 207);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Name_s
            // 
            this.Name_s.HeaderText = "Назва послуги";
            this.Name_s.MinimumWidth = 6;
            this.Name_s.Name = "Name_s";
            this.Name_s.ReadOnly = true;
            this.Name_s.Width = 150;
            // 
            // Tools
            // 
            this.Tools.HeaderText = "Необхідні знаряддя";
            this.Tools.MinimumWidth = 6;
            this.Tools.Name = "Tools";
            this.Tools.ReadOnly = true;
            this.Tools.Width = 150;
            // 
            // Price
            // 
            this.Price.HeaderText = "Ціна";
            this.Price.MinimumWidth = 6;
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            this.Price.Width = 75;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.скинутиФільтриToolStripMenuItem,
            this.очитиститиСписокToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(194, 52);
            // 
            // скинутиФільтриToolStripMenuItem
            // 
            this.скинутиФільтриToolStripMenuItem.Name = "скинутиФільтриToolStripMenuItem";
            this.скинутиФільтриToolStripMenuItem.Size = new System.Drawing.Size(193, 24);
            this.скинутиФільтриToolStripMenuItem.Text = "Скинути фільтри";
            this.скинутиФільтриToolStripMenuItem.Click += new System.EventHandler(this.скинутиФільтриToolStripMenuItem_Click);
            // 
            // очитиститиСписокToolStripMenuItem
            // 
            this.очитиститиСписокToolStripMenuItem.Name = "очитиститиСписокToolStripMenuItem";
            this.очитиститиСписокToolStripMenuItem.Size = new System.Drawing.Size(193, 24);
            this.очитиститиСписокToolStripMenuItem.Text = "очистити список";
            this.очитиститиСписокToolStripMenuItem.Click += new System.EventHandler(this.очитиститиСписокToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.додатиПослугуToolStripMenuItem,
            this.пошукПослугиToolStripMenuItem,
            this.сортуванняToolStripMenuItem,
            this.змінитиToolStripMenuItem,
            this.файлToolStripMenuItem,
            this.вихідToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(813, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // додатиПослугуToolStripMenuItem
            // 
            this.додатиПослугуToolStripMenuItem.Name = "додатиПослугуToolStripMenuItem";
            this.додатиПослугуToolStripMenuItem.Size = new System.Drawing.Size(130, 24);
            this.додатиПослугуToolStripMenuItem.Text = "Додати послугу";
            this.додатиПослугуToolStripMenuItem.Click += new System.EventHandler(this.додатиПослугуToolStripMenuItem_Click);
            // 
            // пошукПослугиToolStripMenuItem
            // 
            this.пошукПослугиToolStripMenuItem.Name = "пошукПослугиToolStripMenuItem";
            this.пошукПослугиToolStripMenuItem.Size = new System.Drawing.Size(128, 24);
            this.пошукПослугиToolStripMenuItem.Text = "Пошук послуги";
            this.пошукПослугиToolStripMenuItem.Click += new System.EventHandler(this.пошукПослугиToolStripMenuItem_Click);
            // 
            // сортуванняToolStripMenuItem
            // 
            this.сортуванняToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.назваToolStripMenuItem,
            this.цінаToolStripMenuItem});
            this.сортуванняToolStripMenuItem.Name = "сортуванняToolStripMenuItem";
            this.сортуванняToolStripMenuItem.Size = new System.Drawing.Size(109, 24);
            this.сортуванняToolStripMenuItem.Text = "Сортування ";
            // 
            // назваToolStripMenuItem
            // 
            this.назваToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.аЯToolStripMenuItem,
            this.яАToolStripMenuItem1});
            this.назваToolStripMenuItem.Name = "назваToolStripMenuItem";
            this.назваToolStripMenuItem.Size = new System.Drawing.Size(134, 26);
            this.назваToolStripMenuItem.Text = "Назва";
            // 
            // аЯToolStripMenuItem
            // 
            this.аЯToolStripMenuItem.Name = "аЯToolStripMenuItem";
            this.аЯToolStripMenuItem.Size = new System.Drawing.Size(117, 26);
            this.аЯToolStripMenuItem.Text = "А-Я";
            this.аЯToolStripMenuItem.Click += new System.EventHandler(this.аЯToolStripMenuItem_Click);
            // 
            // яАToolStripMenuItem1
            // 
            this.яАToolStripMenuItem1.Name = "яАToolStripMenuItem1";
            this.яАToolStripMenuItem1.Size = new System.Drawing.Size(117, 26);
            this.яАToolStripMenuItem1.Text = "Я-А";
            this.яАToolStripMenuItem1.Click += new System.EventHandler(this.яАToolStripMenuItem1_Click);
            // 
            // цінаToolStripMenuItem
            // 
            this.цінаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.toolStripMenuItem3});
            this.цінаToolStripMenuItem.Name = "цінаToolStripMenuItem";
            this.цінаToolStripMenuItem.Size = new System.Drawing.Size(134, 26);
            this.цінаToolStripMenuItem.Text = "Ціна";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(114, 26);
            this.toolStripMenuItem2.Text = "1-9";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(114, 26);
            this.toolStripMenuItem3.Text = "9-1";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.відкиритиЗФайлуToolStripMenuItem,
            this.зберегтиУФайлToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(59, 24);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // відкиритиЗФайлуToolStripMenuItem
            // 
            this.відкиритиЗФайлуToolStripMenuItem.Name = "відкиритиЗФайлуToolStripMenuItem";
            this.відкиритиЗФайлуToolStripMenuItem.Size = new System.Drawing.Size(219, 26);
            this.відкиритиЗФайлуToolStripMenuItem.Text = "Відкирити з файлу";
            this.відкиритиЗФайлуToolStripMenuItem.Click += new System.EventHandler(this.відкиритиЗФайлуToolStripMenuItem_Click);
            // 
            // зберегтиУФайлToolStripMenuItem
            // 
            this.зберегтиУФайлToolStripMenuItem.Name = "зберегтиУФайлToolStripMenuItem";
            this.зберегтиУФайлToolStripMenuItem.Size = new System.Drawing.Size(219, 26);
            this.зберегтиУФайлToolStripMenuItem.Text = "Зберегти у файл";
            this.зберегтиУФайлToolStripMenuItem.Click += new System.EventHandler(this.зберегтиУФайлToolStripMenuItem_Click);
            // 
            // вихідToolStripMenuItem
            // 
            this.вихідToolStripMenuItem.Name = "вихідToolStripMenuItem";
            this.вихідToolStripMenuItem.Size = new System.Drawing.Size(60, 24);
            this.вихідToolStripMenuItem.Text = "Вихід";
            this.вихідToolStripMenuItem.Click += new System.EventHandler(this.вихідToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Service_name
            // 
            this.Service_name.ContextMenuStrip = this.contextMenuStrip2;
            this.Service_name.Location = new System.Drawing.Point(638, 34);
            this.Service_name.Multiline = true;
            this.Service_name.Name = "Service_name";
            this.Service_name.Size = new System.Drawing.Size(141, 30);
            this.Service_name.TabIndex = 2;
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.очиститиУсіПоляToolStripMenuItem});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(202, 28);
            // 
            // очиститиУсіПоляToolStripMenuItem
            // 
            this.очиститиУсіПоляToolStripMenuItem.Name = "очиститиУсіПоляToolStripMenuItem";
            this.очиститиУсіПоляToolStripMenuItem.Size = new System.Drawing.Size(201, 24);
            this.очиститиУсіПоляToolStripMenuItem.Text = "очистити усі поля";
            this.очиститиУсіПоляToolStripMenuItem.Click += new System.EventHandler(this.очиститиУсіПоляToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(501, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Назва послуги";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(501, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Необхідні знаряддя";
            // 
            // Material_for_service
            // 
            this.Material_for_service.ContextMenuStrip = this.contextMenuStrip2;
            this.Material_for_service.Location = new System.Drawing.Point(638, 70);
            this.Material_for_service.Multiline = true;
            this.Material_for_service.Name = "Material_for_service";
            this.Material_for_service.Size = new System.Drawing.Size(141, 30);
            this.Material_for_service.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(501, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Ціна";
            // 
            // Price_for_service
            // 
            this.Price_for_service.ContextMenuStrip = this.contextMenuStrip2;
            this.Price_for_service.Location = new System.Drawing.Point(638, 106);
            this.Price_for_service.Multiline = true;
            this.Price_for_service.Name = "Price_for_service";
            this.Price_for_service.Size = new System.Drawing.Size(141, 30);
            this.Price_for_service.TabIndex = 6;
            // 
            // змінитиToolStripMenuItem
            // 
            this.змінитиToolStripMenuItem.Name = "змінитиToolStripMenuItem";
            this.змінитиToolStripMenuItem.Size = new System.Drawing.Size(79, 24);
            this.змінитиToolStripMenuItem.Text = "Змінити";
            this.змінитиToolStripMenuItem.Click += new System.EventHandler(this.змінитиToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 257);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Price_for_service);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Material_for_service);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Service_name);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Автосервіс";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem додатиПослугуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem пошукПослугиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сортуванняToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вихідToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.TextBox Service_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Material_for_service;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Price_for_service;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem відкиритиЗФайлуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem зберегтиУФайлToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name_s;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tools;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem скинутиФільтриToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem очиститиУсіПоляToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem назваToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem цінаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem аЯToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem яАToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem очитиститиСписокToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem змінитиToolStripMenuItem;
    }
}

