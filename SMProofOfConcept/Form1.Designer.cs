namespace SMProofOfConcept
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
            this.label1 = new System.Windows.Forms.Label();
            this.tb_Name = new System.Windows.Forms.TextBox();
            this.lb_Average = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lb_Inzet = new System.Windows.Forms.Label();
            this.lb_Samenwerking = new System.Windows.Forms.Label();
            this.lb_Programmeren = new System.Windows.Forms.Label();
            this.lb_Concepting = new System.Windows.Forms.Label();
            this.lb_Onderzoek = new System.Windows.Forms.Label();
            this.btn_AddFeedback = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // tb_Name
            // 
            this.tb_Name.Location = new System.Drawing.Point(56, 14);
            this.tb_Name.Name = "tb_Name";
            this.tb_Name.Size = new System.Drawing.Size(100, 20);
            this.tb_Name.TabIndex = 1;
            this.tb_Name.TextChanged += new System.EventHandler(this.tb_Name_TextChanged);
            // 
            // lb_Average
            // 
            this.lb_Average.AutoSize = true;
            this.lb_Average.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Average.Location = new System.Drawing.Point(93, 58);
            this.lb_Average.Name = "lb_Average";
            this.lb_Average.Size = new System.Drawing.Size(126, 76);
            this.lb_Average.TabIndex = 3;
            this.lb_Average.Text = "0,0";
            this.lb_Average.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 31);
            this.label2.TabIndex = 4;
            this.label2.Text = "Inzet";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(193, 31);
            this.label3.TabIndex = 5;
            this.label3.Text = "Samenwerking";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 240);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(193, 31);
            this.label4.TabIndex = 6;
            this.label4.Text = "Programmeren";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(15, 285);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(152, 31);
            this.label5.TabIndex = 7;
            this.label5.Text = "Concepting";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(15, 330);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(147, 31);
            this.label6.TabIndex = 8;
            this.label6.Text = "Onderzoek";
            // 
            // lb_Inzet
            // 
            this.lb_Inzet.AutoSize = true;
            this.lb_Inzet.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Inzet.Location = new System.Drawing.Point(241, 150);
            this.lb_Inzet.Name = "lb_Inzet";
            this.lb_Inzet.Size = new System.Drawing.Size(52, 31);
            this.lb_Inzet.TabIndex = 9;
            this.lb_Inzet.Text = "0,0";
            // 
            // lb_Samenwerking
            // 
            this.lb_Samenwerking.AutoSize = true;
            this.lb_Samenwerking.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Samenwerking.Location = new System.Drawing.Point(241, 195);
            this.lb_Samenwerking.Name = "lb_Samenwerking";
            this.lb_Samenwerking.Size = new System.Drawing.Size(52, 31);
            this.lb_Samenwerking.TabIndex = 10;
            this.lb_Samenwerking.Text = "0,0";
            // 
            // lb_Programmeren
            // 
            this.lb_Programmeren.AutoSize = true;
            this.lb_Programmeren.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Programmeren.Location = new System.Drawing.Point(241, 240);
            this.lb_Programmeren.Name = "lb_Programmeren";
            this.lb_Programmeren.Size = new System.Drawing.Size(52, 31);
            this.lb_Programmeren.TabIndex = 11;
            this.lb_Programmeren.Text = "0,0";
            // 
            // lb_Concepting
            // 
            this.lb_Concepting.AutoSize = true;
            this.lb_Concepting.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Concepting.Location = new System.Drawing.Point(241, 285);
            this.lb_Concepting.Name = "lb_Concepting";
            this.lb_Concepting.Size = new System.Drawing.Size(52, 31);
            this.lb_Concepting.TabIndex = 12;
            this.lb_Concepting.Text = "0,0";
            // 
            // lb_Onderzoek
            // 
            this.lb_Onderzoek.AutoSize = true;
            this.lb_Onderzoek.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Onderzoek.Location = new System.Drawing.Point(241, 330);
            this.lb_Onderzoek.Name = "lb_Onderzoek";
            this.lb_Onderzoek.Size = new System.Drawing.Size(52, 31);
            this.lb_Onderzoek.TabIndex = 13;
            this.lb_Onderzoek.Text = "0,0";
            // 
            // btn_AddFeedback
            // 
            this.btn_AddFeedback.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddFeedback.Location = new System.Drawing.Point(12, 380);
            this.btn_AddFeedback.Name = "btn_AddFeedback";
            this.btn_AddFeedback.Size = new System.Drawing.Size(285, 40);
            this.btn_AddFeedback.TabIndex = 14;
            this.btn_AddFeedback.Text = "Add feedback";
            this.btn_AddFeedback.UseVisualStyleBackColor = true;
            this.btn_AddFeedback.Click += new System.EventHandler(this.btn_AddFeedback_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 432);
            this.Controls.Add(this.btn_AddFeedback);
            this.Controls.Add(this.lb_Onderzoek);
            this.Controls.Add(this.lb_Concepting);
            this.Controls.Add(this.lb_Programmeren);
            this.Controls.Add(this.lb_Samenwerking);
            this.Controls.Add(this.lb_Inzet);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lb_Average);
            this.Controls.Add(this.tb_Name);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_Name;
        private System.Windows.Forms.Label lb_Average;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lb_Inzet;
        private System.Windows.Forms.Label lb_Samenwerking;
        private System.Windows.Forms.Label lb_Programmeren;
        private System.Windows.Forms.Label lb_Concepting;
        private System.Windows.Forms.Label lb_Onderzoek;
        private System.Windows.Forms.Button btn_AddFeedback;
    }
}

