namespace lab1_oop
{
    partial class Painter
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
            this.Paint_Panel = new System.Windows.Forms.Panel();
            this.menu = new System.Windows.Forms.MenuStrip();
            this.SaveMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Figure_comboBox = new System.Windows.Forms.ComboBox();
            this.Draw_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.ClearButton = new System.Windows.Forms.Button();
            this.ContourLabel = new System.Windows.Forms.Label();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.FigureslistBox = new System.Windows.Forms.ListBox();
            this.ContourcolorDialog = new System.Windows.Forms.ColorDialog();
            this.ContourColorButton = new System.Windows.Forms.Button();
            this.ThiknesscomboBox = new System.Windows.Forms.ComboBox();
            this.ThiknessLabel = new System.Windows.Forms.Label();
            this.BrushLabel = new System.Windows.Forms.Label();
            this.BrushColorButton = new System.Windows.Forms.Button();
            this.BrushColorDialog = new System.Windows.Forms.ColorDialog();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changePanelColorToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.languageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PanelColorDialog = new System.Windows.Forms.ColorDialog();
            this.englishToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.russianToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Paint_Panel.SuspendLayout();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // Paint_Panel
            // 
            this.Paint_Panel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Paint_Panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Paint_Panel.Controls.Add(this.menu);
            this.Paint_Panel.Location = new System.Drawing.Point(0, 0);
            this.Paint_Panel.Name = "Paint_Panel";
            this.Paint_Panel.Size = new System.Drawing.Size(983, 500);
            this.Paint_Panel.TabIndex = 0;
            this.Paint_Panel.Paint += new System.Windows.Forms.PaintEventHandler(this.Paint_Panel_Paint);
            this.Paint_Panel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Paint_Panel_MouseClick);
            // 
            // menu
            // 
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SaveMenuItem,
            this.OpenMenuItem,
            this.settingsToolStripMenuItem});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menu.Size = new System.Drawing.Size(981, 24);
            this.menu.TabIndex = 0;
            this.menu.Text = "menuStrip1";
            // 
            // SaveMenuItem
            // 
            this.SaveMenuItem.Name = "SaveMenuItem";
            this.SaveMenuItem.Size = new System.Drawing.Size(59, 20);
            this.SaveMenuItem.Text = "Save As";
            this.SaveMenuItem.Click += new System.EventHandler(this.SaveMenuItem_Click);
            // 
            // OpenMenuItem
            // 
            this.OpenMenuItem.Name = "OpenMenuItem";
            this.OpenMenuItem.Size = new System.Drawing.Size(48, 20);
            this.OpenMenuItem.Text = "Open";
            this.OpenMenuItem.Click += new System.EventHandler(this.OpenMenuItem_Click);
            // 
            // Figure_comboBox
            // 
            this.Figure_comboBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Figure_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Figure_comboBox.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Figure_comboBox.ForeColor = System.Drawing.Color.Black;
            this.Figure_comboBox.FormattingEnabled = true;
            this.Figure_comboBox.Location = new System.Drawing.Point(12, 550);
            this.Figure_comboBox.Name = "Figure_comboBox";
            this.Figure_comboBox.Size = new System.Drawing.Size(123, 23);
            this.Figure_comboBox.TabIndex = 1;
            this.Figure_comboBox.SelectedIndexChanged += new System.EventHandler(this.Figure_comboBox_SelectedIndexChanged);
            // 
            // Draw_button
            // 
            this.Draw_button.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Draw_button.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Draw_button.Location = new System.Drawing.Point(12, 506);
            this.Draw_button.Name = "Draw_button";
            this.Draw_button.Size = new System.Drawing.Size(123, 38);
            this.Draw_button.TabIndex = 2;
            this.Draw_button.Text = "Draw";
            this.Draw_button.UseVisualStyleBackColor = false;
            this.Draw_button.Click += new System.EventHandler(this.Draw_button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(199, 519);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "X1";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(227, 516);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(47, 22);
            this.textBox1.TabIndex = 4;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(199, 547);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "X2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(199, 575);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "X3";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox2.Location = new System.Drawing.Point(227, 544);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(47, 22);
            this.textBox2.TabIndex = 7;
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox3.Location = new System.Drawing.Point(227, 572);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(47, 22);
            this.textBox3.TabIndex = 8;
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(199, 603);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "X4";
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox4.Location = new System.Drawing.Point(227, 600);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(47, 22);
            this.textBox4.TabIndex = 10;
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox5
            // 
            this.textBox5.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox5.Location = new System.Drawing.Point(328, 600);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(47, 22);
            this.textBox5.TabIndex = 18;
            this.textBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(300, 603);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(22, 15);
            this.label5.TabIndex = 17;
            this.label5.Text = "Y4";
            // 
            // textBox6
            // 
            this.textBox6.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox6.Location = new System.Drawing.Point(328, 572);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(47, 22);
            this.textBox6.TabIndex = 16;
            this.textBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox7
            // 
            this.textBox7.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox7.Location = new System.Drawing.Point(328, 544);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(47, 22);
            this.textBox7.TabIndex = 15;
            this.textBox7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(300, 575);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(22, 15);
            this.label6.TabIndex = 14;
            this.label6.Text = "Y3";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(300, 547);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(22, 15);
            this.label7.TabIndex = 13;
            this.label7.Text = "Y2";
            // 
            // textBox8
            // 
            this.textBox8.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox8.Location = new System.Drawing.Point(328, 516);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(47, 22);
            this.textBox8.TabIndex = 12;
            this.textBox8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(300, 519);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(22, 15);
            this.label8.TabIndex = 11;
            this.label8.Text = "Y1";
            // 
            // ClearButton
            // 
            this.ClearButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClearButton.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ClearButton.Location = new System.Drawing.Point(12, 579);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(123, 38);
            this.ClearButton.TabIndex = 19;
            this.ClearButton.Text = "Clean";
            this.ClearButton.UseVisualStyleBackColor = false;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // ContourLabel
            // 
            this.ContourLabel.AutoSize = true;
            this.ContourLabel.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ContourLabel.Location = new System.Drawing.Point(413, 516);
            this.ContourLabel.Name = "ContourLabel";
            this.ContourLabel.Size = new System.Drawing.Size(83, 15);
            this.ContourLabel.TabIndex = 20;
            this.ContourLabel.Text = "Contour color";
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // FigureslistBox
            // 
            this.FigureslistBox.BackColor = System.Drawing.Color.AliceBlue;
            this.FigureslistBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.FigureslistBox.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FigureslistBox.FormattingEnabled = true;
            this.FigureslistBox.ItemHeight = 15;
            this.FigureslistBox.Location = new System.Drawing.Point(985, 1);
            this.FigureslistBox.Name = "FigureslistBox";
            this.FigureslistBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.FigureslistBox.Size = new System.Drawing.Size(79, 499);
            this.FigureslistBox.TabIndex = 1;
            this.FigureslistBox.Click += new System.EventHandler(this.FigureslistBox_Click);
            this.FigureslistBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FigureslistBox_KeyPress);
            // 
            // ContourColorButton
            // 
            this.ContourColorButton.Location = new System.Drawing.Point(416, 543);
            this.ContourColorButton.Name = "ContourColorButton";
            this.ContourColorButton.Size = new System.Drawing.Size(75, 23);
            this.ContourColorButton.TabIndex = 22;
            this.ContourColorButton.UseVisualStyleBackColor = true;
            this.ContourColorButton.Click += new System.EventHandler(this.ContourColorButton_Click);
            // 
            // ThiknesscomboBox
            // 
            this.ThiknesscomboBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ThiknesscomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ThiknesscomboBox.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ThiknesscomboBox.ForeColor = System.Drawing.Color.Black;
            this.ThiknesscomboBox.FormattingEnabled = true;
            this.ThiknesscomboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "4",
            "6",
            "8",
            "10",
            "12"});
            this.ThiknesscomboBox.Location = new System.Drawing.Point(416, 599);
            this.ThiknesscomboBox.Name = "ThiknesscomboBox";
            this.ThiknesscomboBox.Size = new System.Drawing.Size(75, 23);
            this.ThiknesscomboBox.TabIndex = 23;
            this.ThiknesscomboBox.SelectedIndexChanged += new System.EventHandler(this.ThiknesscomboBox_SelectedIndexChanged);
            // 
            // ThiknessLabel
            // 
            this.ThiknessLabel.AutoSize = true;
            this.ThiknessLabel.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ThiknessLabel.Location = new System.Drawing.Point(413, 575);
            this.ThiknessLabel.Name = "ThiknessLabel";
            this.ThiknessLabel.Size = new System.Drawing.Size(59, 15);
            this.ThiknessLabel.TabIndex = 24;
            this.ThiknessLabel.Text = "Thikness";
            // 
            // BrushLabel
            // 
            this.BrushLabel.AutoSize = true;
            this.BrushLabel.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BrushLabel.Location = new System.Drawing.Point(526, 516);
            this.BrushLabel.Name = "BrushLabel";
            this.BrushLabel.Size = new System.Drawing.Size(73, 15);
            this.BrushLabel.TabIndex = 25;
            this.BrushLabel.Text = "Brush color";
            // 
            // BrushColorButton
            // 
            this.BrushColorButton.Location = new System.Drawing.Point(529, 543);
            this.BrushColorButton.Name = "BrushColorButton";
            this.BrushColorButton.Size = new System.Drawing.Size(75, 23);
            this.BrushColorButton.TabIndex = 26;
            this.BrushColorButton.UseVisualStyleBackColor = true;
            this.BrushColorButton.Click += new System.EventHandler(this.BrushColorButton_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changePanelColorToolStripMenuItem1,
            this.languageToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // changePanelColorToolStripMenuItem1
            // 
            this.changePanelColorToolStripMenuItem1.Name = "changePanelColorToolStripMenuItem1";
            this.changePanelColorToolStripMenuItem1.Size = new System.Drawing.Size(179, 22);
            this.changePanelColorToolStripMenuItem1.Text = "Change Panel Color";
            this.changePanelColorToolStripMenuItem1.Click += new System.EventHandler(this.changePanelColorToolStripMenuItem1_Click);
            // 
            // languageToolStripMenuItem
            // 
            this.languageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.englishToolStripMenuItem,
            this.russianToolStripMenuItem});
            this.languageToolStripMenuItem.Name = "languageToolStripMenuItem";
            this.languageToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.languageToolStripMenuItem.Text = "Language";
            // 
            // englishToolStripMenuItem
            // 
            this.englishToolStripMenuItem.Name = "englishToolStripMenuItem";
            this.englishToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.englishToolStripMenuItem.Text = "English";
            this.englishToolStripMenuItem.Click += new System.EventHandler(this.englishToolStripMenuItem_Click);
            // 
            // russianToolStripMenuItem
            // 
            this.russianToolStripMenuItem.Name = "russianToolStripMenuItem";
            this.russianToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.russianToolStripMenuItem.Text = "Russian";
            this.russianToolStripMenuItem.Click += new System.EventHandler(this.russianToolStripMenuItem_Click);
            // 
            // Painter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 632);
            this.Controls.Add(this.BrushColorButton);
            this.Controls.Add(this.BrushLabel);
            this.Controls.Add(this.ThiknessLabel);
            this.Controls.Add(this.ThiknesscomboBox);
            this.Controls.Add(this.ContourColorButton);
            this.Controls.Add(this.FigureslistBox);
            this.Controls.Add(this.ContourLabel);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Draw_button);
            this.Controls.Add(this.Figure_comboBox);
            this.Controls.Add(this.Paint_Panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menu;
            this.Name = "Painter";
            this.Text = "Paint";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Painter_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Painter_FormClosed);
            this.Load += new System.EventHandler(this.Painter_Load);
            this.Paint_Panel.ResumeLayout(false);
            this.Paint_Panel.PerformLayout();
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Paint_Panel;
        private System.Windows.Forms.ComboBox Figure_comboBox;
        private System.Windows.Forms.Button Draw_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Label ContourLabel;
        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem SaveMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OpenMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.ListBox FigureslistBox;
        private System.Windows.Forms.ColorDialog ContourcolorDialog;
        private System.Windows.Forms.Button ContourColorButton;
        private System.Windows.Forms.ComboBox ThiknesscomboBox;
        private System.Windows.Forms.Label ThiknessLabel;
        private System.Windows.Forms.Label BrushLabel;
        private System.Windows.Forms.Button BrushColorButton;
        private System.Windows.Forms.ColorDialog BrushColorDialog;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changePanelColorToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem languageToolStripMenuItem;
        private System.Windows.Forms.ColorDialog PanelColorDialog;
        private System.Windows.Forms.ToolStripMenuItem englishToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem russianToolStripMenuItem;
    }
}

