﻿namespace Presentation
{
    partial class MainFRM
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
            groupBox1 = new GroupBox();
            ExitBtn = new Button();
            BankBtn = new Button();
            OnlineExchangeBtn = new Button();
            label1 = new Label();
            LockBtn = new Button();
            ClockLbl = new Label();
            SettingBtn = new Button();
            BalanceBtn = new Button();
            TaransactionBtn = new Button();
            CashMoneyBtn = new Button();
            CalculateBtn = new Button();
            ReportBtn = new Button();
            UserBtn = new Button();
            CartBtn = new Button();
            progressBar2 = new ProgressBar();
            groupBox2 = new GroupBox();
            MainPanel = new Panel();
            progressBar3 = new ProgressBar();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.BackgroundImageLayout = ImageLayout.None;
            groupBox1.Controls.Add(ExitBtn);
            groupBox1.Controls.Add(BankBtn);
            groupBox1.Controls.Add(OnlineExchangeBtn);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(LockBtn);
            groupBox1.Controls.Add(ClockLbl);
            groupBox1.Controls.Add(SettingBtn);
            groupBox1.Controls.Add(BalanceBtn);
            groupBox1.Controls.Add(TaransactionBtn);
            groupBox1.Controls.Add(CashMoneyBtn);
            groupBox1.Controls.Add(CalculateBtn);
            groupBox1.Controls.Add(ReportBtn);
            groupBox1.Controls.Add(UserBtn);
            groupBox1.Controls.Add(CartBtn);
            groupBox1.Controls.Add(progressBar2);
            groupBox1.FlatStyle = FlatStyle.Flat;
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(1162, 5);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(254, 770);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "مدیریت";
            // 
            // ExitBtn
            // 
            ExitBtn.BackColor = Color.FromArgb(255, 192, 192);
            ExitBtn.Cursor = Cursors.Hand;
            ExitBtn.FlatAppearance.BorderColor = Color.FromArgb(255, 128, 128);
            ExitBtn.FlatAppearance.BorderSize = 2;
            ExitBtn.FlatAppearance.CheckedBackColor = Color.Gray;
            ExitBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(64, 0, 0);
            ExitBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 128, 128);
            ExitBtn.FlatStyle = FlatStyle.Flat;
            ExitBtn.ForeColor = Color.Red;
            ExitBtn.Location = new Point(131, 722);
            ExitBtn.Name = "ExitBtn";
            ExitBtn.Size = new Size(114, 39);
            ExitBtn.TabIndex = 11;
            ExitBtn.Text = "خروج";
            ExitBtn.UseVisualStyleBackColor = false;
            ExitBtn.Click += ExitBtn_Click;
            // 
            // BankBtn
            // 
            BankBtn.BackColor = Color.Tomato;
            BankBtn.Cursor = Cursors.Hand;
            BankBtn.FlatAppearance.BorderColor = Color.White;
            BankBtn.FlatAppearance.BorderSize = 2;
            BankBtn.FlatAppearance.CheckedBackColor = Color.Black;
            BankBtn.FlatAppearance.MouseDownBackColor = Color.Maroon;
            BankBtn.FlatAppearance.MouseOverBackColor = Color.Navy;
            BankBtn.FlatStyle = FlatStyle.Flat;
            BankBtn.Font = new Font("IRANSansWeb", 14.25F);
            BankBtn.ForeColor = Color.White;
            BankBtn.Location = new Point(130, 179);
            BankBtn.Name = "BankBtn";
            BankBtn.Size = new Size(114, 40);
            BankBtn.TabIndex = 15;
            BankBtn.Text = "بانک";
            BankBtn.UseVisualStyleBackColor = false;
            BankBtn.Click += BankBtn_Click;
            // 
            // OnlineExchangeBtn
            // 
            OnlineExchangeBtn.BackColor = Color.Black;
            OnlineExchangeBtn.Cursor = Cursors.Hand;
            OnlineExchangeBtn.FlatAppearance.BorderColor = Color.White;
            OnlineExchangeBtn.FlatAppearance.CheckedBackColor = Color.FromArgb(192, 255, 255);
            OnlineExchangeBtn.FlatAppearance.MouseDownBackColor = Color.RoyalBlue;
            OnlineExchangeBtn.FlatAppearance.MouseOverBackColor = SystemColors.MenuHighlight;
            OnlineExchangeBtn.FlatStyle = FlatStyle.Flat;
            OnlineExchangeBtn.Font = new Font("IRANSansWeb", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            OnlineExchangeBtn.ForeColor = Color.White;
            OnlineExchangeBtn.Location = new Point(10, 126);
            OnlineExchangeBtn.Name = "OnlineExchangeBtn";
            OnlineExchangeBtn.Size = new Size(234, 47);
            OnlineExchangeBtn.TabIndex = 14;
            OnlineExchangeBtn.Text = "صرافی آنلاین";
            OnlineExchangeBtn.UseVisualStyleBackColor = false;
            OnlineExchangeBtn.Click += OnlineExchangeBtn_Click;
            // 
            // label1
            // 
            label1.BackColor = Color.FromArgb(0, 64, 64);
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Cursor = Cursors.SizeAll;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("IRANSansWeb", 17.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(10, 28);
            label1.Name = "label1";
            label1.Size = new Size(234, 78);
            label1.TabIndex = 13;
            label1.Text = "مدیریت و حسابداری";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.MouseDown += label1_MouseDown;
            // 
            // LockBtn
            // 
            LockBtn.BackColor = Color.DodgerBlue;
            LockBtn.Cursor = Cursors.Hand;
            LockBtn.FlatAppearance.BorderColor = Color.RoyalBlue;
            LockBtn.FlatAppearance.BorderSize = 2;
            LockBtn.FlatAppearance.CheckedBackColor = Color.Gray;
            LockBtn.FlatAppearance.MouseDownBackColor = SystemColors.HotTrack;
            LockBtn.FlatAppearance.MouseOverBackColor = Color.RoyalBlue;
            LockBtn.FlatStyle = FlatStyle.Flat;
            LockBtn.ForeColor = Color.White;
            LockBtn.Location = new Point(9, 722);
            LockBtn.Name = "LockBtn";
            LockBtn.Size = new Size(114, 39);
            LockBtn.TabIndex = 12;
            LockBtn.Text = "قفل";
            LockBtn.UseVisualStyleBackColor = false;
            // 
            // ClockLbl
            // 
            ClockLbl.ForeColor = Color.White;
            ClockLbl.Location = new Point(10, 678);
            ClockLbl.Name = "ClockLbl";
            ClockLbl.Size = new Size(234, 41);
            ClockLbl.TabIndex = 10;
            ClockLbl.Text = "ساعت";
            ClockLbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // SettingBtn
            // 
            SettingBtn.BackColor = Color.DarkSlateGray;
            SettingBtn.Cursor = Cursors.Hand;
            SettingBtn.FlatAppearance.BorderColor = Color.White;
            SettingBtn.FlatAppearance.BorderSize = 2;
            SettingBtn.FlatAppearance.CheckedBackColor = Color.Gray;
            SettingBtn.FlatAppearance.MouseDownBackColor = Color.MediumAquamarine;
            SettingBtn.FlatAppearance.MouseOverBackColor = Color.DarkCyan;
            SettingBtn.FlatStyle = FlatStyle.Flat;
            SettingBtn.ForeColor = Color.White;
            SettingBtn.Location = new Point(33, 636);
            SettingBtn.Name = "SettingBtn";
            SettingBtn.Size = new Size(189, 39);
            SettingBtn.TabIndex = 9;
            SettingBtn.Text = "تنظیمات";
            SettingBtn.UseVisualStyleBackColor = false;
            SettingBtn.Click += SettingBtn_Click;
            // 
            // BalanceBtn
            // 
            BalanceBtn.Cursor = Cursors.Hand;
            BalanceBtn.FlatAppearance.BorderColor = Color.White;
            BalanceBtn.FlatAppearance.BorderSize = 2;
            BalanceBtn.FlatAppearance.CheckedBackColor = Color.Black;
            BalanceBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 0, 192);
            BalanceBtn.FlatAppearance.MouseOverBackColor = Color.RoyalBlue;
            BalanceBtn.FlatStyle = FlatStyle.Flat;
            BalanceBtn.ForeColor = Color.White;
            BalanceBtn.Location = new Point(32, 398);
            BalanceBtn.Name = "BalanceBtn";
            BalanceBtn.Size = new Size(190, 40);
            BalanceBtn.TabIndex = 6;
            BalanceBtn.Text = "موجودی";
            BalanceBtn.UseVisualStyleBackColor = true;
            BalanceBtn.Click += BalanceBtn_Click;
            // 
            // TaransactionBtn
            // 
            TaransactionBtn.Cursor = Cursors.Hand;
            TaransactionBtn.FlatAppearance.BorderColor = Color.White;
            TaransactionBtn.FlatAppearance.BorderSize = 2;
            TaransactionBtn.FlatAppearance.CheckedBackColor = Color.Black;
            TaransactionBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 0, 192);
            TaransactionBtn.FlatAppearance.MouseOverBackColor = Color.RoyalBlue;
            TaransactionBtn.FlatStyle = FlatStyle.Flat;
            TaransactionBtn.ForeColor = Color.White;
            TaransactionBtn.Location = new Point(32, 306);
            TaransactionBtn.Name = "TaransactionBtn";
            TaransactionBtn.Size = new Size(190, 40);
            TaransactionBtn.TabIndex = 5;
            TaransactionBtn.Text = "تراکنش ها";
            TaransactionBtn.UseVisualStyleBackColor = true;
            TaransactionBtn.Click += TaransactionBtn_Click;
            // 
            // CashMoneyBtn
            // 
            CashMoneyBtn.Cursor = Cursors.Hand;
            CashMoneyBtn.FlatAppearance.BorderColor = Color.White;
            CashMoneyBtn.FlatAppearance.BorderSize = 2;
            CashMoneyBtn.FlatAppearance.CheckedBackColor = Color.Black;
            CashMoneyBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 0, 192);
            CashMoneyBtn.FlatAppearance.MouseOverBackColor = Color.RoyalBlue;
            CashMoneyBtn.FlatStyle = FlatStyle.Flat;
            CashMoneyBtn.ForeColor = Color.White;
            CashMoneyBtn.Location = new Point(32, 352);
            CashMoneyBtn.Name = "CashMoneyBtn";
            CashMoneyBtn.Size = new Size(190, 40);
            CashMoneyBtn.TabIndex = 4;
            CashMoneyBtn.Text = "نقدی";
            CashMoneyBtn.UseVisualStyleBackColor = true;
            CashMoneyBtn.Click += CashMoneyBtn_Click;
            // 
            // CalculateBtn
            // 
            CalculateBtn.Cursor = Cursors.Hand;
            CalculateBtn.FlatAppearance.BorderColor = Color.White;
            CalculateBtn.FlatAppearance.BorderSize = 2;
            CalculateBtn.FlatAppearance.CheckedBackColor = Color.Black;
            CalculateBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 0, 192);
            CalculateBtn.FlatAppearance.MouseOverBackColor = Color.RoyalBlue;
            CalculateBtn.FlatStyle = FlatStyle.Flat;
            CalculateBtn.ForeColor = Color.White;
            CalculateBtn.Location = new Point(32, 443);
            CalculateBtn.Name = "CalculateBtn";
            CalculateBtn.Size = new Size(190, 40);
            CalculateBtn.TabIndex = 3;
            CalculateBtn.Text = "محاسبات";
            CalculateBtn.UseVisualStyleBackColor = true;
            CalculateBtn.Click += CalculateBtn_Click;
            // 
            // ReportBtn
            // 
            ReportBtn.Cursor = Cursors.Hand;
            ReportBtn.FlatAppearance.BorderColor = Color.White;
            ReportBtn.FlatAppearance.BorderSize = 2;
            ReportBtn.FlatAppearance.CheckedBackColor = Color.Black;
            ReportBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 0, 192);
            ReportBtn.FlatAppearance.MouseOverBackColor = Color.RoyalBlue;
            ReportBtn.FlatStyle = FlatStyle.Flat;
            ReportBtn.ForeColor = Color.White;
            ReportBtn.Location = new Point(32, 489);
            ReportBtn.Name = "ReportBtn";
            ReportBtn.Size = new Size(190, 40);
            ReportBtn.TabIndex = 2;
            ReportBtn.Text = "گزارشات";
            ReportBtn.UseVisualStyleBackColor = true;
            ReportBtn.Click += ReportBtn_Click;
            // 
            // UserBtn
            // 
            UserBtn.BackColor = Color.CornflowerBlue;
            UserBtn.Cursor = Cursors.Hand;
            UserBtn.FlatAppearance.BorderColor = Color.White;
            UserBtn.FlatAppearance.BorderSize = 2;
            UserBtn.FlatAppearance.CheckedBackColor = Color.Black;
            UserBtn.FlatAppearance.MouseDownBackColor = Color.Maroon;
            UserBtn.FlatAppearance.MouseOverBackColor = Color.Navy;
            UserBtn.FlatStyle = FlatStyle.Flat;
            UserBtn.Font = new Font("IRANSansWeb", 14.25F);
            UserBtn.ForeColor = Color.White;
            UserBtn.Location = new Point(10, 225);
            UserBtn.Name = "UserBtn";
            UserBtn.Size = new Size(234, 50);
            UserBtn.TabIndex = 1;
            UserBtn.Text = "مشترکین";
            UserBtn.UseVisualStyleBackColor = false;
            UserBtn.Click += UserBtn_Click;
            // 
            // CartBtn
            // 
            CartBtn.BackColor = Color.Tomato;
            CartBtn.Cursor = Cursors.Hand;
            CartBtn.FlatAppearance.BorderColor = Color.White;
            CartBtn.FlatAppearance.BorderSize = 2;
            CartBtn.FlatAppearance.CheckedBackColor = Color.Black;
            CartBtn.FlatAppearance.MouseDownBackColor = Color.Maroon;
            CartBtn.FlatAppearance.MouseOverBackColor = Color.Navy;
            CartBtn.FlatStyle = FlatStyle.Flat;
            CartBtn.Font = new Font("IRANSansWeb", 14.25F);
            CartBtn.ForeColor = Color.White;
            CartBtn.Location = new Point(10, 179);
            CartBtn.Name = "CartBtn";
            CartBtn.Size = new Size(114, 40);
            CartBtn.TabIndex = 0;
            CartBtn.Text = "کارت";
            CartBtn.UseVisualStyleBackColor = false;
            CartBtn.Click += CartBtn_Click;
            // 
            // progressBar2
            // 
            progressBar2.Location = new Point(-10, 110);
            progressBar2.Name = "progressBar2";
            progressBar2.Size = new Size(275, 10);
            progressBar2.Step = 1;
            progressBar2.Style = ProgressBarStyle.Continuous;
            progressBar2.TabIndex = 17;
            progressBar2.Value = 99;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.Transparent;
            groupBox2.Controls.Add(MainPanel);
            groupBox2.FlatStyle = FlatStyle.Flat;
            groupBox2.Location = new Point(4, 5);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1152, 770);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            // 
            // MainPanel
            // 
            MainPanel.Location = new Point(6, 20);
            MainPanel.Name = "MainPanel";
            MainPanel.Size = new Size(1140, 741);
            MainPanel.TabIndex = 0;
            // 
            // progressBar3
            // 
            progressBar3.BackColor = Color.DarkSlateGray;
            progressBar3.Cursor = Cursors.SizeAll;
            progressBar3.ForeColor = Color.White;
            progressBar3.Location = new Point(-26, 5);
            progressBar3.Name = "progressBar3";
            progressBar3.RightToLeftLayout = true;
            progressBar3.Size = new Size(1472, 5);
            progressBar3.Step = 1;
            progressBar3.Style = ProgressBarStyle.Continuous;
            progressBar3.TabIndex = 18;
            progressBar3.UseWaitCursor = true;
            progressBar3.Value = 99;
            // 
            // MainFRM
            // 
            AutoScaleDimensions = new SizeF(9F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Teal;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1420, 780);
            Controls.Add(progressBar3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Font = new Font("IRANSansWeb", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.Black;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 5, 4, 5);
            Name = "MainFRM";
            RightToLeft = RightToLeft.Yes;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainFORM";
            FormClosing += MainFRM_FormClosing;
            Load += MainFRM_Load;
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button CartBtn;
        private GroupBox groupBox2;
        private Label ClockLbl;
        private Button SettingBtn;
        private Button BalanceBtn;
        private Button TaransactionBtn;
        private Button CashMoneyBtn;
        private Button CalculateBtn;
        private Button ReportBtn;
        private Button UserBtn;
        private Panel MainPanel;
        private Button LockBtn;
        private Button ExitBtn;
        private Label label1;
        private Button OnlineExchangeBtn;
        private Button BankBtn;
        private ProgressBar progressBar2;
        private ProgressBar progressBar3;
    }
}
