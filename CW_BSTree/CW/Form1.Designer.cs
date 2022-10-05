namespace CW
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
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.Btn_generate = new System.Windows.Forms.Button();
            this.Btn_find = new System.Windows.Forms.Button();
            this.TB_from = new System.Windows.Forms.TextBox();
            this.TB_to = new System.Windows.Forms.TextBox();
            this.TB_find = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.SettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Num_count = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_find_step = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Num_count)).BeginInit();
            this.SuspendLayout();
            // 
            // PictureBox1
            // 
            this.PictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PictureBox1.BackColor = System.Drawing.Color.DimGray;
            this.PictureBox1.Location = new System.Drawing.Point(186, 42);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(867, 534);
            this.PictureBox1.TabIndex = 0;
            this.PictureBox1.TabStop = false;
            this.PictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.PictureBox1_Paint);
            // 
            // Btn_generate
            // 
            this.Btn_generate.Location = new System.Drawing.Point(13, 178);
            this.Btn_generate.Name = "Btn_generate";
            this.Btn_generate.Size = new System.Drawing.Size(162, 33);
            this.Btn_generate.TabIndex = 1;
            this.Btn_generate.Text = "Создать дерево";
            this.Btn_generate.UseVisualStyleBackColor = true;
            this.Btn_generate.Click += new System.EventHandler(this.Btn_generate_Click);
            // 
            // Btn_find
            // 
            this.Btn_find.Location = new System.Drawing.Point(13, 277);
            this.Btn_find.Name = "Btn_find";
            this.Btn_find.Size = new System.Drawing.Size(162, 32);
            this.Btn_find.TabIndex = 2;
            this.Btn_find.Text = "Найти";
            this.Btn_find.UseVisualStyleBackColor = true;
            this.Btn_find.Click += new System.EventHandler(this.Btn_find_Click);
            // 
            // TB_from
            // 
            this.TB_from.Location = new System.Drawing.Point(65, 80);
            this.TB_from.Name = "TB_from";
            this.TB_from.Size = new System.Drawing.Size(110, 22);
            this.TB_from.TabIndex = 3;
            // 
            // TB_to
            // 
            this.TB_to.Location = new System.Drawing.Point(65, 115);
            this.TB_to.Name = "TB_to";
            this.TB_to.Size = new System.Drawing.Size(110, 22);
            this.TB_to.TabIndex = 4;
            // 
            // TB_find
            // 
            this.TB_find.Location = new System.Drawing.Point(13, 247);
            this.TB_find.Name = "TB_find";
            this.TB_find.Size = new System.Drawing.Size(162, 22);
            this.TB_find.TabIndex = 6;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SettingsToolStripMenuItem,
            this.AboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1070, 28);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // SettingsToolStripMenuItem
            // 
            this.SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem";
            this.SettingsToolStripMenuItem.Size = new System.Drawing.Size(104, 24);
            this.SettingsToolStripMenuItem.Text = "Параметры";
            this.SettingsToolStripMenuItem.Click += new System.EventHandler(this.SettingsToolStripMenuItem_Click);
            // 
            // AboutToolStripMenuItem
            // 
            this.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem";
            this.AboutToolStripMenuItem.Size = new System.Drawing.Size(118, 24);
            this.AboutToolStripMenuItem.Text = "О программе";
            this.AboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItem_Click);
            // 
            // Num_count
            // 
            this.Num_count.Location = new System.Drawing.Point(65, 148);
            this.Num_count.Name = "Num_count";
            this.Num_count.Size = new System.Drawing.Size(110, 22);
            this.Num_count.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "От:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "До:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "Кол-во:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 32);
            this.label4.TabIndex = 12;
            this.label4.Text = "Заполнить дерево\r\nслучайными числами";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 222);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 16);
            this.label5.TabIndex = 13;
            this.label5.Text = "Найти элемент";
            // 
            // tb_find_step
            // 
            this.tb_find_step.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_find_step.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_find_step.Location = new System.Drawing.Point(186, 584);
            this.tb_find_step.Name = "tb_find_step";
            this.tb_find_step.ReadOnly = true;
            this.tb_find_step.Size = new System.Drawing.Size(867, 34);
            this.tb_find_step.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1070, 630);
            this.Controls.Add(this.tb_find_step);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Num_count);
            this.Controls.Add(this.TB_find);
            this.Controls.Add(this.TB_to);
            this.Controls.Add(this.TB_from);
            this.Controls.Add(this.Btn_find);
            this.Controls.Add(this.Btn_generate);
            this.Controls.Add(this.PictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(1000, 400);
            this.Name = "Form1";
            this.Text = "Приложение для визуализации работы бинарного дерева поиска";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Num_count)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PictureBox1;
        private System.Windows.Forms.Button Btn_generate;
        private System.Windows.Forms.Button Btn_find;
        private System.Windows.Forms.TextBox TB_from;
        private System.Windows.Forms.TextBox TB_to;
        private System.Windows.Forms.TextBox TB_find;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem AboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SettingsToolStripMenuItem;
        private System.Windows.Forms.NumericUpDown Num_count;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_find_step;
    }
}

