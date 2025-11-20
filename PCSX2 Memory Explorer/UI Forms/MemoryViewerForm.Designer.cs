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
        private System.Windows.Forms.GroupBox groupBoxDataView;
        private System.Windows.Forms.Label labelSelectedAddress;
        private System.Windows.Forms.Label labelEndianness;
        private System.Windows.Forms.Label labelInt8;
        private System.Windows.Forms.Label labelInt16;
        private System.Windows.Forms.Label labelInt32;
        private System.Windows.Forms.Label labelInt64;
        private System.Windows.Forms.Label labelFloat;
        private System.Windows.Forms.Label labelDouble;
        private System.Windows.Forms.Label labelString;
        private System.Windows.Forms.TextBox textBoxWriteValue;
        private System.Windows.Forms.Button buttonWriteValue;
        private System.Windows.Forms.ComboBox comboBoxDataType;

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
            this.groupBoxDataView = new System.Windows.Forms.GroupBox();
            this.labelSelectedAddress = new System.Windows.Forms.Label();
            this.labelEndianness = new System.Windows.Forms.Label();
            this.labelInt8 = new System.Windows.Forms.Label();
            this.labelInt16 = new System.Windows.Forms.Label();
            this.labelInt32 = new System.Windows.Forms.Label();
            this.labelInt64 = new System.Windows.Forms.Label();
            this.labelFloat = new System.Windows.Forms.Label();
            this.labelDouble = new System.Windows.Forms.Label();
            this.labelString = new System.Windows.Forms.Label();
            this.textBoxWriteValue = new System.Windows.Forms.TextBox();
            this.buttonWriteValue = new System.Windows.Forms.Button();
            this.comboBoxDataType = new System.Windows.Forms.ComboBox();
            this.panelNavigation.SuspendLayout();
            this.groupBoxDataView.SuspendLayout();
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
            this.richTextBoxMemory.MouseUp += new System.Windows.Forms.MouseEventHandler(this.richTextBoxMemory_MouseUp);
            //
            // groupBoxDataView
            //
            this.groupBoxDataView.Controls.Add(this.labelSelectedAddress);
            this.groupBoxDataView.Controls.Add(this.labelEndianness);
            this.groupBoxDataView.Controls.Add(this.labelInt8);
            this.groupBoxDataView.Controls.Add(this.labelInt16);
            this.groupBoxDataView.Controls.Add(this.labelInt32);
            this.groupBoxDataView.Controls.Add(this.labelInt64);
            this.groupBoxDataView.Controls.Add(this.labelFloat);
            this.groupBoxDataView.Controls.Add(this.labelDouble);
            this.groupBoxDataView.Controls.Add(this.labelString);
            this.groupBoxDataView.Controls.Add(this.comboBoxDataType);
            this.groupBoxDataView.Controls.Add(this.textBoxWriteValue);
            this.groupBoxDataView.Controls.Add(this.buttonWriteValue);
            this.groupBoxDataView.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBoxDataView.Location = new Point(700, 40);
            this.groupBoxDataView.Name = "groupBoxDataView";
            this.groupBoxDataView.Size = new Size(250, 480);
            this.groupBoxDataView.TabIndex = 3;
            this.groupBoxDataView.TabStop = false;
            this.groupBoxDataView.Text = "Data Inspector";
            //
            // labelSelectedAddress
            //
            this.labelSelectedAddress.AutoSize = true;
            this.labelSelectedAddress.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            this.labelSelectedAddress.ForeColor = System.Drawing.Color.DarkBlue;
            this.labelSelectedAddress.Location = new Point(10, 25);
            this.labelSelectedAddress.Name = "labelSelectedAddress";
            this.labelSelectedAddress.Size = new Size(180, 15);
            this.labelSelectedAddress.TabIndex = 0;
            this.labelSelectedAddress.Text = "Address: (select bytes)";
            //
            // labelEndianness
            //
            this.labelEndianness.AutoSize = true;
            this.labelEndianness.Font = new Font("Consolas", 8F, FontStyle.Italic);
            this.labelEndianness.ForeColor = System.Drawing.Color.Gray;
            this.labelEndianness.Location = new Point(10, 42);
            this.labelEndianness.Name = "labelEndianness";
            this.labelEndianness.Size = new Size(140, 13);
            this.labelEndianness.TabIndex = 1;
            this.labelEndianness.Text = "Format: Little-Endian";
            //
            // labelInt8
            //
            this.labelInt8.AutoSize = true;
            this.labelInt8.Font = new Font("Consolas", 9F);
            this.labelInt8.Location = new Point(10, 65);
            this.labelInt8.Name = "labelInt8";
            this.labelInt8.Size = new Size(100, 14);
            this.labelInt8.TabIndex = 2;
            this.labelInt8.Text = "Int8:  -";
            //
            // labelInt16
            //
            this.labelInt16.AutoSize = true;
            this.labelInt16.Font = new Font("Consolas", 9F);
            this.labelInt16.Location = new Point(10, 85);
            this.labelInt16.Name = "labelInt16";
            this.labelInt16.Size = new Size(100, 14);
            this.labelInt16.TabIndex = 3;
            this.labelInt16.Text = "Int16: -";
            //
            // labelInt32
            //
            this.labelInt32.AutoSize = true;
            this.labelInt32.Font = new Font("Consolas", 9F);
            this.labelInt32.Location = new Point(10, 105);
            this.labelInt32.Name = "labelInt32";
            this.labelInt32.Size = new Size(100, 14);
            this.labelInt32.TabIndex = 4;
            this.labelInt32.Text = "Int32: -";
            //
            // labelInt64
            //
            this.labelInt64.AutoSize = true;
            this.labelInt64.Font = new Font("Consolas", 9F);
            this.labelInt64.Location = new Point(10, 125);
            this.labelInt64.Name = "labelInt64";
            this.labelInt64.Size = new Size(100, 14);
            this.labelInt64.TabIndex = 5;
            this.labelInt64.Text = "Int64: -";
            //
            // labelFloat
            //
            this.labelFloat.AutoSize = true;
            this.labelFloat.Font = new Font("Consolas", 9F);
            this.labelFloat.Location = new Point(10, 145);
            this.labelFloat.Name = "labelFloat";
            this.labelFloat.Size = new Size(100, 14);
            this.labelFloat.TabIndex = 6;
            this.labelFloat.Text = "Float: -";
            //
            // labelDouble
            //
            this.labelDouble.AutoSize = true;
            this.labelDouble.Font = new Font("Consolas", 9F);
            this.labelDouble.Location = new Point(10, 165);
            this.labelDouble.Name = "labelDouble";
            this.labelDouble.Size = new Size(100, 14);
            this.labelDouble.TabIndex = 7;
            this.labelDouble.Text = "Double: -";
            //
            // labelString
            //
            this.labelString.AutoSize = true;
            this.labelString.Font = new Font("Consolas", 9F);
            this.labelString.Location = new Point(10, 185);
            this.labelString.Name = "labelString";
            this.labelString.Size = new Size(100, 14);
            this.labelString.TabIndex = 8;
            this.labelString.Text = "String: -";
            //
            // comboBoxDataType
            //
            this.comboBoxDataType.DropDownStyle = ComboBoxStyle.DropDownList;
            this.comboBoxDataType.Items.AddRange(new object[] { "Int8", "Int16", "Int32", "Int64", "Float", "Double" });
            this.comboBoxDataType.Location = new Point(10, 220);
            this.comboBoxDataType.Name = "comboBoxDataType";
            this.comboBoxDataType.SelectedIndex = 2;
            this.comboBoxDataType.Size = new Size(230, 23);
            this.comboBoxDataType.TabIndex = 8;
            //
            // textBoxWriteValue
            //
            this.textBoxWriteValue.Font = new Font("Consolas", 9F);
            this.textBoxWriteValue.Location = new Point(10, 250);
            this.textBoxWriteValue.Name = "textBoxWriteValue";
            this.textBoxWriteValue.PlaceholderText = "Value to write";
            this.textBoxWriteValue.Size = new Size(230, 22);
            this.textBoxWriteValue.TabIndex = 9;
            //
            // buttonWriteValue
            //
            this.buttonWriteValue.Location = new Point(10, 280);
            this.buttonWriteValue.Name = "buttonWriteValue";
            this.buttonWriteValue.Size = new Size(230, 30);
            this.buttonWriteValue.TabIndex = 10;
            this.buttonWriteValue.Text = "Write to Selected Address";
            this.buttonWriteValue.UseVisualStyleBackColor = true;
            this.buttonWriteValue.Click += new System.EventHandler(this.buttonWriteValue_Click);
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
            this.ClientSize = new Size(950, 547);
            this.Controls.Add(this.richTextBoxMemory);
            this.Controls.Add(this.groupBoxDataView);
            this.Controls.Add(this.panelNavigation);
            this.Controls.Add(this.checkBoxDisplayRawAddresses);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MemoryViewerForm";
            this.Text = "Memory Viewer";
            this.panelNavigation.ResumeLayout(false);
            this.panelNavigation.PerformLayout();
            this.groupBoxDataView.ResumeLayout(false);
            this.groupBoxDataView.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
