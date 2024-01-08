namespace CR_RBD_Ulchenko
{
    partial class ChangeUserInfoForm
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
            label1 = new Label();
            LoginTextBox = new TextBox();
            PasswordTextBox = new TextBox();
            label2 = new Label();
            SecondNameTextBox = new TextBox();
            label3 = new Label();
            FirstNameTextBox = new TextBox();
            label4 = new Label();
            MiddleNameTextBox = new TextBox();
            label5 = new Label();
            ApplyChangesButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(16, 17);
            label1.Name = "label1";
            label1.Size = new Size(56, 21);
            label1.TabIndex = 0;
            label1.Text = "Логин";
            // 
            // LoginTextBox
            // 
            LoginTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            LoginTextBox.Location = new Point(16, 47);
            LoginTextBox.MaxLength = 40;
            LoginTextBox.Name = "LoginTextBox";
            LoginTextBox.Size = new Size(296, 23);
            LoginTextBox.TabIndex = 1;
            // 
            // PasswordTextBox
            // 
            PasswordTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            PasswordTextBox.Location = new Point(16, 114);
            PasswordTextBox.MaxLength = 40;
            PasswordTextBox.Name = "PasswordTextBox";
            PasswordTextBox.Size = new Size(296, 23);
            PasswordTextBox.TabIndex = 3;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(16, 84);
            label2.Name = "label2";
            label2.Size = new Size(67, 21);
            label2.TabIndex = 2;
            label2.Text = "Пароль";
            // 
            // SecondNameTextBox
            // 
            SecondNameTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            SecondNameTextBox.Location = new Point(16, 183);
            SecondNameTextBox.MaxLength = 40;
            SecondNameTextBox.Name = "SecondNameTextBox";
            SecondNameTextBox.Size = new Size(296, 23);
            SecondNameTextBox.TabIndex = 5;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(16, 153);
            label3.Name = "label3";
            label3.Size = new Size(80, 21);
            label3.TabIndex = 4;
            label3.Text = "Фамилия";
            // 
            // FirstNameTextBox
            // 
            FirstNameTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            FirstNameTextBox.Location = new Point(16, 252);
            FirstNameTextBox.MaxLength = 40;
            FirstNameTextBox.Name = "FirstNameTextBox";
            FirstNameTextBox.Size = new Size(296, 23);
            FirstNameTextBox.TabIndex = 7;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(16, 222);
            label4.Name = "label4";
            label4.Size = new Size(43, 21);
            label4.TabIndex = 6;
            label4.Text = "Имя";
            // 
            // MiddleNameTextBox
            // 
            MiddleNameTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            MiddleNameTextBox.Location = new Point(16, 326);
            MiddleNameTextBox.MaxLength = 40;
            MiddleNameTextBox.Name = "MiddleNameTextBox";
            MiddleNameTextBox.Size = new Size(296, 23);
            MiddleNameTextBox.TabIndex = 9;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(16, 296);
            label5.Name = "label5";
            label5.Size = new Size(81, 21);
            label5.TabIndex = 8;
            label5.Text = "Отчество";
            // 
            // ApplyChangesButton
            // 
            ApplyChangesButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ApplyChangesButton.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            ApplyChangesButton.Location = new Point(16, 379);
            ApplyChangesButton.Name = "ApplyChangesButton";
            ApplyChangesButton.Size = new Size(296, 57);
            ApplyChangesButton.TabIndex = 10;
            ApplyChangesButton.Text = "Принять изменения";
            ApplyChangesButton.UseVisualStyleBackColor = true;
            ApplyChangesButton.Click += ApplyChangesButton_Click;
            // 
            // ChangeUserInfoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(324, 448);
            Controls.Add(ApplyChangesButton);
            Controls.Add(MiddleNameTextBox);
            Controls.Add(label5);
            Controls.Add(FirstNameTextBox);
            Controls.Add(label4);
            Controls.Add(SecondNameTextBox);
            Controls.Add(label3);
            Controls.Add(PasswordTextBox);
            Controls.Add(label2);
            Controls.Add(LoginTextBox);
            Controls.Add(label1);
            Name = "ChangeUserInfoForm";
            Text = "Изменение личной информации";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox LoginTextBox;
        private TextBox PasswordTextBox;
        private Label label2;
        private TextBox SecondNameTextBox;
        private Label label3;
        private TextBox FirstNameTextBox;
        private Label label4;
        private TextBox MiddleNameTextBox;
        private Label label5;
        private Button ApplyChangesButton;
    }
}