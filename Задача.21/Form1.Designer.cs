namespace Задача._21
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.coef_a = new System.Windows.Forms.TextBox();
            this.coef_b = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.coef_c = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.coef_d = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.bord_right = new System.Windows.Forms.TextBox();
            this.bord_left = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.num_part = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.answer = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(11, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(394, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Введите коэффициенты полинома 3-й степени:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(73, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "x^3 +";
            // 
            // coef_a
            // 
            this.coef_a.BackColor = System.Drawing.Color.MintCream;
            this.coef_a.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.coef_a.Location = new System.Drawing.Point(50, 45);
            this.coef_a.Name = "coef_a";
            this.coef_a.Size = new System.Drawing.Size(22, 26);
            this.coef_a.TabIndex = 0;
            this.coef_a.Text = "a";
            this.coef_a.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.coef_a.Click += new System.EventHandler(this.coef_a_Click);
            this.coef_a.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.coef_a_KeyPress);
            // 
            // coef_b
            // 
            this.coef_b.BackColor = System.Drawing.Color.MintCream;
            this.coef_b.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.coef_b.Location = new System.Drawing.Point(114, 45);
            this.coef_b.Name = "coef_b";
            this.coef_b.Size = new System.Drawing.Size(22, 26);
            this.coef_b.TabIndex = 3;
            this.coef_b.Text = "b";
            this.coef_b.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.coef_b.Click += new System.EventHandler(this.coef_b_Click);
            this.coef_b.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.coef_a_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(136, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "x^2 +";
            // 
            // coef_c
            // 
            this.coef_c.BackColor = System.Drawing.Color.MintCream;
            this.coef_c.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.coef_c.Location = new System.Drawing.Point(174, 45);
            this.coef_c.Name = "coef_c";
            this.coef_c.Size = new System.Drawing.Size(22, 26);
            this.coef_c.TabIndex = 5;
            this.coef_c.Text = "c";
            this.coef_c.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.coef_c.Click += new System.EventHandler(this.coef_c_Click);
            this.coef_c.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.coef_a_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(196, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "x +";
            // 
            // coef_d
            // 
            this.coef_d.BackColor = System.Drawing.Color.MintCream;
            this.coef_d.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.coef_d.Location = new System.Drawing.Point(223, 45);
            this.coef_d.Name = "coef_d";
            this.coef_d.Size = new System.Drawing.Size(22, 26);
            this.coef_d.TabIndex = 7;
            this.coef_d.Text = "d";
            this.coef_d.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.coef_d.Click += new System.EventHandler(this.coef_d_Click);
            this.coef_d.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.coef_a_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(15, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "f(x)=";
            // 
            // label6
            // 
            this.label6.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(11, 81);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(374, 19);
            this.label6.TabIndex = 9;
            this.label6.Text = "Введите левую и правую границу интеграла:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Narrow", 16F);
            this.label7.Location = new System.Drawing.Point(20, 139);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(18, 26);
            this.label7.TabIndex = 10;
            this.label7.Text = "∫";
            // 
            // bord_right
            // 
            this.bord_right.BackColor = System.Drawing.Color.MintCream;
            this.bord_right.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bord_right.Location = new System.Drawing.Point(18, 110);
            this.bord_right.Name = "bord_right";
            this.bord_right.Size = new System.Drawing.Size(22, 26);
            this.bord_right.TabIndex = 11;
            this.bord_right.Text = "x1";
            this.bord_right.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.bord_right.Click += new System.EventHandler(this.bord_right_Click);
            this.bord_right.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.coef_a_KeyPress);
            // 
            // bord_left
            // 
            this.bord_left.BackColor = System.Drawing.Color.MintCream;
            this.bord_left.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bord_left.Location = new System.Drawing.Point(18, 166);
            this.bord_left.Name = "bord_left";
            this.bord_left.Size = new System.Drawing.Size(22, 26);
            this.bord_left.TabIndex = 12;
            this.bord_left.Text = "x2";
            this.bord_left.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.bord_left.Click += new System.EventHandler(this.bord_left_Click);
            this.bord_left.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.coef_a_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(33, 141);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 20);
            this.label8.TabIndex = 13;
            this.label8.Text = "f(x)dx";
            // 
            // label9
            // 
            this.label9.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(11, 203);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(270, 19);
            this.label9.TabIndex = 14;
            this.label9.Text = "Введите количество разбиений:";
            // 
            // num_part
            // 
            this.num_part.BackColor = System.Drawing.Color.MintCream;
            this.num_part.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.num_part.Location = new System.Drawing.Point(18, 232);
            this.num_part.Name = "num_part";
            this.num_part.Size = new System.Drawing.Size(22, 26);
            this.num_part.TabIndex = 15;
            this.num_part.Text = "n";
            this.num_part.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.num_part.Click += new System.EventHandler(this.num_part_Click);
            this.num_part.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.num_part_KeyPress);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Honeydew;
            this.button1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(15, 271);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 32);
            this.button1.TabIndex = 16;
            this.button1.Text = "Решить";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // answer
            // 
            this.answer.BackColor = System.Drawing.Color.MintCream;
            this.answer.Enabled = false;
            this.answer.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.answer.Location = new System.Drawing.Point(73, 316);
            this.answer.Name = "answer";
            this.answer.ReadOnly = true;
            this.answer.Size = new System.Drawing.Size(209, 26);
            this.answer.TabIndex = 17;
            // 
            // label10
            // 
            this.label10.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(11, 319);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 19);
            this.label10.TabIndex = 18;
            this.label10.Text = "Ответ:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(441, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(460, 320);
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(922, 546);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.answer);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.num_part);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.bord_left);
            this.Controls.Add(this.bord_right);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.coef_d);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.coef_c);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.coef_b);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.coef_a);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Калькулятор интегралов | Полиномы 3-й степени | Метод Симпсона";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox coef_a;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox coef_b;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox coef_c;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox coef_d;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox bord_right;
        private System.Windows.Forms.TextBox bord_left;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox num_part;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox answer;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

