namespace MusicPlayer
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.startButton = new System.Windows.Forms.Button();
            this.stopButton = new System.Windows.Forms.Button();
            this.MusicFolderTextBox = new System.Windows.Forms.TextBox();
            this.openButton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.FileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HomeWebMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.AboutMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SundayCheckBox = new System.Windows.Forms.CheckBox();
            this.SaturdayCheckBox = new System.Windows.Forms.CheckBox();
            this.FridayCheckBox = new System.Windows.Forms.CheckBox();
            this.ThursdayCheckBox = new System.Windows.Forms.CheckBox();
            this.WednesdayCheckBox = new System.Windows.Forms.CheckBox();
            this.TuesdayCheckBox = new System.Windows.Forms.CheckBox();
            this.MondayCheckBox = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtEnd = new System.Windows.Forms.MaskedTextBox();
            this.txtStart = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // startButton
            // 
            this.startButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.startButton.Location = new System.Drawing.Point(293, 430);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(127, 55);
            this.startButton.TabIndex = 0;
            this.startButton.Text = "Запустить";
            this.toolTip1.SetToolTip(this.startButton, "Запустить задание");
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // stopButton
            // 
            this.stopButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.stopButton.Location = new System.Drawing.Point(16, 430);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(127, 55);
            this.stopButton.TabIndex = 1;
            this.stopButton.Text = "Остановить";
            this.toolTip1.SetToolTip(this.stopButton, "Остановить задание");
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.StopButton_Click);
            // 
            // MusicFolderTextBox
            // 
            this.MusicFolderTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MusicFolderTextBox.Location = new System.Drawing.Point(16, 86);
            this.MusicFolderTextBox.Name = "MusicFolderTextBox";
            this.MusicFolderTextBox.Size = new System.Drawing.Size(344, 27);
            this.MusicFolderTextBox.TabIndex = 2;
            // 
            // openButton
            // 
            this.openButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.openButton.Location = new System.Drawing.Point(372, 86);
            this.openButton.Name = "openButton";
            this.openButton.Size = new System.Drawing.Size(48, 27);
            this.openButton.TabIndex = 3;
            this.openButton.Text = "...";
            this.openButton.UseVisualStyleBackColor = true;
            this.openButton.Click += new System.EventHandler(this.OpenButton_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileMenuItem,
            this.HelpMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(438, 28);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // FileMenuItem
            // 
            this.FileMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ExitMenuItem});
            this.FileMenuItem.Name = "FileMenuItem";
            this.FileMenuItem.Size = new System.Drawing.Size(59, 24);
            this.FileMenuItem.Text = "Файл";
            // 
            // ExitMenuItem
            // 
            this.ExitMenuItem.Name = "ExitMenuItem";
            this.ExitMenuItem.Size = new System.Drawing.Size(136, 26);
            this.ExitMenuItem.Text = "Выход";
            this.ExitMenuItem.Click += new System.EventHandler(this.ExitMenuItem_Click);
            // 
            // HelpMenuItem
            // 
            this.HelpMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.HomeWebMenuItem,
            this.toolStripSeparator1,
            this.AboutMenuItem});
            this.HelpMenuItem.Name = "HelpMenuItem";
            this.HelpMenuItem.Size = new System.Drawing.Size(83, 24);
            this.HelpMenuItem.Text = "Помощь";
            // 
            // HomeWebMenuItem
            // 
            this.HomeWebMenuItem.Name = "HomeWebMenuItem";
            this.HomeWebMenuItem.Size = new System.Drawing.Size(236, 26);
            this.HomeWebMenuItem.Text = "Домашняя страница";
            this.HomeWebMenuItem.Click += new System.EventHandler(this.HomeWebMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(233, 6);
            // 
            // AboutMenuItem
            // 
            this.AboutMenuItem.Name = "AboutMenuItem";
            this.AboutMenuItem.Size = new System.Drawing.Size(236, 26);
            this.AboutMenuItem.Text = "О программе...";
            this.AboutMenuItem.Click += new System.EventHandler(this.AboutMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Выберите папку с музыкой:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.SundayCheckBox);
            this.groupBox1.Controls.Add(this.SaturdayCheckBox);
            this.groupBox1.Controls.Add(this.FridayCheckBox);
            this.groupBox1.Controls.Add(this.ThursdayCheckBox);
            this.groupBox1.Controls.Add(this.WednesdayCheckBox);
            this.groupBox1.Controls.Add(this.TuesdayCheckBox);
            this.groupBox1.Controls.Add(this.MondayCheckBox);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(16, 150);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(404, 151);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Дни недели";
            this.toolTip1.SetToolTip(this.groupBox1, "Выбрать дни недели");
            // 
            // SundayCheckBox
            // 
            this.SundayCheckBox.AutoSize = true;
            this.SundayCheckBox.Location = new System.Drawing.Point(240, 87);
            this.SundayCheckBox.Name = "SundayCheckBox";
            this.SundayCheckBox.Size = new System.Drawing.Size(140, 24);
            this.SundayCheckBox.TabIndex = 6;
            this.SundayCheckBox.Text = "Воскресение";
            this.SundayCheckBox.UseVisualStyleBackColor = true;
            // 
            // SaturdayCheckBox
            // 
            this.SaturdayCheckBox.AutoSize = true;
            this.SaturdayCheckBox.Location = new System.Drawing.Point(240, 57);
            this.SaturdayCheckBox.Name = "SaturdayCheckBox";
            this.SaturdayCheckBox.Size = new System.Drawing.Size(101, 24);
            this.SaturdayCheckBox.TabIndex = 5;
            this.SaturdayCheckBox.Text = "Суббота";
            this.SaturdayCheckBox.UseVisualStyleBackColor = true;
            // 
            // FridayCheckBox
            // 
            this.FridayCheckBox.AutoSize = true;
            this.FridayCheckBox.Checked = true;
            this.FridayCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.FridayCheckBox.Location = new System.Drawing.Point(240, 27);
            this.FridayCheckBox.Name = "FridayCheckBox";
            this.FridayCheckBox.Size = new System.Drawing.Size(104, 24);
            this.FridayCheckBox.TabIndex = 4;
            this.FridayCheckBox.Text = "Пятница";
            this.FridayCheckBox.UseVisualStyleBackColor = true;
            // 
            // ThursdayCheckBox
            // 
            this.ThursdayCheckBox.AutoSize = true;
            this.ThursdayCheckBox.Checked = true;
            this.ThursdayCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ThursdayCheckBox.Location = new System.Drawing.Point(18, 116);
            this.ThursdayCheckBox.Name = "ThursdayCheckBox";
            this.ThursdayCheckBox.Size = new System.Drawing.Size(102, 24);
            this.ThursdayCheckBox.TabIndex = 3;
            this.ThursdayCheckBox.Text = "Четверг";
            this.ThursdayCheckBox.UseVisualStyleBackColor = true;
            // 
            // WednesdayCheckBox
            // 
            this.WednesdayCheckBox.AutoSize = true;
            this.WednesdayCheckBox.Checked = true;
            this.WednesdayCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.WednesdayCheckBox.Location = new System.Drawing.Point(18, 86);
            this.WednesdayCheckBox.Name = "WednesdayCheckBox";
            this.WednesdayCheckBox.Size = new System.Drawing.Size(85, 24);
            this.WednesdayCheckBox.TabIndex = 2;
            this.WednesdayCheckBox.Text = "Среда";
            this.WednesdayCheckBox.UseVisualStyleBackColor = true;
            // 
            // TuesdayCheckBox
            // 
            this.TuesdayCheckBox.AutoSize = true;
            this.TuesdayCheckBox.Checked = true;
            this.TuesdayCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.TuesdayCheckBox.Location = new System.Drawing.Point(18, 56);
            this.TuesdayCheckBox.Name = "TuesdayCheckBox";
            this.TuesdayCheckBox.Size = new System.Drawing.Size(102, 24);
            this.TuesdayCheckBox.TabIndex = 1;
            this.TuesdayCheckBox.Text = "Вторник";
            this.TuesdayCheckBox.UseVisualStyleBackColor = true;
            // 
            // MondayCheckBox
            // 
            this.MondayCheckBox.AutoSize = true;
            this.MondayCheckBox.Checked = true;
            this.MondayCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.MondayCheckBox.Location = new System.Drawing.Point(18, 26);
            this.MondayCheckBox.Name = "MondayCheckBox";
            this.MondayCheckBox.Size = new System.Drawing.Size(145, 24);
            this.MondayCheckBox.TabIndex = 0;
            this.MondayCheckBox.Text = "Понедельник";
            this.MondayCheckBox.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtEnd);
            this.groupBox2.Controls.Add(this.txtStart);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(16, 323);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(404, 101);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Время";
            this.toolTip1.SetToolTip(this.groupBox2, "Выбрать время");
            // 
            // txtEnd
            // 
            this.txtEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtEnd.Location = new System.Drawing.Point(302, 41);
            this.txtEnd.Mask = "00:00";
            this.txtEnd.Name = "txtEnd";
            this.txtEnd.Size = new System.Drawing.Size(62, 27);
            this.txtEnd.TabIndex = 10;
            this.txtEnd.Text = "1800";
            this.txtEnd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtEnd.ValidatingType = typeof(System.DateTime);
            // 
            // txtStart
            // 
            this.txtStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtStart.Location = new System.Drawing.Point(101, 41);
            this.txtStart.Mask = "00:00";
            this.txtStart.Name = "txtStart";
            this.txtStart.Size = new System.Drawing.Size(62, 27);
            this.txtStart.TabIndex = 10;
            this.txtStart.Text = "0800";
            this.txtStart.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtStart.ValidatingType = typeof(System.DateTime);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(231, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Конец:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Начало:";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.statusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 499);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(438, 26);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 9;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(55, 20);
            this.toolStripStatusLabel1.Text = "Статус:";
            // 
            // statusLabel
            // 
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(18, 20);
            this.statusLabel.Text = "...";
            // 
            // timer
            // 
            this.timer.Interval = 5000;
            this.timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 525);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.openButton);
            this.Controls.Add(this.MusicFolderTextBox);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ПлеерPRO";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.TextBox MusicFolderTextBox;
        private System.Windows.Forms.Button openButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem FileMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox SundayCheckBox;
        private System.Windows.Forms.CheckBox SaturdayCheckBox;
        private System.Windows.Forms.CheckBox FridayCheckBox;
        private System.Windows.Forms.CheckBox ThursdayCheckBox;
        private System.Windows.Forms.CheckBox WednesdayCheckBox;
        private System.Windows.Forms.CheckBox TuesdayCheckBox;
        private System.Windows.Forms.CheckBox MondayCheckBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel;
        private System.Windows.Forms.MaskedTextBox txtStart;
        private System.Windows.Forms.MaskedTextBox txtEnd;
        private System.Windows.Forms.ToolStripMenuItem ExitMenuItem;
        private System.Windows.Forms.ToolStripMenuItem HelpMenuItem;
        private System.Windows.Forms.ToolStripMenuItem HomeWebMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem AboutMenuItem;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

