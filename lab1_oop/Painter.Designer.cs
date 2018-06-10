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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Painter));
            this.Paint_Panel = new System.Windows.Forms.Panel();
            this.menu = new System.Windows.Forms.MenuStrip();
            this.SaveMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changePanelColorToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.languageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.englishToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.russianToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.frenchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveYourOwnFigureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.PanelColorDialog = new System.Windows.Forms.ColorDialog();
            this.Paint_Panel.SuspendLayout();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // Paint_Panel
            // 
            this.Paint_Panel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Paint_Panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Paint_Panel.Controls.Add(this.menu);
            resources.ApplyResources(this.Paint_Panel, "Paint_Panel");
            this.Paint_Panel.Name = "Paint_Panel";
            this.Paint_Panel.Paint += new System.Windows.Forms.PaintEventHandler(this.Paint_Panel_Paint);
            this.Paint_Panel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Paint_Panel_MouseClick);
            // 
            // menu
            // 
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SaveMenuItem,
            this.OpenMenuItem,
            this.settingsToolStripMenuItem,
            this.saveYourOwnFigureToolStripMenuItem});
            resources.ApplyResources(this.menu, "menu");
            this.menu.Name = "menu";
            this.menu.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            // 
            // SaveMenuItem
            // 
            this.SaveMenuItem.Name = "SaveMenuItem";
            resources.ApplyResources(this.SaveMenuItem, "SaveMenuItem");
            this.SaveMenuItem.Click += new System.EventHandler(this.SaveMenuItem_Click);
            // 
            // OpenMenuItem
            // 
            this.OpenMenuItem.Name = "OpenMenuItem";
            resources.ApplyResources(this.OpenMenuItem, "OpenMenuItem");
            this.OpenMenuItem.Click += new System.EventHandler(this.OpenMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changePanelColorToolStripMenuItem1,
            this.languageToolStripMenuItem,
            this.saveToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            resources.ApplyResources(this.settingsToolStripMenuItem, "settingsToolStripMenuItem");
            // 
            // changePanelColorToolStripMenuItem1
            // 
            this.changePanelColorToolStripMenuItem1.Name = "changePanelColorToolStripMenuItem1";
            resources.ApplyResources(this.changePanelColorToolStripMenuItem1, "changePanelColorToolStripMenuItem1");
            this.changePanelColorToolStripMenuItem1.Click += new System.EventHandler(this.changePanelColorToolStripMenuItem1_Click);
            // 
            // languageToolStripMenuItem
            // 
            this.languageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.englishToolStripMenuItem,
            this.russianToolStripMenuItem,
            this.frenchToolStripMenuItem});
            this.languageToolStripMenuItem.Name = "languageToolStripMenuItem";
            resources.ApplyResources(this.languageToolStripMenuItem, "languageToolStripMenuItem");
            // 
            // englishToolStripMenuItem
            // 
            this.englishToolStripMenuItem.Name = "englishToolStripMenuItem";
            resources.ApplyResources(this.englishToolStripMenuItem, "englishToolStripMenuItem");
            this.englishToolStripMenuItem.Click += new System.EventHandler(this.englishToolStripMenuItem_Click);
            // 
            // russianToolStripMenuItem
            // 
            this.russianToolStripMenuItem.Name = "russianToolStripMenuItem";
            resources.ApplyResources(this.russianToolStripMenuItem, "russianToolStripMenuItem");
            this.russianToolStripMenuItem.Click += new System.EventHandler(this.russianToolStripMenuItem_Click);
            // 
            // frenchToolStripMenuItem
            // 
            this.frenchToolStripMenuItem.Name = "frenchToolStripMenuItem";
            resources.ApplyResources(this.frenchToolStripMenuItem, "frenchToolStripMenuItem");
            this.frenchToolStripMenuItem.Click += new System.EventHandler(this.frenchToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            resources.ApplyResources(this.saveToolStripMenuItem, "saveToolStripMenuItem");
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveYourOwnFigureToolStripMenuItem
            // 
            this.saveYourOwnFigureToolStripMenuItem.Name = "saveYourOwnFigureToolStripMenuItem";
            resources.ApplyResources(this.saveYourOwnFigureToolStripMenuItem, "saveYourOwnFigureToolStripMenuItem");
            this.saveYourOwnFigureToolStripMenuItem.Click += new System.EventHandler(this.saveYourOwnFigureToolStripMenuItem_Click);
            // 
            // Figure_comboBox
            // 
            this.Figure_comboBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Figure_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.Figure_comboBox, "Figure_comboBox");
            this.Figure_comboBox.ForeColor = System.Drawing.Color.Black;
            this.Figure_comboBox.FormattingEnabled = true;
            this.Figure_comboBox.Items.AddRange(new object[] {
            resources.GetString("Figure_comboBox.Items"),
            resources.GetString("Figure_comboBox.Items1"),
            resources.GetString("Figure_comboBox.Items2"),
            resources.GetString("Figure_comboBox.Items3"),
            resources.GetString("Figure_comboBox.Items4"),
            resources.GetString("Figure_comboBox.Items5")});
            this.Figure_comboBox.Name = "Figure_comboBox";
            this.Figure_comboBox.SelectedIndexChanged += new System.EventHandler(this.Figure_comboBox_SelectedIndexChanged);
            // 
            // Draw_button
            // 
            this.Draw_button.BackColor = System.Drawing.SystemColors.ControlLight;
            resources.ApplyResources(this.Draw_button, "Draw_button");
            this.Draw_button.Name = "Draw_button";
            this.Draw_button.UseVisualStyleBackColor = false;
            this.Draw_button.Click += new System.EventHandler(this.Draw_button_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // textBox1
            // 
            resources.ApplyResources(this.textBox1, "textBox1");
            this.textBox1.Name = "textBox1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // textBox2
            // 
            resources.ApplyResources(this.textBox2, "textBox2");
            this.textBox2.Name = "textBox2";
            // 
            // textBox3
            // 
            resources.ApplyResources(this.textBox3, "textBox3");
            this.textBox3.Name = "textBox3";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // textBox4
            // 
            resources.ApplyResources(this.textBox4, "textBox4");
            this.textBox4.Name = "textBox4";
            // 
            // textBox5
            // 
            resources.ApplyResources(this.textBox5, "textBox5");
            this.textBox5.Name = "textBox5";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // textBox6
            // 
            resources.ApplyResources(this.textBox6, "textBox6");
            this.textBox6.Name = "textBox6";
            // 
            // textBox7
            // 
            resources.ApplyResources(this.textBox7, "textBox7");
            this.textBox7.Name = "textBox7";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // textBox8
            // 
            resources.ApplyResources(this.textBox8, "textBox8");
            this.textBox8.Name = "textBox8";
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
            // 
            // ClearButton
            // 
            this.ClearButton.BackColor = System.Drawing.SystemColors.ControlLight;
            resources.ApplyResources(this.ClearButton, "ClearButton");
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.UseVisualStyleBackColor = false;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // ContourLabel
            // 
            resources.ApplyResources(this.ContourLabel, "ContourLabel");
            this.ContourLabel.Name = "ContourLabel";
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // FigureslistBox
            // 
            this.FigureslistBox.BackColor = System.Drawing.Color.AliceBlue;
            this.FigureslistBox.Cursor = System.Windows.Forms.Cursors.Default;
            resources.ApplyResources(this.FigureslistBox, "FigureslistBox");
            this.FigureslistBox.FormattingEnabled = true;
            this.FigureslistBox.Name = "FigureslistBox";
            this.FigureslistBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.FigureslistBox.Click += new System.EventHandler(this.FigureslistBox_Click);
            this.FigureslistBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FigureslistBox_KeyPress);
            // 
            // ContourColorButton
            // 
            resources.ApplyResources(this.ContourColorButton, "ContourColorButton");
            this.ContourColorButton.Name = "ContourColorButton";
            this.ContourColorButton.UseVisualStyleBackColor = true;
            this.ContourColorButton.Click += new System.EventHandler(this.ContourColorButton_Click);
            // 
            // ThiknesscomboBox
            // 
            this.ThiknesscomboBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ThiknesscomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.ThiknesscomboBox, "ThiknesscomboBox");
            this.ThiknesscomboBox.ForeColor = System.Drawing.Color.Black;
            this.ThiknesscomboBox.FormattingEnabled = true;
            this.ThiknesscomboBox.Items.AddRange(new object[] {
            resources.GetString("ThiknesscomboBox.Items"),
            resources.GetString("ThiknesscomboBox.Items1"),
            resources.GetString("ThiknesscomboBox.Items2"),
            resources.GetString("ThiknesscomboBox.Items3"),
            resources.GetString("ThiknesscomboBox.Items4"),
            resources.GetString("ThiknesscomboBox.Items5"),
            resources.GetString("ThiknesscomboBox.Items6")});
            this.ThiknesscomboBox.Name = "ThiknesscomboBox";
            this.ThiknesscomboBox.SelectedIndexChanged += new System.EventHandler(this.ThiknesscomboBox_SelectedIndexChanged);
            // 
            // ThiknessLabel
            // 
            resources.ApplyResources(this.ThiknessLabel, "ThiknessLabel");
            this.ThiknessLabel.Name = "ThiknessLabel";
            // 
            // BrushLabel
            // 
            resources.ApplyResources(this.BrushLabel, "BrushLabel");
            this.BrushLabel.Name = "BrushLabel";
            // 
            // BrushColorButton
            // 
            resources.ApplyResources(this.BrushColorButton, "BrushColorButton");
            this.BrushColorButton.Name = "BrushColorButton";
            this.BrushColorButton.UseVisualStyleBackColor = true;
            this.BrushColorButton.Click += new System.EventHandler(this.BrushColorButton_Click);
            // 
            // Painter
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Paint_Panel);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menu;
            this.Name = "Painter";
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
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem frenchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveYourOwnFigureToolStripMenuItem;
    }
}

