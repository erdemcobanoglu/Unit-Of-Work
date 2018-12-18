namespace MainForm
{
    partial class CustomerMessageListForm
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
            this.dtgCustomerMessage = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.miUpdate = new System.Windows.Forms.ToolStripMenuItem();
            this.miDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCustomerMessage)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgCustomerMessage
            // 
            this.dtgCustomerMessage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgCustomerMessage.ContextMenuStrip = this.contextMenuStrip1;
            this.dtgCustomerMessage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgCustomerMessage.Location = new System.Drawing.Point(0, 0);
            this.dtgCustomerMessage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtgCustomerMessage.Name = "dtgCustomerMessage";
            this.dtgCustomerMessage.RowTemplate.Height = 24;
            this.dtgCustomerMessage.Size = new System.Drawing.Size(937, 559);
            this.dtgCustomerMessage.TabIndex = 0;
            this.dtgCustomerMessage.RowContextMenuStripNeeded += new System.Windows.Forms.DataGridViewRowContextMenuStripNeededEventHandler(this.dtgCustomerMessage_RowContextMenuStripNeeded);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miUpdate,
            this.miDelete});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(136, 52);
            // 
            // miUpdate
            // 
            this.miUpdate.Name = "miUpdate";
            this.miUpdate.Size = new System.Drawing.Size(135, 24);
            this.miUpdate.Text = "Güncelle";
            this.miUpdate.Click += new System.EventHandler(this.miUpdate_Click);
            // 
            // miDelete
            // 
            this.miDelete.Name = "miDelete";
            this.miDelete.Size = new System.Drawing.Size(135, 24);
            this.miDelete.Text = "Sil";
            this.miDelete.Click += new System.EventHandler(this.miDelete_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Transparent;
            this.btnBack.BackgroundImage = global::MainForm.Properties.Resources.Button_Back_1_32;
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.GreenYellow;
            this.btnBack.Location = new System.Drawing.Point(16, 491);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(68, 53);
            this.btnBack.TabIndex = 15;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // CustomerMessageListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(937, 559);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.dtgCustomerMessage);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "CustomerMessageListForm";
            this.Text = "CustomerMessageList";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CustomerMessageListForm_FormClosing);
            this.Load += new System.EventHandler(this.CustomerMessageListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgCustomerMessage)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgCustomerMessage;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem miUpdate;
        private System.Windows.Forms.ToolStripMenuItem miDelete;
        private System.Windows.Forms.Button btnBack;
    }
}