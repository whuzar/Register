namespace Register
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.login_txt = new System.Windows.Forms.TextBox();
            this.email_txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.password_txt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.passwd_into = new System.Windows.Forms.TextBox();
            this.loginto_txt = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(98, 241);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(161, 29);
            this.button1.TabIndex = 0;
            this.button1.Text = "Zarejestruj";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // login_txt
            // 
            this.login_txt.Location = new System.Drawing.Point(119, 73);
            this.login_txt.Name = "login_txt";
            this.login_txt.Size = new System.Drawing.Size(125, 27);
            this.login_txt.TabIndex = 1;
            this.login_txt.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // email_txt
            // 
            this.email_txt.Location = new System.Drawing.Point(119, 127);
            this.email_txt.Name = "email_txt";
            this.email_txt.Size = new System.Drawing.Size(125, 27);
            this.email_txt.TabIndex = 2;
            this.email_txt.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Login";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "E-mail";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // password_txt
            // 
            this.password_txt.Location = new System.Drawing.Point(119, 184);
            this.password_txt.Name = "password_txt";
            this.password_txt.Size = new System.Drawing.Size(125, 27);
            this.password_txt.TabIndex = 5;
            this.password_txt.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Hasło";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(139, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Rejestracja";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(513, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Logowanie";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(420, 134);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Hasło";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(420, 73);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 20);
            this.label7.TabIndex = 10;
            this.label7.Text = "Login";
            // 
            // passwd_into
            // 
            this.passwd_into.Location = new System.Drawing.Point(493, 127);
            this.passwd_into.Name = "passwd_into";
            this.passwd_into.Size = new System.Drawing.Size(125, 27);
            this.passwd_into.TabIndex = 9;
            // 
            // loginto_txt
            // 
            this.loginto_txt.Location = new System.Drawing.Point(493, 73);
            this.loginto_txt.Name = "loginto_txt";
            this.loginto_txt.Size = new System.Drawing.Size(125, 27);
            this.loginto_txt.TabIndex = 8;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(468, 241);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(161, 29);
            this.button2.TabIndex = 13;
            this.button2.Text = "Zaloguj";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(152, 291);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 20);
            this.label8.TabIndex = 14;
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(525, 191);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 20);
            this.label9.TabIndex = 15;
            this.label9.Text = "label9";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.passwd_into);
            this.Controls.Add(this.loginto_txt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.password_txt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.email_txt);
            this.Controls.Add(this.login_txt);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1;
        private TextBox login_txt;
        private TextBox email_txt;
        private Label label1;
        private Label label2;
        private TextBox password_txt;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox passwd_into;
        private TextBox loginto_txt;
        private Button button2;
        private Label label8;
        private Label label9;
    }
}