namespace PCSX2_Memory_Explorer
{
    partial class MemoryViewerForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.RichTextBox richTextBoxMemory;
        private System.Windows.Forms.CheckBox checkBoxDisplayRawAddresses;

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
            this.SuspendLayout();
            // 
            // richTextBoxMemory
            // 
            this.richTextBoxMemory.Dock = System.Windows.Forms.DockStyle.Top;
            this.richTextBoxMemory.Location = new System.Drawing.Point(0, 0);
            this.richTextBoxMemory.Margin = new System.Windows.Forms.Padding(2);
            this.richTextBoxMemory.Name = "richTextBoxMemory";
            this.richTextBoxMemory.ReadOnly = true;
            this.richTextBoxMemory.Size = new System.Drawing.Size(600, 330);
            this.richTextBoxMemory.TabIndex = 0;
            this.richTextBoxMemory.Text = "";
            // 
            // checkBoxDisplayRawAddresses
            // 
            this.checkBoxDisplayRawAddresses.AutoSize = true;
            this.checkBoxDisplayRawAddresses.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.checkBoxDisplayRawAddresses.Location = new System.Drawing.Point(0, 349);
            this.checkBoxDisplayRawAddresses.Name = "checkBoxDisplayRawAddresses";
            this.checkBoxDisplayRawAddresses.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.checkBoxDisplayRawAddresses.Size = new System.Drawing.Size(600, 17);
            this.checkBoxDisplayRawAddresses.TabIndex = 1;
            this.checkBoxDisplayRawAddresses.Text = "Display Raw Addresses";
            this.checkBoxDisplayRawAddresses.UseVisualStyleBackColor = true;
            this.checkBoxDisplayRawAddresses.CheckedChanged += new System.EventHandler(this.checkBoxDisplayRawAddresses_CheckedChanged);
            // 
            // MemoryViewerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.richTextBoxMemory);
            this.Controls.Add(this.checkBoxDisplayRawAddresses);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MemoryViewerForm";
            this.Text = "Memory Viewer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
