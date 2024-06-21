namespace PCSX2_Memory_Explorer
{
    partial class MemoryManager
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox textBoxWriteValue;
        private System.Windows.Forms.Button buttonWrite;
        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.Button buttonRead;
        private System.Windows.Forms.Button buttonViewMemory;
        private System.Windows.Forms.TextBox textBoxReadValue;
        private System.Windows.Forms.Label labelEEmem;
        private System.Windows.Forms.Label labelIOPmem;
        private System.Windows.Forms.Label labelVUmem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel labelStatus;
        private System.Windows.Forms.Label memAddressLbl;
        private System.Windows.Forms.TextBox textBoxMemAddress;
        private System.Windows.Forms.ComboBox comboBox1;

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
            textBoxWriteValue = new TextBox();
            buttonWrite = new Button();
            buttonConnect = new Button();
            buttonRead = new Button();
            buttonViewMemory = new Button();
            textBoxReadValue = new TextBox();
            labelEEmem = new Label();
            labelIOPmem = new Label();
            labelVUmem = new Label();
            statusStrip1 = new StatusStrip();
            labelStatus = new ToolStripStatusLabel();
            memAddressLbl = new Label();
            textBoxMemAddress = new TextBox();
            comboBox1 = new ComboBox();
            label1 = new Label();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // textBoxWriteValue
            // 
            textBoxWriteValue.Location = new Point(133, 210);
            textBoxWriteValue.Name = "textBoxWriteValue";
            textBoxWriteValue.Size = new Size(100, 23);
            textBoxWriteValue.TabIndex = 7;
            // 
            // buttonWrite
            // 
            buttonWrite.Location = new Point(133, 181);
            buttonWrite.Name = "buttonWrite";
            buttonWrite.Size = new Size(100, 23);
            buttonWrite.TabIndex = 1;
            buttonWrite.Text = "Write Memory";
            buttonWrite.UseVisualStyleBackColor = true;
            buttonWrite.Click += buttonWrite_Click;
            // 
            // buttonConnect
            // 
            buttonConnect.Location = new Point(12, 12);
            buttonConnect.Name = "buttonConnect";
            buttonConnect.Size = new Size(100, 23);
            buttonConnect.TabIndex = 0;
            buttonConnect.Text = "Connect";
            buttonConnect.UseVisualStyleBackColor = true;
            buttonConnect.Click += buttonConnect_Click;
            // 
            // buttonRead
            // 
            buttonRead.Location = new Point(12, 181);
            buttonRead.Name = "buttonRead";
            buttonRead.Size = new Size(100, 23);
            buttonRead.TabIndex = 3;
            buttonRead.Text = "Read Memory";
            buttonRead.UseVisualStyleBackColor = true;
            buttonRead.Click += buttonRead_Click;
            // 
            // buttonViewMemory
            // 
            buttonViewMemory.Location = new Point(12, 41);
            buttonViewMemory.Name = "buttonViewMemory";
            buttonViewMemory.Size = new Size(100, 23);
            buttonViewMemory.TabIndex = 4;
            buttonViewMemory.Text = "View Memory";
            buttonViewMemory.UseVisualStyleBackColor = true;
            buttonViewMemory.Click += buttonViewMemory_Click;
            // 
            // textBoxReadValue
            // 
            textBoxReadValue.Location = new Point(12, 210);
            textBoxReadValue.Name = "textBoxReadValue";
            textBoxReadValue.Size = new Size(100, 23);
            textBoxReadValue.TabIndex = 5;
            // 
            // labelEEmem
            // 
            labelEEmem.AutoSize = true;
            labelEEmem.Location = new Point(130, 12);
            labelEEmem.Name = "labelEEmem";
            labelEEmem.Size = new Size(50, 15);
            labelEEmem.TabIndex = 7;
            labelEEmem.Text = "EEmem:";
            // 
            // labelIOPmem
            // 
            labelIOPmem.AutoSize = true;
            labelIOPmem.Location = new Point(130, 40);
            labelIOPmem.Name = "labelIOPmem";
            labelIOPmem.Size = new Size(57, 15);
            labelIOPmem.TabIndex = 8;
            labelIOPmem.Text = "IOPmem:";
            // 
            // labelVUmem
            // 
            labelVUmem.AutoSize = true;
            labelVUmem.Location = new Point(130, 69);
            labelVUmem.Name = "labelVUmem";
            labelVUmem.Size = new Size(53, 15);
            labelVUmem.TabIndex = 9;
            labelVUmem.Text = "VUmem:";
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { labelStatus });
            statusStrip1.Location = new Point(0, 243);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(350, 22);
            statusStrip1.TabIndex = 10;
            statusStrip1.Text = "statusStrip1";
            // 
            // labelStatus
            // 
            labelStatus.Name = "labelStatus";
            labelStatus.Size = new Size(39, 17);
            labelStatus.Text = "Status";
            // 
            // memAddressLbl
            // 
            memAddressLbl.AutoSize = true;
            memAddressLbl.Location = new Point(12, 146);
            memAddressLbl.Name = "memAddressLbl";
            memAddressLbl.Size = new Size(100, 15);
            memAddressLbl.TabIndex = 11;
            memAddressLbl.Text = "Memory Address:";
            // 
            // textBoxMemAddress
            // 
            textBoxMemAddress.Location = new Point(118, 142);
            textBoxMemAddress.Name = "textBoxMemAddress";
            textBoxMemAddress.Size = new Size(127, 23);
            textBoxMemAddress.TabIndex = 12;
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Ratchet & Clank", "Ratchet & Clank: Going Commando" });
            comboBox1.Location = new Point(12, 101);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(326, 23);
            comboBox1.TabIndex = 13;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 83);
            label1.Name = "label1";
            label1.Size = new Size(46, 15);
            label1.TabIndex = 14;
            label1.Text = "Games:";
            // 
            // MemoryManager
            // 
            ClientSize = new Size(350, 265);
            Controls.Add(label1);
            Controls.Add(comboBox1);
            Controls.Add(textBoxMemAddress);
            Controls.Add(memAddressLbl);
            Controls.Add(statusStrip1);
            Controls.Add(labelVUmem);
            Controls.Add(labelIOPmem);
            Controls.Add(labelEEmem);
            Controls.Add(textBoxReadValue);
            Controls.Add(buttonViewMemory);
            Controls.Add(buttonRead);
            Controls.Add(buttonConnect);
            Controls.Add(buttonWrite);
            Controls.Add(textBoxWriteValue);
            MinimumSize = new Size(366, 304);
            Name = "MemoryManager";
            Text = "Memory Manager";
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private Label label1;
    }
}
