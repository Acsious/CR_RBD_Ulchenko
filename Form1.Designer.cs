namespace CR_RBD_Ulchenko
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
            ChangeUserInfoButton = new Button();
            MakeSignUpButton = new Button();
            DeleteSignUpButton = new Button();
            SolveTickets = new Button();
            SolveQuestions = new Button();
            SuspendLayout();
            // 
            // ChangeUserInfoButton
            // 
            ChangeUserInfoButton.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            ChangeUserInfoButton.Location = new Point(33, 31);
            ChangeUserInfoButton.Name = "ChangeUserInfoButton";
            ChangeUserInfoButton.Size = new Size(446, 43);
            ChangeUserInfoButton.TabIndex = 0;
            ChangeUserInfoButton.Text = "Изменить личную информацию";
            ChangeUserInfoButton.UseVisualStyleBackColor = true;
            ChangeUserInfoButton.Click += ChangeUserInfoButton_Click;
            // 
            // MakeSignUpButton
            // 
            MakeSignUpButton.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            MakeSignUpButton.Location = new Point(33, 105);
            MakeSignUpButton.Name = "MakeSignUpButton";
            MakeSignUpButton.Size = new Size(446, 43);
            MakeSignUpButton.TabIndex = 1;
            MakeSignUpButton.Text = "Записаться на занятие";
            MakeSignUpButton.UseVisualStyleBackColor = true;
            MakeSignUpButton.Click += MakeSignUpButton_Click;
            // 
            // DeleteSignUpButton
            // 
            DeleteSignUpButton.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            DeleteSignUpButton.Location = new Point(33, 181);
            DeleteSignUpButton.Name = "DeleteSignUpButton";
            DeleteSignUpButton.Size = new Size(446, 43);
            DeleteSignUpButton.TabIndex = 2;
            DeleteSignUpButton.Text = "Отменить запись на занятие";
            DeleteSignUpButton.UseVisualStyleBackColor = true;
            // 
            // SolveTickets
            // 
            SolveTickets.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            SolveTickets.Location = new Point(33, 261);
            SolveTickets.Name = "SolveTickets";
            SolveTickets.Size = new Size(446, 43);
            SolveTickets.TabIndex = 3;
            SolveTickets.Text = "Решать билеты";
            SolveTickets.UseVisualStyleBackColor = true;
            SolveTickets.Click += SolveTickets_Click;
            // 
            // SolveQuestions
            // 
            SolveQuestions.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            SolveQuestions.Location = new Point(33, 340);
            SolveQuestions.Name = "SolveQuestions";
            SolveQuestions.Size = new Size(446, 43);
            SolveQuestions.TabIndex = 4;
            SolveQuestions.Text = "Решать вопросы";
            SolveQuestions.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(514, 421);
            Controls.Add(SolveQuestions);
            Controls.Add(SolveTickets);
            Controls.Add(DeleteSignUpButton);
            Controls.Add(MakeSignUpButton);
            Controls.Add(ChangeUserInfoButton);
            Name = "Form1";
            Text = "Приложение курсанта для информационной системы автошколы";
            ResumeLayout(false);
        }

        #endregion

        private Button ChangeUserInfoButton;
        private Button MakeSignUpButton;
        private Button DeleteSignUpButton;
        private Button SolveTickets;
        private Button SolveQuestions;
    }
}