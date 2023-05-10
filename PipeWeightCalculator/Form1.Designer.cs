namespace PipeWeightCalculator
{
    partial class Form1
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
            this.pipeNominalDiameterComboBox = new System.Windows.Forms.ComboBox();
            this.wallThicknessComboBox = new System.Windows.Forms.ComboBox();
            this.materialComboBox = new System.Windows.Forms.ComboBox();
            this.pipeLengthTextBox1 = new System.Windows.Forms.TextBox();
            this.calculateButton1 = new System.Windows.Forms.Button();
            this.pipeMassResultLabel1 = new System.Windows.Forms.Label();
            this.pipeConfiguratorLabel = new System.Windows.Forms.Label();
            this.nominalDiameterLabel1 = new System.Windows.Forms.Label();
            this.wallThicknessLabel1 = new System.Windows.Forms.Label();
            this.materialLabel = new System.Windows.Forms.Label();
            this.resultLabel1 = new System.Windows.Forms.Label();
            this.lengthLabel1 = new System.Windows.Forms.Label();
            this.configuratorLabel = new System.Windows.Forms.Label();
            this.pipeLengthTextBox2 = new System.Windows.Forms.Label();
            this.resultLabel2 = new System.Windows.Forms.Label();
            this.wallThicknessLabel2 = new System.Windows.Forms.Label();
            this.nominalDiameterLabel2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pipeMassResultLabel2 = new System.Windows.Forms.Label();
            this.pipeLengthTextBox = new System.Windows.Forms.TextBox();
            this.wallThicknessTextBox = new System.Windows.Forms.TextBox();
            this.pipeNominalDiameterTextBox = new System.Windows.Forms.TextBox();
            this.calculateButton2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pipeNominalDiameterComboBox
            // 
            this.pipeNominalDiameterComboBox.FormattingEnabled = true;
            this.pipeNominalDiameterComboBox.Location = new System.Drawing.Point(40, 160);
            this.pipeNominalDiameterComboBox.Name = "pipeNominalDiameterComboBox";
            this.pipeNominalDiameterComboBox.Size = new System.Drawing.Size(250, 28);
            this.pipeNominalDiameterComboBox.TabIndex = 0;
            this.pipeNominalDiameterComboBox.SelectedIndexChanged += new System.EventHandler(this.pipeNominalDiameterComboBox_SelectedIndexChanged);
            // 
            // wallThicknessComboBox
            // 
            this.wallThicknessComboBox.FormattingEnabled = true;
            this.wallThicknessComboBox.Location = new System.Drawing.Point(40, 260);
            this.wallThicknessComboBox.Name = "wallThicknessComboBox";
            this.wallThicknessComboBox.Size = new System.Drawing.Size(250, 28);
            this.wallThicknessComboBox.TabIndex = 2;
            // 
            // materialComboBox
            // 
            this.materialComboBox.FormattingEnabled = true;
            this.materialComboBox.Location = new System.Drawing.Point(820, 160);
            this.materialComboBox.Name = "materialComboBox";
            this.materialComboBox.Size = new System.Drawing.Size(250, 28);
            this.materialComboBox.TabIndex = 1;
            // 
            // pipeLengthTextBox1
            // 
            this.pipeLengthTextBox1.Location = new System.Drawing.Point(40, 360);
            this.pipeLengthTextBox1.Name = "pipeLengthTextBox1";
            this.pipeLengthTextBox1.Size = new System.Drawing.Size(250, 26);
            this.pipeLengthTextBox1.TabIndex = 3;
            this.pipeLengthTextBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.pipeLengthTextBox1_KeyPress);
            // 
            // calculateButton1
            // 
            this.calculateButton1.Location = new System.Drawing.Point(40, 560);
            this.calculateButton1.Name = "calculateButton1";
            this.calculateButton1.Size = new System.Drawing.Size(250, 48);
            this.calculateButton1.TabIndex = 4;
            this.calculateButton1.Text = "Calculate";
            this.calculateButton1.UseVisualStyleBackColor = true;
            this.calculateButton1.Click += new System.EventHandler(this.calculateButton1_Click);
            // 
            // pipeMassResultLabel1
            // 
            this.pipeMassResultLabel1.BackColor = System.Drawing.SystemColors.Window;
            this.pipeMassResultLabel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pipeMassResultLabel1.Location = new System.Drawing.Point(40, 460);
            this.pipeMassResultLabel1.Name = "pipeMassResultLabel1";
            this.pipeMassResultLabel1.Size = new System.Drawing.Size(250, 26);
            this.pipeMassResultLabel1.TabIndex = 5;
            // 
            // pipeConfiguratorLabel
            // 
            this.pipeConfiguratorLabel.AutoSize = true;
            this.pipeConfiguratorLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pipeConfiguratorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.pipeConfiguratorLabel.Location = new System.Drawing.Point(40, 46);
            this.pipeConfiguratorLabel.Name = "pipeConfiguratorLabel";
            this.pipeConfiguratorLabel.Size = new System.Drawing.Size(129, 20);
            this.pipeConfiguratorLabel.TabIndex = 6;
            this.pipeConfiguratorLabel.Text = "Select from list";
            // 
            // nominalDiameterLabel1
            // 
            this.nominalDiameterLabel1.AutoSize = true;
            this.nominalDiameterLabel1.Location = new System.Drawing.Point(40, 120);
            this.nominalDiameterLabel1.Name = "nominalDiameterLabel1";
            this.nominalDiameterLabel1.Size = new System.Drawing.Size(159, 20);
            this.nominalDiameterLabel1.TabIndex = 7;
            this.nominalDiameterLabel1.Text = "Nominal pipe size DN";
            // 
            // wallThicknessLabel1
            // 
            this.wallThicknessLabel1.AutoSize = true;
            this.wallThicknessLabel1.Location = new System.Drawing.Point(40, 220);
            this.wallThicknessLabel1.Name = "wallThicknessLabel1";
            this.wallThicknessLabel1.Size = new System.Drawing.Size(148, 20);
            this.wallThicknessLabel1.TabIndex = 8;
            this.wallThicknessLabel1.Text = "Wall thickness [mm]";
            // 
            // materialLabel
            // 
            this.materialLabel.AutoSize = true;
            this.materialLabel.Location = new System.Drawing.Point(820, 120);
            this.materialLabel.Name = "materialLabel";
            this.materialLabel.Size = new System.Drawing.Size(65, 20);
            this.materialLabel.TabIndex = 9;
            this.materialLabel.Text = "Material";
            // 
            // resultLabel1
            // 
            this.resultLabel1.AutoSize = true;
            this.resultLabel1.Location = new System.Drawing.Point(40, 420);
            this.resultLabel1.Name = "resultLabel1";
            this.resultLabel1.Size = new System.Drawing.Size(88, 20);
            this.resultLabel1.TabIndex = 10;
            this.resultLabel1.Text = "Weight [kg]";
            // 
            // lengthLabel1
            // 
            this.lengthLabel1.AutoSize = true;
            this.lengthLabel1.Location = new System.Drawing.Point(40, 320);
            this.lengthLabel1.Name = "lengthLabel1";
            this.lengthLabel1.Size = new System.Drawing.Size(84, 20);
            this.lengthLabel1.TabIndex = 11;
            this.lengthLabel1.Text = "Length [m]";
            // 
            // configuratorLabel
            // 
            this.configuratorLabel.AutoSize = true;
            this.configuratorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.configuratorLabel.Location = new System.Drawing.Point(820, 46);
            this.configuratorLabel.Name = "configuratorLabel";
            this.configuratorLabel.Size = new System.Drawing.Size(109, 20);
            this.configuratorLabel.TabIndex = 12;
            this.configuratorLabel.Text = "Configurator";
            // 
            // pipeLengthTextBox2
            // 
            this.pipeLengthTextBox2.AutoSize = true;
            this.pipeLengthTextBox2.Location = new System.Drawing.Point(440, 320);
            this.pipeLengthTextBox2.Name = "pipeLengthTextBox2";
            this.pipeLengthTextBox2.Size = new System.Drawing.Size(84, 20);
            this.pipeLengthTextBox2.TabIndex = 17;
            this.pipeLengthTextBox2.Text = "Length [m]";
            // 
            // resultLabel2
            // 
            this.resultLabel2.AutoSize = true;
            this.resultLabel2.Location = new System.Drawing.Point(440, 420);
            this.resultLabel2.Name = "resultLabel2";
            this.resultLabel2.Size = new System.Drawing.Size(88, 20);
            this.resultLabel2.TabIndex = 16;
            this.resultLabel2.Text = "Weight [kg]";
            // 
            // wallThicknessLabel2
            // 
            this.wallThicknessLabel2.AutoSize = true;
            this.wallThicknessLabel2.Location = new System.Drawing.Point(440, 220);
            this.wallThicknessLabel2.Name = "wallThicknessLabel2";
            this.wallThicknessLabel2.Size = new System.Drawing.Size(148, 20);
            this.wallThicknessLabel2.TabIndex = 15;
            this.wallThicknessLabel2.Text = "Wall thickness [mm]";
            // 
            // nominalDiameterLabel2
            // 
            this.nominalDiameterLabel2.AutoSize = true;
            this.nominalDiameterLabel2.Location = new System.Drawing.Point(440, 120);
            this.nominalDiameterLabel2.Name = "nominalDiameterLabel2";
            this.nominalDiameterLabel2.Size = new System.Drawing.Size(197, 20);
            this.nominalDiameterLabel2.TabIndex = 14;
            this.nominalDiameterLabel2.Text = "Nominal pipe size DN [mm]";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(440, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "Manual calculate";
            // 
            // pipeMassResultLabel2
            // 
            this.pipeMassResultLabel2.BackColor = System.Drawing.SystemColors.Window;
            this.pipeMassResultLabel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pipeMassResultLabel2.Location = new System.Drawing.Point(444, 460);
            this.pipeMassResultLabel2.Name = "pipeMassResultLabel2";
            this.pipeMassResultLabel2.Size = new System.Drawing.Size(250, 26);
            this.pipeMassResultLabel2.TabIndex = 19;
            // 
            // pipeLengthTextBox
            // 
            this.pipeLengthTextBox.Location = new System.Drawing.Point(444, 360);
            this.pipeLengthTextBox.Name = "pipeLengthTextBox";
            this.pipeLengthTextBox.Size = new System.Drawing.Size(250, 26);
            this.pipeLengthTextBox.TabIndex = 18;
            this.pipeLengthTextBox.Tag = "";
            this.pipeLengthTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.pipeLengthTextBox_KeyPress);
            // 
            // wallThicknessTextBox
            // 
            this.wallThicknessTextBox.Location = new System.Drawing.Point(444, 260);
            this.wallThicknessTextBox.Name = "wallThicknessTextBox";
            this.wallThicknessTextBox.Size = new System.Drawing.Size(250, 26);
            this.wallThicknessTextBox.TabIndex = 20;
            this.wallThicknessTextBox.Tag = "";
            this.wallThicknessTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.wallThicknessTextBox_KeyPress);
            // 
            // pipeNominalDiameterTextBox
            // 
            this.pipeNominalDiameterTextBox.Location = new System.Drawing.Point(444, 162);
            this.pipeNominalDiameterTextBox.Name = "pipeNominalDiameterTextBox";
            this.pipeNominalDiameterTextBox.Size = new System.Drawing.Size(250, 26);
            this.pipeNominalDiameterTextBox.TabIndex = 21;
            this.pipeNominalDiameterTextBox.Tag = "";
            this.pipeNominalDiameterTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.pipeNominalDiameterTextBox_KeyPress);
            // 
            // calculateButton2
            // 
            this.calculateButton2.Location = new System.Drawing.Point(444, 560);
            this.calculateButton2.Name = "calculateButton2";
            this.calculateButton2.Size = new System.Drawing.Size(250, 48);
            this.calculateButton2.TabIndex = 22;
            this.calculateButton2.Text = "Calculate";
            this.calculateButton2.UseVisualStyleBackColor = true;
            this.calculateButton2.Click += new System.EventHandler(this.calculateButton2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1127, 680);
            this.Controls.Add(this.calculateButton2);
            this.Controls.Add(this.pipeNominalDiameterTextBox);
            this.Controls.Add(this.wallThicknessTextBox);
            this.Controls.Add(this.pipeMassResultLabel2);
            this.Controls.Add(this.pipeLengthTextBox);
            this.Controls.Add(this.pipeLengthTextBox2);
            this.Controls.Add(this.resultLabel2);
            this.Controls.Add(this.wallThicknessLabel2);
            this.Controls.Add(this.nominalDiameterLabel2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.configuratorLabel);
            this.Controls.Add(this.lengthLabel1);
            this.Controls.Add(this.resultLabel1);
            this.Controls.Add(this.materialLabel);
            this.Controls.Add(this.wallThicknessLabel1);
            this.Controls.Add(this.nominalDiameterLabel1);
            this.Controls.Add(this.pipeConfiguratorLabel);
            this.Controls.Add(this.pipeMassResultLabel1);
            this.Controls.Add(this.calculateButton1);
            this.Controls.Add(this.pipeLengthTextBox1);
            this.Controls.Add(this.wallThicknessComboBox);
            this.Controls.Add(this.materialComboBox);
            this.Controls.Add(this.pipeNominalDiameterComboBox);
            this.Name = "Form1";
            this.Text = "Pipe weight calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox pipeLengthTextBox1;
        private System.Windows.Forms.Button calculateButton1;
        private System.Windows.Forms.Label pipeMassResultLabel1;
        private System.Windows.Forms.Label pipeConfiguratorLabel;
        private System.Windows.Forms.Label nominalDiameterLabel1;
        private System.Windows.Forms.Label wallThicknessLabel1;
        private System.Windows.Forms.Label materialLabel;
        private System.Windows.Forms.Label resultLabel1;
        private System.Windows.Forms.Label lengthLabel1;
        private System.Windows.Forms.Label configuratorLabel;
        private System.Windows.Forms.Label pipeLengthTextBox2;
        private System.Windows.Forms.Label resultLabel2;
        private System.Windows.Forms.Label wallThicknessLabel2;
        private System.Windows.Forms.Label nominalDiameterLabel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label pipeMassResultLabel2;
        private System.Windows.Forms.TextBox pipeLengthTextBox;
        private System.Windows.Forms.TextBox wallThicknessTextBox;
        private System.Windows.Forms.TextBox pipeNominalDiameterTextBox;
        private System.Windows.Forms.Button calculateButton2;
        public System.Windows.Forms.ComboBox pipeNominalDiameterComboBox;
        public System.Windows.Forms.ComboBox wallThicknessComboBox;
        public System.Windows.Forms.ComboBox materialComboBox;
    }
}

