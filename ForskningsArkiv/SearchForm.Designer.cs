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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox1Søg = new System.Windows.Forms.TextBox();
            this.buttonSøgFri = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button2Emnetyper = new System.Windows.Forms.Button();
            this.textBox2Emnetyper = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.MatriealetypeBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.materialfriesøg = new System.Windows.Forms.TextBox();
            this.søgMaterialetyper = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            // 
            // buttonSøgFri
            // 
            this.buttonSøgFri.BackColor = System.Drawing.SystemColors.Control;
            this.buttonSøgFri.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonSøgFri.Location = new System.Drawing.Point(195, 37);
            this.buttonSøgFri.Name = "buttonSøgFri";
            this.buttonSøgFri.Size = new System.Drawing.Size(74, 20);
            this.buttonSøgFri.TabIndex = 8;
            this.buttonSøgFri.Text = "Søg";
            this.buttonSøgFri.UseVisualStyleBackColor = false;
            this.buttonSøgFri.Click += new System.EventHandler(this.buttonSøgFri_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Søg i Sagsoplysninger";
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
            this.label2.Location = new System.Drawing.Point(9, 380);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Søg i Emnetyper";
            // 
            // button2Emnetyper
            // 
            this.button2Emnetyper.Location = new System.Drawing.Point(160, 411);
            this.button2Emnetyper.Name = "button2Emnetyper";
            this.button2Emnetyper.Size = new System.Drawing.Size(96, 23);
            this.button2Emnetyper.TabIndex = 12;
            this.button2Emnetyper.Text = "Søg";
            this.button2Emnetyper.UseVisualStyleBackColor = true;
            this.button2Emnetyper.Click += new System.EventHandler(this.button2Emnetyper_Click);
            // 
            // textBox2Emnetyper
            // 
            this.textBox2Emnetyper.Location = new System.Drawing.Point(9, 426);
            this.textBox2Emnetyper.Name = "textBox2Emnetyper";
            this.textBox2Emnetyper.Size = new System.Drawing.Size(142, 20);
            this.textBox2Emnetyper.TabIndex = 13;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(9, 399);
            this.comboBox1.MaxDropDownItems = 50;
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(142, 21);
            this.comboBox1.TabIndex = 14;
            // 
            // MatriealetypeBox
            // 
            this.MatriealetypeBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MatriealetypeBox.FormattingEnabled = true;
            this.MatriealetypeBox.Location = new System.Drawing.Point(12, 311);
            this.MatriealetypeBox.MaxDropDownItems = 50;
            this.MatriealetypeBox.Name = "MatriealetypeBox";
            this.MatriealetypeBox.Size = new System.Drawing.Size(142, 21);
            this.MatriealetypeBox.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 295);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Søg i MaterialeTyper";
            // 
            // materialfriesøg
            // 
            this.materialfriesøg.Location = new System.Drawing.Point(12, 338);
            this.materialfriesøg.Name = "materialfriesøg";
            this.materialfriesøg.Size = new System.Drawing.Size(142, 20);
            this.materialfriesøg.TabIndex = 17;
            // 
            // søgMaterialetyper
            // 
            this.søgMaterialetyper.Location = new System.Drawing.Point(160, 322);
            this.søgMaterialetyper.Name = "søgMaterialetyper";
            this.søgMaterialetyper.Size = new System.Drawing.Size(96, 23);
            this.søgMaterialetyper.TabIndex = 18;
            this.søgMaterialetyper.Text = "Søg";
            this.søgMaterialetyper.UseVisualStyleBackColor = true;
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1317, 551);
            this.Controls.Add(this.søgMaterialetyper);
            this.Controls.Add(this.materialfriesøg);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.MatriealetypeBox);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox2Emnetyper);
            this.Controls.Add(this.button2Emnetyper);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonSøgFri);
            this.Controls.Add(this.textBox1Søg);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Name = "SearchForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SearchForm";
            this.TransparencyKey = System.Drawing.Color.LightGray;
            this.Load += new System.EventHandler(this.SearchForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.DataGridView dataGridView1;
        public System.Windows.Forms.TextBox textBox1Søg;
        public System.Windows.Forms.Button buttonSøgFri;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        internal System.Windows.Forms.Button button2Emnetyper;
        internal System.Windows.Forms.TextBox textBox2Emnetyper;
        public System.Windows.Forms.ComboBox comboBox1;
        public System.Windows.Forms.ComboBox MatriealetypeBox;
        private System.Windows.Forms.Label label3;
        internal System.Windows.Forms.TextBox materialfriesøg;
        internal System.Windows.Forms.Button søgMaterialetyper;
    }
}