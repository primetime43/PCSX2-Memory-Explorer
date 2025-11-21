namespace PCSX2_Memory_Explorer
{
    partial class MemoryManager
    {
        private System.ComponentModel.IContainer components = null;
        private Button buttonConnect;
        private Label labelEEmem;
        private Label labelIOPmem;
        private Label labelVUmem;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel labelStatus;
        private GroupBox groupBoxConnection;
        private GroupBox groupBoxGames;
        private GroupBox groupBoxTools;
        private ListBox listBoxGames;
        private Button buttonOpenGame;
        private TextBox textBoxMemAddress;
        private Label labelMemAddress;
        private Button buttonViewMemory;

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
            this.groupBoxTools = new GroupBox();
            this.listBoxGames = new ListBox();
            this.buttonOpenGame = new Button();
            this.textBoxMemAddress = new TextBox();
            this.labelMemAddress = new Label();
            this.buttonViewMemory = new Button();

            this.statusStrip1.SuspendLayout();
            this.groupBoxConnection.SuspendLayout();
            this.groupBoxGames.SuspendLayout();
            this.groupBoxTools.SuspendLayout();
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
            this.groupBoxGames.Controls.Add(this.listBoxGames);
            this.groupBoxGames.Controls.Add(this.buttonOpenGame);
            this.groupBoxGames.Location = new Point(12, 118);
            this.groupBoxGames.Name = "groupBoxGames";
            this.groupBoxGames.Size = new Size(350, 300);
            this.groupBoxGames.TabIndex = 2;
            this.groupBoxGames.TabStop = false;
            this.groupBoxGames.Text = "Supported Games";

            //
            // listBoxGames
            //
            this.listBoxGames.FormattingEnabled = true;
            this.listBoxGames.ItemHeight = 15;
            this.listBoxGames.Items.AddRange(Common.GameRegistry.SupportedGames.ToArray());
            this.listBoxGames.Location = new Point(15, 25);
            this.listBoxGames.Name = "listBoxGames";
            this.listBoxGames.Size = new Size(320, 229);
            this.listBoxGames.TabIndex = 0;
            this.listBoxGames.DoubleClick += this.listBoxGames_DoubleClick;

            //
            // buttonOpenGame
            //
            this.buttonOpenGame.Location = new Point(15, 260);
            this.buttonOpenGame.Name = "buttonOpenGame";
            this.buttonOpenGame.Size = new Size(320, 30);
            this.buttonOpenGame.TabIndex = 1;
            this.buttonOpenGame.Text = "Open Memory Editor";
            this.buttonOpenGame.UseVisualStyleBackColor = true;
            this.buttonOpenGame.Click += this.buttonOpenGame_Click;

            //
            // groupBoxTools
            //
            this.groupBoxTools.Controls.Add(this.buttonViewMemory);
            this.groupBoxTools.Controls.Add(this.labelMemAddress);
            this.groupBoxTools.Controls.Add(this.textBoxMemAddress);
            this.groupBoxTools.Location = new Point(368, 118);
            this.groupBoxTools.Name = "groupBoxTools";
            this.groupBoxTools.Size = new Size(204, 300);
            this.groupBoxTools.TabIndex = 3;
            this.groupBoxTools.TabStop = false;
            this.groupBoxTools.Text = "Memory Viewer";

            //
            // buttonViewMemory
            //
            this.buttonViewMemory.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            this.buttonViewMemory.Location = new Point(15, 30);
            this.buttonViewMemory.Name = "buttonViewMemory";
            this.buttonViewMemory.Size = new Size(174, 50);
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
            this.labelMemAddress.Size = new Size(174, 30);
            this.labelMemAddress.TabIndex = 1;
            this.labelMemAddress.Text = "Optional: Jump to address\r\n(Leave empty to start at 0x0)";

            //
            // textBoxMemAddress
            //
            this.textBoxMemAddress.Font = new Font("Consolas", 10F);
            this.textBoxMemAddress.Location = new Point(15, 135);
            this.textBoxMemAddress.Name = "textBoxMemAddress";
            this.textBoxMemAddress.PlaceholderText = "e.g., 0x1A7A00";
            this.textBoxMemAddress.Size = new Size(174, 23);
            this.textBoxMemAddress.TabIndex = 2;

            //
            // MemoryManager
            //
            this.ClientSize = new Size(584, 450);
            this.Controls.Add(this.groupBoxTools);
            this.Controls.Add(this.groupBoxGames);
            this.Controls.Add(this.groupBoxConnection);
            this.Controls.Add(this.statusStrip1);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MemoryManager";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "PCSX2 Memory Explorer";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBoxConnection.ResumeLayout(false);
            this.groupBoxConnection.PerformLayout();
            this.groupBoxGames.ResumeLayout(false);
            this.groupBoxTools.ResumeLayout(false);
            this.groupBoxTools.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
