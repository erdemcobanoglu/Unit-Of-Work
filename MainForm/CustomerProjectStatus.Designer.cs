namespace MainForm
{
    partial class CustomerProjectStatus
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
            this.dgvCustomerProjectStatus = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomerProjectStatus)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCustomerProjectStatus
            // 
            this.dgvCustomerProjectStatus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomerProjectStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCustomerProjectStatus.Location = new System.Drawing.Point(0, 0);
            this.dgvCustomerProjectStatus.Name = "dgvCustomerProjectStatus";
            this.dgvCustomerProjectStatus.RowTemplate.Height = 24;
            this.dgvCustomerProjectStatus.Size = new System.Drawing.Size(785, 428);
            this.dgvCustomerProjectStatus.TabIndex = 0;
            // 
            // CustomerProjectStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 428);
            this.Controls.Add(this.dgvCustomerProjectStatus);
            this.Name = "CustomerProjectStatus";
            this.Text = "CustomerProjectStatus";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CustomerProjectStatus_FormClosing);
            this.Load += new System.EventHandler(this.CustomerProjectStatus_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomerProjectStatus)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCustomerProjectStatus;
    }
}