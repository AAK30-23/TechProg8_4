namespace TechProg8_4
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
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.radioButtonAll = new System.Windows.Forms.RadioButton();
            this.radioButtonSigns = new System.Windows.Forms.RadioButton();
            this.radioButtonNumbers = new System.Windows.Forms.RadioButton();
            this.radioButtonStart = new System.Windows.Forms.RadioButton();
            this.radioButtonText = new System.Windows.Forms.RadioButton();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.radioButtonNone = new System.Windows.Forms.RadioButton();
            this.radioButtonLower = new System.Windows.Forms.RadioButton();
            this.radioButtonUpper = new System.Windows.Forms.RadioButton();
            this.domainUpDown1 = new System.Windows.Forms.DomainUpDown();
            this.button2 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(16, 415);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Click";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(721, 348);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.radioButtonAll);
            this.tabPage1.Controls.Add(this.radioButtonSigns);
            this.tabPage1.Controls.Add(this.radioButtonNumbers);
            this.tabPage1.Controls.Add(this.radioButtonStart);
            this.tabPage1.Controls.Add(this.radioButtonText);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(713, 319);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Filters";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // radioButtonAll
            // 
            this.radioButtonAll.AutoSize = true;
            this.radioButtonAll.Checked = true;
            this.radioButtonAll.Location = new System.Drawing.Point(50, 180);
            this.radioButtonAll.Name = "radioButtonAll";
            this.radioButtonAll.Size = new System.Drawing.Size(43, 20);
            this.radioButtonAll.TabIndex = 4;
            this.radioButtonAll.TabStop = true;
            this.radioButtonAll.Text = "All";
            this.radioButtonAll.UseVisualStyleBackColor = true;
            this.radioButtonAll.CheckedChanged += new System.EventHandler(this.radioButtonAll_CheckedChanged);
            // 
            // radioButtonSigns
            // 
            this.radioButtonSigns.AutoSize = true;
            this.radioButtonSigns.Location = new System.Drawing.Point(50, 140);
            this.radioButtonSigns.Name = "radioButtonSigns";
            this.radioButtonSigns.Size = new System.Drawing.Size(62, 20);
            this.radioButtonSigns.TabIndex = 3;
            this.radioButtonSigns.Text = "Signs";
            this.radioButtonSigns.UseVisualStyleBackColor = true;
            this.radioButtonSigns.CheckedChanged += new System.EventHandler(this.radioButtonSigns_CheckedChanged);
            // 
            // radioButtonNumbers
            // 
            this.radioButtonNumbers.AutoSize = true;
            this.radioButtonNumbers.Location = new System.Drawing.Point(50, 100);
            this.radioButtonNumbers.Name = "radioButtonNumbers";
            this.radioButtonNumbers.Size = new System.Drawing.Size(83, 20);
            this.radioButtonNumbers.TabIndex = 2;
            this.radioButtonNumbers.Text = "Numbers";
            this.radioButtonNumbers.UseVisualStyleBackColor = true;
            this.radioButtonNumbers.CheckedChanged += new System.EventHandler(this.radioButtonNumbers_CheckedChanged);
            // 
            // radioButtonStart
            // 
            this.radioButtonStart.AutoSize = true;
            this.radioButtonStart.Location = new System.Drawing.Point(50, 20);
            this.radioButtonStart.Name = "radioButtonStart";
            this.radioButtonStart.Size = new System.Drawing.Size(87, 20);
            this.radioButtonStart.TabIndex = 1;
            this.radioButtonStart.Text = "Start letter";
            this.radioButtonStart.UseVisualStyleBackColor = true;
            this.radioButtonStart.CheckedChanged += new System.EventHandler(this.radioButtonStart_CheckedChanged);
            // 
            // radioButtonText
            // 
            this.radioButtonText.AutoSize = true;
            this.radioButtonText.Location = new System.Drawing.Point(50, 60);
            this.radioButtonText.Name = "radioButtonText";
            this.radioButtonText.Size = new System.Drawing.Size(111, 20);
            this.radioButtonText.TabIndex = 0;
            this.radioButtonText.Text = "Text with letter";
            this.radioButtonText.UseVisualStyleBackColor = true;
            this.radioButtonText.CheckedChanged += new System.EventHandler(this.radioButtonText_CheckedChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.radioButtonNone);
            this.tabPage2.Controls.Add(this.radioButtonLower);
            this.tabPage2.Controls.Add(this.radioButtonUpper);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(713, 319);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Transformations";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // radioButtonNone
            // 
            this.radioButtonNone.AutoSize = true;
            this.radioButtonNone.Checked = true;
            this.radioButtonNone.Location = new System.Drawing.Point(50, 100);
            this.radioButtonNone.Name = "radioButtonNone";
            this.radioButtonNone.Size = new System.Drawing.Size(61, 20);
            this.radioButtonNone.TabIndex = 2;
            this.radioButtonNone.TabStop = true;
            this.radioButtonNone.Text = "None";
            this.radioButtonNone.UseVisualStyleBackColor = true;
            // 
            // radioButtonLower
            // 
            this.radioButtonLower.AutoSize = true;
            this.radioButtonLower.Enabled = false;
            this.radioButtonLower.Location = new System.Drawing.Point(50, 60);
            this.radioButtonLower.Name = "radioButtonLower";
            this.radioButtonLower.Size = new System.Drawing.Size(64, 20);
            this.radioButtonLower.TabIndex = 1;
            this.radioButtonLower.Text = "Lower";
            this.radioButtonLower.UseVisualStyleBackColor = true;
            // 
            // radioButtonUpper
            // 
            this.radioButtonUpper.AutoSize = true;
            this.radioButtonUpper.Enabled = false;
            this.radioButtonUpper.Location = new System.Drawing.Point(50, 20);
            this.radioButtonUpper.Name = "radioButtonUpper";
            this.radioButtonUpper.Size = new System.Drawing.Size(66, 20);
            this.radioButtonUpper.TabIndex = 0;
            this.radioButtonUpper.Text = "Upper";
            this.radioButtonUpper.UseVisualStyleBackColor = true;
            // 
            // domainUpDown1
            // 
            this.domainUpDown1.Enabled = false;
            this.domainUpDown1.InterceptArrowKeys = false;
            this.domainUpDown1.Items.Add("A");
            this.domainUpDown1.Items.Add("B");
            this.domainUpDown1.Items.Add("C");
            this.domainUpDown1.Items.Add("D");
            this.domainUpDown1.Items.Add("E");
            this.domainUpDown1.Items.Add("F");
            this.domainUpDown1.Items.Add("G");
            this.domainUpDown1.Items.Add("H");
            this.domainUpDown1.Items.Add("I");
            this.domainUpDown1.Items.Add("J");
            this.domainUpDown1.Items.Add("K");
            this.domainUpDown1.Items.Add("L");
            this.domainUpDown1.Items.Add("M");
            this.domainUpDown1.Items.Add("N");
            this.domainUpDown1.Items.Add("O");
            this.domainUpDown1.Items.Add("P");
            this.domainUpDown1.Items.Add("Q");
            this.domainUpDown1.Items.Add("R");
            this.domainUpDown1.Items.Add("S");
            this.domainUpDown1.Items.Add("T");
            this.domainUpDown1.Items.Add("U");
            this.domainUpDown1.Items.Add("V");
            this.domainUpDown1.Items.Add("W");
            this.domainUpDown1.Items.Add("X");
            this.domainUpDown1.Items.Add("Y");
            this.domainUpDown1.Items.Add("Z");
            this.domainUpDown1.Location = new System.Drawing.Point(16, 376);
            this.domainUpDown1.Name = "domainUpDown1";
            this.domainUpDown1.ReadOnly = true;
            this.domainUpDown1.Size = new System.Drawing.Size(120, 22);
            this.domainUpDown1.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(609, 415);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Close";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.domainUpDown1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.RadioButton radioButtonAll;
        private System.Windows.Forms.RadioButton radioButtonSigns;
        private System.Windows.Forms.RadioButton radioButtonNumbers;
        private System.Windows.Forms.RadioButton radioButtonStart;
        private System.Windows.Forms.RadioButton radioButtonText;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.RadioButton radioButtonLower;
        private System.Windows.Forms.RadioButton radioButtonUpper;
        private System.Windows.Forms.DomainUpDown domainUpDown1;
        private System.Windows.Forms.RadioButton radioButtonNone;
        private System.Windows.Forms.Button button2;
    }
}

