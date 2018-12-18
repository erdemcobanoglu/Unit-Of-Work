namespace MainForm
{
    partial class TaskForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.Button();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.cmbProje = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbEmployee = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rdbDevelop = new System.Windows.Forms.RadioButton();
            this.rdbTested = new System.Windows.Forms.RadioButton();
            this.rdbNotStarted = new System.Windows.Forms.RadioButton();
            this.dtpFinalDate = new System.Windows.Forms.DateTimePicker();
            this.dtpBeginDate = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.btnBack);
            this.panel1.Controls.Add(this.txtDescription);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.cmbProje);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.cmbEmployee);
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.dtpFinalDate);
            this.panel1.Controls.Add(this.dtpBeginDate);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(43, 27);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(548, 699);
            this.panel1.TabIndex = 2;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Transparent;
            this.btnBack.BackgroundImage = global::MainForm.Properties.Resources.Button_Back_1_32;
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.GreenYellow;
            this.btnBack.Location = new System.Drawing.Point(28, 626);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(68, 53);
            this.btnBack.TabIndex = 12;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(243, 468);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(267, 121);
            this.txtDescription.TabIndex = 11;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.PapayaWhip;
            this.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.GreenYellow;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSave.Location = new System.Drawing.Point(317, 617);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(193, 63);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Görev Atamasını Yap";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // cmbProje
            // 
            this.cmbProje.FormattingEnabled = true;
            this.cmbProje.Location = new System.Drawing.Point(243, 400);
            this.cmbProje.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbProje.Name = "cmbProje";
            this.cmbProje.Size = new System.Drawing.Size(265, 24);
            this.cmbProje.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.7931F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label4.Location = new System.Drawing.Point(23, 468);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 24);
            this.label4.TabIndex = 8;
            this.label4.Text = "Açıklama : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.7931F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label5.Location = new System.Drawing.Point(23, 394);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 24);
            this.label5.TabIndex = 8;
            this.label5.Text = "Proje : ";
            // 
            // cmbEmployee
            // 
            this.cmbEmployee.FormattingEnabled = true;
            this.cmbEmployee.Location = new System.Drawing.Point(243, 338);
            this.cmbEmployee.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbEmployee.Name = "cmbEmployee";
            this.cmbEmployee.Size = new System.Drawing.Size(265, 24);
            this.cmbEmployee.TabIndex = 7;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rdbDevelop);
            this.groupBox3.Controls.Add(this.rdbTested);
            this.groupBox3.Controls.Add(this.rdbNotStarted);
            this.groupBox3.Location = new System.Drawing.Point(243, 181);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Size = new System.Drawing.Size(267, 103);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            // 
            // rdbDevelop
            // 
            this.rdbDevelop.AutoSize = true;
            this.rdbDevelop.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rdbDevelop.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rdbDevelop.Location = new System.Drawing.Point(19, 44);
            this.rdbDevelop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdbDevelop.Name = "rdbDevelop";
            this.rdbDevelop.Size = new System.Drawing.Size(111, 21);
            this.rdbDevelop.TabIndex = 0;
            this.rdbDevelop.TabStop = true;
            this.rdbDevelop.Text = "Geliştirilcek";
            this.rdbDevelop.UseVisualStyleBackColor = true;
            // 
            // rdbTested
            // 
            this.rdbTested.AutoSize = true;
            this.rdbTested.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rdbTested.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rdbTested.Location = new System.Drawing.Point(19, 71);
            this.rdbTested.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdbTested.Name = "rdbTested";
            this.rdbTested.Size = new System.Drawing.Size(115, 21);
            this.rdbTested.TabIndex = 5;
            this.rdbTested.TabStop = true;
            this.rdbTested.Text = "Test Edilcek";
            this.rdbTested.UseVisualStyleBackColor = true;
            // 
            // rdbNotStarted
            // 
            this.rdbNotStarted.AutoSize = true;
            this.rdbNotStarted.Checked = true;
            this.rdbNotStarted.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rdbNotStarted.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rdbNotStarted.Location = new System.Drawing.Point(19, 18);
            this.rdbNotStarted.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdbNotStarted.Name = "rdbNotStarted";
            this.rdbNotStarted.Size = new System.Drawing.Size(109, 21);
            this.rdbNotStarted.TabIndex = 0;
            this.rdbNotStarted.TabStop = true;
            this.rdbNotStarted.Text = "Başlanmadı";
            this.rdbNotStarted.UseVisualStyleBackColor = true;
            // 
            // dtpFinalDate
            // 
            this.dtpFinalDate.Location = new System.Drawing.Point(243, 105);
            this.dtpFinalDate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpFinalDate.Name = "dtpFinalDate";
            this.dtpFinalDate.Size = new System.Drawing.Size(265, 22);
            this.dtpFinalDate.TabIndex = 4;
            // 
            // dtpBeginDate
            // 
            this.dtpBeginDate.Location = new System.Drawing.Point(243, 26);
            this.dtpBeginDate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpBeginDate.Name = "dtpBeginDate";
            this.dtpBeginDate.Size = new System.Drawing.Size(265, 22);
            this.dtpBeginDate.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.7931F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label7.Location = new System.Drawing.Point(23, 332);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 24);
            this.label7.TabIndex = 0;
            this.label7.Text = "Çalışan : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.7931F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label2.Location = new System.Drawing.Point(23, 218);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Durum : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.7931F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label3.Location = new System.Drawing.Point(23, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(177, 24);
            this.label3.TabIndex = 0;
            this.label3.Text = "Başlangıç Tarihi : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.7931F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Location = new System.Drawing.Point(23, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bitiş Tarihi : ";
            // 
            // TaskForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(651, 750);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "TaskForm";
            this.Text = "TaskForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TaskForm_FormClosing);
            this.Load += new System.EventHandler(this.TaskForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbProje;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbEmployee;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rdbDevelop;
        private System.Windows.Forms.RadioButton rdbTested;
        private System.Windows.Forms.RadioButton rdbNotStarted;
        private System.Windows.Forms.DateTimePicker dtpFinalDate;
        private System.Windows.Forms.DateTimePicker dtpBeginDate;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnBack;
    }
}