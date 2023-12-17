namespace calc_app
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            main2 = new TextBox();
            more_info = new Button();
            n0 = new Button();
            button3 = new Button();
            button4 = new Button();
            nPoint = new Button();
            nSumm = new Button();
            n1 = new Button();
            n2 = new Button();
            n3 = new Button();
            nPlus = new Button();
            n4 = new Button();
            n5 = new Button();
            n6 = new Button();
            nMinus = new Button();
            n7 = new Button();
            n8 = new Button();
            n9 = new Button();
            nSplit = new Button();
            nUmnog = new Button();
            x2 = new Button();
            kX = new Button();
            n1delx = new Button();
            Main = new NumericUpDown();
            Del = new Button();
            Clear = new Button();
            sign = new Label();
            sin = new Button();
            cos = new Button();
            tg = new Button();
            ctg = new Button();
            arcsin = new Button();
            arccos = new Button();
            arctg = new Button();
            arcctg = new Button();
            pi = new Button();
            contextMenuStrip1 = new ContextMenuStrip(components);
            history = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)Main).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(158, 14);
            label1.TabIndex = 0;
            label1.Text = "Розробив Владислав Шрамко";
            // 
            // main2
            // 
            main2.BackColor = SystemColors.Control;
            main2.BorderStyle = BorderStyle.None;
            main2.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            main2.Location = new Point(12, 22);
            main2.Name = "main2";
            main2.ReadOnly = true;
            main2.RightToLeft = RightToLeft.No;
            main2.Size = new Size(360, 25);
            main2.TabIndex = 2;
            main2.TextAlign = HorizontalAlignment.Right;
            // 
            // more_info
            // 
            more_info.BackColor = SystemColors.ControlLight;
            more_info.FlatAppearance.BorderSize = 0;
            more_info.FlatAppearance.MouseDownBackColor = Color.FromArgb(224, 224, 224);
            more_info.FlatStyle = FlatStyle.Flat;
            more_info.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            more_info.Location = new Point(12, 381);
            more_info.Name = "more_info";
            more_info.Size = new Size(85, 45);
            more_info.TabIndex = 3;
            more_info.Text = "sin, cos, tg ...";
            more_info.UseVisualStyleBackColor = false;
            more_info.Click += more_info_Click;
            // 
            // n0
            // 
            n0.BackColor = SystemColors.ControlLight;
            n0.FlatAppearance.BorderSize = 0;
            n0.FlatAppearance.MouseDownBackColor = Color.FromArgb(224, 224, 224);
            n0.FlatStyle = FlatStyle.Flat;
            n0.Location = new Point(103, 381);
            n0.Name = "n0";
            n0.Size = new Size(85, 45);
            n0.TabIndex = 4;
            n0.Text = "0";
            n0.UseVisualStyleBackColor = false;
            n0.Click += n0_Click;
            // 
            // button3
            // 
            button3.FlatAppearance.MouseDownBackColor = Color.FromArgb(224, 224, 224);
            button3.FlatStyle = FlatStyle.Flat;
            button3.Location = new Point(180, 375);
            button3.Name = "button3";
            button3.Size = new Size(0, 0);
            button3.TabIndex = 5;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.FlatAppearance.MouseDownBackColor = Color.FromArgb(224, 224, 224);
            button4.FlatStyle = FlatStyle.Flat;
            button4.Location = new Point(264, 375);
            button4.Name = "button4";
            button4.Size = new Size(0, 0);
            button4.TabIndex = 6;
            button4.Text = "button4";
            button4.UseVisualStyleBackColor = true;
            // 
            // nPoint
            // 
            nPoint.BackColor = SystemColors.ControlLight;
            nPoint.FlatAppearance.BorderSize = 0;
            nPoint.FlatAppearance.MouseDownBackColor = Color.FromArgb(224, 224, 224);
            nPoint.FlatStyle = FlatStyle.Flat;
            nPoint.Location = new Point(194, 381);
            nPoint.Name = "nPoint";
            nPoint.Size = new Size(85, 45);
            nPoint.TabIndex = 7;
            nPoint.Text = ",";
            nPoint.UseVisualStyleBackColor = false;
            nPoint.Click += nPoint_Click;
            // 
            // nSumm
            // 
            nSumm.BackColor = SystemColors.ControlLight;
            nSumm.FlatAppearance.BorderSize = 0;
            nSumm.FlatAppearance.MouseDownBackColor = Color.FromArgb(224, 224, 224);
            nSumm.FlatStyle = FlatStyle.Flat;
            nSumm.Location = new Point(285, 381);
            nSumm.Name = "nSumm";
            nSumm.Size = new Size(85, 45);
            nSumm.TabIndex = 8;
            nSumm.Text = "=";
            nSumm.UseVisualStyleBackColor = false;
            nSumm.Click += nSumm_Click;
            // 
            // n1
            // 
            n1.BackColor = SystemColors.ControlLight;
            n1.FlatAppearance.BorderSize = 0;
            n1.FlatAppearance.MouseDownBackColor = Color.FromArgb(224, 224, 224);
            n1.FlatStyle = FlatStyle.Flat;
            n1.Location = new Point(12, 330);
            n1.Name = "n1";
            n1.Size = new Size(85, 45);
            n1.TabIndex = 9;
            n1.Text = "1";
            n1.UseVisualStyleBackColor = false;
            n1.Click += n1_Click;
            // 
            // n2
            // 
            n2.BackColor = SystemColors.ControlLight;
            n2.FlatAppearance.BorderSize = 0;
            n2.FlatAppearance.MouseDownBackColor = Color.FromArgb(224, 224, 224);
            n2.FlatStyle = FlatStyle.Flat;
            n2.Location = new Point(103, 330);
            n2.Name = "n2";
            n2.Size = new Size(85, 45);
            n2.TabIndex = 10;
            n2.Text = "2";
            n2.UseVisualStyleBackColor = false;
            n2.Click += n2_Click;
            // 
            // n3
            // 
            n3.BackColor = SystemColors.ControlLight;
            n3.FlatAppearance.BorderSize = 0;
            n3.FlatAppearance.MouseDownBackColor = Color.FromArgb(224, 224, 224);
            n3.FlatStyle = FlatStyle.Flat;
            n3.Location = new Point(194, 330);
            n3.Name = "n3";
            n3.Size = new Size(85, 45);
            n3.TabIndex = 11;
            n3.Text = "3";
            n3.UseVisualStyleBackColor = false;
            n3.Click += n3_Click;
            // 
            // nPlus
            // 
            nPlus.BackColor = SystemColors.ControlLight;
            nPlus.FlatAppearance.BorderSize = 0;
            nPlus.FlatAppearance.MouseDownBackColor = Color.FromArgb(224, 224, 224);
            nPlus.FlatStyle = FlatStyle.Flat;
            nPlus.Location = new Point(285, 330);
            nPlus.Name = "nPlus";
            nPlus.Size = new Size(85, 45);
            nPlus.TabIndex = 12;
            nPlus.Text = "+";
            nPlus.UseVisualStyleBackColor = false;
            nPlus.Click += nPlus_Click;
            // 
            // n4
            // 
            n4.BackColor = SystemColors.ControlLight;
            n4.FlatAppearance.BorderSize = 0;
            n4.FlatAppearance.MouseDownBackColor = Color.FromArgb(224, 224, 224);
            n4.FlatStyle = FlatStyle.Flat;
            n4.Location = new Point(12, 279);
            n4.Name = "n4";
            n4.Size = new Size(85, 45);
            n4.TabIndex = 13;
            n4.Text = "4";
            n4.UseVisualStyleBackColor = false;
            n4.Click += n4_Click;
            // 
            // n5
            // 
            n5.BackColor = SystemColors.ControlLight;
            n5.FlatAppearance.BorderSize = 0;
            n5.FlatAppearance.MouseDownBackColor = Color.FromArgb(224, 224, 224);
            n5.FlatStyle = FlatStyle.Flat;
            n5.Location = new Point(103, 279);
            n5.Name = "n5";
            n5.Size = new Size(85, 45);
            n5.TabIndex = 14;
            n5.Text = "5";
            n5.UseVisualStyleBackColor = false;
            n5.Click += n5_Click;
            // 
            // n6
            // 
            n6.BackColor = SystemColors.ControlLight;
            n6.FlatAppearance.BorderSize = 0;
            n6.FlatAppearance.MouseDownBackColor = Color.FromArgb(224, 224, 224);
            n6.FlatStyle = FlatStyle.Flat;
            n6.Location = new Point(194, 279);
            n6.Name = "n6";
            n6.Size = new Size(85, 45);
            n6.TabIndex = 15;
            n6.Text = "6";
            n6.UseVisualStyleBackColor = false;
            n6.Click += n6_Click;
            // 
            // nMinus
            // 
            nMinus.BackColor = SystemColors.ControlLight;
            nMinus.FlatAppearance.BorderSize = 0;
            nMinus.FlatAppearance.MouseDownBackColor = Color.FromArgb(224, 224, 224);
            nMinus.FlatStyle = FlatStyle.Flat;
            nMinus.Location = new Point(285, 279);
            nMinus.Name = "nMinus";
            nMinus.Size = new Size(85, 45);
            nMinus.TabIndex = 16;
            nMinus.Text = "-";
            nMinus.UseVisualStyleBackColor = false;
            nMinus.Click += nMinus_Click;
            // 
            // n7
            // 
            n7.BackColor = SystemColors.ControlLight;
            n7.FlatAppearance.BorderSize = 0;
            n7.FlatAppearance.MouseDownBackColor = Color.FromArgb(224, 224, 224);
            n7.FlatStyle = FlatStyle.Flat;
            n7.Location = new Point(12, 228);
            n7.Name = "n7";
            n7.Size = new Size(85, 45);
            n7.TabIndex = 17;
            n7.Text = "7";
            n7.UseVisualStyleBackColor = false;
            n7.Click += n7_Click;
            // 
            // n8
            // 
            n8.BackColor = SystemColors.ControlLight;
            n8.FlatAppearance.BorderSize = 0;
            n8.FlatAppearance.MouseDownBackColor = Color.FromArgb(224, 224, 224);
            n8.FlatStyle = FlatStyle.Flat;
            n8.Location = new Point(103, 228);
            n8.Name = "n8";
            n8.Size = new Size(85, 45);
            n8.TabIndex = 18;
            n8.Text = "8";
            n8.UseVisualStyleBackColor = false;
            n8.Click += n8_Click;
            // 
            // n9
            // 
            n9.BackColor = SystemColors.ControlLight;
            n9.FlatAppearance.BorderSize = 0;
            n9.FlatAppearance.MouseDownBackColor = Color.FromArgb(224, 224, 224);
            n9.FlatStyle = FlatStyle.Flat;
            n9.Location = new Point(194, 228);
            n9.Name = "n9";
            n9.Size = new Size(85, 45);
            n9.TabIndex = 19;
            n9.Text = "9";
            n9.UseVisualStyleBackColor = false;
            n9.Click += n9_Click;
            // 
            // nSplit
            // 
            nSplit.BackColor = SystemColors.ControlLight;
            nSplit.FlatAppearance.BorderSize = 0;
            nSplit.FlatAppearance.MouseDownBackColor = Color.FromArgb(224, 224, 224);
            nSplit.FlatStyle = FlatStyle.Flat;
            nSplit.Location = new Point(285, 228);
            nSplit.Name = "nSplit";
            nSplit.Size = new Size(85, 45);
            nSplit.TabIndex = 20;
            nSplit.Text = "÷";
            nSplit.UseVisualStyleBackColor = false;
            nSplit.Click += nSplit_Click;
            // 
            // nUmnog
            // 
            nUmnog.BackColor = SystemColors.ControlLight;
            nUmnog.FlatAppearance.BorderSize = 0;
            nUmnog.FlatAppearance.MouseDownBackColor = Color.FromArgb(224, 224, 224);
            nUmnog.FlatStyle = FlatStyle.Flat;
            nUmnog.Location = new Point(285, 177);
            nUmnog.Name = "nUmnog";
            nUmnog.Size = new Size(85, 45);
            nUmnog.TabIndex = 21;
            nUmnog.Text = "*";
            nUmnog.UseVisualStyleBackColor = false;
            nUmnog.Click += nUmnog_Click;
            // 
            // x2
            // 
            x2.BackColor = SystemColors.ControlLight;
            x2.FlatAppearance.BorderSize = 0;
            x2.FlatAppearance.MouseDownBackColor = Color.FromArgb(224, 224, 224);
            x2.FlatStyle = FlatStyle.Flat;
            x2.Location = new Point(194, 177);
            x2.Name = "x2";
            x2.Size = new Size(85, 45);
            x2.TabIndex = 22;
            x2.Text = "x²";
            x2.UseVisualStyleBackColor = false;
            x2.Click += x2_Click;
            // 
            // kX
            // 
            kX.BackColor = SystemColors.ControlLight;
            kX.FlatAppearance.BorderSize = 0;
            kX.FlatAppearance.MouseDownBackColor = Color.FromArgb(224, 224, 224);
            kX.FlatStyle = FlatStyle.Flat;
            kX.Location = new Point(103, 177);
            kX.Name = "kX";
            kX.Size = new Size(85, 45);
            kX.TabIndex = 23;
            kX.Text = "√x";
            kX.UseVisualStyleBackColor = false;
            kX.Click += kX_Click;
            // 
            // n1delx
            // 
            n1delx.BackColor = SystemColors.ControlLight;
            n1delx.FlatAppearance.BorderSize = 0;
            n1delx.FlatAppearance.MouseDownBackColor = Color.FromArgb(224, 224, 224);
            n1delx.FlatStyle = FlatStyle.Flat;
            n1delx.Location = new Point(12, 177);
            n1delx.Name = "n1delx";
            n1delx.Size = new Size(85, 45);
            n1delx.TabIndex = 24;
            n1delx.Text = "1/x";
            n1delx.UseVisualStyleBackColor = false;
            n1delx.Click += n1delx_Click;
            // 
            // Main
            // 
            Main.BackColor = SystemColors.Control;
            Main.BorderStyle = BorderStyle.None;
            Main.Font = new Font("Arial", 36F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Main.Increment = new decimal(new int[] { 0, 0, 0, 0 });
            Main.Location = new Point(-18, 75);
            Main.Maximum = new decimal(new int[] { -1304428545, 434162106, 542, 0 });
            Main.Minimum = new decimal(new int[] { -1304428545, 434162106, 542, int.MinValue });
            Main.Name = "Main";
            Main.Size = new Size(390, 59);
            Main.TabIndex = 25;
            Main.TextAlign = HorizontalAlignment.Right;
            Main.ThousandsSeparator = true;
            Main.UpDownAlign = LeftRightAlignment.Left;
            Main.ValueChanged += Main_ValueChanged;
            // 
            // Del
            // 
            Del.BackColor = SystemColors.ControlLight;
            Del.FlatAppearance.BorderSize = 0;
            Del.FlatAppearance.MouseDownBackColor = Color.FromArgb(224, 224, 224);
            Del.FlatStyle = FlatStyle.Flat;
            Del.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Del.Location = new Point(285, 149);
            Del.Name = "Del";
            Del.Size = new Size(85, 22);
            Del.TabIndex = 26;
            Del.Text = "Del";
            Del.UseVisualStyleBackColor = false;
            Del.Click += Del_Click;
            // 
            // Clear
            // 
            Clear.BackColor = SystemColors.ControlLight;
            Clear.FlatAppearance.BorderSize = 0;
            Clear.FlatAppearance.MouseDownBackColor = Color.FromArgb(224, 224, 224);
            Clear.FlatStyle = FlatStyle.Flat;
            Clear.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Clear.Location = new Point(194, 149);
            Clear.Name = "Clear";
            Clear.Size = new Size(85, 22);
            Clear.TabIndex = 27;
            Clear.Text = "Clear";
            Clear.UseVisualStyleBackColor = false;
            Clear.Click += Clear_Click;
            // 
            // sign
            // 
            sign.AutoSize = true;
            sign.Location = new Point(317, 50);
            sign.Name = "sign";
            sign.RightToLeft = RightToLeft.No;
            sign.Size = new Size(65, 22);
            sign.TabIndex = 29;
            sign.Text = "x^(1/2)";
            sign.TextAlign = ContentAlignment.TopRight;
            sign.Click += sign_Click;
            // 
            // sin
            // 
            sin.BackColor = SystemColors.ControlLight;
            sin.Enabled = false;
            sin.FlatAppearance.BorderSize = 0;
            sin.FlatAppearance.MouseDownBackColor = Color.FromArgb(224, 224, 224);
            sin.FlatStyle = FlatStyle.Flat;
            sin.Location = new Point(12, 330);
            sin.Name = "sin";
            sin.Size = new Size(85, 45);
            sin.TabIndex = 30;
            sin.Text = "sin";
            sin.UseVisualStyleBackColor = false;
            sin.Visible = false;
            sin.Click += sin_Click;
            // 
            // cos
            // 
            cos.BackColor = SystemColors.ControlLight;
            cos.Enabled = false;
            cos.FlatAppearance.BorderSize = 0;
            cos.FlatAppearance.MouseDownBackColor = Color.FromArgb(224, 224, 224);
            cos.FlatStyle = FlatStyle.Flat;
            cos.Location = new Point(103, 330);
            cos.Name = "cos";
            cos.Size = new Size(85, 45);
            cos.TabIndex = 31;
            cos.Text = "cos";
            cos.UseVisualStyleBackColor = false;
            cos.Visible = false;
            cos.Click += cos_Click;
            // 
            // tg
            // 
            tg.BackColor = SystemColors.ControlLight;
            tg.Enabled = false;
            tg.FlatAppearance.BorderSize = 0;
            tg.FlatAppearance.MouseDownBackColor = Color.FromArgb(224, 224, 224);
            tg.FlatStyle = FlatStyle.Flat;
            tg.Location = new Point(194, 330);
            tg.Name = "tg";
            tg.Size = new Size(85, 45);
            tg.TabIndex = 32;
            tg.Text = "tg";
            tg.UseVisualStyleBackColor = false;
            tg.Visible = false;
            tg.Click += tg_Click;
            // 
            // ctg
            // 
            ctg.BackColor = SystemColors.ControlLight;
            ctg.Enabled = false;
            ctg.FlatAppearance.BorderSize = 0;
            ctg.FlatAppearance.MouseDownBackColor = Color.FromArgb(224, 224, 224);
            ctg.FlatStyle = FlatStyle.Flat;
            ctg.Location = new Point(12, 279);
            ctg.Name = "ctg";
            ctg.Size = new Size(85, 45);
            ctg.TabIndex = 33;
            ctg.Text = "ctg";
            ctg.UseVisualStyleBackColor = false;
            ctg.Visible = false;
            ctg.Click += ctg_Click;
            // 
            // arcsin
            // 
            arcsin.BackColor = SystemColors.ControlLight;
            arcsin.Enabled = false;
            arcsin.FlatAppearance.BorderSize = 0;
            arcsin.FlatAppearance.MouseDownBackColor = Color.FromArgb(224, 224, 224);
            arcsin.FlatStyle = FlatStyle.Flat;
            arcsin.Location = new Point(103, 279);
            arcsin.Name = "arcsin";
            arcsin.Size = new Size(85, 45);
            arcsin.TabIndex = 34;
            arcsin.Text = "arcsin";
            arcsin.UseVisualStyleBackColor = false;
            arcsin.Visible = false;
            arcsin.Click += arcsin_Click;
            // 
            // arccos
            // 
            arccos.BackColor = SystemColors.ControlLight;
            arccos.Enabled = false;
            arccos.FlatAppearance.BorderSize = 0;
            arccos.FlatAppearance.MouseDownBackColor = Color.FromArgb(224, 224, 224);
            arccos.FlatStyle = FlatStyle.Flat;
            arccos.Location = new Point(194, 279);
            arccos.Name = "arccos";
            arccos.Size = new Size(85, 45);
            arccos.TabIndex = 35;
            arccos.Text = "arccos";
            arccos.UseVisualStyleBackColor = false;
            arccos.Visible = false;
            arccos.Click += arccos_Click;
            // 
            // arctg
            // 
            arctg.BackColor = SystemColors.ControlLight;
            arctg.Enabled = false;
            arctg.FlatAppearance.BorderSize = 0;
            arctg.FlatAppearance.MouseDownBackColor = Color.FromArgb(224, 224, 224);
            arctg.FlatStyle = FlatStyle.Flat;
            arctg.Location = new Point(12, 228);
            arctg.Name = "arctg";
            arctg.Size = new Size(85, 45);
            arctg.TabIndex = 36;
            arctg.Text = "arctg";
            arctg.UseVisualStyleBackColor = false;
            arctg.Visible = false;
            arctg.Click += arctg_Click;
            // 
            // arcctg
            // 
            arcctg.BackColor = SystemColors.ControlLight;
            arcctg.Enabled = false;
            arcctg.FlatAppearance.BorderSize = 0;
            arcctg.FlatAppearance.MouseDownBackColor = Color.FromArgb(224, 224, 224);
            arcctg.FlatStyle = FlatStyle.Flat;
            arcctg.Location = new Point(103, 228);
            arcctg.Name = "arcctg";
            arcctg.Size = new Size(85, 45);
            arcctg.TabIndex = 37;
            arcctg.Text = "arcctg";
            arcctg.UseVisualStyleBackColor = false;
            arcctg.Visible = false;
            arcctg.Click += arcctg_Click;
            // 
            // pi
            // 
            pi.BackColor = SystemColors.ControlLight;
            pi.Enabled = false;
            pi.FlatAppearance.BorderSize = 0;
            pi.FlatAppearance.MouseDownBackColor = Color.FromArgb(224, 224, 224);
            pi.FlatStyle = FlatStyle.Flat;
            pi.Location = new Point(194, 228);
            pi.Name = "pi";
            pi.Size = new Size(85, 45);
            pi.TabIndex = 38;
            pi.Text = "pi";
            pi.UseVisualStyleBackColor = false;
            pi.Visible = false;
            pi.Click += pi_Click;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // history
            // 
            history.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            history.FormattingEnabled = true;
            history.Location = new Point(12, 148);
            history.Name = "history";
            history.Size = new Size(176, 24);
            history.TabIndex = 40;
            history.Text = "Історія розрахунків";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(381, 437);
            Controls.Add(history);
            Controls.Add(pi);
            Controls.Add(arcctg);
            Controls.Add(arctg);
            Controls.Add(arccos);
            Controls.Add(arcsin);
            Controls.Add(ctg);
            Controls.Add(tg);
            Controls.Add(cos);
            Controls.Add(sin);
            Controls.Add(sign);
            Controls.Add(Clear);
            Controls.Add(Del);
            Controls.Add(Main);
            Controls.Add(n1delx);
            Controls.Add(kX);
            Controls.Add(x2);
            Controls.Add(nUmnog);
            Controls.Add(nSplit);
            Controls.Add(n9);
            Controls.Add(n8);
            Controls.Add(n7);
            Controls.Add(nMinus);
            Controls.Add(n6);
            Controls.Add(n5);
            Controls.Add(n4);
            Controls.Add(nPlus);
            Controls.Add(n3);
            Controls.Add(n2);
            Controls.Add(n1);
            Controls.Add(nSumm);
            Controls.Add(nPoint);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(n0);
            Controls.Add(more_info);
            Controls.Add(main2);
            Controls.Add(label1);
            Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Margin = new Padding(5, 4, 5, 4);
            Name = "Form1";
            Text = "Калькулятор ";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)Main).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox main2;
        private Button more_info;
        private Button n0;
        private Button button3;
        private Button button4;
        private Button nPoint;
        private Button nSumm;
        private Button n1;
        private Button n2;
        private Button n3;
        private Button nPlus;
        private Button n4;
        private Button n5;
        private Button n6;
        private Button nMinus;
        private Button n7;
        private Button n8;
        private Button n9;
        private Button nSplit;
        private Button nUmnog;
        private Button x2;
        private Button kX;
        private Button n1delx;
        private NumericUpDown Main;
        private Button Del;
        private Button Clear;
        private Label sign;
        private Button sin;
        private Button cos;
        private Button tg;
        private Button ctg;
        private Button arcsin;
        private Button arccos;
        private Button arctg;
        private Button arcctg;
        private Button pi;
        private ContextMenuStrip contextMenuStrip1;
        private ComboBox history;
    }
}
