namespace ReadingMNISTDatabase
{
    partial class Form1
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
			this.Read = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.btn_Show = new System.Windows.Forms.Button();
			this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
			this.label1 = new System.Windows.Forms.Label();
			this.chckBx_Threshold = new System.Windows.Forms.CheckBox();
			this.rdoBtn_TrainingSet = new System.Windows.Forms.RadioButton();
			this.rdoBtn_TestingSet = new System.Windows.Forms.RadioButton();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.Zero = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.One = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Two = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Three = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Four = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Five = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Six = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Seven = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Eight = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Nune = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.AccuracyLabel = new System.Windows.Forms.TextBox();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// Read
			// 
			this.Read.Location = new System.Drawing.Point(84, 27);
			this.Read.Margin = new System.Windows.Forms.Padding(2);
			this.Read.Name = "Read";
			this.Read.Size = new System.Drawing.Size(122, 30);
			this.Read.TabIndex = 0;
			this.Read.Text = "Read Database";
			this.Read.UseVisualStyleBackColor = true;
			this.Read.Click += new System.EventHandler(this.Read_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.Color.White;
			this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pictureBox1.Location = new System.Drawing.Point(178, 87);
			this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(40, 31);
			this.pictureBox1.TabIndex = 1;
			this.pictureBox1.TabStop = false;
			// 
			// btn_Show
			// 
			this.btn_Show.Location = new System.Drawing.Point(178, 145);
			this.btn_Show.Margin = new System.Windows.Forms.Padding(2);
			this.btn_Show.Name = "btn_Show";
			this.btn_Show.Size = new System.Drawing.Size(86, 37);
			this.btn_Show.TabIndex = 2;
			this.btn_Show.Text = "Show";
			this.btn_Show.UseVisualStyleBackColor = true;
			this.btn_Show.Click += new System.EventHandler(this.btn_Show_Click);
			// 
			// numericUpDown1
			// 
			this.numericUpDown1.Location = new System.Drawing.Point(37, 89);
			this.numericUpDown1.Margin = new System.Windows.Forms.Padding(2);
			this.numericUpDown1.Maximum = new decimal(new int[] {
            60000,
            0,
            0,
            0});
			this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.numericUpDown1.Name = "numericUpDown1";
			this.numericUpDown1.Size = new System.Drawing.Size(74, 20);
			this.numericUpDown1.TabIndex = 3;
			this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(236, 93);
			this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(0, 13);
			this.label1.TabIndex = 4;
			// 
			// chckBx_Threshold
			// 
			this.chckBx_Threshold.AutoSize = true;
			this.chckBx_Threshold.Location = new System.Drawing.Point(37, 169);
			this.chckBx_Threshold.Margin = new System.Windows.Forms.Padding(2);
			this.chckBx_Threshold.Name = "chckBx_Threshold";
			this.chckBx_Threshold.Size = new System.Drawing.Size(94, 17);
			this.chckBx_Threshold.TabIndex = 5;
			this.chckBx_Threshold.Text = "With threshold";
			this.chckBx_Threshold.UseVisualStyleBackColor = true;
			// 
			// rdoBtn_TrainingSet
			// 
			this.rdoBtn_TrainingSet.AutoSize = true;
			this.rdoBtn_TrainingSet.Checked = true;
			this.rdoBtn_TrainingSet.Location = new System.Drawing.Point(37, 119);
			this.rdoBtn_TrainingSet.Margin = new System.Windows.Forms.Padding(2);
			this.rdoBtn_TrainingSet.Name = "rdoBtn_TrainingSet";
			this.rdoBtn_TrainingSet.Size = new System.Drawing.Size(79, 17);
			this.rdoBtn_TrainingSet.TabIndex = 6;
			this.rdoBtn_TrainingSet.TabStop = true;
			this.rdoBtn_TrainingSet.Text = "TrainingSet";
			this.rdoBtn_TrainingSet.UseVisualStyleBackColor = true;
			// 
			// rdoBtn_TestingSet
			// 
			this.rdoBtn_TestingSet.AutoSize = true;
			this.rdoBtn_TestingSet.Location = new System.Drawing.Point(38, 145);
			this.rdoBtn_TestingSet.Margin = new System.Windows.Forms.Padding(2);
			this.rdoBtn_TestingSet.Name = "rdoBtn_TestingSet";
			this.rdoBtn_TestingSet.Size = new System.Drawing.Size(76, 17);
			this.rdoBtn_TestingSet.TabIndex = 7;
			this.rdoBtn_TestingSet.Text = "TestingSet";
			this.rdoBtn_TestingSet.UseVisualStyleBackColor = true;
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Zero,
            this.One,
            this.Two,
            this.Three,
            this.Four,
            this.Five,
            this.Six,
            this.Seven,
            this.Eight,
            this.Nune});
			this.dataGridView1.Location = new System.Drawing.Point(279, 48);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.Size = new System.Drawing.Size(543, 243);
			this.dataGridView1.TabIndex = 8;
			// 
			// Zero
			// 
			this.Zero.HeaderText = "Zero";
			this.Zero.MaxInputLength = 5;
			this.Zero.Name = "Zero";
			this.Zero.ReadOnly = true;
			this.Zero.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.Zero.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.Zero.Width = 50;
			// 
			// One
			// 
			this.One.HeaderText = "One";
			this.One.MaxInputLength = 5;
			this.One.Name = "One";
			this.One.ReadOnly = true;
			this.One.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.One.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.One.Width = 50;
			// 
			// Two
			// 
			this.Two.HeaderText = "Two";
			this.Two.MaxInputLength = 5;
			this.Two.Name = "Two";
			this.Two.ReadOnly = true;
			this.Two.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.Two.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.Two.Width = 50;
			// 
			// Three
			// 
			this.Three.HeaderText = "Three";
			this.Three.MaxInputLength = 5;
			this.Three.Name = "Three";
			this.Three.ReadOnly = true;
			this.Three.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.Three.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.Three.Width = 50;
			// 
			// Four
			// 
			this.Four.HeaderText = "Four";
			this.Four.MaxInputLength = 5;
			this.Four.Name = "Four";
			this.Four.ReadOnly = true;
			this.Four.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.Four.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.Four.Width = 50;
			// 
			// Five
			// 
			this.Five.HeaderText = "Five";
			this.Five.MaxInputLength = 5;
			this.Five.Name = "Five";
			this.Five.ReadOnly = true;
			this.Five.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.Five.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.Five.Width = 50;
			// 
			// Six
			// 
			this.Six.HeaderText = "Six";
			this.Six.MaxInputLength = 5;
			this.Six.Name = "Six";
			this.Six.ReadOnly = true;
			this.Six.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.Six.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.Six.Width = 50;
			// 
			// Seven
			// 
			this.Seven.HeaderText = "Seven";
			this.Seven.MaxInputLength = 5;
			this.Seven.Name = "Seven";
			this.Seven.ReadOnly = true;
			this.Seven.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.Seven.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.Seven.Width = 50;
			// 
			// Eight
			// 
			this.Eight.HeaderText = "Eight";
			this.Eight.MaxInputLength = 5;
			this.Eight.Name = "Eight";
			this.Eight.ReadOnly = true;
			this.Eight.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.Eight.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.Eight.Width = 50;
			// 
			// Nune
			// 
			this.Nune.HeaderText = "Nine";
			this.Nune.MaxInputLength = 5;
			this.Nune.Name = "Nune";
			this.Nune.ReadOnly = true;
			this.Nune.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.Nune.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.Nune.Width = 50;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(283, 12);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(83, 13);
			this.label2.TabIndex = 9;
			this.label2.Text = "Confution Matrix";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(832, 51);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(52, 13);
			this.label3.TabIndex = 10;
			this.label3.Text = "Accuarcy";
			// 
			// AccuracyLabel
			// 
			this.AccuracyLabel.Location = new System.Drawing.Point(893, 48);
			this.AccuracyLabel.Name = "AccuracyLabel";
			this.AccuracyLabel.Size = new System.Drawing.Size(72, 20);
			this.AccuracyLabel.TabIndex = 11;
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(189, 243);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(22, 20);
			this.textBox1.TabIndex = 12;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(55, 246);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(76, 13);
			this.label4.TabIndex = 13;
			this.label4.Text = "ClassifiedClass";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(982, 303);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.AccuracyLabel);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.rdoBtn_TestingSet);
			this.Controls.Add(this.rdoBtn_TrainingSet);
			this.Controls.Add(this.chckBx_Threshold);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.numericUpDown1);
			this.Controls.Add(this.btn_Show);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.Read);
			this.Margin = new System.Windows.Forms.Padding(2);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Read;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_Show;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chckBx_Threshold;
        private System.Windows.Forms.RadioButton rdoBtn_TrainingSet;
        private System.Windows.Forms.RadioButton rdoBtn_TestingSet;
								private System.Windows.Forms.DataGridView dataGridView1;
								private System.Windows.Forms.DataGridViewTextBoxColumn Zero;
								private System.Windows.Forms.DataGridViewTextBoxColumn One;
								private System.Windows.Forms.DataGridViewTextBoxColumn Two;
								private System.Windows.Forms.DataGridViewTextBoxColumn Three;
								private System.Windows.Forms.DataGridViewTextBoxColumn Four;
								private System.Windows.Forms.DataGridViewTextBoxColumn Five;
								private System.Windows.Forms.DataGridViewTextBoxColumn Six;
								private System.Windows.Forms.DataGridViewTextBoxColumn Seven;
								private System.Windows.Forms.DataGridViewTextBoxColumn Eight;
								private System.Windows.Forms.DataGridViewTextBoxColumn Nune;
								private System.Windows.Forms.Label label2;
								private System.Windows.Forms.Label label3;
								private System.Windows.Forms.TextBox AccuracyLabel;
								private System.Windows.Forms.TextBox textBox1;
								private System.Windows.Forms.Label label4;
    }
}

