namespace MemoryAllocation
{
    partial class MemoryAllocation
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.HolesGroupBox = new System.Windows.Forms.GroupBox();
            this.NumberOfHolesLabel = new System.Windows.Forms.Label();
            this.HoleFinish = new System.Windows.Forms.Button();
            this.AddHole = new System.Windows.Forms.Button();
            this.HoleAddressTextBox = new System.Windows.Forms.TextBox();
            this.HoleSizeTextBox = new System.Windows.Forms.TextBox();
            this.HoleAddressLabel = new System.Windows.Forms.Label();
            this.HoleSizeLabel = new System.Windows.Forms.Label();
            this.NumberOfProcessesGroupBox = new System.Windows.Forms.GroupBox();
            this.NumberOfProcessesTextBox = new System.Windows.Forms.TextBox();
            this.NumberOfProcessesFinish = new System.Windows.Forms.Button();
            this.NumberOfProcessesLabel = new System.Windows.Forms.Label();
            this.ProcessesGroupBox = new System.Windows.Forms.GroupBox();
            this.AddProcessButton = new System.Windows.Forms.Button();
            this.ProcessSizeTextBox = new System.Windows.Forms.TextBox();
            this.ProcessNameTextBox = new System.Windows.Forms.TextBox();
            this.ProcessSizeLabel = new System.Windows.Forms.Label();
            this.ProcessName = new System.Windows.Forms.Label();
            this.MethodOfAllocationGroupBox = new System.Windows.Forms.GroupBox();
            this.Test = new System.Windows.Forms.Label();
            this.MethodOfAllocationButton = new System.Windows.Forms.Button();
            this.BestFitRadioButton = new System.Windows.Forms.RadioButton();
            this.FirstFitRadioButton = new System.Windows.Forms.RadioButton();
            this.ScreeningTextBox = new System.Windows.Forms.TextBox();
            this.ScreeningGroupBox = new System.Windows.Forms.GroupBox();
            this.DeAllocationGroupBox = new System.Windows.Forms.GroupBox();
            this.DeAllocationButton = new System.Windows.Forms.Button();
            this.ProcessToBeAllocatedNameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.AllocationGroupBox = new System.Windows.Forms.GroupBox();
            this.AllocationButton = new System.Windows.Forms.Button();
            this.ProcessSizeAllocationTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ProcessNameAllocationTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CompactionGroupBox = new System.Windows.Forms.GroupBox();
            this.CompactionModeLabel = new System.Windows.Forms.Label();
            this.CompactionModeButton = new System.Windows.Forms.Button();
            this.CompactionModeOFFRadio = new System.Windows.Forms.RadioButton();
            this.CompactionModeONRadio = new System.Windows.Forms.RadioButton();
            this.HolesGroupBox.SuspendLayout();
            this.NumberOfProcessesGroupBox.SuspendLayout();
            this.ProcessesGroupBox.SuspendLayout();
            this.MethodOfAllocationGroupBox.SuspendLayout();
            this.ScreeningGroupBox.SuspendLayout();
            this.DeAllocationGroupBox.SuspendLayout();
            this.AllocationGroupBox.SuspendLayout();
            this.CompactionGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // HolesGroupBox
            // 
            this.HolesGroupBox.Controls.Add(this.NumberOfHolesLabel);
            this.HolesGroupBox.Controls.Add(this.HoleFinish);
            this.HolesGroupBox.Controls.Add(this.AddHole);
            this.HolesGroupBox.Controls.Add(this.HoleAddressTextBox);
            this.HolesGroupBox.Controls.Add(this.HoleSizeTextBox);
            this.HolesGroupBox.Controls.Add(this.HoleAddressLabel);
            this.HolesGroupBox.Controls.Add(this.HoleSizeLabel);
            this.HolesGroupBox.Location = new System.Drawing.Point(12, 12);
            this.HolesGroupBox.Name = "HolesGroupBox";
            this.HolesGroupBox.Size = new System.Drawing.Size(541, 136);
            this.HolesGroupBox.TabIndex = 0;
            this.HolesGroupBox.TabStop = false;
            this.HolesGroupBox.Text = "Holes";
            this.HolesGroupBox.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // NumberOfHolesLabel
            // 
            this.NumberOfHolesLabel.AutoSize = true;
            this.NumberOfHolesLabel.Location = new System.Drawing.Point(454, 98);
            this.NumberOfHolesLabel.Name = "NumberOfHolesLabel";
            this.NumberOfHolesLabel.Size = new System.Drawing.Size(16, 17);
            this.NumberOfHolesLabel.TabIndex = 3;
            this.NumberOfHolesLabel.Text = "0";
            this.NumberOfHolesLabel.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // HoleFinish
            // 
            this.HoleFinish.Location = new System.Drawing.Point(274, 89);
            this.HoleFinish.Name = "HoleFinish";
            this.HoleFinish.Size = new System.Drawing.Size(102, 35);
            this.HoleFinish.TabIndex = 4;
            this.HoleFinish.Text = "Finish";
            this.HoleFinish.UseVisualStyleBackColor = true;
            this.HoleFinish.Click += new System.EventHandler(this.HoleFinish_Click);
            // 
            // AddHole
            // 
            this.AddHole.Location = new System.Drawing.Point(125, 89);
            this.AddHole.Name = "AddHole";
            this.AddHole.Size = new System.Drawing.Size(100, 35);
            this.AddHole.TabIndex = 0;
            this.AddHole.Text = "Add Hole";
            this.AddHole.UseVisualStyleBackColor = true;
            this.AddHole.Click += new System.EventHandler(this.AddHole_Click);
            // 
            // HoleAddressTextBox
            // 
            this.HoleAddressTextBox.Location = new System.Drawing.Point(370, 51);
            this.HoleAddressTextBox.Name = "HoleAddressTextBox";
            this.HoleAddressTextBox.Size = new System.Drawing.Size(100, 24);
            this.HoleAddressTextBox.TabIndex = 3;
            this.HoleAddressTextBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // HoleSizeTextBox
            // 
            this.HoleSizeTextBox.Location = new System.Drawing.Point(105, 48);
            this.HoleSizeTextBox.Name = "HoleSizeTextBox";
            this.HoleSizeTextBox.Size = new System.Drawing.Size(100, 24);
            this.HoleSizeTextBox.TabIndex = 2;
            // 
            // HoleAddressLabel
            // 
            this.HoleAddressLabel.AutoSize = true;
            this.HoleAddressLabel.Location = new System.Drawing.Point(248, 51);
            this.HoleAddressLabel.Name = "HoleAddressLabel";
            this.HoleAddressLabel.Size = new System.Drawing.Size(86, 17);
            this.HoleAddressLabel.TabIndex = 1;
            this.HoleAddressLabel.Text = "Hole Address";
            // 
            // HoleSizeLabel
            // 
            this.HoleSizeLabel.AutoSize = true;
            this.HoleSizeLabel.Location = new System.Drawing.Point(18, 48);
            this.HoleSizeLabel.Name = "HoleSizeLabel";
            this.HoleSizeLabel.Size = new System.Drawing.Size(61, 17);
            this.HoleSizeLabel.TabIndex = 0;
            this.HoleSizeLabel.Text = "Hole Size";
            // 
            // NumberOfProcessesGroupBox
            // 
            this.NumberOfProcessesGroupBox.Controls.Add(this.NumberOfProcessesTextBox);
            this.NumberOfProcessesGroupBox.Controls.Add(this.NumberOfProcessesFinish);
            this.NumberOfProcessesGroupBox.Controls.Add(this.NumberOfProcessesLabel);
            this.NumberOfProcessesGroupBox.Location = new System.Drawing.Point(12, 221);
            this.NumberOfProcessesGroupBox.Name = "NumberOfProcessesGroupBox";
            this.NumberOfProcessesGroupBox.Size = new System.Drawing.Size(541, 90);
            this.NumberOfProcessesGroupBox.TabIndex = 1;
            this.NumberOfProcessesGroupBox.TabStop = false;
            this.NumberOfProcessesGroupBox.Text = "Number of Process";
            // 
            // NumberOfProcessesTextBox
            // 
            this.NumberOfProcessesTextBox.Location = new System.Drawing.Point(296, 38);
            this.NumberOfProcessesTextBox.Name = "NumberOfProcessesTextBox";
            this.NumberOfProcessesTextBox.Size = new System.Drawing.Size(100, 24);
            this.NumberOfProcessesTextBox.TabIndex = 2;
            // 
            // NumberOfProcessesFinish
            // 
            this.NumberOfProcessesFinish.Location = new System.Drawing.Point(427, 36);
            this.NumberOfProcessesFinish.Name = "NumberOfProcessesFinish";
            this.NumberOfProcessesFinish.Size = new System.Drawing.Size(87, 27);
            this.NumberOfProcessesFinish.TabIndex = 1;
            this.NumberOfProcessesFinish.Text = "Finish";
            this.NumberOfProcessesFinish.UseVisualStyleBackColor = true;
            this.NumberOfProcessesFinish.Click += new System.EventHandler(this.NumberOfProcessesFinish_Click);
            // 
            // NumberOfProcessesLabel
            // 
            this.NumberOfProcessesLabel.AutoSize = true;
            this.NumberOfProcessesLabel.Location = new System.Drawing.Point(18, 41);
            this.NumberOfProcessesLabel.Name = "NumberOfProcessesLabel";
            this.NumberOfProcessesLabel.Size = new System.Drawing.Size(238, 17);
            this.NumberOfProcessesLabel.TabIndex = 0;
            this.NumberOfProcessesLabel.Text = "Please Enter the number of processes";
            // 
            // ProcessesGroupBox
            // 
            this.ProcessesGroupBox.Controls.Add(this.AddProcessButton);
            this.ProcessesGroupBox.Controls.Add(this.ProcessSizeTextBox);
            this.ProcessesGroupBox.Controls.Add(this.ProcessNameTextBox);
            this.ProcessesGroupBox.Controls.Add(this.ProcessSizeLabel);
            this.ProcessesGroupBox.Controls.Add(this.ProcessName);
            this.ProcessesGroupBox.Location = new System.Drawing.Point(12, 317);
            this.ProcessesGroupBox.Name = "ProcessesGroupBox";
            this.ProcessesGroupBox.Size = new System.Drawing.Size(541, 138);
            this.ProcessesGroupBox.TabIndex = 1;
            this.ProcessesGroupBox.TabStop = false;
            this.ProcessesGroupBox.Text = "Processes";
            // 
            // AddProcessButton
            // 
            this.AddProcessButton.Location = new System.Drawing.Point(199, 93);
            this.AddProcessButton.Name = "AddProcessButton";
            this.AddProcessButton.Size = new System.Drawing.Size(100, 35);
            this.AddProcessButton.TabIndex = 4;
            this.AddProcessButton.Text = "Add Process";
            this.AddProcessButton.UseVisualStyleBackColor = true;
            this.AddProcessButton.Click += new System.EventHandler(this.AddProcessButton_Click);
            // 
            // ProcessSizeTextBox
            // 
            this.ProcessSizeTextBox.Location = new System.Drawing.Point(347, 45);
            this.ProcessSizeTextBox.Name = "ProcessSizeTextBox";
            this.ProcessSizeTextBox.Size = new System.Drawing.Size(100, 24);
            this.ProcessSizeTextBox.TabIndex = 8;
            this.ProcessSizeTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // ProcessNameTextBox
            // 
            this.ProcessNameTextBox.Location = new System.Drawing.Point(125, 45);
            this.ProcessNameTextBox.Name = "ProcessNameTextBox";
            this.ProcessNameTextBox.Size = new System.Drawing.Size(100, 24);
            this.ProcessNameTextBox.TabIndex = 7;
            // 
            // ProcessSizeLabel
            // 
            this.ProcessSizeLabel.AutoSize = true;
            this.ProcessSizeLabel.Location = new System.Drawing.Point(248, 48);
            this.ProcessSizeLabel.Name = "ProcessSizeLabel";
            this.ProcessSizeLabel.Size = new System.Drawing.Size(82, 17);
            this.ProcessSizeLabel.TabIndex = 6;
            this.ProcessSizeLabel.Text = "Process Size";
            this.ProcessSizeLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // ProcessName
            // 
            this.ProcessName.AutoSize = true;
            this.ProcessName.Location = new System.Drawing.Point(18, 48);
            this.ProcessName.Name = "ProcessName";
            this.ProcessName.Size = new System.Drawing.Size(94, 17);
            this.ProcessName.TabIndex = 5;
            this.ProcessName.Text = "Process Name";
            // 
            // MethodOfAllocationGroupBox
            // 
            this.MethodOfAllocationGroupBox.Controls.Add(this.Test);
            this.MethodOfAllocationGroupBox.Controls.Add(this.MethodOfAllocationButton);
            this.MethodOfAllocationGroupBox.Controls.Add(this.BestFitRadioButton);
            this.MethodOfAllocationGroupBox.Controls.Add(this.FirstFitRadioButton);
            this.MethodOfAllocationGroupBox.Location = new System.Drawing.Point(12, 461);
            this.MethodOfAllocationGroupBox.Name = "MethodOfAllocationGroupBox";
            this.MethodOfAllocationGroupBox.Size = new System.Drawing.Size(541, 80);
            this.MethodOfAllocationGroupBox.TabIndex = 1;
            this.MethodOfAllocationGroupBox.TabStop = false;
            this.MethodOfAllocationGroupBox.Text = "Method Of Allocation";
            // 
            // Test
            // 
            this.Test.AutoSize = true;
            this.Test.Location = new System.Drawing.Point(454, 44);
            this.Test.Name = "Test";
            this.Test.Size = new System.Drawing.Size(54, 17);
            this.Test.TabIndex = 3;
            this.Test.Text = "Method";
            // 
            // MethodOfAllocationButton
            // 
            this.MethodOfAllocationButton.BackColor = System.Drawing.Color.Lavender;
            this.MethodOfAllocationButton.Location = new System.Drawing.Point(303, 36);
            this.MethodOfAllocationButton.Name = "MethodOfAllocationButton";
            this.MethodOfAllocationButton.Size = new System.Drawing.Size(144, 29);
            this.MethodOfAllocationButton.TabIndex = 2;
            this.MethodOfAllocationButton.Text = "Start Allocation";
            this.MethodOfAllocationButton.UseVisualStyleBackColor = false;
            this.MethodOfAllocationButton.Click += new System.EventHandler(this.MethodOfAllocationButton_Click);
            // 
            // BestFitRadioButton
            // 
            this.BestFitRadioButton.AutoSize = true;
            this.BestFitRadioButton.Location = new System.Drawing.Point(199, 40);
            this.BestFitRadioButton.Name = "BestFitRadioButton";
            this.BestFitRadioButton.Size = new System.Drawing.Size(73, 21);
            this.BestFitRadioButton.TabIndex = 1;
            this.BestFitRadioButton.TabStop = true;
            this.BestFitRadioButton.Text = "Best Fit";
            this.BestFitRadioButton.UseVisualStyleBackColor = true;
            this.BestFitRadioButton.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // FirstFitRadioButton
            // 
            this.FirstFitRadioButton.AutoSize = true;
            this.FirstFitRadioButton.Location = new System.Drawing.Point(21, 40);
            this.FirstFitRadioButton.Name = "FirstFitRadioButton";
            this.FirstFitRadioButton.Size = new System.Drawing.Size(72, 21);
            this.FirstFitRadioButton.TabIndex = 0;
            this.FirstFitRadioButton.TabStop = true;
            this.FirstFitRadioButton.Text = "First Fit";
            this.FirstFitRadioButton.UseVisualStyleBackColor = true;
            // 
            // ScreeningTextBox
            // 
            this.ScreeningTextBox.Location = new System.Drawing.Point(6, 22);
            this.ScreeningTextBox.Multiline = true;
            this.ScreeningTextBox.Name = "ScreeningTextBox";
            this.ScreeningTextBox.Size = new System.Drawing.Size(528, 676);
            this.ScreeningTextBox.TabIndex = 0;
            // 
            // ScreeningGroupBox
            // 
            this.ScreeningGroupBox.Controls.Add(this.ScreeningTextBox);
            this.ScreeningGroupBox.Location = new System.Drawing.Point(569, 12);
            this.ScreeningGroupBox.Name = "ScreeningGroupBox";
            this.ScreeningGroupBox.Size = new System.Drawing.Size(540, 706);
            this.ScreeningGroupBox.TabIndex = 4;
            this.ScreeningGroupBox.TabStop = false;
            this.ScreeningGroupBox.Text = "Screening";
            this.ScreeningGroupBox.Enter += new System.EventHandler(this.ScreeningGroupBox_Enter);
            // 
            // DeAllocationGroupBox
            // 
            this.DeAllocationGroupBox.Controls.Add(this.DeAllocationButton);
            this.DeAllocationGroupBox.Controls.Add(this.ProcessToBeAllocatedNameTextBox);
            this.DeAllocationGroupBox.Controls.Add(this.label1);
            this.DeAllocationGroupBox.Location = new System.Drawing.Point(13, 547);
            this.DeAllocationGroupBox.Name = "DeAllocationGroupBox";
            this.DeAllocationGroupBox.Size = new System.Drawing.Size(540, 69);
            this.DeAllocationGroupBox.TabIndex = 5;
            this.DeAllocationGroupBox.TabStop = false;
            this.DeAllocationGroupBox.Text = "De-Allocation";
            // 
            // DeAllocationButton
            // 
            this.DeAllocationButton.Location = new System.Drawing.Point(346, 28);
            this.DeAllocationButton.Name = "DeAllocationButton";
            this.DeAllocationButton.Size = new System.Drawing.Size(100, 27);
            this.DeAllocationButton.TabIndex = 2;
            this.DeAllocationButton.Text = "De-Allocate";
            this.DeAllocationButton.UseVisualStyleBackColor = true;
            this.DeAllocationButton.Click += new System.EventHandler(this.DeAllocationButton_Click);
            // 
            // ProcessToBeAllocatedNameTextBox
            // 
            this.ProcessToBeAllocatedNameTextBox.Location = new System.Drawing.Point(198, 31);
            this.ProcessToBeAllocatedNameTextBox.Name = "ProcessToBeAllocatedNameTextBox";
            this.ProcessToBeAllocatedNameTextBox.Size = new System.Drawing.Size(100, 24);
            this.ProcessToBeAllocatedNameTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Process To Be Allocated";
            // 
            // AllocationGroupBox
            // 
            this.AllocationGroupBox.Controls.Add(this.AllocationButton);
            this.AllocationGroupBox.Controls.Add(this.ProcessSizeAllocationTextBox);
            this.AllocationGroupBox.Controls.Add(this.label3);
            this.AllocationGroupBox.Controls.Add(this.ProcessNameAllocationTextBox);
            this.AllocationGroupBox.Controls.Add(this.label2);
            this.AllocationGroupBox.Location = new System.Drawing.Point(12, 622);
            this.AllocationGroupBox.Name = "AllocationGroupBox";
            this.AllocationGroupBox.Size = new System.Drawing.Size(541, 96);
            this.AllocationGroupBox.TabIndex = 3;
            this.AllocationGroupBox.TabStop = false;
            this.AllocationGroupBox.Text = "Allocation";
            // 
            // AllocationButton
            // 
            this.AllocationButton.Location = new System.Drawing.Point(199, 57);
            this.AllocationButton.Name = "AllocationButton";
            this.AllocationButton.Size = new System.Drawing.Size(112, 33);
            this.AllocationButton.TabIndex = 11;
            this.AllocationButton.Text = "Allocate";
            this.AllocationButton.UseVisualStyleBackColor = true;
            this.AllocationButton.Click += new System.EventHandler(this.AllocationButton_Click);
            // 
            // ProcessSizeAllocationTextBox
            // 
            this.ProcessSizeAllocationTextBox.Location = new System.Drawing.Point(347, 30);
            this.ProcessSizeAllocationTextBox.Name = "ProcessSizeAllocationTextBox";
            this.ProcessSizeAllocationTextBox.Size = new System.Drawing.Size(100, 24);
            this.ProcessSizeAllocationTextBox.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(248, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Process Size";
            // 
            // ProcessNameAllocationTextBox
            // 
            this.ProcessNameAllocationTextBox.Location = new System.Drawing.Point(125, 30);
            this.ProcessNameAllocationTextBox.Name = "ProcessNameAllocationTextBox";
            this.ProcessNameAllocationTextBox.Size = new System.Drawing.Size(100, 24);
            this.ProcessNameAllocationTextBox.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Process Name";
            // 
            // CompactionGroupBox
            // 
            this.CompactionGroupBox.Controls.Add(this.CompactionModeLabel);
            this.CompactionGroupBox.Controls.Add(this.CompactionModeButton);
            this.CompactionGroupBox.Controls.Add(this.CompactionModeOFFRadio);
            this.CompactionGroupBox.Controls.Add(this.CompactionModeONRadio);
            this.CompactionGroupBox.Location = new System.Drawing.Point(13, 155);
            this.CompactionGroupBox.Name = "CompactionGroupBox";
            this.CompactionGroupBox.Size = new System.Drawing.Size(540, 60);
            this.CompactionGroupBox.TabIndex = 6;
            this.CompactionGroupBox.TabStop = false;
            this.CompactionGroupBox.Text = "Compaction Mode";
            // 
            // CompactionModeLabel
            // 
            this.CompactionModeLabel.AutoSize = true;
            this.CompactionModeLabel.Location = new System.Drawing.Point(390, 30);
            this.CompactionModeLabel.Name = "CompactionModeLabel";
            this.CompactionModeLabel.Size = new System.Drawing.Size(41, 17);
            this.CompactionModeLabel.TabIndex = 3;
            this.CompactionModeLabel.Text = "Mode";
            // 
            // CompactionModeButton
            // 
            this.CompactionModeButton.Location = new System.Drawing.Point(231, 23);
            this.CompactionModeButton.Name = "CompactionModeButton";
            this.CompactionModeButton.Size = new System.Drawing.Size(144, 31);
            this.CompactionModeButton.TabIndex = 2;
            this.CompactionModeButton.Text = "Choose Mode";
            this.CompactionModeButton.UseVisualStyleBackColor = true;
            this.CompactionModeButton.Click += new System.EventHandler(this.CompactionModeButton_Click);
            // 
            // CompactionModeOFFRadio
            // 
            this.CompactionModeOFFRadio.AutoSize = true;
            this.CompactionModeOFFRadio.Location = new System.Drawing.Point(142, 23);
            this.CompactionModeOFFRadio.Name = "CompactionModeOFFRadio";
            this.CompactionModeOFFRadio.Size = new System.Drawing.Size(53, 21);
            this.CompactionModeOFFRadio.TabIndex = 1;
            this.CompactionModeOFFRadio.TabStop = true;
            this.CompactionModeOFFRadio.Text = "OFF";
            this.CompactionModeOFFRadio.UseVisualStyleBackColor = true;
            // 
            // CompactionModeONRadio
            // 
            this.CompactionModeONRadio.AutoSize = true;
            this.CompactionModeONRadio.Location = new System.Drawing.Point(33, 24);
            this.CompactionModeONRadio.Name = "CompactionModeONRadio";
            this.CompactionModeONRadio.Size = new System.Drawing.Size(48, 21);
            this.CompactionModeONRadio.TabIndex = 0;
            this.CompactionModeONRadio.TabStop = true;
            this.CompactionModeONRadio.Text = "ON";
            this.CompactionModeONRadio.UseVisualStyleBackColor = true;
            // 
            // MemoryAllocation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(1121, 732);
            this.Controls.Add(this.CompactionGroupBox);
            this.Controls.Add(this.AllocationGroupBox);
            this.Controls.Add(this.DeAllocationGroupBox);
            this.Controls.Add(this.ScreeningGroupBox);
            this.Controls.Add(this.NumberOfProcessesGroupBox);
            this.Controls.Add(this.ProcessesGroupBox);
            this.Controls.Add(this.MethodOfAllocationGroupBox);
            this.Controls.Add(this.HolesGroupBox);
            this.Name = "MemoryAllocation";
            this.Text = "MemoryAllocation";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.HolesGroupBox.ResumeLayout(false);
            this.HolesGroupBox.PerformLayout();
            this.NumberOfProcessesGroupBox.ResumeLayout(false);
            this.NumberOfProcessesGroupBox.PerformLayout();
            this.ProcessesGroupBox.ResumeLayout(false);
            this.ProcessesGroupBox.PerformLayout();
            this.MethodOfAllocationGroupBox.ResumeLayout(false);
            this.MethodOfAllocationGroupBox.PerformLayout();
            this.ScreeningGroupBox.ResumeLayout(false);
            this.ScreeningGroupBox.PerformLayout();
            this.DeAllocationGroupBox.ResumeLayout(false);
            this.DeAllocationGroupBox.PerformLayout();
            this.AllocationGroupBox.ResumeLayout(false);
            this.AllocationGroupBox.PerformLayout();
            this.CompactionGroupBox.ResumeLayout(false);
            this.CompactionGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox HolesGroupBox;
        private System.Windows.Forms.GroupBox NumberOfProcessesGroupBox;
        private System.Windows.Forms.GroupBox ProcessesGroupBox;
        private System.Windows.Forms.GroupBox MethodOfAllocationGroupBox;
        private System.Windows.Forms.TextBox HoleAddressTextBox;
        private System.Windows.Forms.TextBox HoleSizeTextBox;
        private System.Windows.Forms.Label HoleAddressLabel;
        private System.Windows.Forms.Label HoleSizeLabel;
        private System.Windows.Forms.Button HoleFinish;
        private System.Windows.Forms.Button AddHole;
        private System.Windows.Forms.TextBox NumberOfProcessesTextBox;
        private System.Windows.Forms.Button NumberOfProcessesFinish;
        private System.Windows.Forms.Label NumberOfProcessesLabel;
        private System.Windows.Forms.Button AddProcessButton;
        private System.Windows.Forms.TextBox ProcessSizeTextBox;
        private System.Windows.Forms.TextBox ProcessNameTextBox;
        private System.Windows.Forms.Label ProcessSizeLabel;
        private System.Windows.Forms.Label ProcessName;
        private System.Windows.Forms.RadioButton BestFitRadioButton;
        private System.Windows.Forms.RadioButton FirstFitRadioButton;
        private System.Windows.Forms.Button MethodOfAllocationButton;
        private System.Windows.Forms.Label NumberOfHolesLabel;
        private System.Windows.Forms.Label Test;
        private System.Windows.Forms.TextBox ScreeningTextBox;
        private System.Windows.Forms.GroupBox ScreeningGroupBox;
        private System.Windows.Forms.GroupBox DeAllocationGroupBox;
        private System.Windows.Forms.Button DeAllocationButton;
        private System.Windows.Forms.TextBox ProcessToBeAllocatedNameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox AllocationGroupBox;
        private System.Windows.Forms.Button AllocationButton;
        private System.Windows.Forms.TextBox ProcessSizeAllocationTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ProcessNameAllocationTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox CompactionGroupBox;
        private System.Windows.Forms.RadioButton CompactionModeOFFRadio;
        private System.Windows.Forms.RadioButton CompactionModeONRadio;
        private System.Windows.Forms.Label CompactionModeLabel;
        private System.Windows.Forms.Button CompactionModeButton;
    }
}

