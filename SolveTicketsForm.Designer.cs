﻿namespace CR_RBD_Ulchenko
{
    partial class SolveTicketsForm
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
            Ticket1Button = new Button();
            Ticket2Button = new Button();
            Ticket3Button = new Button();
            Ticket4Button = new Button();
            SuspendLayout();
            // 
            // Ticket1Button
            // 
            Ticket1Button.Location = new Point(12, 18);
            Ticket1Button.Name = "Ticket1Button";
            Ticket1Button.Size = new Size(92, 82);
            Ticket1Button.TabIndex = 0;
            Ticket1Button.Text = "Билет 1";
            Ticket1Button.UseVisualStyleBackColor = true;
            Ticket1Button.Click += Ticket1Button_Click;
            // 
            // Ticket2Button
            // 
            Ticket2Button.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Ticket2Button.Location = new Point(140, 18);
            Ticket2Button.Name = "Ticket2Button";
            Ticket2Button.Size = new Size(92, 82);
            Ticket2Button.TabIndex = 1;
            Ticket2Button.Text = "Билет 2";
            Ticket2Button.UseVisualStyleBackColor = true;
            Ticket2Button.Click += Ticket2Button_Click;
            // 
            // Ticket3Button
            // 
            Ticket3Button.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            Ticket3Button.Location = new Point(12, 133);
            Ticket3Button.Name = "Ticket3Button";
            Ticket3Button.Size = new Size(92, 82);
            Ticket3Button.TabIndex = 2;
            Ticket3Button.Text = "Билет 3";
            Ticket3Button.UseVisualStyleBackColor = true;
            Ticket3Button.Click += Ticket3Button_Click;
            // 
            // Ticket4Button
            // 
            Ticket4Button.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            Ticket4Button.Location = new Point(140, 133);
            Ticket4Button.Name = "Ticket4Button";
            Ticket4Button.Size = new Size(92, 82);
            Ticket4Button.TabIndex = 3;
            Ticket4Button.Text = "Билет 4";
            Ticket4Button.UseVisualStyleBackColor = true;
            Ticket4Button.Click += Ticket4Button_Click;
            // 
            // SolveTicketsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(244, 227);
            Controls.Add(Ticket4Button);
            Controls.Add(Ticket3Button);
            Controls.Add(Ticket2Button);
            Controls.Add(Ticket1Button);
            Name = "SolveTicketsForm";
            Text = "Решать билеты";
            ResumeLayout(false);
        }

        #endregion

        private Button Ticket1Button;
        private Button Ticket2Button;
        private Button Ticket3Button;
        private Button Ticket4Button;
    }
}