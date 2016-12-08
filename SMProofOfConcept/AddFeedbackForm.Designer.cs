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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nuc_Onderzoek = new System.Windows.Forms.NumericUpDown();
            this.nud_Concepting = new System.Windows.Forms.NumericUpDown();
            this.nud_Programmeren = new System.Windows.Forms.NumericUpDown();
            this.nud_Samenwerking = new System.Windows.Forms.NumericUpDown();
            this.nud_Inzet = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_feedback = new System.Windows.Forms.Button();
            this.GroupBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nuc_Onderzoek)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Concepting)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Programmeren)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Samenwerking)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Inzet)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_naam
            // 
            this.lbl_naam.AutoSize = true;
            this.lbl_naam.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lbl_naam.Location = new System.Drawing.Point(9, 7);
            this.lbl_naam.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_naam.Name = "lbl_naam";
            this.lbl_naam.Size = new System.Drawing.Size(215, 31);
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
            this.GroupBox.Location = new System.Drawing.Point(14, 60);
            this.GroupBox.Margin = new System.Windows.Forms.Padding(2);
            this.GroupBox.Name = "GroupBox";
            this.GroupBox.Padding = new System.Windows.Forms.Padding(2);
            this.GroupBox.Size = new System.Drawing.Size(176, 160);
            this.GroupBox.TabIndex = 1;
            this.GroupBox.TabStop = false;
            this.GroupBox.Text = "Selecteer groepsgenoot";
            // 
            // rbtn_John
            // 
            this.rbtn_John.AutoSize = true;
            this.rbtn_John.Location = new System.Drawing.Point(4, 135);
            this.rbtn_John.Margin = new System.Windows.Forms.Padding(2);
            this.rbtn_John.Name = "rbtn_John";
            this.rbtn_John.Size = new System.Drawing.Size(93, 17);
            this.rbtn_John.TabIndex = 5;
            this.rbtn_John.TabStop = true;
            this.rbtn_John.Text = "John Meerten ";
            this.rbtn_John.UseVisualStyleBackColor = true;
            this.rbtn_John.CheckedChanged += new System.EventHandler(this.rbtn_John_CheckedChanged);
            // 
            // rbtn_Mark
            // 
            this.rbtn_Mark.AutoSize = true;
            this.rbtn_Mark.Location = new System.Drawing.Point(4, 113);
            this.rbtn_Mark.Margin = new System.Windows.Forms.Padding(2);
            this.rbtn_Mark.Name = "rbtn_Mark";
            this.rbtn_Mark.Size = new System.Drawing.Size(117, 17);
            this.rbtn_Mark.TabIndex = 4;
            this.rbtn_Mark.TabStop = true;
            this.rbtn_Mark.Text = "Mark van den Hurk";
            this.rbtn_Mark.UseVisualStyleBackColor = true;
            this.rbtn_Mark.CheckedChanged += new System.EventHandler(this.rbtn_Mark_CheckedChanged);
            // 
            // rbtn_Dennis
            // 
            this.rbtn_Dennis.AutoSize = true;
            this.rbtn_Dennis.Location = new System.Drawing.Point(4, 91);
            this.rbtn_Dennis.Margin = new System.Windows.Forms.Padding(2);
            this.rbtn_Dennis.Name = "rbtn_Dennis";
            this.rbtn_Dennis.Size = new System.Drawing.Size(103, 17);
            this.rbtn_Dennis.TabIndex = 3;
            this.rbtn_Dennis.TabStop = true;
            this.rbtn_Dennis.Text = "Dennis v\'Nainde";
            this.rbtn_Dennis.UseVisualStyleBackColor = true;
            this.rbtn_Dennis.CheckedChanged += new System.EventHandler(this.rbtn_Dennis_CheckedChanged);
            // 
            // rbtn_Cas
            // 
            this.rbtn_Cas.AutoSize = true;
            this.rbtn_Cas.Location = new System.Drawing.Point(4, 69);
            this.rbtn_Cas.Margin = new System.Windows.Forms.Padding(2);
            this.rbtn_Cas.Name = "rbtn_Cas";
            this.rbtn_Cas.Size = new System.Drawing.Size(78, 17);
            this.rbtn_Cas.TabIndex = 2;
            this.rbtn_Cas.TabStop = true;
            this.rbtn_Cas.Text = "Cas Hutten";
            this.rbtn_Cas.UseVisualStyleBackColor = true;
            this.rbtn_Cas.CheckedChanged += new System.EventHandler(this.rbtn_Cas_CheckedChanged);
            // 
            // rbtn_Jeroen
            // 
            this.rbtn_Jeroen.AutoSize = true;
            this.rbtn_Jeroen.Location = new System.Drawing.Point(4, 47);
            this.rbtn_Jeroen.Margin = new System.Windows.Forms.Padding(2);
            this.rbtn_Jeroen.Name = "rbtn_Jeroen";
            this.rbtn_Jeroen.Size = new System.Drawing.Size(90, 17);
            this.rbtn_Jeroen.TabIndex = 1;
            this.rbtn_Jeroen.TabStop = true;
            this.rbtn_Jeroen.Text = "Jeroen Peters";
            this.rbtn_Jeroen.UseVisualStyleBackColor = true;
            this.rbtn_Jeroen.CheckedChanged += new System.EventHandler(this.rbtn_Jeroen_CheckedChanged);
            // 
            // rbtn_Ricky
            // 
            this.rbtn_Ricky.AutoSize = true;
            this.rbtn_Ricky.Location = new System.Drawing.Point(4, 25);
            this.rbtn_Ricky.Margin = new System.Windows.Forms.Padding(2);
            this.rbtn_Ricky.Name = "rbtn_Ricky";
            this.rbtn_Ricky.Size = new System.Drawing.Size(95, 17);
            this.rbtn_Ricky.TabIndex = 0;
            this.rbtn_Ricky.TabStop = true;
            this.rbtn_Ricky.Text = "Ricky Rekkers";
            this.rbtn_Ricky.UseVisualStyleBackColor = true;
            this.rbtn_Ricky.CheckedChanged += new System.EventHandler(this.rbtn_Ricky_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nuc_Onderzoek);
            this.groupBox1.Controls.Add(this.nud_Concepting);
            this.groupBox1.Controls.Add(this.nud_Programmeren);
            this.groupBox1.Controls.Add(this.nud_Samenwerking);
            this.groupBox1.Controls.Add(this.nud_Inzet);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(265, 60);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(198, 152);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kies categorie";
            // 
            // nuc_Onderzoek
            // 
            this.nuc_Onderzoek.DecimalPlaces = 1;
            this.nuc_Onderzoek.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nuc_Onderzoek.Location = new System.Drawing.Point(102, 121);
            this.nuc_Onderzoek.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nuc_Onderzoek.Name = "nuc_Onderzoek";
            this.nuc_Onderzoek.Size = new System.Drawing.Size(91, 20);
            this.nuc_Onderzoek.TabIndex = 9;
            this.nuc_Onderzoek.ValueChanged += new System.EventHandler(this.nuc_Onderzoek_ValueChanged);
            // 
            // nud_Concepting
            // 
            this.nud_Concepting.DecimalPlaces = 1;
            this.nud_Concepting.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nud_Concepting.Location = new System.Drawing.Point(102, 95);
            this.nud_Concepting.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nud_Concepting.Name = "nud_Concepting";
            this.nud_Concepting.Size = new System.Drawing.Size(91, 20);
            this.nud_Concepting.TabIndex = 8;
            this.nud_Concepting.ValueChanged += new System.EventHandler(this.nud_Concepting_ValueChanged);
            // 
            // nud_Programmeren
            // 
            this.nud_Programmeren.DecimalPlaces = 1;
            this.nud_Programmeren.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nud_Programmeren.Location = new System.Drawing.Point(102, 69);
            this.nud_Programmeren.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nud_Programmeren.Name = "nud_Programmeren";
            this.nud_Programmeren.Size = new System.Drawing.Size(91, 20);
            this.nud_Programmeren.TabIndex = 7;
            this.nud_Programmeren.ValueChanged += new System.EventHandler(this.nud_Programmeren_ValueChanged);
            // 
            // nud_Samenwerking
            // 
            this.nud_Samenwerking.DecimalPlaces = 1;
            this.nud_Samenwerking.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nud_Samenwerking.Location = new System.Drawing.Point(102, 41);
            this.nud_Samenwerking.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nud_Samenwerking.Name = "nud_Samenwerking";
            this.nud_Samenwerking.Size = new System.Drawing.Size(91, 20);
            this.nud_Samenwerking.TabIndex = 6;
            this.nud_Samenwerking.ValueChanged += new System.EventHandler(this.nud_Samenwerking_ValueChanged);
            // 
            // nud_Inzet
            // 
            this.nud_Inzet.DecimalPlaces = 1;
            this.nud_Inzet.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nud_Inzet.Location = new System.Drawing.Point(102, 15);
            this.nud_Inzet.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nud_Inzet.Name = "nud_Inzet";
            this.nud_Inzet.Size = new System.Drawing.Size(91, 20);
            this.nud_Inzet.TabIndex = 5;
            this.nud_Inzet.ValueChanged += new System.EventHandler(this.nud_Inzet_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Onderzoek";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Concepting";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Programmeren";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Samenwerking";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Inzet";
            // 
            // btn_feedback
            // 
            this.btn_feedback.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.btn_feedback.Location = new System.Drawing.Point(127, 297);
            this.btn_feedback.Margin = new System.Windows.Forms.Padding(2);
            this.btn_feedback.Name = "btn_feedback";
            this.btn_feedback.Size = new System.Drawing.Size(176, 43);
            this.btn_feedback.TabIndex = 4;
            this.btn_feedback.Text = "Verstuur";
            this.btn_feedback.UseVisualStyleBackColor = true;
            this.btn_feedback.Click += new System.EventHandler(this.btn_feedback_Click);
            // 
            // AddFeedbackForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 365);
            this.Controls.Add(this.btn_feedback);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.GroupBox);
            this.Controls.Add(this.lbl_naam);
            this.Name = "AddFeedbackForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddFeedbackForm";
            this.GroupBox.ResumeLayout(false);
            this.GroupBox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nuc_Onderzoek)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Concepting)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Programmeren)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Samenwerking)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Inzet)).EndInit();
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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_feedback;
        private System.Windows.Forms.NumericUpDown nuc_Onderzoek;
        private System.Windows.Forms.NumericUpDown nud_Concepting;
        private System.Windows.Forms.NumericUpDown nud_Programmeren;
        private System.Windows.Forms.NumericUpDown nud_Samenwerking;
        private System.Windows.Forms.NumericUpDown nud_Inzet;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}