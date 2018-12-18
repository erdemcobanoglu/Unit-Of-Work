namespace MainForm
{
    partial class TaskListForm
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
            this.dgvTask = new System.Windows.Forms.DataGridView();
            this.cmTask = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.miDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.miUpdate = new System.Windows.Forms.ToolStripMenuItem();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTask)).BeginInit();
            this.cmTask.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvTask
            // 
            this.dgvTask.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTask.ContextMenuStrip = this.cmTask;
            this.dgvTask.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTask.Location = new System.Drawing.Point(0, 0);
            this.dgvTask.Margin = new System.Windows.Forms.Padding(4);
            this.dgvTask.Name = "dgvTask";
            this.dgvTask.Size = new System.Drawing.Size(983, 501);
            this.dgvTask.TabIndex = 0;
            this.dgvTask.RowContextMenuStripNeeded += new System.Windows.Forms.DataGridViewRowContextMenuStripNeededEventHandler(this.dgvTask_RowContextMenuStripNeeded);
            // 
            // cmTask
            // 
            this.cmTask.ImageScalingSize = new System.Drawing.Size(19, 19);
            this.cmTask.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miDelete,
            this.miUpdate});
            this.cmTask.Name = "cmTask";
            this.cmTask.Size = new System.Drawing.Size(136, 52);
            // 
            // miDelete
            // 
            this.miDelete.Name = "miDelete";
            this.miDelete.Size = new System.Drawing.Size(135, 24);
            this.miDelete.Text = "Sil";
            this.miDelete.Click += new System.EventHandler(this.miDelete_Click);
            // 
            // miUpdate
            // 
            this.miUpdate.Name = "miUpdate";
            this.miUpdate.Size = new System.Drawing.Size(135, 24);
            this.miUpdate.Text = "Güncelle";
            this.miUpdate.Click += new System.EventHandler(this.miUpdate_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Transparent;
            this.btnBack.BackgroundImage = global::MainForm.Properties.Resources.Button_Back_1_32;
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.GreenYellow;
            this.btnBack.Location = new System.Drawing.Point(16, 433);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(68, 53);
            this.btnBack.TabIndex = 1;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // TaskListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(983, 501);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.dgvTask);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "TaskListForm";
            this.Text = "TaskListForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TaskListForm_FormClosing);
            this.Load += new System.EventHandler(this.TaskListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTask)).EndInit();
            this.cmTask.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTask;
        private System.Windows.Forms.ContextMenuStrip cmTask;
        private System.Windows.Forms.ToolStripMenuItem miDelete;
        private System.Windows.Forms.ToolStripMenuItem miUpdate;
        private System.Windows.Forms.Button btnBack;
    }
}