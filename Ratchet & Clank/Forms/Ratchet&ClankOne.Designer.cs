namespace Ratchet___Clank
{
    partial class RatchetAndClankOne
    {
        private System.ComponentModel.IContainer components = null;
        private Button setBoltsBtn;
        private TextBox textBoxBolts;
        private GroupBox groupBoxBolts;
        private TableLayoutPanel tableLayoutPanel;

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
            setBoltsBtn = new Button();
            textBoxBolts = new TextBox();
            groupBoxBolts = new GroupBox();
            tableLayoutPanel = new TableLayoutPanel();
            groupBoxBolts.SuspendLayout();
            tableLayoutPanel.SuspendLayout();
            SuspendLayout();
            // 
            // setBoltsBtn
            // 
            setBoltsBtn.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            setBoltsBtn.Location = new Point(208, 22);
            setBoltsBtn.Name = "setBoltsBtn";
            setBoltsBtn.Size = new Size(83, 33);
            setBoltsBtn.TabIndex = 1;
            setBoltsBtn.Text = "Set Bolts";
            setBoltsBtn.UseVisualStyleBackColor = true;
            setBoltsBtn.Click += setBoltsBtn_Click;
            // 
            // textBoxBolts
            // 
            textBoxBolts.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textBoxBolts.Location = new Point(3, 27);
            textBoxBolts.Name = "textBoxBolts";
            textBoxBolts.Size = new Size(199, 23);
            textBoxBolts.TabIndex = 0;
            // 
            // groupBoxBolts
            // 
            groupBoxBolts.Controls.Add(tableLayoutPanel);
            groupBoxBolts.Dock = DockStyle.Top;
            groupBoxBolts.Location = new Point(10, 10);
            groupBoxBolts.Name = "groupBoxBolts";
            groupBoxBolts.Size = new Size(300, 100);
            groupBoxBolts.TabIndex = 0;
            groupBoxBolts.TabStop = false;
            groupBoxBolts.Text = "Set Bolts";
            // 
            // tableLayoutPanel
            // 
            tableLayoutPanel.ColumnCount = 2;
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel.Controls.Add(textBoxBolts, 0, 0);
            tableLayoutPanel.Controls.Add(setBoltsBtn, 1, 0);
            tableLayoutPanel.Dock = DockStyle.Fill;
            tableLayoutPanel.Location = new Point(3, 19);
            tableLayoutPanel.Name = "tableLayoutPanel";
            tableLayoutPanel.RowCount = 1;
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel.Size = new Size(294, 78);
            tableLayoutPanel.TabIndex = 0;
            // 
            // RatchetAndClankOne
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(320, 120);
            Controls.Add(groupBoxBolts);
            Name = "RatchetAndClankOne";
            Padding = new Padding(10);
            Text = "Ratchet & Clank";
            groupBoxBolts.ResumeLayout(false);
            tableLayoutPanel.ResumeLayout(false);
            tableLayoutPanel.PerformLayout();
            ResumeLayout(false);
        }
    }
}
