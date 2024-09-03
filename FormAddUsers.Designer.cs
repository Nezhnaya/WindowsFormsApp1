namespace WindowsFormsApp1
{
    partial class FormAddUsers
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
            this.PhonemaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.roleIDComboBox = new System.Windows.Forms.ComboBox();
            this.BindingSourceRole = new System.Windows.Forms.BindingSource(this.components);
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.radioButtonMen = new System.Windows.Forms.RadioButton();
            this.radioButtonWoman = new System.Windows.Forms.RadioButton();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox2 = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.loginTextBox = new System.Windows.Forms.TextBox();
            this.first_NameTextBox = new System.Windows.Forms.TextBox();
            this.second_NameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.BindingSourceRole)).BeginInit();
            this.SuspendLayout();
            // 
            // PhonemaskedTextBox
            // 
            this.PhonemaskedTextBox.Location = new System.Drawing.Point(175, 368);
            this.PhonemaskedTextBox.Mask = "+7 (000) 000-00-00";
            this.PhonemaskedTextBox.Name = "PhonemaskedTextBox";
            this.PhonemaskedTextBox.Size = new System.Drawing.Size(100, 20);
            this.PhonemaskedTextBox.TabIndex = 0;
            // 
            // roleIDComboBox
            // 
            this.roleIDComboBox.DataSource = this.BindingSourceRole;
            this.roleIDComboBox.DisplayMember = "Name";
            this.roleIDComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.roleIDComboBox.FormattingEnabled = true;
            this.roleIDComboBox.Location = new System.Drawing.Point(520, 310);
            this.roleIDComboBox.Name = "roleIDComboBox";
            this.roleIDComboBox.Size = new System.Drawing.Size(121, 21);
            this.roleIDComboBox.TabIndex = 1;
            this.roleIDComboBox.ValueMember = "ID";
            // 
            // BindingSourceRole
            // 
            this.BindingSourceRole.DataSource = typeof(WindowsFormsApp1.DBContext.Roles);
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(88, 40);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(75, 23);
            this.buttonBack.TabIndex = 2;
            this.buttonBack.Text = "Назад";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(701, 398);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 3;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // radioButtonMen
            // 
            this.radioButtonMen.AutoSize = true;
            this.radioButtonMen.Checked = true;
            this.radioButtonMen.Location = new System.Drawing.Point(505, 353);
            this.radioButtonMen.Name = "radioButtonMen";
            this.radioButtonMen.Size = new System.Drawing.Size(71, 17);
            this.radioButtonMen.TabIndex = 4;
            this.radioButtonMen.TabStop = true;
            this.radioButtonMen.Text = "Мужской";
            this.radioButtonMen.UseVisualStyleBackColor = true;
            // 
            // radioButtonWoman
            // 
            this.radioButtonWoman.AutoSize = true;
            this.radioButtonWoman.Location = new System.Drawing.Point(596, 353);
            this.radioButtonWoman.Name = "radioButtonWoman";
            this.radioButtonWoman.Size = new System.Drawing.Size(72, 17);
            this.radioButtonWoman.TabIndex = 5;
            this.radioButtonWoman.Text = "Женский";
            this.radioButtonWoman.UseVisualStyleBackColor = true;
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(175, 310);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(100, 20);
            this.emailTextBox.TabIndex = 6;
            // 
            // passwordTextBox2
            // 
            this.passwordTextBox2.Location = new System.Drawing.Point(175, 253);
            this.passwordTextBox2.Name = "passwordTextBox2";
            this.passwordTextBox2.Size = new System.Drawing.Size(100, 20);
            this.passwordTextBox2.TabIndex = 7;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(175, 201);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '*';
            this.passwordTextBox.Size = new System.Drawing.Size(100, 20);
            this.passwordTextBox.TabIndex = 8;
            // 
            // loginTextBox
            // 
            this.loginTextBox.Location = new System.Drawing.Point(175, 145);
            this.loginTextBox.Name = "loginTextBox";
            this.loginTextBox.Size = new System.Drawing.Size(100, 20);
            this.loginTextBox.TabIndex = 9;
            // 
            // first_NameTextBox
            // 
            this.first_NameTextBox.Location = new System.Drawing.Point(520, 145);
            this.first_NameTextBox.Name = "first_NameTextBox";
            this.first_NameTextBox.Size = new System.Drawing.Size(100, 20);
            this.first_NameTextBox.TabIndex = 10;
            // 
            // second_NameTextBox
            // 
            this.second_NameTextBox.Location = new System.Drawing.Point(520, 200);
            this.second_NameTextBox.Name = "second_NameTextBox";
            this.second_NameTextBox.Size = new System.Drawing.Size(100, 20);
            this.second_NameTextBox.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Логин";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 201);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Пароль";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(68, 259);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Повтор пароля";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(68, 310);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Эл почта";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(64, 368);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Телефон";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(415, 145);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Имя";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(418, 206);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Фамилия";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(414, 316);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Роль";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(413, 353);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(27, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "Пол";
            // 
            // FormAddUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.second_NameTextBox);
            this.Controls.Add(this.first_NameTextBox);
            this.Controls.Add(this.loginTextBox);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.passwordTextBox2);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.radioButtonWoman);
            this.Controls.Add(this.radioButtonMen);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.roleIDComboBox);
            this.Controls.Add(this.PhonemaskedTextBox);
            this.Name = "FormAddUsers";
            this.Text = "FormAddUsers";
            this.Load += new System.EventHandler(this.FormAddUsers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BindingSourceRole)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox PhonemaskedTextBox;
        private System.Windows.Forms.ComboBox roleIDComboBox;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.RadioButton radioButtonMen;
        private System.Windows.Forms.RadioButton radioButtonWoman;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox passwordTextBox2;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.TextBox loginTextBox;
        private System.Windows.Forms.TextBox first_NameTextBox;
        private System.Windows.Forms.TextBox second_NameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.BindingSource BindingSourceRole;
    }
}