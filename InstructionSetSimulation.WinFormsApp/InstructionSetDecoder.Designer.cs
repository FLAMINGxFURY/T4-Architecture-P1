
namespace InstructionSetSimulation.WinFormsApp
{
    partial class InstructionSetDecoder
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InstructionSetDecoder));
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.openFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.BinaryFileBox = new System.Windows.Forms.TextBox();
			this.BinaryFileBoxLabel = new System.Windows.Forms.Label();
			this.DecodedInstructionsBox = new System.Windows.Forms.TextBox();
			this.DecodedInstructionsBoxLabel = new System.Windows.Forms.Label();
			this.CXBox = new System.Windows.Forms.TextBox();
			this.DXBox = new System.Windows.Forms.TextBox();
			this.SPBox = new System.Windows.Forms.TextBox();
			this.BPBox = new System.Windows.Forms.TextBox();
			this.S0Box = new System.Windows.Forms.TextBox();
			this.S1Box = new System.Windows.Forms.TextBox();
			this.PCBox = new System.Windows.Forms.TextBox();
			this.CBox = new System.Windows.Forms.TextBox();
			this.RegistersHeaderLabel = new System.Windows.Forms.Label();
			this.NextBtn = new System.Windows.Forms.Button();
			this.BXBox = new System.Windows.Forms.TextBox();
			this.AXBox = new System.Windows.Forms.TextBox();
			this.AXLabel = new System.Windows.Forms.Label();
			this.BXLabel = new System.Windows.Forms.Label();
			this.CXLabel = new System.Windows.Forms.Label();
			this.DXLabel = new System.Windows.Forms.Label();
			this.SPLabel = new System.Windows.Forms.Label();
			this.BPLabel = new System.Windows.Forms.Label();
			this.S0Label = new System.Windows.Forms.Label();
			this.S1Label = new System.Windows.Forms.Label();
			this.PCLabel = new System.Windows.Forms.Label();
			this.CLabel = new System.Windows.Forms.Label();
			this.PLabel = new System.Windows.Forms.Label();
			this.PBox = new System.Windows.Forms.TextBox();
			this.ALabel = new System.Windows.Forms.Label();
			this.ABox = new System.Windows.Forms.TextBox();
			this.ZLabel = new System.Windows.Forms.Label();
			this.ZBox = new System.Windows.Forms.TextBox();
			this.SLabel = new System.Windows.Forms.Label();
			this.SBox = new System.Windows.Forms.TextBox();
			this.OLabel = new System.Windows.Forms.Label();
			this.OBox = new System.Windows.Forms.TextBox();
			this.txtCurrentInst = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 3, 0, 3);
			this.menuStrip1.Size = new System.Drawing.Size(671, 30);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openFileToolStripMenuItem});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
			this.fileToolStripMenuItem.Text = "File";
			// 
			// openFileToolStripMenuItem
			// 
			this.openFileToolStripMenuItem.Name = "openFileToolStripMenuItem";
			this.openFileToolStripMenuItem.Size = new System.Drawing.Size(155, 26);
			this.openFileToolStripMenuItem.Text = "Open File";
			this.openFileToolStripMenuItem.Click += new System.EventHandler(this.openFileToolStripMenuItem_Click);
			// 
			// helpToolStripMenuItem
			// 
			this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
			this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
			this.helpToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
			this.helpToolStripMenuItem.Text = "Help";
			// 
			// aboutToolStripMenuItem
			// 
			this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
			this.aboutToolStripMenuItem.Size = new System.Drawing.Size(133, 26);
			this.aboutToolStripMenuItem.Text = "About";
			this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
			// 
			// BinaryFileBox
			// 
			this.BinaryFileBox.Location = new System.Drawing.Point(14, 73);
			this.BinaryFileBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.BinaryFileBox.Multiline = true;
			this.BinaryFileBox.Name = "BinaryFileBox";
			this.BinaryFileBox.ReadOnly = true;
			this.BinaryFileBox.Size = new System.Drawing.Size(363, 255);
			this.BinaryFileBox.TabIndex = 1;
			// 
			// BinaryFileBoxLabel
			// 
			this.BinaryFileBoxLabel.AutoSize = true;
			this.BinaryFileBoxLabel.Location = new System.Drawing.Point(14, 49);
			this.BinaryFileBoxLabel.Name = "BinaryFileBoxLabel";
			this.BinaryFileBoxLabel.Size = new System.Drawing.Size(77, 20);
			this.BinaryFileBoxLabel.TabIndex = 2;
			this.BinaryFileBoxLabel.Text = "Binary File";
			// 
			// DecodedInstructionsBox
			// 
			this.DecodedInstructionsBox.AcceptsReturn = true;
			this.DecodedInstructionsBox.Location = new System.Drawing.Point(14, 379);
			this.DecodedInstructionsBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.DecodedInstructionsBox.Multiline = true;
			this.DecodedInstructionsBox.Name = "DecodedInstructionsBox";
			this.DecodedInstructionsBox.ReadOnly = true;
			this.DecodedInstructionsBox.Size = new System.Drawing.Size(363, 316);
			this.DecodedInstructionsBox.TabIndex = 3;
			this.DecodedInstructionsBox.WordWrap = false;
			// 
			// DecodedInstructionsBoxLabel
			// 
			this.DecodedInstructionsBoxLabel.AutoSize = true;
			this.DecodedInstructionsBoxLabel.Location = new System.Drawing.Point(14, 355);
			this.DecodedInstructionsBoxLabel.Name = "DecodedInstructionsBoxLabel";
			this.DecodedInstructionsBoxLabel.Size = new System.Drawing.Size(149, 20);
			this.DecodedInstructionsBoxLabel.TabIndex = 4;
			this.DecodedInstructionsBoxLabel.Text = "Decoded Instructions";
			// 
			// CXBox
			// 
			this.CXBox.Location = new System.Drawing.Point(466, 387);
			this.CXBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.CXBox.Name = "CXBox";
			this.CXBox.PlaceholderText = "0";
			this.CXBox.ReadOnly = true;
			this.CXBox.Size = new System.Drawing.Size(156, 27);
			this.CXBox.TabIndex = 5;
			this.CXBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// DXBox
			// 
			this.DXBox.Location = new System.Drawing.Point(466, 421);
			this.DXBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.DXBox.Name = "DXBox";
			this.DXBox.PlaceholderText = "0";
			this.DXBox.ReadOnly = true;
			this.DXBox.Size = new System.Drawing.Size(156, 27);
			this.DXBox.TabIndex = 6;
			this.DXBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// SPBox
			// 
			this.SPBox.Location = new System.Drawing.Point(466, 457);
			this.SPBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.SPBox.Name = "SPBox";
			this.SPBox.PlaceholderText = "0";
			this.SPBox.ReadOnly = true;
			this.SPBox.Size = new System.Drawing.Size(156, 27);
			this.SPBox.TabIndex = 7;
			this.SPBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// BPBox
			// 
			this.BPBox.Location = new System.Drawing.Point(466, 492);
			this.BPBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.BPBox.Name = "BPBox";
			this.BPBox.PlaceholderText = "0";
			this.BPBox.ReadOnly = true;
			this.BPBox.Size = new System.Drawing.Size(156, 27);
			this.BPBox.TabIndex = 8;
			this.BPBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// S0Box
			// 
			this.S0Box.Location = new System.Drawing.Point(466, 527);
			this.S0Box.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.S0Box.Name = "S0Box";
			this.S0Box.PlaceholderText = "0";
			this.S0Box.ReadOnly = true;
			this.S0Box.Size = new System.Drawing.Size(156, 27);
			this.S0Box.TabIndex = 9;
			this.S0Box.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// S1Box
			// 
			this.S1Box.Location = new System.Drawing.Point(466, 563);
			this.S1Box.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.S1Box.Name = "S1Box";
			this.S1Box.PlaceholderText = "0";
			this.S1Box.ReadOnly = true;
			this.S1Box.Size = new System.Drawing.Size(156, 27);
			this.S1Box.TabIndex = 10;
			this.S1Box.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// PCBox
			// 
			this.PCBox.Location = new System.Drawing.Point(466, 597);
			this.PCBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.PCBox.Name = "PCBox";
			this.PCBox.PlaceholderText = "0";
			this.PCBox.ReadOnly = true;
			this.PCBox.Size = new System.Drawing.Size(156, 27);
			this.PCBox.TabIndex = 11;
			this.PCBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// CBox
			// 
			this.CBox.Location = new System.Drawing.Point(466, 632);
			this.CBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.CBox.Name = "CBox";
			this.CBox.PlaceholderText = "0";
			this.CBox.ReadOnly = true;
			this.CBox.Size = new System.Drawing.Size(25, 27);
			this.CBox.TabIndex = 12;
			// 
			// RegistersHeaderLabel
			// 
			this.RegistersHeaderLabel.AutoSize = true;
			this.RegistersHeaderLabel.Location = new System.Drawing.Point(466, 276);
			this.RegistersHeaderLabel.Name = "RegistersHeaderLabel";
			this.RegistersHeaderLabel.Size = new System.Drawing.Size(69, 20);
			this.RegistersHeaderLabel.TabIndex = 13;
			this.RegistersHeaderLabel.Text = "Registers";
			// 
			// NextBtn
			// 
			this.NextBtn.Location = new System.Drawing.Point(439, 73);
			this.NextBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.NextBtn.Name = "NextBtn";
			this.NextBtn.Size = new System.Drawing.Size(184, 83);
			this.NextBtn.TabIndex = 14;
			this.NextBtn.Text = "Execute Next Instruction";
			this.NextBtn.UseVisualStyleBackColor = true;
			this.NextBtn.Click += new System.EventHandler(this.NextBtn_Click);
			// 
			// BXBox
			// 
			this.BXBox.Location = new System.Drawing.Point(466, 352);
			this.BXBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.BXBox.Name = "BXBox";
			this.BXBox.PlaceholderText = "0";
			this.BXBox.ReadOnly = true;
			this.BXBox.Size = new System.Drawing.Size(156, 27);
			this.BXBox.TabIndex = 15;
			this.BXBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// AXBox
			// 
			this.AXBox.Location = new System.Drawing.Point(466, 317);
			this.AXBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.AXBox.Name = "AXBox";
			this.AXBox.PlaceholderText = "0";
			this.AXBox.ReadOnly = true;
			this.AXBox.Size = new System.Drawing.Size(156, 27);
			this.AXBox.TabIndex = 16;
			this.AXBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// AXLabel
			// 
			this.AXLabel.AutoSize = true;
			this.AXLabel.Location = new System.Drawing.Point(432, 324);
			this.AXLabel.Name = "AXLabel";
			this.AXLabel.Size = new System.Drawing.Size(28, 20);
			this.AXLabel.TabIndex = 17;
			this.AXLabel.Text = "AX";
			// 
			// BXLabel
			// 
			this.BXLabel.AutoSize = true;
			this.BXLabel.Location = new System.Drawing.Point(432, 359);
			this.BXLabel.Name = "BXLabel";
			this.BXLabel.Size = new System.Drawing.Size(27, 20);
			this.BXLabel.TabIndex = 18;
			this.BXLabel.Text = "BX";
			// 
			// CXLabel
			// 
			this.CXLabel.AutoSize = true;
			this.CXLabel.Location = new System.Drawing.Point(432, 395);
			this.CXLabel.Name = "CXLabel";
			this.CXLabel.Size = new System.Drawing.Size(27, 20);
			this.CXLabel.TabIndex = 19;
			this.CXLabel.Text = "CX";
			// 
			// DXLabel
			// 
			this.DXLabel.AutoSize = true;
			this.DXLabel.Location = new System.Drawing.Point(432, 429);
			this.DXLabel.Name = "DXLabel";
			this.DXLabel.Size = new System.Drawing.Size(29, 20);
			this.DXLabel.TabIndex = 20;
			this.DXLabel.Text = "DX";
			// 
			// SPLabel
			// 
			this.SPLabel.AutoSize = true;
			this.SPLabel.Location = new System.Drawing.Point(432, 464);
			this.SPLabel.Name = "SPLabel";
			this.SPLabel.Size = new System.Drawing.Size(25, 20);
			this.SPLabel.TabIndex = 21;
			this.SPLabel.Text = "SP";
			// 
			// BPLabel
			// 
			this.BPLabel.AutoSize = true;
			this.BPLabel.Location = new System.Drawing.Point(432, 499);
			this.BPLabel.Name = "BPLabel";
			this.BPLabel.Size = new System.Drawing.Size(26, 20);
			this.BPLabel.TabIndex = 22;
			this.BPLabel.Text = "BP";
			// 
			// S0Label
			// 
			this.S0Label.AutoSize = true;
			this.S0Label.Location = new System.Drawing.Point(432, 533);
			this.S0Label.Name = "S0Label";
			this.S0Label.Size = new System.Drawing.Size(25, 20);
			this.S0Label.TabIndex = 23;
			this.S0Label.Text = "S0";
			// 
			// S1Label
			// 
			this.S1Label.AutoSize = true;
			this.S1Label.Location = new System.Drawing.Point(432, 569);
			this.S1Label.Name = "S1Label";
			this.S1Label.Size = new System.Drawing.Size(25, 20);
			this.S1Label.TabIndex = 24;
			this.S1Label.Text = "S1";
			// 
			// PCLabel
			// 
			this.PCLabel.AutoSize = true;
			this.PCLabel.Location = new System.Drawing.Point(432, 604);
			this.PCLabel.Name = "PCLabel";
			this.PCLabel.Size = new System.Drawing.Size(26, 20);
			this.PCLabel.TabIndex = 25;
			this.PCLabel.Text = "PC";
			// 
			// CLabel
			// 
			this.CLabel.AutoSize = true;
			this.CLabel.Location = new System.Drawing.Point(439, 639);
			this.CLabel.Name = "CLabel";
			this.CLabel.Size = new System.Drawing.Size(18, 20);
			this.CLabel.TabIndex = 26;
			this.CLabel.Text = "C";
			// 
			// PLabel
			// 
			this.PLabel.AutoSize = true;
			this.PLabel.Location = new System.Drawing.Point(503, 639);
			this.PLabel.Name = "PLabel";
			this.PLabel.Size = new System.Drawing.Size(17, 20);
			this.PLabel.TabIndex = 28;
			this.PLabel.Text = "P";
			// 
			// PBox
			// 
			this.PBox.Location = new System.Drawing.Point(530, 632);
			this.PBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.PBox.Name = "PBox";
			this.PBox.PlaceholderText = "0";
			this.PBox.ReadOnly = true;
			this.PBox.Size = new System.Drawing.Size(25, 27);
			this.PBox.TabIndex = 27;
			// 
			// ALabel
			// 
			this.ALabel.AutoSize = true;
			this.ALabel.Location = new System.Drawing.Point(570, 639);
			this.ALabel.Name = "ALabel";
			this.ALabel.Size = new System.Drawing.Size(19, 20);
			this.ALabel.TabIndex = 30;
			this.ALabel.Text = "A";
			// 
			// ABox
			// 
			this.ABox.Location = new System.Drawing.Point(597, 632);
			this.ABox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.ABox.Name = "ABox";
			this.ABox.PlaceholderText = "0";
			this.ABox.ReadOnly = true;
			this.ABox.Size = new System.Drawing.Size(25, 27);
			this.ABox.TabIndex = 29;
			// 
			// ZLabel
			// 
			this.ZLabel.AutoSize = true;
			this.ZLabel.Location = new System.Drawing.Point(439, 675);
			this.ZLabel.Name = "ZLabel";
			this.ZLabel.Size = new System.Drawing.Size(18, 20);
			this.ZLabel.TabIndex = 32;
			this.ZLabel.Text = "Z";
			// 
			// ZBox
			// 
			this.ZBox.Location = new System.Drawing.Point(466, 667);
			this.ZBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.ZBox.Name = "ZBox";
			this.ZBox.PlaceholderText = "0";
			this.ZBox.ReadOnly = true;
			this.ZBox.Size = new System.Drawing.Size(25, 27);
			this.ZBox.TabIndex = 31;
			// 
			// SLabel
			// 
			this.SLabel.AutoSize = true;
			this.SLabel.Location = new System.Drawing.Point(503, 675);
			this.SLabel.Name = "SLabel";
			this.SLabel.Size = new System.Drawing.Size(17, 20);
			this.SLabel.TabIndex = 34;
			this.SLabel.Text = "S";
			// 
			// SBox
			// 
			this.SBox.Location = new System.Drawing.Point(530, 667);
			this.SBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.SBox.Name = "SBox";
			this.SBox.PlaceholderText = "0";
			this.SBox.ReadOnly = true;
			this.SBox.Size = new System.Drawing.Size(25, 27);
			this.SBox.TabIndex = 33;
			// 
			// OLabel
			// 
			this.OLabel.AutoSize = true;
			this.OLabel.Location = new System.Drawing.Point(570, 675);
			this.OLabel.Name = "OLabel";
			this.OLabel.Size = new System.Drawing.Size(20, 20);
			this.OLabel.TabIndex = 36;
			this.OLabel.Text = "O";
			// 
			// OBox
			// 
			this.OBox.Location = new System.Drawing.Point(597, 667);
			this.OBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.OBox.Name = "OBox";
			this.OBox.PlaceholderText = "0";
			this.OBox.ReadOnly = true;
			this.OBox.Size = new System.Drawing.Size(25, 27);
			this.OBox.TabIndex = 35;
			// 
			// txtCurrentInst
			// 
			this.txtCurrentInst.AcceptsReturn = true;
			this.txtCurrentInst.Location = new System.Drawing.Point(465, 221);
			this.txtCurrentInst.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.txtCurrentInst.Multiline = true;
			this.txtCurrentInst.Name = "txtCurrentInst";
			this.txtCurrentInst.ReadOnly = true;
			this.txtCurrentInst.Size = new System.Drawing.Size(156, 29);
			this.txtCurrentInst.TabIndex = 37;
			this.txtCurrentInst.WordWrap = false;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(466, 180);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(133, 20);
			this.label1.TabIndex = 38;
			this.label1.Text = "Current Instruction:";
			// 
			// InstructionSetDecoder
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(671, 739);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtCurrentInst);
			this.Controls.Add(this.OLabel);
			this.Controls.Add(this.OBox);
			this.Controls.Add(this.SLabel);
			this.Controls.Add(this.SBox);
			this.Controls.Add(this.ZLabel);
			this.Controls.Add(this.ZBox);
			this.Controls.Add(this.ALabel);
			this.Controls.Add(this.ABox);
			this.Controls.Add(this.PLabel);
			this.Controls.Add(this.PBox);
			this.Controls.Add(this.CLabel);
			this.Controls.Add(this.PCLabel);
			this.Controls.Add(this.S1Label);
			this.Controls.Add(this.S0Label);
			this.Controls.Add(this.BPLabel);
			this.Controls.Add(this.SPLabel);
			this.Controls.Add(this.DXLabel);
			this.Controls.Add(this.CXLabel);
			this.Controls.Add(this.BXLabel);
			this.Controls.Add(this.AXLabel);
			this.Controls.Add(this.AXBox);
			this.Controls.Add(this.BXBox);
			this.Controls.Add(this.NextBtn);
			this.Controls.Add(this.RegistersHeaderLabel);
			this.Controls.Add(this.CBox);
			this.Controls.Add(this.PCBox);
			this.Controls.Add(this.S1Box);
			this.Controls.Add(this.S0Box);
			this.Controls.Add(this.BPBox);
			this.Controls.Add(this.SPBox);
			this.Controls.Add(this.DXBox);
			this.Controls.Add(this.CXBox);
			this.Controls.Add(this.DecodedInstructionsBoxLabel);
			this.Controls.Add(this.DecodedInstructionsBox);
			this.Controls.Add(this.BinaryFileBoxLabel);
			this.Controls.Add(this.BinaryFileBox);
			this.Controls.Add(this.menuStrip1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.menuStrip1;
			this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.Name = "InstructionSetDecoder";
			this.Text = "Instruction Set Decoder";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.TextBox BinaryFileBox;
        private System.Windows.Forms.Label BinaryFileBoxLabel;
        private System.Windows.Forms.TextBox DecodedInstructionsBox;
        private System.Windows.Forms.Label DecodedInstructionsBoxLabel;
        private System.Windows.Forms.TextBox CXBox;
        private System.Windows.Forms.TextBox DXBox;
        private System.Windows.Forms.TextBox SPBox;
        private System.Windows.Forms.TextBox BPBox;
        private System.Windows.Forms.TextBox S0Box;
        private System.Windows.Forms.TextBox S1Box;
        private System.Windows.Forms.TextBox PCBox;
        private System.Windows.Forms.TextBox CBox;
        private System.Windows.Forms.Label RegistersHeaderLabel;
        private System.Windows.Forms.Button NextBtn;
		private System.Windows.Forms.TextBox BXBox;
		private System.Windows.Forms.TextBox AXBox;
		private System.Windows.Forms.Label AXLabel;
		private System.Windows.Forms.Label BXLabel;
		private System.Windows.Forms.Label CXLabel;
		private System.Windows.Forms.Label DXLabel;
		private System.Windows.Forms.Label SPLabel;
		private System.Windows.Forms.Label BPLabel;
		private System.Windows.Forms.Label S0Label;
		private System.Windows.Forms.Label S1Label;
		private System.Windows.Forms.Label PCLabel;
		private System.Windows.Forms.Label CLabel;
		private System.Windows.Forms.Label PLabel;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label ALabel;
		private System.Windows.Forms.TextBox ABox;
		private System.Windows.Forms.Label ZLabel;
		private System.Windows.Forms.TextBox ZBox;
		private System.Windows.Forms.Label SLabel;
		private System.Windows.Forms.TextBox SBox;
		private System.Windows.Forms.Label OLabel;
		private System.Windows.Forms.TextBox OBox;
		private System.Windows.Forms.TextBox PBox;
        private System.Windows.Forms.TextBox txtCurrentInst;
        private System.Windows.Forms.Label label1;
    }
}

