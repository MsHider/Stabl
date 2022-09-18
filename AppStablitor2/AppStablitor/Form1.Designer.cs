
namespace AppStablitor
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
            this.gp1 = new System.Windows.Forms.GroupBox();
            this.gp2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tLogin = new System.Windows.Forms.TextBox();
            this.tFIO = new System.Windows.Forms.TextBox();
            this.tSport = new System.Windows.Forms.TextBox();
            this.tNewLogin = new System.Windows.Forms.TextBox();
            this.tNewPass = new System.Windows.Forms.TextBox();
            this.tPass = new System.Windows.Forms.TextBox();
            this.nAge = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.btReg = new System.Windows.Forms.Button();
            this.gp1.SuspendLayout();
            this.gp2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nAge)).BeginInit();
            this.SuspendLayout();
            // 
            // gp1
            // 
            this.gp1.Controls.Add(this.button1);
            this.gp1.Controls.Add(this.tPass);
            this.gp1.Controls.Add(this.tLogin);
            this.gp1.Controls.Add(this.label2);
            this.gp1.Controls.Add(this.label1);
            this.gp1.Location = new System.Drawing.Point(11, 11);
            this.gp1.Name = "gp1";
            this.gp1.Size = new System.Drawing.Size(342, 145);
            this.gp1.TabIndex = 0;
            this.gp1.TabStop = false;
            this.gp1.Text = "Вход пользователя";
            // 
            // gp2
            // 
            this.gp2.Controls.Add(this.btReg);
            this.gp2.Controls.Add(this.nAge);
            this.gp2.Controls.Add(this.tNewPass);
            this.gp2.Controls.Add(this.tNewLogin);
            this.gp2.Controls.Add(this.tSport);
            this.gp2.Controls.Add(this.tFIO);
            this.gp2.Controls.Add(this.label7);
            this.gp2.Controls.Add(this.label6);
            this.gp2.Controls.Add(this.label5);
            this.gp2.Controls.Add(this.label4);
            this.gp2.Controls.Add(this.label3);
            this.gp2.Location = new System.Drawing.Point(12, 162);
            this.gp2.Name = "gp2";
            this.gp2.Size = new System.Drawing.Size(341, 268);
            this.gp2.TabIndex = 1;
            this.gp2.TabStop = false;
            this.gp2.Text = "Регистрация нового пользователя";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Логин:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Пароль:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "ФИО:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Возраст:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Вид спорта:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 145);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Логин:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(5, 186);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Пароль:";
            // 
            // tLogin
            // 
            this.tLogin.Location = new System.Drawing.Point(6, 42);
            this.tLogin.Name = "tLogin";
            this.tLogin.Size = new System.Drawing.Size(329, 20);
            this.tLogin.TabIndex = 2;
            // 
            // tFIO
            // 
            this.tFIO.Location = new System.Drawing.Point(6, 40);
            this.tFIO.Name = "tFIO";
            this.tFIO.Size = new System.Drawing.Size(326, 20);
            this.tFIO.TabIndex = 3;
            // 
            // tSport
            // 
            this.tSport.Location = new System.Drawing.Point(6, 119);
            this.tSport.Name = "tSport";
            this.tSport.Size = new System.Drawing.Size(326, 20);
            this.tSport.TabIndex = 6;
            // 
            // tNewLogin
            // 
            this.tNewLogin.Location = new System.Drawing.Point(6, 163);
            this.tNewLogin.Name = "tNewLogin";
            this.tNewLogin.Size = new System.Drawing.Size(326, 20);
            this.tNewLogin.TabIndex = 7;
            // 
            // tNewPass
            // 
            this.tNewPass.Location = new System.Drawing.Point(6, 204);
            this.tNewPass.Name = "tNewPass";
            this.tNewPass.Size = new System.Drawing.Size(326, 20);
            this.tNewPass.TabIndex = 8;
            // 
            // tPass
            // 
            this.tPass.Location = new System.Drawing.Point(6, 81);
            this.tPass.Name = "tPass";
            this.tPass.PasswordChar = '*';
            this.tPass.Size = new System.Drawing.Size(329, 20);
            this.tPass.TabIndex = 9;
            // 
            // nAge
            // 
            this.nAge.Location = new System.Drawing.Point(6, 80);
            this.nAge.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nAge.Name = "nAge";
            this.nAge.Size = new System.Drawing.Size(120, 20);
            this.nAge.TabIndex = 9;
            this.nAge.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 116);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(329, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Войти";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btReg
            // 
            this.btReg.Location = new System.Drawing.Point(5, 237);
            this.btReg.Name = "btReg";
            this.btReg.Size = new System.Drawing.Size(329, 23);
            this.btReg.TabIndex = 11;
            this.btReg.Text = "Регистрация";
            this.btReg.UseVisualStyleBackColor = true;
            this.btReg.Click += new System.EventHandler(this.btReg_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 434);
            this.Controls.Add(this.gp2);
            this.Controls.Add(this.gp1);
            this.Name = "Form1";
            this.Text = "Авторизация";
            this.gp1.ResumeLayout(false);
            this.gp1.PerformLayout();
            this.gp2.ResumeLayout(false);
            this.gp2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nAge)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gp1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tPass;
        private System.Windows.Forms.TextBox tLogin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gp2;
        private System.Windows.Forms.Button btReg;
        private System.Windows.Forms.NumericUpDown nAge;
        private System.Windows.Forms.TextBox tNewPass;
        private System.Windows.Forms.TextBox tNewLogin;
        private System.Windows.Forms.TextBox tSport;
        private System.Windows.Forms.TextBox tFIO;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}

