namespace ForskningsArkiv
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBoxFrisøgning = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonSøg = new System.Windows.Forms.Button();
            this.comboEmnetyper = new System.Windows.Forms.ComboBox();
            this.MatriealetypeBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.PeriodeLB = new System.Windows.Forms.Label();
            this.PeriodeTPComboBox = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.EksperimenttyperComboBox = new System.Windows.Forms.ComboBox();
            this.textboxSagstitel = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.textBoxSagoprettet = new System.Windows.Forms.TextBox();
            this.textBoxsagAfsluttet = new System.Windows.Forms.TextBox();
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
            this.dataGridView1.Location = new System.Drawing.Point(372, 37);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(919, 442);
            this.dataGridView1.TabIndex = 6;
            // 
            // textBoxFrisøgning
            // 
            this.textBoxFrisøgning.Location = new System.Drawing.Point(12, 37);
            this.textBoxFrisøgning.Name = "textBoxFrisøgning";
            this.textBoxFrisøgning.Size = new System.Drawing.Size(166, 20);
            this.textBoxFrisøgning.TabIndex = 7;
            this.textBoxFrisøgning.TextChanged += new System.EventHandler(this.textBox1Søg_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 21);
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
            this.label2.Location = new System.Drawing.Point(1, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Søg i Emnetyper";
            // 
            // buttonSøg
            // 
            this.buttonSøg.Location = new System.Drawing.Point(12, 434);
            this.buttonSøg.Name = "buttonSøg";
            this.buttonSøg.Size = new System.Drawing.Size(264, 31);
            this.buttonSøg.TabIndex = 12;
            this.buttonSøg.Text = "Søg";
            this.buttonSøg.UseVisualStyleBackColor = true;
            this.buttonSøg.Click += new System.EventHandler(this.button2Emnetyper_Click);
            // 
            // comboEmnetyper
            // 
            this.comboEmnetyper.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboEmnetyper.FormattingEnabled = true;
            this.comboEmnetyper.Location = new System.Drawing.Point(2, 22);
            this.comboEmnetyper.MaxDropDownItems = 50;
            this.comboEmnetyper.Name = "comboEmnetyper";
            this.comboEmnetyper.Size = new System.Drawing.Size(139, 21);
            this.comboEmnetyper.TabIndex = 14;
            this.comboEmnetyper.SelectedIndexChanged += new System.EventHandler(this.comboEmnetyper_SelectedIndexChanged);
            // 
            // MatriealetypeBox
            // 
            this.MatriealetypeBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MatriealetypeBox.FormattingEnabled = true;
            this.MatriealetypeBox.Location = new System.Drawing.Point(1, 64);
            this.MatriealetypeBox.MaxDropDownItems = 50;
            this.MatriealetypeBox.Name = "MatriealetypeBox";
            this.MatriealetypeBox.Size = new System.Drawing.Size(139, 21);
            this.MatriealetypeBox.TabIndex = 15;
            this.MatriealetypeBox.SelectedIndexChanged += new System.EventHandler(this.MatriealetypeBox_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(-2, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Søg i MaterialeTyper";
            // 
            // PeriodeLB
            // 
            this.PeriodeLB.AutoSize = true;
            this.PeriodeLB.Location = new System.Drawing.Point(1, 132);
            this.PeriodeLB.Name = "PeriodeLB";
            this.PeriodeLB.Size = new System.Drawing.Size(43, 13);
            this.PeriodeLB.TabIndex = 17;
            this.PeriodeLB.Text = "Periode";
            // 
            // PeriodeTPComboBox
            // 
            this.PeriodeTPComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PeriodeTPComboBox.FormattingEnabled = true;
            this.PeriodeTPComboBox.Location = new System.Drawing.Point(2, 148);
            this.PeriodeTPComboBox.MaxDropDownItems = 50;
            this.PeriodeTPComboBox.Name = "PeriodeTPComboBox";
            this.PeriodeTPComboBox.Size = new System.Drawing.Size(139, 21);
            this.PeriodeTPComboBox.TabIndex = 18;
            this.PeriodeTPComboBox.SelectedIndexChanged += new System.EventHandler(this.PeriodeTPComboBox_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.EksperimenttyperComboBox);
            this.panel1.Controls.Add(this.PeriodeTPComboBox);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.PeriodeLB);
            this.panel1.Controls.Add(this.MatriealetypeBox);
            this.panel1.Controls.Add(this.comboEmnetyper);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(12, 166);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(316, 251);
            this.panel1.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 90);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Eksperimentyper:";
            // 
            // EksperimenttyperComboBox
            // 
            this.EksperimenttyperComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.EksperimenttyperComboBox.FormattingEnabled = true;
            this.EksperimenttyperComboBox.Location = new System.Drawing.Point(1, 106);
            this.EksperimenttyperComboBox.MaxDropDownItems = 50;
            this.EksperimenttyperComboBox.Name = "EksperimenttyperComboBox";
            this.EksperimenttyperComboBox.Size = new System.Drawing.Size(139, 21);
            this.EksperimenttyperComboBox.TabIndex = 19;
            this.EksperimenttyperComboBox.SelectedIndexChanged += new System.EventHandler(this.EksperimenttyperComboBox_SelectedIndexChanged);
            // 
            // textboxSagstitel
            // 
            this.textboxSagstitel.Location = new System.Drawing.Point(12, 76);
            this.textboxSagstitel.Name = "textboxSagstitel";
            this.textboxSagstitel.Size = new System.Drawing.Size(166, 20);
            this.textboxSagstitel.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Sagstitel:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "Sag oprettet:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(132, 103);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 13);
            this.label6.TabIndex = 24;
            this.label6.Text = "Sag afsluttet:";
            // 
            // textBoxSagoprettet
            // 
            this.textBoxSagoprettet.Location = new System.Drawing.Point(17, 126);
            this.textBoxSagoprettet.Name = "textBoxSagoprettet";
            this.textBoxSagoprettet.Size = new System.Drawing.Size(64, 20);
            this.textBoxSagoprettet.TabIndex = 30;
            this.textBoxSagoprettet.TextChanged += new System.EventHandler(this.textBoxSagoprettet_TextChanged);
            // 
            // textBoxsagAfsluttet
            // 
            this.textBoxsagAfsluttet.Location = new System.Drawing.Point(135, 126);
            this.textBoxsagAfsluttet.Name = "textBoxsagAfsluttet";
            this.textBoxsagAfsluttet.Size = new System.Drawing.Size(64, 20);
            this.textBoxsagAfsluttet.TabIndex = 31;
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1317, 551);
            this.Controls.Add(this.textBoxsagAfsluttet);
            this.Controls.Add(this.textBoxSagoprettet);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textboxSagstitel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonSøg);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxFrisøgning);
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
        public System.Windows.Forms.TextBox textBoxFrisøgning;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        internal System.Windows.Forms.Button buttonSøg;
        public System.Windows.Forms.ComboBox comboEmnetyper;
        public System.Windows.Forms.ComboBox MatriealetypeBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label PeriodeLB;
        public System.Windows.Forms.ComboBox PeriodeTPComboBox;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.TextBox textboxSagstitel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Timer timer1;
        public System.Windows.Forms.TextBox textBoxSagoprettet;
        public System.Windows.Forms.TextBox textBoxsagAfsluttet;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.ComboBox EksperimenttyperComboBox;
    }
}