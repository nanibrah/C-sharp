using System.Configuration;

namespace Main
{
    partial class MainForm
    {
        // ----------------------------------------------------------------- //
        // |              DO NOT TOUCH IF YOU DONT KNOW                    | //
        // ----------------------------------------------------------------- //




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
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            login = new Button();
            textBox2 = new TextBox();
            label4 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // login
            // 
            login.Font = new Font("Segoe UI", 20F);
            login.Location = new Point(560, 303);
            login.Name = "login";
            login.Size = new Size(173, 45);
            login.TabIndex = 7;
            login.Text = "Đăng nhập";
            login.UseVisualStyleBackColor = true;
            login.Click += button1_Click;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 25F);
            textBox2.Location = new Point(525, 247);
            textBox2.MinimumSize = new Size(4, 50);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Password";
            textBox2.Size = new Size(239, 52);
            textBox2.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 20F);
            label4.Location = new Point(525, 207);
            label4.Name = "label4";
            label4.Size = new Size(134, 37);
            label4.TabIndex = 5;
            label4.Text = "Password:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 20F);
            label3.Location = new Point(525, 110);
            label3.Name = "label3";
            label3.Size = new Size(142, 37);
            label3.TabIndex = 4;
            label3.Text = "Username:";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 25F);
            textBox1.Location = new Point(525, 150);
            textBox1.MinimumSize = new Size(4, 50);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Username";
            textBox1.Size = new Size(239, 52);
            textBox1.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Variable Display", 24.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 83);
            label2.MaximumSize = new Size(490, 0);
            label2.Name = "label2";
            label2.Size = new Size(470, 308);
            label2.TabIndex = 2;
            label2.Text = "Use For Free \r\n + Antiban account\r\n + Antiban device\r\n + AimHead\r\n + Esp\r\nDM: Pham208 on discord for better version\r\n";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Snap ITC", 50.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(246, 9);
            label1.MinimumSize = new Size(500, 0);
            label1.Name = "label1";
            label1.Size = new Size(626, 86);
            label1.TabIndex = 1;
            label1.Text = "EngineCheatFF";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            AcceptButton = login;
            AccessibleRole = AccessibleRole.None;
            AllowDrop = true;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(884, 561);
            Controls.Add(login);
            Controls.Add(textBox2);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            ImeMode = ImeMode.Close;
            MaximumSize = new Size(900, 600);
            MinimumSize = new Size(900, 460);
            Name = "MainForm";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EngineCheatFF | Pham208";
            WindowState = FormWindowState.Maximized;
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        #region AfterLogin
        private void AfterLogin()
        {
            AimHead = new Label();
            ActiveAimHead = new Button();
            Fixlag = new Label();
            ActiveFixlag = new Button();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            SuspendLayout();
            //
            // Title
            //
            label1.Font = new Font("Snap ITC", 50.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(138, 9);
            label1.MinimumSize = new Size(500, 0);
            label1.Name = "label1";
            label1.Size = new Size(626, 86);
            label1.TabIndex = 1;
            label1.Text = "EngineCheatFF";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // AimHead
            // 
            AimHead.Font = new Font("Segoe UI", 20F);
            AimHead.Location = new Point(176, 141);
            AimHead.Name = "AimHead";
            AimHead.Size = new Size(127, 37);
            AimHead.TabIndex = 8;
            AimHead.Text = "AimHead";
            // 
            // ActiveAimHead
            // 
            ActiveAimHead.Font = new Font("Segoe UI", 15F);
            ActiveAimHead.Location = new Point(295, 145);
            ActiveAimHead.Name = "ActiveAimHead";
            ActiveAimHead.Size = new Size(127, 33);
            ActiveAimHead.TabIndex = 9;
            ActiveAimHead.Text = "Active";
            ActiveAimHead.UseVisualStyleBackColor = true;
            ActiveAimHead.Click += button2_Click;
            // 
            // ActiveFixlag
            // 
            ActiveFixlag.Font = new Font("Segoe UI", 15F);
            ActiveFixlag.Location = new Point(295, 287);
            ActiveFixlag.Name = "ActiveFixlag";
            ActiveFixlag.Size = new Size(127, 33);
            ActiveFixlag.TabIndex = 10;
            ActiveFixlag.Text = "Active";
            ActiveFixlag.UseVisualStyleBackColor = true;
            ActiveFixlag.Click += button3_Click;
            // 
            // Fixlag
            // 
            Fixlag.AutoSize = true;
            Fixlag.Font = new Font("Segoe UI", 20F);
            Fixlag.Location = new Point(176, 282);
            Fixlag.Name = "Fixlag";
            Fixlag.Size = new Size(86, 37);
            Fixlag.TabIndex = 11;
            Fixlag.Text = "Fixlag";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15F);
            label5.Location = new Point(193, 178);
            label5.Name = "label5";
            label5.Size = new Size(69, 28);
            label5.TabIndex = 12;
            label5.Text = "Status:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 15F);
            label6.Location = new Point(193, 319);
            label6.Name = "label6";
            label6.Size = new Size(69, 28);
            label6.TabIndex = 13;
            label6.Text = "Status:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 15F);
            label7.ForeColor = Color.Red;
            label7.Location = new Point(268, 181);
            label7.Name = "label7";
            label7.Size = new Size(88, 28);
            label7.TabIndex = 14;
            label7.Text = "Disabled";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 15F);
            label8.ForeColor = Color.Red;
            label8.Location = new Point(268, 323);
            label8.Name = "label8";
            label8.Size = new Size(88, 28);
            label8.TabIndex = 15;
            label8.Text = "Disabled";

            // 
            // MainForm
            // 
            Controls.Add(label1);
            Controls.Add(AimHead);
            Controls.Add(ActiveAimHead);
            Controls.Add(Fixlag);
            Controls.Add(ActiveFixlag);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(label8);
        }
        #endregion

        private Button login;
        private TextBox textBox2;
        private Label label4;
        private Label label3;
        private TextBox textBox1;
        private Label label2;
        private Label label1;
        private Label AimHead;
        private Button ActiveAimHead;
        private Button ActiveFixlag;
        private Label Fixlag;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
    }
}
