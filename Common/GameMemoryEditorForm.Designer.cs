namespace Common
{
    partial class GameMemoryEditorForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dataGridViewMemory;
        private System.Windows.Forms.Button buttonRefreshAll;
        private System.Windows.Forms.Button buttonWriteAll;
        private System.Windows.Forms.CheckBox checkBoxAutoRefresh;
        private System.Windows.Forms.Timer timerAutoRefresh;
        private System.Windows.Forms.Timer timerFreeze;
        private System.Windows.Forms.Label labelGameName;
        private System.Windows.Forms.ComboBox comboBoxCategory;
        private System.Windows.Forms.Label labelCategory;
        private System.Windows.Forms.Label labelFreezeCount;
        private System.Windows.Forms.Label labelTooltipHint;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridViewMemory = new System.Windows.Forms.DataGridView();
            this.buttonRefreshAll = new System.Windows.Forms.Button();
            this.buttonWriteAll = new System.Windows.Forms.Button();
            this.checkBoxAutoRefresh = new System.Windows.Forms.CheckBox();
            this.timerAutoRefresh = new System.Windows.Forms.Timer(this.components);
            this.timerFreeze = new System.Windows.Forms.Timer(this.components);
            this.labelGameName = new System.Windows.Forms.Label();
            this.comboBoxCategory = new System.Windows.Forms.ComboBox();
            this.labelCategory = new System.Windows.Forms.Label();
            this.labelFreezeCount = new System.Windows.Forms.Label();
            this.labelTooltipHint = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMemory)).BeginInit();
            this.SuspendLayout();
            //
            // labelGameName
            //
            this.labelGameName.AutoSize = true;
            this.labelGameName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.labelGameName.Location = new System.Drawing.Point(12, 12);
            this.labelGameName.Name = "labelGameName";
            this.labelGameName.Size = new System.Drawing.Size(150, 21);
            this.labelGameName.TabIndex = 0;
            this.labelGameName.Text = "Game Memory Editor";
            //
            // labelCategory
            //
            this.labelCategory.AutoSize = true;
            this.labelCategory.Location = new System.Drawing.Point(12, 45);
            this.labelCategory.Name = "labelCategory";
            this.labelCategory.Size = new System.Drawing.Size(58, 15);
            this.labelCategory.TabIndex = 1;
            this.labelCategory.Text = "Category:";
            //
            // comboBoxCategory
            //
            this.comboBoxCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCategory.Location = new System.Drawing.Point(75, 42);
            this.comboBoxCategory.Name = "comboBoxCategory";
            this.comboBoxCategory.Size = new System.Drawing.Size(150, 23);
            this.comboBoxCategory.TabIndex = 2;
            this.comboBoxCategory.SelectedIndexChanged += new System.EventHandler(this.comboBoxCategory_SelectedIndexChanged);
            //
            // dataGridViewMemory
            //
            this.dataGridViewMemory.AllowUserToAddRows = false;
            this.dataGridViewMemory.AllowUserToDeleteRows = false;
            this.dataGridViewMemory.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewMemory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewMemory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMemory.Location = new System.Drawing.Point(12, 75);
            this.dataGridViewMemory.Name = "dataGridViewMemory";
            this.dataGridViewMemory.RowHeadersWidth = 25;
            this.dataGridViewMemory.Size = new System.Drawing.Size(760, 450);
            this.dataGridViewMemory.TabIndex = 3;
            //
            // buttonRefreshAll
            //
            this.buttonRefreshAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonRefreshAll.Location = new System.Drawing.Point(12, 535);
            this.buttonRefreshAll.Name = "buttonRefreshAll";
            this.buttonRefreshAll.Size = new System.Drawing.Size(120, 30);
            this.buttonRefreshAll.TabIndex = 4;
            this.buttonRefreshAll.Text = "Refresh All Values";
            this.buttonRefreshAll.UseVisualStyleBackColor = true;
            this.buttonRefreshAll.Click += new System.EventHandler(this.buttonRefreshAll_Click);
            //
            // buttonWriteAll
            //
            this.buttonWriteAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonWriteAll.Location = new System.Drawing.Point(138, 535);
            this.buttonWriteAll.Name = "buttonWriteAll";
            this.buttonWriteAll.Size = new System.Drawing.Size(120, 30);
            this.buttonWriteAll.TabIndex = 5;
            this.buttonWriteAll.Text = "Write All Changes";
            this.buttonWriteAll.UseVisualStyleBackColor = true;
            this.buttonWriteAll.Click += new System.EventHandler(this.buttonWriteAll_Click);
            //
            // checkBoxAutoRefresh
            //
            this.checkBoxAutoRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxAutoRefresh.AutoSize = true;
            this.checkBoxAutoRefresh.Location = new System.Drawing.Point(640, 542);
            this.checkBoxAutoRefresh.Name = "checkBoxAutoRefresh";
            this.checkBoxAutoRefresh.Size = new System.Drawing.Size(132, 19);
            this.checkBoxAutoRefresh.TabIndex = 6;
            this.checkBoxAutoRefresh.Text = "Auto-Refresh (1 sec)";
            this.checkBoxAutoRefresh.UseVisualStyleBackColor = true;
            this.checkBoxAutoRefresh.CheckedChanged += new System.EventHandler(this.checkBoxAutoRefresh_CheckedChanged);
            //
            // timerAutoRefresh
            //
            this.timerAutoRefresh.Interval = 1000;
            this.timerAutoRefresh.Tick += new System.EventHandler(this.timerAutoRefresh_Tick);
            //
            // timerFreeze
            //
            this.timerFreeze.Interval = 100;
            this.timerFreeze.Enabled = true;
            this.timerFreeze.Tick += new System.EventHandler(this.timerFreeze_Tick);
            //
            // labelFreezeCount
            //
            this.labelFreezeCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelFreezeCount.AutoSize = true;
            this.labelFreezeCount.Location = new System.Drawing.Point(270, 542);
            this.labelFreezeCount.Name = "labelFreezeCount";
            this.labelFreezeCount.Size = new System.Drawing.Size(100, 15);
            this.labelFreezeCount.TabIndex = 7;
            this.labelFreezeCount.Text = "Frozen: 0 values";
            //
            // labelTooltipHint
            //
            this.labelTooltipHint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTooltipHint.AutoSize = true;
            this.labelTooltipHint.ForeColor = System.Drawing.Color.Gray;
            this.labelTooltipHint.Location = new System.Drawing.Point(550, 45);
            this.labelTooltipHint.Name = "labelTooltipHint";
            this.labelTooltipHint.Size = new System.Drawing.Size(150, 15);
            this.labelTooltipHint.TabIndex = 8;
            this.labelTooltipHint.Text = "Click 'View' button for detailed notes";
            //
            // GameMemoryEditorForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 577);
            this.Controls.Add(this.labelTooltipHint);
            this.Controls.Add(this.labelFreezeCount);
            this.Controls.Add(this.checkBoxAutoRefresh);
            this.Controls.Add(this.buttonWriteAll);
            this.Controls.Add(this.buttonRefreshAll);
            this.Controls.Add(this.dataGridViewMemory);
            this.Controls.Add(this.comboBoxCategory);
            this.Controls.Add(this.labelCategory);
            this.Controls.Add(this.labelGameName);
            this.MinimumSize = new System.Drawing.Size(600, 400);
            this.Name = "GameMemoryEditorForm";
            this.Text = "Game Memory Editor";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMemory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
