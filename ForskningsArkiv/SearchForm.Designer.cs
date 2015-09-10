﻿namespace ForskningsArkiv
{
    partial class SearchForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox1Søg = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button2Emnetyper = new System.Windows.Forms.Button();
            this.comboEmnetyper = new System.Windows.Forms.ComboBox();
            this.MatriealetypeBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.PeriodeLB = new System.Windows.Forms.Label();
            this.PeriodeTPComboBox = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtFritekstsøg = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Silver;
            this.dataGridView1.CausesValidation = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(633, 37);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(658, 442);
            this.dataGridView1.TabIndex = 6;
            // 
            // textBox1Søg
            // 
            this.textBox1Søg.Location = new System.Drawing.Point(12, 37);
            this.textBox1Søg.Name = "textBox1Søg";
            this.textBox1Søg.Size = new System.Drawing.Size(166, 20);
            this.textBox1Søg.TabIndex = 7;
            this.textBox1Søg.TextChanged += new System.EventHandler(this.textBox1Søg_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Fritekstsøgning:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button1.Location = new System.Drawing.Point(12, 499);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(1279, 32);
            this.button1.TabIndex = 4;
            this.button1.Text = "Afslut søg";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Søg i Emnetyper";
            // 
            // button2Emnetyper
            // 
            this.button2Emnetyper.Location = new System.Drawing.Point(9, 448);
            this.button2Emnetyper.Name = "button2Emnetyper";
            this.button2Emnetyper.Size = new System.Drawing.Size(264, 31);
            this.button2Emnetyper.TabIndex = 12;
            this.button2Emnetyper.Text = "Søg";
            this.button2Emnetyper.UseVisualStyleBackColor = true;
            this.button2Emnetyper.Click += new System.EventHandler(this.button2Emnetyper_Click);
            // 
            // comboEmnetyper
            // 
            this.comboEmnetyper.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboEmnetyper.FormattingEnabled = true;
            this.comboEmnetyper.Location = new System.Drawing.Point(1, 64);
            this.comboEmnetyper.MaxDropDownItems = 50;
            this.comboEmnetyper.Name = "comboEmnetyper";
            this.comboEmnetyper.Size = new System.Drawing.Size(139, 21);
            this.comboEmnetyper.TabIndex = 14;
            // 
            // MatriealetypeBox
            // 
            this.MatriealetypeBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MatriealetypeBox.FormattingEnabled = true;
            this.MatriealetypeBox.Location = new System.Drawing.Point(1, 104);
            this.MatriealetypeBox.MaxDropDownItems = 50;
            this.MatriealetypeBox.Name = "MatriealetypeBox";
            this.MatriealetypeBox.Size = new System.Drawing.Size(139, 21);
            this.MatriealetypeBox.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(-2, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Søg i MaterialeTyper";
            // 
            // PeriodeLB
            // 
            this.PeriodeLB.AutoSize = true;
            this.PeriodeLB.Location = new System.Drawing.Point(0, 8);
            this.PeriodeLB.Name = "PeriodeLB";
            this.PeriodeLB.Size = new System.Drawing.Size(43, 13);
            this.PeriodeLB.TabIndex = 17;
            this.PeriodeLB.Text = "Periode";
            // 
            // PeriodeTPComboBox
            // 
            this.PeriodeTPComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PeriodeTPComboBox.FormattingEnabled = true;
            this.PeriodeTPComboBox.Location = new System.Drawing.Point(1, 24);
            this.PeriodeTPComboBox.MaxDropDownItems = 50;
            this.PeriodeTPComboBox.Name = "PeriodeTPComboBox";
            this.PeriodeTPComboBox.Size = new System.Drawing.Size(139, 21);
            this.PeriodeTPComboBox.TabIndex = 18;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.PeriodeTPComboBox);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.PeriodeLB);
            this.panel1.Controls.Add(this.MatriealetypeBox);
            this.panel1.Controls.Add(this.comboEmnetyper);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(12, 213);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(234, 155);
            this.panel1.TabIndex = 19;
            // 
            // BtFritekstsøg
            // 
            this.BtFritekstsøg.Location = new System.Drawing.Point(12, 63);
            this.BtFritekstsøg.Name = "BtFritekstsøg";
            this.BtFritekstsøg.Size = new System.Drawing.Size(166, 31);
            this.BtFritekstsøg.TabIndex = 20;
            this.BtFritekstsøg.Text = "Søg";
            this.BtFritekstsøg.UseVisualStyleBackColor = true;
            this.BtFritekstsøg.Click += new System.EventHandler(this.BtFritekstsøg_Click);
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1317, 551);
            this.Controls.Add(this.BtFritekstsøg);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button2Emnetyper);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1Søg);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Name = "SearchForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SearchForm";
            this.TransparencyKey = System.Drawing.Color.LightGray;
            this.Load += new System.EventHandler(this.SearchForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.DataGridView dataGridView1;
        public System.Windows.Forms.TextBox textBox1Søg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        internal System.Windows.Forms.Button button2Emnetyper;
        public System.Windows.Forms.ComboBox comboEmnetyper;
        public System.Windows.Forms.ComboBox MatriealetypeBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label PeriodeLB;
        public System.Windows.Forms.ComboBox PeriodeTPComboBox;
        private System.Windows.Forms.Panel panel1;
        internal System.Windows.Forms.Button BtFritekstsøg;
    }
}