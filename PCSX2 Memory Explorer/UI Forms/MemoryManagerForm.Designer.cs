namespace PCSX2_Memory_Explorer
{
    partial class MemoryManager
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.Label labelEEmem;
        private System.Windows.Forms.Label labelIOPmem;
        private System.Windows.Forms.Label labelVUmem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel labelStatus;
        private System.Windows.Forms.GroupBox groupBoxConnection;
        private System.Windows.Forms.GroupBox groupBoxGames;
        private System.Windows.Forms.GroupBox groupBoxManualMemory;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button buttonOpenGame;
        private System.Windows.Forms.TextBox textBoxMemAddress;
        private System.Windows.Forms.Label labelMemAddress;
        private System.Windows.Forms.Button buttonViewMemory;

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
            this.buttonConnect = new Button();
            this.labelEEmem = new Label();
            this.labelIOPmem = new Label();
            this.labelVUmem = new Label();
            this.statusStrip1 = new StatusStrip();
            this.labelStatus = new ToolStripStatusLabel();
            this.groupBoxConnection = new GroupBox();
            this.groupBoxGames = new GroupBox();
            this.groupBoxManualMemory = new GroupBox();
            this.comboBox1 = new ComboBox();
            this.buttonOpenGame = new Button();
            this.textBoxMemAddress = new TextBox();
            this.labelMemAddress = new Label();
            this.buttonViewMemory = new Button();

            this.statusStrip1.SuspendLayout();
            this.groupBoxConnection.SuspendLayout();
            this.groupBoxGames.SuspendLayout();
            this.groupBoxManualMemory.SuspendLayout();
            this.SuspendLayout();

            //
            // statusStrip1
            //
            this.statusStrip1.Items.AddRange(new ToolStripItem[] { this.labelStatus });
            this.statusStrip1.Location = new Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new Size(584, 22);
            this.statusStrip1.TabIndex = 0;

            //
            // labelStatus
            //
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new Size(118, 17);
            this.labelStatus.Text = "Not connected";

            //
            // groupBoxConnection
            //
            this.groupBoxConnection.Controls.Add(this.buttonConnect);
            this.groupBoxConnection.Controls.Add(this.labelEEmem);
            this.groupBoxConnection.Controls.Add(this.labelIOPmem);
            this.groupBoxConnection.Controls.Add(this.labelVUmem);
            this.groupBoxConnection.Location = new Point(12, 12);
            this.groupBoxConnection.Name = "groupBoxConnection";
            this.groupBoxConnection.Size = new Size(560, 100);
            this.groupBoxConnection.TabIndex = 1;
            this.groupBoxConnection.TabStop = false;
            this.groupBoxConnection.Text = "PCSX2 Connection";

            //
            // buttonConnect
            //
            this.buttonConnect.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            this.buttonConnect.Location = new Point(15, 30);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new Size(120, 50);
            this.buttonConnect.TabIndex = 0;
            this.buttonConnect.Text = "Connect to PCSX2";
            this.buttonConnect.UseVisualStyleBackColor = true;
            this.buttonConnect.Click += this.buttonConnect_Click;

            //
            // labelEEmem
            //
            this.labelEEmem.AutoSize = true;
            this.labelEEmem.Location = new Point(150, 30);
            this.labelEEmem.Name = "labelEEmem";
            this.labelEEmem.Size = new Size(100, 15);
            this.labelEEmem.TabIndex = 1;
            this.labelEEmem.Text = "EEmem: Not loaded";

            //
            // labelIOPmem
            //
            this.labelIOPmem.AutoSize = true;
            this.labelIOPmem.Location = new Point(150, 50);
            this.labelIOPmem.Name = "labelIOPmem";
            this.labelIOPmem.Size = new Size(108, 15);
            this.labelIOPmem.TabIndex = 2;
            this.labelIOPmem.Text = "IOPmem: Not loaded";

            //
            // labelVUmem
            //
            this.labelVUmem.AutoSize = true;
            this.labelVUmem.Location = new Point(150, 70);
            this.labelVUmem.Name = "labelVUmem";
            this.labelVUmem.Size = new Size(104, 15);
            this.labelVUmem.TabIndex = 3;
            this.labelVUmem.Text = "VUmem: Not loaded";

            //
            // groupBoxGames
            //
            this.groupBoxGames.Controls.Add(this.comboBox1);
            this.groupBoxGames.Controls.Add(this.buttonOpenGame);
            this.groupBoxGames.Location = new Point(12, 118);
            this.groupBoxGames.Name = "groupBoxGames";
            this.groupBoxGames.Size = new Size(275, 290);
            this.groupBoxGames.TabIndex = 2;
            this.groupBoxGames.TabStop = false;
            this.groupBoxGames.Text = "Game-Specific Memory Tools";

            //
            // comboBox1
            //
            this.comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new Font("Segoe UI", 9F);
            this.comboBox1.FormattingEnabled = true;
            // Populate from GameRegistry - add/remove games in Common.GameRegistry.SupportedGames
            this.comboBox1.Items.AddRange(Common.GameRegistry.SupportedGames.ToArray());
            this.comboBox1.Location = new Point(15, 30);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new Size(245, 23);
            this.comboBox1.TabIndex = 0;

            //
            // buttonOpenGame
            //
            this.buttonOpenGame.Location = new Point(15, 60);
            this.buttonOpenGame.Name = "buttonOpenGame";
            this.buttonOpenGame.Size = new Size(245, 35);
            this.buttonOpenGame.TabIndex = 1;
            this.buttonOpenGame.Text = "Open Game Memory Editor";
            this.buttonOpenGame.UseVisualStyleBackColor = true;
            this.buttonOpenGame.Click += this.comboBox1_SelectedIndexChanged;

            //
            // groupBoxManualMemory
            //
            this.groupBoxManualMemory.Controls.Add(this.buttonViewMemory);
            this.groupBoxManualMemory.Controls.Add(this.labelMemAddress);
            this.groupBoxManualMemory.Controls.Add(this.textBoxMemAddress);
            this.groupBoxManualMemory.Location = new Point(293, 118);
            this.groupBoxManualMemory.Name = "groupBoxManualMemory";
            this.groupBoxManualMemory.Size = new Size(279, 290);
            this.groupBoxManualMemory.TabIndex = 3;
            this.groupBoxManualMemory.TabStop = false;
            this.groupBoxManualMemory.Text = "Memory Viewer";

            //
            // buttonViewMemory
            //
            this.buttonViewMemory.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            this.buttonViewMemory.Location = new Point(15, 30);
            this.buttonViewMemory.Name = "buttonViewMemory";
            this.buttonViewMemory.Size = new Size(250, 50);
            this.buttonViewMemory.TabIndex = 0;
            this.buttonViewMemory.Text = "Open Memory Viewer";
            this.buttonViewMemory.UseVisualStyleBackColor = true;
            this.buttonViewMemory.Click += this.buttonViewMemory_Click;

            //
            // labelMemAddress
            //
            this.labelMemAddress.AutoSize = true;
            this.labelMemAddress.Location = new Point(15, 100);
            this.labelMemAddress.Name = "labelMemAddress";
            this.labelMemAddress.Size = new Size(250, 30);
            this.labelMemAddress.TabIndex = 1;
            this.labelMemAddress.Text = "Optional: Jump to specific address\n(Leave empty to start at 0x0)";

            //
            // textBoxMemAddress
            //
            this.textBoxMemAddress.Font = new Font("Consolas", 10F);
            this.textBoxMemAddress.Location = new Point(15, 135);
            this.textBoxMemAddress.Name = "textBoxMemAddress";
            this.textBoxMemAddress.PlaceholderText = "e.g., 0x1A7A00";
            this.textBoxMemAddress.Size = new Size(250, 23);
            this.textBoxMemAddress.TabIndex = 2;

            //
            // MemoryManager
            //
            this.ClientSize = new Size(584, 450);
            this.Controls.Add(this.groupBoxManualMemory);
            this.Controls.Add(this.groupBoxGames);
            this.Controls.Add(this.groupBoxConnection);
            this.Controls.Add(this.statusStrip1);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MemoryManager";
            this.Text = "PCSX2 Memory Explorer";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBoxConnection.ResumeLayout(false);
            this.groupBoxConnection.PerformLayout();
            this.groupBoxGames.ResumeLayout(false);
            this.groupBoxManualMemory.ResumeLayout(false);
            this.groupBoxManualMemory.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
