namespace BinF6
{
    partial class crossRateComboBox
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
            this.startButton = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.mutRateLabel = new System.Windows.Forms.Label();
            this.crossLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.mutRateComboBox = new System.Windows.Forms.ComboBox();
            this.crossRateBox = new System.Windows.Forms.ComboBox();
            this.NoElitism = new System.Windows.Forms.RadioButton();
            this.Elitism = new System.Windows.Forms.RadioButton();
            this.secBestPref = new System.Windows.Forms.RadioButton();
            this.mutPref = new System.Windows.Forms.RadioButton();
            this.popSizeBox = new System.Windows.Forms.TextBox();
            this.bestFitBox = new System.Windows.Forms.TextBox();
            this.avgFitBox = new System.Windows.Forms.TextBox();
            this.worstFitBox = new System.Windows.Forms.TextBox();
            this.intCount = new System.Windows.Forms.TextBox();
            this.geneBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.commentBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.fitnessBox = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.prefCountComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // startButton
            // 
            this.startButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startButton.Location = new System.Drawing.Point(13, 13);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(75, 23);
            this.startButton.TabIndex = 0;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // resetButton
            // 
            this.resetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetButton.Location = new System.Drawing.Point(13, 43);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(75, 23);
            this.resetButton.TabIndex = 1;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // mutRateLabel
            // 
            this.mutRateLabel.AutoSize = true;
            this.mutRateLabel.Location = new System.Drawing.Point(10, 69);
            this.mutRateLabel.Name = "mutRateLabel";
            this.mutRateLabel.Size = new System.Drawing.Size(74, 13);
            this.mutRateLabel.TabIndex = 2;
            this.mutRateLabel.Text = "Mutation Rate";
            // 
            // crossLabel
            // 
            this.crossLabel.AutoSize = true;
            this.crossLabel.Location = new System.Drawing.Point(10, 114);
            this.crossLabel.Name = "crossLabel";
            this.crossLabel.Size = new System.Drawing.Size(80, 13);
            this.crossLabel.TabIndex = 3;
            this.crossLabel.Text = "Crossover Rate";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 158);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Elitism";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 279);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Population Size";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(161, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Best Fitness: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(161, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Average Fitness: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(161, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Worst Fitness:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(161, 158);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Interaction Count:";
            // 
            // mutRateComboBox
            // 
            this.mutRateComboBox.DropDownWidth = 100;
            this.mutRateComboBox.FormattingEnabled = true;
            this.mutRateComboBox.Items.AddRange(new object[] {
            "0,01",
            "0,02",
            "0,03",
            "0,04",
            "0,05",
            "0,1",
            "0,15",
            "0,2"});
            this.mutRateComboBox.Location = new System.Drawing.Point(13, 86);
            this.mutRateComboBox.Name = "mutRateComboBox";
            this.mutRateComboBox.Size = new System.Drawing.Size(90, 21);
            this.mutRateComboBox.TabIndex = 10;
            this.mutRateComboBox.TextChanged += new System.EventHandler(this.mutRateComboBox_TextChanged);
            // 
            // crossRateBox
            // 
            this.crossRateBox.FormattingEnabled = true;
            this.crossRateBox.Items.AddRange(new object[] {
            "0,3",
            "0,5",
            "0,7",
            "0,8",
            "0,9",
            "0,95"});
            this.crossRateBox.Location = new System.Drawing.Point(12, 130);
            this.crossRateBox.Name = "crossRateBox";
            this.crossRateBox.Size = new System.Drawing.Size(90, 21);
            this.crossRateBox.TabIndex = 11;
            // 
            // NoElitism
            // 
            this.NoElitism.AutoSize = true;
            this.NoElitism.Checked = true;
            this.NoElitism.Location = new System.Drawing.Point(12, 175);
            this.NoElitism.Name = "NoElitism";
            this.NoElitism.Size = new System.Drawing.Size(71, 17);
            this.NoElitism.TabIndex = 12;
            this.NoElitism.TabStop = true;
            this.NoElitism.Text = "No Elitism";
            this.NoElitism.UseVisualStyleBackColor = true;
            // 
            // Elitism
            // 
            this.Elitism.AutoSize = true;
            this.Elitism.Location = new System.Drawing.Point(12, 199);
            this.Elitism.Name = "Elitism";
            this.Elitism.Size = new System.Drawing.Size(54, 17);
            this.Elitism.TabIndex = 13;
            this.Elitism.TabStop = true;
            this.Elitism.Text = "Elitism";
            this.Elitism.UseVisualStyleBackColor = true;
            // 
            // secBestPref
            // 
            this.secBestPref.AutoSize = true;
            this.secBestPref.Location = new System.Drawing.Point(12, 223);
            this.secBestPref.Name = "secBestPref";
            this.secBestPref.Size = new System.Drawing.Size(89, 17);
            this.secBestPref.TabIndex = 14;
            this.secBestPref.TabStop = true;
            this.secBestPref.Text = "2nd Best Pref";
            this.secBestPref.UseVisualStyleBackColor = true;
            // 
            // mutPref
            // 
            this.mutPref.AutoSize = true;
            this.mutPref.Location = new System.Drawing.Point(12, 247);
            this.mutPref.Name = "mutPref";
            this.mutPref.Size = new System.Drawing.Size(88, 17);
            this.mutPref.TabIndex = 15;
            this.mutPref.TabStop = true;
            this.mutPref.Text = "Mutation Pref";
            this.mutPref.UseVisualStyleBackColor = true;
            // 
            // popSizeBox
            // 
            this.popSizeBox.Location = new System.Drawing.Point(12, 296);
            this.popSizeBox.Name = "popSizeBox";
            this.popSizeBox.Size = new System.Drawing.Size(100, 20);
            this.popSizeBox.TabIndex = 16;
            this.popSizeBox.Text = "100";
            this.popSizeBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // bestFitBox
            // 
            this.bestFitBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bestFitBox.Location = new System.Drawing.Point(269, 23);
            this.bestFitBox.Name = "bestFitBox";
            this.bestFitBox.ReadOnly = true;
            this.bestFitBox.Size = new System.Drawing.Size(300, 20);
            this.bestFitBox.TabIndex = 17;
            this.bestFitBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // avgFitBox
            // 
            this.avgFitBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.avgFitBox.Location = new System.Drawing.Point(269, 69);
            this.avgFitBox.Name = "avgFitBox";
            this.avgFitBox.ReadOnly = true;
            this.avgFitBox.Size = new System.Drawing.Size(300, 20);
            this.avgFitBox.TabIndex = 18;
            this.avgFitBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // worstFitBox
            // 
            this.worstFitBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.worstFitBox.Location = new System.Drawing.Point(269, 114);
            this.worstFitBox.Name = "worstFitBox";
            this.worstFitBox.ReadOnly = true;
            this.worstFitBox.Size = new System.Drawing.Size(300, 20);
            this.worstFitBox.TabIndex = 19;
            this.worstFitBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // intCount
            // 
            this.intCount.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.intCount.Location = new System.Drawing.Point(269, 158);
            this.intCount.Name = "intCount";
            this.intCount.ReadOnly = true;
            this.intCount.Size = new System.Drawing.Size(300, 20);
            this.intCount.TabIndex = 20;
            this.intCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // geneBox
            // 
            this.geneBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.geneBox.Location = new System.Drawing.Point(164, 223);
            this.geneBox.Name = "geneBox";
            this.geneBox.ReadOnly = true;
            this.geneBox.Size = new System.Drawing.Size(405, 20);
            this.geneBox.TabIndex = 21;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(161, 203);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 22;
            this.label7.Text = "Best Gene";
            // 
            // commentBox
            // 
            this.commentBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.commentBox.Location = new System.Drawing.Point(164, 279);
            this.commentBox.Multiline = true;
            this.commentBox.Name = "commentBox";
            this.commentBox.ReadOnly = true;
            this.commentBox.Size = new System.Drawing.Size(400, 200);
            this.commentBox.TabIndex = 23;
            this.commentBox.Text = "Comments";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 333);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 13);
            this.label8.TabIndex = 24;
            this.label8.Text = "Expected Fitness";
            // 
            // fitnessBox
            // 
            this.fitnessBox.FormattingEnabled = true;
            this.fitnessBox.Items.AddRange(new object[] {
            "0,9",
            "0,95",
            "0,99",
            "0,995",
            "0,999"});
            this.fitnessBox.Location = new System.Drawing.Point(12, 350);
            this.fitnessBox.Name = "fitnessBox";
            this.fitnessBox.Size = new System.Drawing.Size(90, 21);
            this.fitnessBox.TabIndex = 25;
            this.fitnessBox.Text = "0,999";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 391);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 13);
            this.label9.TabIndex = 26;
            this.label9.Text = "Pref Count";
            // 
            // prefCountComboBox
            // 
            this.prefCountComboBox.AllowDrop = true;
            this.prefCountComboBox.FormattingEnabled = true;
            this.prefCountComboBox.Items.AddRange(new object[] {
            "3",
            "5",
            "8",
            "10",
            "12",
            "15",
            "20"});
            this.prefCountComboBox.Location = new System.Drawing.Point(12, 408);
            this.prefCountComboBox.Name = "prefCountComboBox";
            this.prefCountComboBox.Size = new System.Drawing.Size(90, 21);
            this.prefCountComboBox.TabIndex = 27;
            this.prefCountComboBox.Text = "5";
            // 
            // crossRateComboBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 550);
            this.Controls.Add(this.prefCountComboBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.fitnessBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.commentBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.geneBox);
            this.Controls.Add(this.intCount);
            this.Controls.Add(this.worstFitBox);
            this.Controls.Add(this.avgFitBox);
            this.Controls.Add(this.bestFitBox);
            this.Controls.Add(this.popSizeBox);
            this.Controls.Add(this.mutPref);
            this.Controls.Add(this.secBestPref);
            this.Controls.Add(this.Elitism);
            this.Controls.Add(this.NoElitism);
            this.Controls.Add(this.crossRateBox);
            this.Controls.Add(this.mutRateComboBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.crossLabel);
            this.Controls.Add(this.mutRateLabel);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.startButton);
            this.Name = "crossRateComboBox";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Label mutRateLabel;
        private System.Windows.Forms.Label crossLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox mutRateComboBox;
        private System.Windows.Forms.ComboBox crossRateBox;
        private System.Windows.Forms.RadioButton NoElitism;
        private System.Windows.Forms.RadioButton Elitism;
        private System.Windows.Forms.RadioButton secBestPref;
        private System.Windows.Forms.RadioButton mutPref;
        private System.Windows.Forms.TextBox popSizeBox;
        private System.Windows.Forms.TextBox bestFitBox;
        private System.Windows.Forms.TextBox avgFitBox;
        private System.Windows.Forms.TextBox worstFitBox;
        private System.Windows.Forms.TextBox intCount;
        private System.Windows.Forms.TextBox geneBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox commentBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox fitnessBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox prefCountComboBox;
    }
}

