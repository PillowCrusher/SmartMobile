namespace SMProofOfConcept
{
    partial class AddFeedbackForm
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
            this.lbl_naam = new System.Windows.Forms.Label();
            this.GroupBox = new System.Windows.Forms.GroupBox();
            this.rbtn_John = new System.Windows.Forms.RadioButton();
            this.rbtn_Mark = new System.Windows.Forms.RadioButton();
            this.rbtn_Dennis = new System.Windows.Forms.RadioButton();
            this.rbtn_Cas = new System.Windows.Forms.RadioButton();
            this.rbtn_Jeroen = new System.Windows.Forms.RadioButton();
            this.rbtn_Ricky = new System.Windows.Forms.RadioButton();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.radioButton7 = new System.Windows.Forms.RadioButton();
            this.radioButton8 = new System.Windows.Forms.RadioButton();
            this.btn_feedback = new System.Windows.Forms.Button();
            this.GroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_naam
            // 
            this.lbl_naam.AutoSize = true;
            this.lbl_naam.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lbl_naam.Location = new System.Drawing.Point(12, 9);
            this.lbl_naam.Name = "lbl_naam";
            this.lbl_naam.Size = new System.Drawing.Size(269, 39);
            this.lbl_naam.TabIndex = 0;
            this.lbl_naam.Text = "Feedback geven";
            // 
            // GroupBox
            // 
            this.GroupBox.Controls.Add(this.rbtn_John);
            this.GroupBox.Controls.Add(this.rbtn_Mark);
            this.GroupBox.Controls.Add(this.rbtn_Dennis);
            this.GroupBox.Controls.Add(this.rbtn_Cas);
            this.GroupBox.Controls.Add(this.rbtn_Jeroen);
            this.GroupBox.Controls.Add(this.rbtn_Ricky);
            this.GroupBox.Location = new System.Drawing.Point(19, 74);
            this.GroupBox.Name = "GroupBox";
            this.GroupBox.Size = new System.Drawing.Size(235, 197);
            this.GroupBox.TabIndex = 1;
            this.GroupBox.TabStop = false;
            this.GroupBox.Text = "Selecteer groepsgenoot";
            // 
            // rbtn_John
            // 
            this.rbtn_John.AutoSize = true;
            this.rbtn_John.Location = new System.Drawing.Point(6, 166);
            this.rbtn_John.Name = "rbtn_John";
            this.rbtn_John.Size = new System.Drawing.Size(120, 21);
            this.rbtn_John.TabIndex = 5;
            this.rbtn_John.TabStop = true;
            this.rbtn_John.Text = "John Meerten ";
            this.rbtn_John.UseVisualStyleBackColor = true;
            // 
            // rbtn_Mark
            // 
            this.rbtn_Mark.AutoSize = true;
            this.rbtn_Mark.Location = new System.Drawing.Point(6, 139);
            this.rbtn_Mark.Name = "rbtn_Mark";
            this.rbtn_Mark.Size = new System.Drawing.Size(149, 21);
            this.rbtn_Mark.TabIndex = 4;
            this.rbtn_Mark.TabStop = true;
            this.rbtn_Mark.Text = "Mark van den Hurk";
            this.rbtn_Mark.UseVisualStyleBackColor = true;
            // 
            // rbtn_Dennis
            // 
            this.rbtn_Dennis.AutoSize = true;
            this.rbtn_Dennis.Location = new System.Drawing.Point(6, 112);
            this.rbtn_Dennis.Name = "rbtn_Dennis";
            this.rbtn_Dennis.Size = new System.Drawing.Size(132, 21);
            this.rbtn_Dennis.TabIndex = 3;
            this.rbtn_Dennis.TabStop = true;
            this.rbtn_Dennis.Text = "Dennis v\'Nainde";
            this.rbtn_Dennis.UseVisualStyleBackColor = true;
            this.rbtn_Dennis.CheckedChanged += new System.EventHandler(this.rbtn__CheckedChanged);
            // 
            // rbtn_Cas
            // 
            this.rbtn_Cas.AutoSize = true;
            this.rbtn_Cas.Location = new System.Drawing.Point(6, 85);
            this.rbtn_Cas.Name = "rbtn_Cas";
            this.rbtn_Cas.Size = new System.Drawing.Size(99, 21);
            this.rbtn_Cas.TabIndex = 2;
            this.rbtn_Cas.TabStop = true;
            this.rbtn_Cas.Text = "Cas Hutten";
            this.rbtn_Cas.UseVisualStyleBackColor = true;
            // 
            // rbtn_Jeroen
            // 
            this.rbtn_Jeroen.AutoSize = true;
            this.rbtn_Jeroen.Location = new System.Drawing.Point(6, 58);
            this.rbtn_Jeroen.Name = "rbtn_Jeroen";
            this.rbtn_Jeroen.Size = new System.Drawing.Size(118, 21);
            this.rbtn_Jeroen.TabIndex = 1;
            this.rbtn_Jeroen.TabStop = true;
            this.rbtn_Jeroen.Text = "Jeroen Peters";
            this.rbtn_Jeroen.UseVisualStyleBackColor = true;
            // 
            // rbtn_Ricky
            // 
            this.rbtn_Ricky.AutoSize = true;
            this.rbtn_Ricky.Location = new System.Drawing.Point(6, 31);
            this.rbtn_Ricky.Name = "rbtn_Ricky";
            this.rbtn_Ricky.Size = new System.Drawing.Size(119, 21);
            this.rbtn_Ricky.TabIndex = 0;
            this.rbtn_Ricky.TabStop = true;
            this.rbtn_Ricky.Text = "Ricky Rekkers";
            this.rbtn_Ricky.UseVisualStyleBackColor = true;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.DecimalPlaces = 1;
            this.numericUpDown1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.numericUpDown1.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDown1.Location = new System.Drawing.Point(339, 265);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(264, 45);
            this.numericUpDown1.TabIndex = 2;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton4);
            this.groupBox1.Controls.Add(this.radioButton5);
            this.groupBox1.Controls.Add(this.radioButton6);
            this.groupBox1.Controls.Add(this.radioButton7);
            this.groupBox1.Controls.Add(this.radioButton8);
            this.groupBox1.Location = new System.Drawing.Point(339, 74);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(264, 170);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kies categorie";
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(6, 139);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(99, 21);
            this.radioButton4.TabIndex = 4;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Onderzoek";
            this.radioButton4.UseVisualStyleBackColor = true;
            this.radioButton4.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(5, 112);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(100, 21);
            this.radioButton5.TabIndex = 3;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "Concepting";
            this.radioButton5.UseVisualStyleBackColor = true;
            this.radioButton5.CheckedChanged += new System.EventHandler(this.radioButton5_CheckedChanged);
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Location = new System.Drawing.Point(6, 85);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(123, 21);
            this.radioButton6.TabIndex = 2;
            this.radioButton6.TabStop = true;
            this.radioButton6.Text = "Programmeren";
            this.radioButton6.UseVisualStyleBackColor = true;
            this.radioButton6.CheckedChanged += new System.EventHandler(this.radioButton6_CheckedChanged);
            // 
            // radioButton7
            // 
            this.radioButton7.AutoSize = true;
            this.radioButton7.Location = new System.Drawing.Point(6, 58);
            this.radioButton7.Name = "radioButton7";
            this.radioButton7.Size = new System.Drawing.Size(121, 21);
            this.radioButton7.TabIndex = 1;
            this.radioButton7.TabStop = true;
            this.radioButton7.Text = "Samenwerking";
            this.radioButton7.UseVisualStyleBackColor = true;
            this.radioButton7.CheckedChanged += new System.EventHandler(this.radioButton7_CheckedChanged);
            // 
            // radioButton8
            // 
            this.radioButton8.AutoSize = true;
            this.radioButton8.Location = new System.Drawing.Point(6, 31);
            this.radioButton8.Name = "radioButton8";
            this.radioButton8.Size = new System.Drawing.Size(59, 21);
            this.radioButton8.TabIndex = 0;
            this.radioButton8.TabStop = true;
            this.radioButton8.Text = "Inzet";
            this.radioButton8.UseVisualStyleBackColor = true;
            this.radioButton8.CheckedChanged += new System.EventHandler(this.radioButton8_CheckedChanged);
            // 
            // btn_feedback
            // 
            this.btn_feedback.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.btn_feedback.Location = new System.Drawing.Point(169, 365);
            this.btn_feedback.Name = "btn_feedback";
            this.btn_feedback.Size = new System.Drawing.Size(235, 53);
            this.btn_feedback.TabIndex = 4;
            this.btn_feedback.Text = "Verstuur";
            this.btn_feedback.UseVisualStyleBackColor = true;
            this.btn_feedback.Click += new System.EventHandler(this.btn_feedback_Click);
            // 
            // AddFeedbackForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 449);
            this.Controls.Add(this.btn_feedback);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.GroupBox);
            this.Controls.Add(this.lbl_naam);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AddFeedbackForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddFeedbackForm";
            this.GroupBox.ResumeLayout(false);
            this.GroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_naam;
        private System.Windows.Forms.GroupBox GroupBox;
        private System.Windows.Forms.RadioButton rbtn_John;
        private System.Windows.Forms.RadioButton rbtn_Mark;
        private System.Windows.Forms.RadioButton rbtn_Dennis;
        private System.Windows.Forms.RadioButton rbtn_Cas;
        private System.Windows.Forms.RadioButton rbtn_Jeroen;
        private System.Windows.Forms.RadioButton rbtn_Ricky;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton6;
        private System.Windows.Forms.RadioButton radioButton7;
        private System.Windows.Forms.RadioButton radioButton8;
        private System.Windows.Forms.Button btn_feedback;
    }
}