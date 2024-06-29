namespace Ratchet___Clank
{
    partial class RatchetAndClankOne
    {
        private System.ComponentModel.IContainer components = null;
        private Button setBoltsBtn;
        private TextBox textBoxBolts;
        private Button readBoltsBtn;
        private ComboBox comboBoxItems;
        private Button toggleItemBtn;
        private GroupBox groupBoxBolts;
        private GroupBox groupBoxItems;
        private TableLayoutPanel tableLayoutPanelBolts;
        private TableLayoutPanel tableLayoutPanelItems;

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
            readBoltsBtn = new Button();
            comboBoxItems = new ComboBox();
            toggleItemBtn = new Button();
            groupBoxBolts = new GroupBox();
            tableLayoutPanelBolts = new TableLayoutPanel();
            groupBoxItems = new GroupBox();
            tableLayoutPanelItems = new TableLayoutPanel();
            giveAllItems = new Button();
            groupBoxAmmo = new GroupBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            textBoxAmmo = new TextBox();
            setAmmoBtn = new Button();
            comboBoxAmmoItems = new ComboBox();
            groupBoxBolts.SuspendLayout();
            tableLayoutPanelBolts.SuspendLayout();
            groupBoxItems.SuspendLayout();
            tableLayoutPanelItems.SuspendLayout();
            groupBoxAmmo.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // setBoltsBtn
            // 
            setBoltsBtn.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            setBoltsBtn.Location = new Point(239, 22);
            setBoltsBtn.Name = "setBoltsBtn";
            setBoltsBtn.Size = new Size(72, 33);
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
            textBoxBolts.Size = new Size(230, 23);
            textBoxBolts.TabIndex = 0;
            // 
            // readBoltsBtn
            // 
            readBoltsBtn.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            readBoltsBtn.Location = new Point(317, 22);
            readBoltsBtn.Name = "readBoltsBtn";
            readBoltsBtn.Size = new Size(74, 33);
            readBoltsBtn.TabIndex = 2;
            readBoltsBtn.Text = "Read Bolts";
            readBoltsBtn.UseVisualStyleBackColor = true;
            readBoltsBtn.Click += readBoltsBtn_Click;
            // 
            // comboBoxItems
            // 
            comboBoxItems.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            comboBoxItems.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxItems.FormattingEnabled = true;
            comboBoxItems.Location = new Point(3, 14);
            comboBoxItems.Name = "comboBoxItems";
            comboBoxItems.Size = new Size(269, 23);
            comboBoxItems.TabIndex = 0;
            // 
            // toggleItemBtn
            // 
            toggleItemBtn.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            toggleItemBtn.Location = new Point(278, 9);
            toggleItemBtn.Name = "toggleItemBtn";
            toggleItemBtn.Size = new Size(113, 33);
            toggleItemBtn.TabIndex = 1;
            toggleItemBtn.Text = "Toggle Item";
            toggleItemBtn.UseVisualStyleBackColor = true;
            toggleItemBtn.Click += toggleItemBtn_Click;
            // 
            // groupBoxBolts
            // 
            groupBoxBolts.Controls.Add(tableLayoutPanelBolts);
            groupBoxBolts.Dock = DockStyle.Top;
            groupBoxBolts.Location = new Point(10, 10);
            groupBoxBolts.Name = "groupBoxBolts";
            groupBoxBolts.Size = new Size(400, 100);
            groupBoxBolts.TabIndex = 0;
            groupBoxBolts.TabStop = false;
            groupBoxBolts.Text = "Set Bolts";
            // 
            // tableLayoutPanelBolts
            // 
            tableLayoutPanelBolts.ColumnCount = 3;
            tableLayoutPanelBolts.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            tableLayoutPanelBolts.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanelBolts.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanelBolts.Controls.Add(textBoxBolts, 0, 0);
            tableLayoutPanelBolts.Controls.Add(setBoltsBtn, 1, 0);
            tableLayoutPanelBolts.Controls.Add(readBoltsBtn, 2, 0);
            tableLayoutPanelBolts.Dock = DockStyle.Fill;
            tableLayoutPanelBolts.Location = new Point(3, 19);
            tableLayoutPanelBolts.Name = "tableLayoutPanelBolts";
            tableLayoutPanelBolts.RowCount = 1;
            tableLayoutPanelBolts.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanelBolts.Size = new Size(394, 78);
            tableLayoutPanelBolts.TabIndex = 0;
            // 
            // groupBoxItems
            // 
            groupBoxItems.Controls.Add(tableLayoutPanelItems);
            groupBoxItems.Dock = DockStyle.Top;
            groupBoxItems.Location = new Point(10, 110);
            groupBoxItems.Name = "groupBoxItems";
            groupBoxItems.Size = new Size(400, 126);
            groupBoxItems.TabIndex = 1;
            groupBoxItems.TabStop = false;
            groupBoxItems.Text = "Toggle Items";
            // 
            // tableLayoutPanelItems
            // 
            tableLayoutPanelItems.ColumnCount = 2;
            tableLayoutPanelItems.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
            tableLayoutPanelItems.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanelItems.Controls.Add(comboBoxItems, 0, 0);
            tableLayoutPanelItems.Controls.Add(toggleItemBtn, 1, 0);
            tableLayoutPanelItems.Controls.Add(giveAllItems, 0, 1);
            tableLayoutPanelItems.Dock = DockStyle.Fill;
            tableLayoutPanelItems.Location = new Point(3, 19);
            tableLayoutPanelItems.Name = "tableLayoutPanelItems";
            tableLayoutPanelItems.RowCount = 2;
            tableLayoutPanelItems.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanelItems.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanelItems.Size = new Size(394, 104);
            tableLayoutPanelItems.TabIndex = 0;
            // 
            // giveAllItems
            // 
            giveAllItems.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            giveAllItems.Location = new Point(3, 63);
            giveAllItems.Name = "giveAllItems";
            giveAllItems.Size = new Size(269, 30);
            giveAllItems.TabIndex = 2;
            giveAllItems.Text = "Give All Items";
            giveAllItems.UseVisualStyleBackColor = true;
            giveAllItems.Click += giveAllItems_Click;
            // 
            // groupBoxAmmo
            // 
            groupBoxAmmo.Controls.Add(tableLayoutPanel1);
            groupBoxAmmo.Dock = DockStyle.Top;
            groupBoxAmmo.Location = new Point(10, 236);
            groupBoxAmmo.Name = "groupBoxAmmo";
            groupBoxAmmo.Size = new Size(400, 100);
            groupBoxAmmo.TabIndex = 2;
            groupBoxAmmo.TabStop = false;
            groupBoxAmmo.Text = "Set Ammo";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel1.Controls.Add(textBoxAmmo, 0, 1);
            tableLayoutPanel1.Controls.Add(setAmmoBtn, 1, 1);
            tableLayoutPanel1.Controls.Add(comboBoxAmmoItems, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(3, 19);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 49.998745F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50.001255F));
            tableLayoutPanel1.Size = new Size(394, 78);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // textBoxAmmo
            // 
            textBoxAmmo.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textBoxAmmo.Location = new Point(3, 46);
            textBoxAmmo.Name = "textBoxAmmo";
            textBoxAmmo.Size = new Size(269, 23);
            textBoxAmmo.TabIndex = 2;
            // 
            // setAmmoBtn
            // 
            setAmmoBtn.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            setAmmoBtn.Location = new Point(278, 41);
            setAmmoBtn.Name = "setAmmoBtn";
            setAmmoBtn.Size = new Size(113, 33);
            setAmmoBtn.TabIndex = 1;
            setAmmoBtn.Text = "Set Ammo";
            setAmmoBtn.UseVisualStyleBackColor = true;
            setAmmoBtn.Click += setAmmoBtn_Click;
            // 
            // comboBoxAmmoItems
            // 
            comboBoxAmmoItems.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            comboBoxAmmoItems.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxAmmoItems.FormattingEnabled = true;
            comboBoxAmmoItems.Location = new Point(3, 7);
            comboBoxAmmoItems.Name = "comboBoxAmmoItems";
            comboBoxAmmoItems.Size = new Size(269, 23);
            comboBoxAmmoItems.TabIndex = 0;
            // 
            // RatchetAndClankOne
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(420, 349);
            Controls.Add(groupBoxAmmo);
            Controls.Add(groupBoxItems);
            Controls.Add(groupBoxBolts);
            Name = "RatchetAndClankOne";
            Padding = new Padding(10);
            Text = "Ratchet & Clank";
            groupBoxBolts.ResumeLayout(false);
            tableLayoutPanelBolts.ResumeLayout(false);
            tableLayoutPanelBolts.PerformLayout();
            groupBoxItems.ResumeLayout(false);
            tableLayoutPanelItems.ResumeLayout(false);
            groupBoxAmmo.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        private GroupBox groupBoxAmmo;
        private TableLayoutPanel tableLayoutPanel1;
        private ComboBox comboBoxAmmoItems;
        private Button setAmmoBtn;
        private TextBox textBoxAmmo;
        private Button giveAllItems;
    }
}
