namespace VikaDonchenko
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
            this.button1 = new System.Windows.Forms.Button();
            this.listBoxBooks = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonImport = new System.Windows.Forms.Button();
            this.buttonExport = new System.Windows.Forms.Button();
            this.comboBoxFormat = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonConvertFormat = new System.Windows.Forms.Button();
            this.comboBoxNewFormat = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(149)))), ((int)(((byte)(212)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(312, 232);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(160, 70);
            this.button1.TabIndex = 0;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBoxBooks
            // 
            this.listBoxBooks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(205)))), ((int)(((byte)(231)))));
            this.listBoxBooks.FormattingEnabled = true;
            this.listBoxBooks.ItemHeight = 16;
            this.listBoxBooks.Location = new System.Drawing.Point(312, 320);
            this.listBoxBooks.Name = "listBoxBooks";
            this.listBoxBooks.Size = new System.Drawing.Size(1056, 308);
            this.listBoxBooks.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(424, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Название ";
            // 
            // txtTitle
            // 
            this.txtTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(205)))), ((int)(((byte)(231)))));
            this.txtTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtTitle.Location = new System.Drawing.Point(355, 183);
            this.txtTitle.Multiline = true;
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(210, 30);
            this.txtTitle.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(149)))), ((int)(((byte)(212)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(618, 232);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(160, 70);
            this.button2.TabIndex = 4;
            this.button2.Text = "Удалить";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(149)))), ((int)(((byte)(212)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(918, 232);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(160, 70);
            this.button3.TabIndex = 5;
            this.button3.Text = "Поиск по названию";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // txtAuthor
            // 
            this.txtAuthor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(205)))), ((int)(((byte)(231)))));
            this.txtAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtAuthor.Location = new System.Drawing.Point(618, 183);
            this.txtAuthor.Multiline = true;
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(210, 30);
            this.txtAuthor.TabIndex = 6;
            // 
            // txtYear
            // 
            this.txtYear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(205)))), ((int)(((byte)(231)))));
            this.txtYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtYear.Location = new System.Drawing.Point(868, 183);
            this.txtYear.Multiline = true;
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(210, 30);
            this.txtYear.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(703, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Автор";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(962, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Год";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(149)))), ((int)(((byte)(212)))));
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(1208, 232);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(160, 70);
            this.button4.TabIndex = 10;
            this.button4.Text = "Поиск по автору";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(205)))), ((int)(((byte)(231)))));
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtSearch.Location = new System.Drawing.Point(744, 76);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(210, 49);
            this.txtSearch.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(824, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "Ввести:";
            // 
            // buttonImport
            // 
            this.buttonImport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(149)))), ((int)(((byte)(212)))));
            this.buttonImport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonImport.Location = new System.Drawing.Point(59, 55);
            this.buttonImport.Name = "buttonImport";
            this.buttonImport.Size = new System.Drawing.Size(160, 70);
            this.buttonImport.TabIndex = 13;
            this.buttonImport.Text = "Импорт книг ";
            this.buttonImport.UseVisualStyleBackColor = false;
            this.buttonImport.Click += new System.EventHandler(this.buttonImport_Click);
            // 
            // buttonExport
            // 
            this.buttonExport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(149)))), ((int)(((byte)(212)))));
            this.buttonExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExport.Location = new System.Drawing.Point(59, 153);
            this.buttonExport.Name = "buttonExport";
            this.buttonExport.Size = new System.Drawing.Size(160, 70);
            this.buttonExport.TabIndex = 17;
            this.buttonExport.Text = "Экспорт книг";
            this.buttonExport.UseVisualStyleBackColor = false;
            this.buttonExport.Click += new System.EventHandler(this.buttonExportText_Click);
            // 
            // comboBoxFormat
            // 
            this.comboBoxFormat.FormattingEnabled = true;
            this.comboBoxFormat.Location = new System.Drawing.Point(1122, 189);
            this.comboBoxFormat.Name = "comboBoxFormat";
            this.comboBoxFormat.Size = new System.Drawing.Size(210, 24);
            this.comboBoxFormat.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1175, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 16);
            this.label5.TabIndex = 19;
            this.label5.Text = "Выбор формата";
            // 
            // buttonConvertFormat
            // 
            this.buttonConvertFormat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(149)))), ((int)(((byte)(212)))));
            this.buttonConvertFormat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonConvertFormat.Location = new System.Drawing.Point(59, 396);
            this.buttonConvertFormat.Name = "buttonConvertFormat";
            this.buttonConvertFormat.Size = new System.Drawing.Size(160, 70);
            this.buttonConvertFormat.TabIndex = 20;
            this.buttonConvertFormat.Text = "Изменить формат\r\n";
            this.buttonConvertFormat.UseVisualStyleBackColor = false;
            this.buttonConvertFormat.Click += new System.EventHandler(this.buttonConvertFormat_Click);
            // 
            // comboBoxNewFormat
            // 
            this.comboBoxNewFormat.FormattingEnabled = true;
            this.comboBoxNewFormat.Location = new System.Drawing.Point(35, 366);
            this.comboBoxNewFormat.Name = "comboBoxNewFormat";
            this.comboBoxNewFormat.Size = new System.Drawing.Size(210, 24);
            this.comboBoxNewFormat.TabIndex = 21;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(173)))), ((int)(((byte)(218)))));
            this.ClientSize = new System.Drawing.Size(1391, 652);
            this.Controls.Add(this.comboBoxNewFormat);
            this.Controls.Add(this.buttonConvertFormat);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBoxFormat);
            this.Controls.Add(this.buttonExport);
            this.Controls.Add(this.buttonImport);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtYear);
            this.Controls.Add(this.txtAuthor);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxBooks);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBoxBooks;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonImport;
        private System.Windows.Forms.Button buttonExport;
        private System.Windows.Forms.ComboBox comboBoxFormat;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonConvertFormat;
        private System.Windows.Forms.ComboBox comboBoxNewFormat;
    }
}

