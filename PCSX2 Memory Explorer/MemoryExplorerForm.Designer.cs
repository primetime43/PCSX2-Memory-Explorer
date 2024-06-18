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
            this.textBoxWriteValue = new System.Windows.Forms.TextBox();
            this.buttonWrite = new System.Windows.Forms.Button();
            this.buttonConnect = new System.Windows.Forms.Button();
            this.buttonRead = new System.Windows.Forms.Button();
            this.buttonViewMemory = new System.Windows.Forms.Button();
            this.textBoxReadValue = new System.Windows.Forms.TextBox();
            this.labelEEmem = new System.Windows.Forms.Label();
            this.labelIOPmem = new System.Windows.Forms.Label();
            this.labelVUmem = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.labelStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.memAddressLbl = new System.Windows.Forms.Label();
            this.textBoxMemAddress = new System.Windows.Forms.TextBox();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxWriteValue
            // 
            this.textBoxWriteValue.Location = new System.Drawing.Point(133, 210);
            this.textBoxWriteValue.Name = "textBoxWriteValue";
            this.textBoxWriteValue.Size = new System.Drawing.Size(100, 20);
            this.textBoxWriteValue.TabIndex = 7;
            // 
            // buttonWrite
            // 
            this.buttonWrite.Location = new System.Drawing.Point(133, 181);
            this.buttonWrite.Name = "buttonWrite";
            this.buttonWrite.Size = new System.Drawing.Size(100, 23);
            this.buttonWrite.TabIndex = 1;
            this.buttonWrite.Text = "Write Memory";
            this.buttonWrite.UseVisualStyleBackColor = true;
            this.buttonWrite.Click += new System.EventHandler(this.buttonWrite_Click);
            // 
            // buttonConnect
            // 
            this.buttonConnect.Location = new System.Drawing.Point(12, 12);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(100, 23);
            this.buttonConnect.TabIndex = 0;
            this.buttonConnect.Text = "Connect";
            this.buttonConnect.UseVisualStyleBackColor = true;
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
            // 
            // buttonRead
            // 
            this.buttonRead.Location = new System.Drawing.Point(12, 181);
            this.buttonRead.Name = "buttonRead";
            this.buttonRead.Size = new System.Drawing.Size(100, 23);
            this.buttonRead.TabIndex = 3;
            this.buttonRead.Text = "Read Memory";
            this.buttonRead.UseVisualStyleBackColor = true;
            this.buttonRead.Click += new System.EventHandler(this.buttonRead_Click);
            // 
            // buttonViewMemory
            // 
            this.buttonViewMemory.Location = new System.Drawing.Point(12, 41);
            this.buttonViewMemory.Name = "buttonViewMemory";
            this.buttonViewMemory.Size = new System.Drawing.Size(100, 23);
            this.buttonViewMemory.TabIndex = 4;
            this.buttonViewMemory.Text = "View Memory";
            this.buttonViewMemory.UseVisualStyleBackColor = true;
            this.buttonViewMemory.Click += new System.EventHandler(this.buttonViewMemory_Click);
            // 
            // textBoxReadValue
            // 
            this.textBoxReadValue.Location = new System.Drawing.Point(12, 210);
            this.textBoxReadValue.Name = "textBoxReadValue";
            this.textBoxReadValue.Size = new System.Drawing.Size(100, 20);
            this.textBoxReadValue.TabIndex = 5;
            // 
            // labelEEmem
            // 
            this.labelEEmem.AutoSize = true;
            this.labelEEmem.Location = new System.Drawing.Point(130, 12);
            this.labelEEmem.Name = "labelEEmem";
            this.labelEEmem.Size = new System.Drawing.Size(46, 13);
            this.labelEEmem.TabIndex = 7;
            this.labelEEmem.Text = "EEmem:";
            // 
            // labelIOPmem
            // 
            this.labelIOPmem.AutoSize = true;
            this.labelIOPmem.Location = new System.Drawing.Point(130, 40);
            this.labelIOPmem.Name = "labelIOPmem";
            this.labelIOPmem.Size = new System.Drawing.Size(50, 13);
            this.labelIOPmem.TabIndex = 8;
            this.labelIOPmem.Text = "IOPmem:";
            // 
            // labelVUmem
            // 
            this.labelVUmem.AutoSize = true;
            this.labelVUmem.Location = new System.Drawing.Point(130, 69);
            this.labelVUmem.Name = "labelVUmem";
            this.labelVUmem.Size = new System.Drawing.Size(47, 13);
            this.labelVUmem.TabIndex = 9;
            this.labelVUmem.Text = "VUmem:";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.labelStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 243);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(350, 22);
            this.statusStrip1.TabIndex = 10;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // labelStatus
            // 
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(39, 17);
            this.labelStatus.Text = "Status";
            // 
            // memAddressLbl
            // 
            this.memAddressLbl.AutoSize = true;
            this.memAddressLbl.Location = new System.Drawing.Point(12, 146);
            this.memAddressLbl.Name = "memAddressLbl";
            this.memAddressLbl.Size = new System.Drawing.Size(88, 13);
            this.memAddressLbl.TabIndex = 11;
            this.memAddressLbl.Text = "Memory Address:";
            // 
            // textBoxMemAddress
            // 
            this.textBoxMemAddress.Location = new System.Drawing.Point(106, 143);
            this.textBoxMemAddress.Name = "textBoxMemAddress";
            this.textBoxMemAddress.Size = new System.Drawing.Size(127, 20);
            this.textBoxMemAddress.TabIndex = 12;
            // 
            // MemoryManager
            // 
            this.ClientSize = new System.Drawing.Size(350, 265);
            this.Controls.Add(this.textBoxMemAddress);
            this.Controls.Add(this.memAddressLbl);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.labelVUmem);
            this.Controls.Add(this.labelIOPmem);
            this.Controls.Add(this.labelEEmem);
            this.Controls.Add(this.textBoxReadValue);
            this.Controls.Add(this.buttonViewMemory);
            this.Controls.Add(this.buttonRead);
            this.Controls.Add(this.buttonConnect);
            this.Controls.Add(this.buttonWrite);
            this.Controls.Add(this.textBoxWriteValue);
            this.MinimumSize = new System.Drawing.Size(366, 304);
            this.Name = "MemoryManager";
            this.Text = "Memory Manager";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel labelStatus;
        private System.Windows.Forms.Label memAddressLbl;
        private System.Windows.Forms.TextBox textBoxMemAddress;
    }
}
