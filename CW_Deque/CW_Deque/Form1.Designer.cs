namespace CW_Deque
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
            this.textBox_input = new System.Windows.Forms.TextBox();
            this.Btn_PushFront = new System.Windows.Forms.Button();
            this.Btn_PushBack = new System.Windows.Forms.Button();
            this.Btn_PopFront = new System.Windows.Forms.Button();
            this.Btn_PopBack = new System.Windows.Forms.Button();
            this.Btn_Clear = new System.Windows.Forms.Button();
            this.Btn_IsEqual = new System.Windows.Forms.Button();
            this.Btn_Info = new System.Windows.Forms.Button();
            this.listView_deque = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.сolumnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // textBox_input
            // 
            this.textBox_input.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_input.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBox_input.Location = new System.Drawing.Point(726, 12);
            this.textBox_input.Name = "textBox_input";
            this.textBox_input.Size = new System.Drawing.Size(144, 26);
            this.textBox_input.TabIndex = 1;
            // 
            // Btn_PushFront
            // 
            this.Btn_PushFront.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_PushFront.Location = new System.Drawing.Point(726, 44);
            this.Btn_PushFront.Name = "Btn_PushFront";
            this.Btn_PushFront.Size = new System.Drawing.Size(144, 45);
            this.Btn_PushFront.TabIndex = 2;
            this.Btn_PushFront.Text = "Добавить в начало";
            this.Btn_PushFront.UseVisualStyleBackColor = true;
            this.Btn_PushFront.Click += new System.EventHandler(this.Btn_PushFront_Click);
            // 
            // Btn_PushBack
            // 
            this.Btn_PushBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_PushBack.Location = new System.Drawing.Point(726, 95);
            this.Btn_PushBack.Name = "Btn_PushBack";
            this.Btn_PushBack.Size = new System.Drawing.Size(144, 45);
            this.Btn_PushBack.TabIndex = 3;
            this.Btn_PushBack.Text = "Добавить в конец";
            this.Btn_PushBack.UseVisualStyleBackColor = true;
            this.Btn_PushBack.Click += new System.EventHandler(this.Btn_PushBack_Click);
            // 
            // Btn_PopFront
            // 
            this.Btn_PopFront.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Btn_PopFront.Location = new System.Drawing.Point(12, 396);
            this.Btn_PopFront.Name = "Btn_PopFront";
            this.Btn_PopFront.Size = new System.Drawing.Size(144, 45);
            this.Btn_PopFront.TabIndex = 4;
            this.Btn_PopFront.Text = "Удалить с начала";
            this.Btn_PopFront.UseVisualStyleBackColor = true;
            this.Btn_PopFront.Click += new System.EventHandler(this.Btn_PopFront_Click);
            // 
            // Btn_PopBack
            // 
            this.Btn_PopBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Btn_PopBack.Location = new System.Drawing.Point(162, 396);
            this.Btn_PopBack.Name = "Btn_PopBack";
            this.Btn_PopBack.Size = new System.Drawing.Size(144, 45);
            this.Btn_PopBack.TabIndex = 5;
            this.Btn_PopBack.Text = "Удалить с конца";
            this.Btn_PopBack.UseVisualStyleBackColor = true;
            this.Btn_PopBack.Click += new System.EventHandler(this.Btn_PopBack_Click);
            // 
            // Btn_Clear
            // 
            this.Btn_Clear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Btn_Clear.Location = new System.Drawing.Point(312, 396);
            this.Btn_Clear.Name = "Btn_Clear";
            this.Btn_Clear.Size = new System.Drawing.Size(144, 45);
            this.Btn_Clear.TabIndex = 6;
            this.Btn_Clear.Text = "Очистить дэк";
            this.Btn_Clear.UseVisualStyleBackColor = true;
            this.Btn_Clear.Click += new System.EventHandler(this.Btn_Clear_Click);
            // 
            // Btn_IsEqual
            // 
            this.Btn_IsEqual.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_IsEqual.Location = new System.Drawing.Point(726, 146);
            this.Btn_IsEqual.Name = "Btn_IsEqual";
            this.Btn_IsEqual.Size = new System.Drawing.Size(144, 45);
            this.Btn_IsEqual.TabIndex = 7;
            this.Btn_IsEqual.Text = "Содержится ли элемент";
            this.Btn_IsEqual.UseVisualStyleBackColor = true;
            this.Btn_IsEqual.Click += new System.EventHandler(this.Btn_IsEqual_Click);
            // 
            // Btn_Info
            // 
            this.Btn_Info.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Btn_Info.Location = new System.Drawing.Point(462, 396);
            this.Btn_Info.Name = "Btn_Info";
            this.Btn_Info.Size = new System.Drawing.Size(144, 45);
            this.Btn_Info.TabIndex = 8;
            this.Btn_Info.Text = "О программе";
            this.Btn_Info.UseVisualStyleBackColor = true;
            this.Btn_Info.Click += new System.EventHandler(this.Btn_Info_Click);
            // 
            // listView_deque
            // 
            this.listView_deque.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView_deque.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.сolumnHeader4});
            this.listView_deque.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.listView_deque.HideSelection = false;
            this.listView_deque.Location = new System.Drawing.Point(12, 12);
            this.listView_deque.Name = "listView_deque";
            this.listView_deque.Size = new System.Drawing.Size(708, 378);
            this.listView_deque.TabIndex = 9;
            this.listView_deque.UseCompatibleStateImageBehavior = false;
            this.listView_deque.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Данные";
            this.columnHeader1.Width = 170;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Адрес текущего";
            this.columnHeader2.Width = 170;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Адрес предыдущего";
            this.columnHeader3.Width = 170;
            // 
            // сolumnHeader4
            // 
            this.сolumnHeader4.Text = "Адрес следующего";
            this.сolumnHeader4.Width = 170;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 453);
            this.Controls.Add(this.listView_deque);
            this.Controls.Add(this.Btn_Info);
            this.Controls.Add(this.Btn_IsEqual);
            this.Controls.Add(this.Btn_Clear);
            this.Controls.Add(this.Btn_PopBack);
            this.Controls.Add(this.Btn_PopFront);
            this.Controls.Add(this.Btn_PushBack);
            this.Controls.Add(this.Btn_PushFront);
            this.Controls.Add(this.textBox_input);
            this.Name = "Form1";
            this.Text = "Курсовая работа";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox_input;
        private System.Windows.Forms.Button Btn_PushFront;
        private System.Windows.Forms.Button Btn_PushBack;
        private System.Windows.Forms.Button Btn_PopFront;
        private System.Windows.Forms.Button Btn_PopBack;
        private System.Windows.Forms.Button Btn_Clear;
        private System.Windows.Forms.Button Btn_IsEqual;
        private System.Windows.Forms.Button Btn_Info;
        private System.Windows.Forms.ListView listView_deque;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader сolumnHeader4;
    }
}

