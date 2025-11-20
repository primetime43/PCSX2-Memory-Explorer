namespace PCSX2_Memory_Explorer
{
    partial class MemoryViewerForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.RichTextBox richTextBoxMemory;
        private System.Windows.Forms.CheckBox checkBoxDisplayRawAddresses;
        private System.Windows.Forms.TextBox textBoxAddress;
        private System.Windows.Forms.Button buttonGo;
        private System.Windows.Forms.Button buttonPrevious;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.Panel panelNavigation;
        private System.Windows.Forms.Label labelMemoryRange;

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
            this.richTextBoxMemory = new System.Windows.Forms.RichTextBox();
            this.checkBoxDisplayRawAddresses = new System.Windows.Forms.CheckBox();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.buttonGo = new System.Windows.Forms.Button();
            this.buttonPrevious = new System.Windows.Forms.Button();
            this.buttonNext = new System.Windows.Forms.Button();
            this.labelAddress = new System.Windows.Forms.Label();
            this.panelNavigation = new System.Windows.Forms.Panel();
            this.labelMemoryRange = new System.Windows.Forms.Label();
            this.panelNavigation.SuspendLayout();
            this.SuspendLayout();
            //
            // panelNavigation
            //
            this.panelNavigation.Controls.Add(this.labelAddress);
            this.panelNavigation.Controls.Add(this.textBoxAddress);
            this.panelNavigation.Controls.Add(this.buttonGo);
            this.panelNavigation.Controls.Add(this.buttonPrevious);
            this.panelNavigation.Controls.Add(this.buttonNext);
            this.panelNavigation.Controls.Add(this.labelMemoryRange);
            this.panelNavigation.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelNavigation.Location = new Point(0, 0);
            this.panelNavigation.Name = "panelNavigation";
            this.panelNavigation.Size = new Size(700, 40);
            this.panelNavigation.TabIndex = 0;
            //
            // labelAddress
            //
            this.labelAddress.AutoSize = true;
            this.labelAddress.Location = new Point(10, 13);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new Size(88, 13);
            this.labelAddress.TabIndex = 0;
            this.labelAddress.Text = "Jump to Address:";
            //
            // textBoxAddress
            //
            this.textBoxAddress.Location = new Point(105, 10);
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new Size(120, 20);
            this.textBoxAddress.TabIndex = 1;
            this.textBoxAddress.Text = "0x0";
            //
            // buttonGo
            //
            this.buttonGo.Location = new Point(230, 8);
            this.buttonGo.Name = "buttonGo";
            this.buttonGo.Size = new Size(50, 23);
            this.buttonGo.TabIndex = 2;
            this.buttonGo.Text = "Go";
            this.buttonGo.UseVisualStyleBackColor = true;
            this.buttonGo.Click += new System.EventHandler(this.buttonGo_Click);
            //
            // buttonPrevious
            //
            this.buttonPrevious.Location = new Point(290, 8);
            this.buttonPrevious.Name = "buttonPrevious";
            this.buttonPrevious.Size = new Size(75, 23);
            this.buttonPrevious.TabIndex = 3;
            this.buttonPrevious.Text = "< Previous";
            this.buttonPrevious.UseVisualStyleBackColor = true;
            this.buttonPrevious.Click += new System.EventHandler(this.buttonPrevious_Click);
            //
            // buttonNext
            //
            this.buttonNext.Location = new Point(370, 8);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new Size(75, 23);
            this.buttonNext.TabIndex = 4;
            this.buttonNext.Text = "Next >";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            //
            // richTextBoxMemory
            //
            this.richTextBoxMemory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBoxMemory.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.richTextBoxMemory.Location = new Point(0, 40);
            this.richTextBoxMemory.Margin = new System.Windows.Forms.Padding(2);
            this.richTextBoxMemory.Name = "richTextBoxMemory";
            this.richTextBoxMemory.ReadOnly = true;
            this.richTextBoxMemory.Size = new Size(700, 480);
            this.richTextBoxMemory.TabIndex = 1;
            this.richTextBoxMemory.Text = "";
            this.richTextBoxMemory.WordWrap = false;
            //
            // labelMemoryRange
            //
            this.labelMemoryRange.AutoSize = true;
            this.labelMemoryRange.Location = new Point(460, 13);
            this.labelMemoryRange.Name = "labelMemoryRange";
            this.labelMemoryRange.Size = new Size(200, 13);
            this.labelMemoryRange.TabIndex = 5;
            this.labelMemoryRange.Text = "Viewing: 0x00000000 - 0x00000200";
            //
            // checkBoxDisplayRawAddresses
            //
            this.checkBoxDisplayRawAddresses.AutoSize = true;
            this.checkBoxDisplayRawAddresses.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.checkBoxDisplayRawAddresses.Location = new Point(0, 520);
            this.checkBoxDisplayRawAddresses.Name = "checkBoxDisplayRawAddresses";
            this.checkBoxDisplayRawAddresses.Padding = new System.Windows.Forms.Padding(5, 5, 0, 5);
            this.checkBoxDisplayRawAddresses.Size = new Size(700, 27);
            this.checkBoxDisplayRawAddresses.TabIndex = 2;
            this.checkBoxDisplayRawAddresses.Text = "Display Raw Addresses (hover for info)";
            this.checkBoxDisplayRawAddresses.UseVisualStyleBackColor = true;
            this.checkBoxDisplayRawAddresses.CheckedChanged += new System.EventHandler(this.checkBoxDisplayRawAddresses_CheckedChanged);
            //
            // MemoryViewerForm
            //
            this.AutoScaleDimensions = new SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new Size(700, 547);
            this.Controls.Add(this.richTextBoxMemory);
            this.Controls.Add(this.panelNavigation);
            this.Controls.Add(this.checkBoxDisplayRawAddresses);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MemoryViewerForm";
            this.Text = "Memory Viewer";
            this.panelNavigation.ResumeLayout(false);
            this.panelNavigation.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
