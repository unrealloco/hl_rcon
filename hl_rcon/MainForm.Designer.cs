﻿namespace hl_rcon
{
    partial class MainForm
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
            this.groupBoxRconConsole = new System.Windows.Forms.GroupBox();
            this.clearCommand = new System.Windows.Forms.CheckBox();
            this.buttonSend = new System.Windows.Forms.Button();
            this.textBoxCommand = new System.Windows.Forms.TextBox();
            this.labelInfo = new System.Windows.Forms.Label();
            this.textBoxConsole = new System.Windows.Forms.RichTextBox();
            this.groupBoxServer = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxAdress = new System.Windows.Forms.MaskedTextBox();
            this.textBoxPassword = new System.Windows.Forms.MaskedTextBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tab1_groupBox1 = new System.Windows.Forms.GroupBox();
            this.tab1_button1 = new System.Windows.Forms.Button();
            this.tab1_numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.groupBoxRconConsole.SuspendLayout();
            this.groupBoxServer.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tab1_groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tab1_numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxRconConsole
            // 
            this.groupBoxRconConsole.Controls.Add(this.clearCommand);
            this.groupBoxRconConsole.Controls.Add(this.buttonSend);
            this.groupBoxRconConsole.Controls.Add(this.textBoxCommand);
            this.groupBoxRconConsole.Controls.Add(this.labelInfo);
            this.groupBoxRconConsole.Controls.Add(this.textBoxConsole);
            this.groupBoxRconConsole.Location = new System.Drawing.Point(8, 80);
            this.groupBoxRconConsole.Name = "groupBoxRconConsole";
            this.groupBoxRconConsole.Size = new System.Drawing.Size(360, 252);
            this.groupBoxRconConsole.TabIndex = 3;
            this.groupBoxRconConsole.TabStop = false;
            this.groupBoxRconConsole.Text = "RCON Konsola";
            // 
            // clearCommand
            // 
            this.clearCommand.AutoSize = true;
            this.clearCommand.Checked = true;
            this.clearCommand.CheckState = System.Windows.Forms.CheckState.Checked;
            this.clearCommand.Location = new System.Drawing.Point(258, 225);
            this.clearCommand.Name = "clearCommand";
            this.clearCommand.Size = new System.Drawing.Size(15, 14);
            this.clearCommand.TabIndex = 6;
            this.clearCommand.UseVisualStyleBackColor = true;
            // 
            // buttonSend
            // 
            this.buttonSend.Location = new System.Drawing.Point(279, 221);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(75, 21);
            this.buttonSend.TabIndex = 4;
            this.buttonSend.Text = "Wyslij";
            this.buttonSend.UseVisualStyleBackColor = true;
            this.buttonSend.Click += new System.EventHandler(this.buttonSend_Click);
            // 
            // textBoxCommand
            // 
            this.textBoxCommand.Location = new System.Drawing.Point(69, 221);
            this.textBoxCommand.Name = "textBoxCommand";
            this.textBoxCommand.Size = new System.Drawing.Size(183, 20);
            this.textBoxCommand.TabIndex = 3;
            // 
            // labelInfo
            // 
            this.labelInfo.AutoSize = true;
            this.labelInfo.Location = new System.Drawing.Point(8, 224);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(55, 13);
            this.labelInfo.TabIndex = 1;
            this.labelInfo.Text = "Komenda:";
            // 
            // textBoxConsole
            // 
            this.textBoxConsole.Location = new System.Drawing.Point(9, 19);
            this.textBoxConsole.Name = "textBoxConsole";
            this.textBoxConsole.ReadOnly = true;
            this.textBoxConsole.Size = new System.Drawing.Size(345, 195);
            this.textBoxConsole.TabIndex = 5;
            this.textBoxConsole.Text = "";
            // 
            // groupBoxServer
            // 
            this.groupBoxServer.Controls.Add(this.label1);
            this.groupBoxServer.Controls.Add(this.textBoxAdress);
            this.groupBoxServer.Controls.Add(this.textBoxPassword);
            this.groupBoxServer.Controls.Add(this.labelPassword);
            this.groupBoxServer.Location = new System.Drawing.Point(6, 6);
            this.groupBoxServer.Name = "groupBoxServer";
            this.groupBoxServer.Size = new System.Drawing.Size(360, 68);
            this.groupBoxServer.TabIndex = 2;
            this.groupBoxServer.TabStop = false;
            this.groupBoxServer.Text = "Dane logowania";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Adres:";
            // 
            // textBoxAdress
            // 
            this.textBoxAdress.Location = new System.Drawing.Point(85, 16);
            this.textBoxAdress.Name = "textBoxAdress";
            this.textBoxAdress.Size = new System.Drawing.Size(269, 20);
            this.textBoxAdress.TabIndex = 5;
            this.textBoxAdress.ValidatingType = typeof(int);
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(85, 42);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(269, 20);
            this.textBoxPassword.TabIndex = 2;
            this.textBoxPassword.ValidatingType = typeof(int);
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(8, 45);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(73, 13);
            this.labelPassword.TabIndex = 4;
            this.labelPassword.Text = "RCON Hasło:";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(387, 364);
            this.tabControl1.TabIndex = 7;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBoxServer);
            this.tabPage1.Controls.Add(this.groupBoxRconConsole);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(379, 338);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Główne";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tab1_groupBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(379, 338);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "jk_botti";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tab1_groupBox1
            // 
            this.tab1_groupBox1.Controls.Add(this.tab1_button1);
            this.tab1_groupBox1.Controls.Add(this.tab1_numericUpDown1);
            this.tab1_groupBox1.Location = new System.Drawing.Point(8, 6);
            this.tab1_groupBox1.Name = "tab1_groupBox1";
            this.tab1_groupBox1.Size = new System.Drawing.Size(171, 50);
            this.tab1_groupBox1.TabIndex = 0;
            this.tab1_groupBox1.TabStop = false;
            this.tab1_groupBox1.Text = "Ilość botów (min && max)";
            // 
            // tab1_button1
            // 
            this.tab1_button1.Location = new System.Drawing.Point(132, 19);
            this.tab1_button1.Name = "tab1_button1";
            this.tab1_button1.Size = new System.Drawing.Size(33, 20);
            this.tab1_button1.TabIndex = 1;
            this.tab1_button1.Text = "OK";
            this.tab1_button1.UseVisualStyleBackColor = true;
            this.tab1_button1.Click += new System.EventHandler(this.tab1_button1_Click);
            // 
            // tab1_numericUpDown1
            // 
            this.tab1_numericUpDown1.Location = new System.Drawing.Point(6, 19);
            this.tab1_numericUpDown1.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.tab1_numericUpDown1.Name = "tab1_numericUpDown1";
            this.tab1_numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.tab1_numericUpDown1.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 364);
            this.Controls.Add(this.tabControl1);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.Text = "Half-Life RCON";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBoxRconConsole.ResumeLayout(false);
            this.groupBoxRconConsole.PerformLayout();
            this.groupBoxServer.ResumeLayout(false);
            this.groupBoxServer.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tab1_groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tab1_numericUpDown1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxRconConsole;
        private System.Windows.Forms.Button buttonSend;
        private System.Windows.Forms.TextBox textBoxCommand;
        private System.Windows.Forms.Label labelInfo;
        private System.Windows.Forms.RichTextBox textBoxConsole;
        private System.Windows.Forms.GroupBox groupBoxServer;
        private System.Windows.Forms.MaskedTextBox textBoxPassword;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.CheckBox clearCommand;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox tab1_groupBox1;
        private System.Windows.Forms.Button tab1_button1;
        private System.Windows.Forms.NumericUpDown tab1_numericUpDown1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox textBoxAdress;
    }
}

