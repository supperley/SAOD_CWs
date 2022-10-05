namespace CW_Stack
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
            this.Btn_add = new System.Windows.Forms.Button();
            this.Btn_delete = new System.Windows.Forms.Button();
            this.Btn_clear = new System.Windows.Forms.Button();
            this.Btn_about = new System.Windows.Forms.Button();
            this.TB_input = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listView_stack = new System.Windows.Forms.ListView();
            this.ColumnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // Btn_add
            // 
            this.Btn_add.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Btn_add.Location = new System.Drawing.Point(12, 387);
            this.Btn_add.Name = "Btn_add";
            this.Btn_add.Size = new System.Drawing.Size(120, 40);
            this.Btn_add.TabIndex = 1;
            this.Btn_add.Text = "Добавить";
            this.Btn_add.UseVisualStyleBackColor = true;
            this.Btn_add.Click += new System.EventHandler(this.Btn_add_Click);
            // 
            // Btn_delete
            // 
            this.Btn_delete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Btn_delete.Location = new System.Drawing.Point(138, 387);
            this.Btn_delete.Name = "Btn_delete";
            this.Btn_delete.Size = new System.Drawing.Size(120, 40);
            this.Btn_delete.TabIndex = 2;
            this.Btn_delete.Text = "Удалить";
            this.Btn_delete.UseVisualStyleBackColor = true;
            this.Btn_delete.Click += new System.EventHandler(this.Btn_delete_Click);
            // 
            // Btn_clear
            // 
            this.Btn_clear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Btn_clear.Location = new System.Drawing.Point(264, 387);
            this.Btn_clear.Name = "Btn_clear";
            this.Btn_clear.Size = new System.Drawing.Size(120, 40);
            this.Btn_clear.TabIndex = 3;
            this.Btn_clear.Text = "Очистить";
            this.Btn_clear.UseVisualStyleBackColor = true;
            this.Btn_clear.Click += new System.EventHandler(this.Btn_clear_Click);
            // 
            // Btn_about
            // 
            this.Btn_about.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Btn_about.Location = new System.Drawing.Point(390, 387);
            this.Btn_about.Name = "Btn_about";
            this.Btn_about.Size = new System.Drawing.Size(120, 40);
            this.Btn_about.TabIndex = 4;
            this.Btn_about.Text = "О программе";
            this.Btn_about.UseVisualStyleBackColor = true;
            this.Btn_about.Click += new System.EventHandler(this.Btn_about_Click);
            // 
            // TB_input
            // 
            this.TB_input.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TB_input.Location = new System.Drawing.Point(12, 29);
            this.TB_input.Name = "TB_input";
            this.TB_input.Size = new System.Drawing.Size(498, 28);
            this.TB_input.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Ввод информации";
            // 
            // listView_stack
            // 
            this.listView_stack.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView_stack.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColumnHeader1,
            this.ColumnHeader2,
            this.ColumnHeader3});
            this.listView_stack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.listView_stack.HideSelection = false;
            this.listView_stack.Location = new System.Drawing.Point(12, 63);
            this.listView_stack.Name = "listView_stack";
            this.listView_stack.Size = new System.Drawing.Size(498, 318);
            this.listView_stack.TabIndex = 7;
            this.listView_stack.UseCompatibleStateImageBehavior = false;
            this.listView_stack.View = System.Windows.Forms.View.Details;
            // 
            // ColumnHeader1
            // 
            this.ColumnHeader1.Text = "Данные";
            this.ColumnHeader1.Width = 160;
            // 
            // ColumnHeader2
            // 
            this.ColumnHeader2.Text = "Текущий адрес";
            this.ColumnHeader2.Width = 160;
            // 
            // ColumnHeader3
            // 
            this.ColumnHeader3.Text = "Адрес предыдущего";
            this.ColumnHeader3.Width = 160;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 439);
            this.Controls.Add(this.listView_stack);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TB_input);
            this.Controls.Add(this.Btn_about);
            this.Controls.Add(this.Btn_clear);
            this.Controls.Add(this.Btn_delete);
            this.Controls.Add(this.Btn_add);
            this.Name = "Form1";
            this.Text = "Курсовая работа - стек";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Btn_add;
        private System.Windows.Forms.Button Btn_delete;
        private System.Windows.Forms.Button Btn_clear;
        private System.Windows.Forms.Button Btn_about;
        private System.Windows.Forms.TextBox TB_input;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listView_stack;
        private System.Windows.Forms.ColumnHeader ColumnHeader1;
        private System.Windows.Forms.ColumnHeader ColumnHeader2;
        private System.Windows.Forms.ColumnHeader ColumnHeader3;
    }
}

