namespace EasyRpgCommands
{
    partial class ProcessJsonControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProcessJsonControl));

            // Control declarations
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.extractionLabel = new System.Windows.Forms.Label();

            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.operationPanel = new System.Windows.Forms.Panel();
            this.typePanel = new System.Windows.Forms.Panel();

            this.operationComboBox = new System.Windows.Forms.ComboBox();
            this.typeComboBox = new System.Windows.Forms.ComboBox();
            this.extractionComboBox = new System.Windows.Forms.ComboBox();
            this.prettyPrintCheckbox = new System.Windows.Forms.CheckBox();

            this.rmSelectVariableEx1 = new EasyRpgCommands.RmSelectVariableEx();
            this.rmSelectVariableEx2 = new EasyRpgCommands.RmSelectVariableEx();
            this.rmSelectVariableEx3 = new EasyRpgCommands.RmSelectVariableEx();
            this.rmSelectVariableEx4 = new EasyRpgCommands.RmSelectVariableEx();
            this.rmSelectVariableEx5 = new EasyRpgCommands.RmSelectVariableEx();
            // Form Layout Setup
            this.groupBox1.SuspendLayout();
            this.typePanel.SuspendLayout();
            this.operationPanel.SuspendLayout();
            this.SuspendLayout();

            // Label configurations
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Operation:";

            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "JSON String Var:";

            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Target Var Type:";

            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Target Var ID:";

            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 189);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "JSON Path:";

            this.extractionLabel.AutoSize = true;
            this.extractionLabel.Location = new System.Drawing.Point(6, 230);
            this.extractionLabel.Name = "extractionLabel";
            this.extractionLabel.Size = new System.Drawing.Size(85, 20);
            this.extractionLabel.TabIndex = 19;
            this.extractionLabel.Text = "Extract Values:";

            // Panel configurations
            this.operationPanel.Location = new System.Drawing.Point(252, 25);
            this.operationPanel.Name = "operationPanel";
            this.operationPanel.Size = new System.Drawing.Size(200, 42);
            this.operationPanel.TabIndex = 16;

            this.typePanel.Location = new System.Drawing.Point(252, 107);
            this.typePanel.Name = "typePanel";
            this.typePanel.Size = new System.Drawing.Size(200, 40);
            this.typePanel.TabIndex = 17;

            // ComboBox configurations
            this.operationComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.operationComboBox.FormattingEnabled = true;
            this.operationComboBox.Location = new System.Drawing.Point(4, 4);
            this.operationComboBox.Name = "operationComboBox";
            this.operationComboBox.Size = new System.Drawing.Size(176, 28);
            this.operationComboBox.TabIndex = 0;
            this.operationComboBox.SelectedIndexChanged += new System.EventHandler(this.operationComboBox_SelectedIndexChanged);

            this.typeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.typeComboBox.FormattingEnabled = true;
            this.typeComboBox.Location = new System.Drawing.Point(4, 4);
            this.typeComboBox.Name = "typeComboBox";
            this.typeComboBox.Size = new System.Drawing.Size(176, 28);
            this.typeComboBox.TabIndex = 0;
            this.typeComboBox.SelectedIndexChanged += new System.EventHandler(this.typeComboBox_SelectedIndexChanged);

            this.extractionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.extractionComboBox.FormattingEnabled = true;
            this.extractionComboBox.Location = new System.Drawing.Point(137, 230);
            this.extractionComboBox.Name = "extractionComboBox";
            this.extractionComboBox.Size = new System.Drawing.Size(140, 28);
            this.extractionComboBox.TabIndex = 18;

            // Checkbox configuration
            this.prettyPrintCheckbox.AutoSize = true;
            this.prettyPrintCheckbox.Location = new System.Drawing.Point(300, 230);
            this.prettyPrintCheckbox.Name = "prettyPrintCheckbox";
            this.prettyPrintCheckbox.Size = new System.Drawing.Size(117, 24);
            this.prettyPrintCheckbox.TabIndex = 20;
            this.prettyPrintCheckbox.Text = "Pretty Print";
            this.prettyPrintCheckbox.UseVisualStyleBackColor = true;

            // RmSelectVariableEx controls configuration
            this.rmSelectVariableEx1.ItemWidth1 = 100;
            this.rmSelectVariableEx1.ItemWidth2 = 120;
            this.rmSelectVariableEx1.Location = new System.Drawing.Point(137, 25);
            this.rmSelectVariableEx1.Name = "rmSelectVariableEx1";
            this.rmSelectVariableEx1.NumericButtonClick = null;
            this.rmSelectVariableEx1.NumericValue = 0;
            this.rmSelectVariableEx1.SelectedType = cmdcs.RmSelectVariableEx.ValueType.NumericLiteral;
            this.rmSelectVariableEx1.SelectedTypeIndex = 0;
            this.rmSelectVariableEx1.Size = new System.Drawing.Size(400, 35);
            this.rmSelectVariableEx1.StringButtonClick = null;
            this.rmSelectVariableEx1.StringValue = "";
            this.rmSelectVariableEx1.TabIndex = 2;
            this.rmSelectVariableEx1.ValueRange = ((System.ValueTuple<int, int>)(resources.GetObject("rmSelectVariableEx1.ValueRange")));
            this.rmSelectVariableEx1.ValueTypeArray = new cmdcs.RmSelectVariableEx.ValueType[] {
                cmdcs.RmSelectVariableEx.ValueType.NumericLiteral,
                cmdcs.RmSelectVariableEx.ValueType.Variable,
                cmdcs.RmSelectVariableEx.ValueType.VariableRef};
            this.rmSelectVariableEx1.ValueTypeChanged += new cmdcs.RmSelectVariableEx.ValueTypeChangedEventHandler(this.rmSelectVariableEx1_ValueTypeChanged);

            this.rmSelectVariableEx2.ItemWidth1 = 100;
            this.rmSelectVariableEx2.ItemWidth2 = 120;
            this.rmSelectVariableEx2.Location = new System.Drawing.Point(137, 66);
            this.rmSelectVariableEx2.Name = "rmSelectVariableEx2";
            this.rmSelectVariableEx2.NumericButtonClick = null;
            this.rmSelectVariableEx2.NumericValue = 0;
            this.rmSelectVariableEx2.SelectedType = cmdcs.RmSelectVariableEx.ValueType.Strvar;
            this.rmSelectVariableEx2.SelectedTypeIndex = 0;
            this.rmSelectVariableEx2.Size = new System.Drawing.Size(400, 35);
            this.rmSelectVariableEx2.StringButtonClick = null;
            this.rmSelectVariableEx2.StringValue = "";
            this.rmSelectVariableEx2.TabIndex = 3;
            this.rmSelectVariableEx2.ValueRange = ((System.ValueTuple<int, int>)(resources.GetObject("rmSelectVariableEx2.ValueRange")));
            this.rmSelectVariableEx2.ValueTypeArray = new cmdcs.RmSelectVariableEx.ValueType[] {
                cmdcs.RmSelectVariableEx.ValueType.Strvar,
                cmdcs.RmSelectVariableEx.ValueType.StrvarRef};

            this.rmSelectVariableEx3.ItemWidth1 = 100;
            this.rmSelectVariableEx3.ItemWidth2 = 120;
            this.rmSelectVariableEx3.Location = new System.Drawing.Point(137, 107);
            this.rmSelectVariableEx3.Name = "rmSelectVariableEx3";
            this.rmSelectVariableEx3.NumericButtonClick = null;
            this.rmSelectVariableEx3.NumericValue = 0;
            this.rmSelectVariableEx3.SelectedType = cmdcs.RmSelectVariableEx.ValueType.NumericLiteral;
            this.rmSelectVariableEx3.SelectedTypeIndex = 0;
            this.rmSelectVariableEx3.Size = new System.Drawing.Size(400, 35);
            this.rmSelectVariableEx3.StringButtonClick = null;
            this.rmSelectVariableEx3.StringValue = "";
            this.rmSelectVariableEx3.TabIndex = 6;
            this.rmSelectVariableEx3.ValueRange = ((System.ValueTuple<int, int>)(resources.GetObject("rmSelectVariableEx3.ValueRange")));
            this.rmSelectVariableEx3.ValueTypeArray = new cmdcs.RmSelectVariableEx.ValueType[] {
                cmdcs.RmSelectVariableEx.ValueType.NumericLiteral,
                cmdcs.RmSelectVariableEx.ValueType.Variable,
                cmdcs.RmSelectVariableEx.ValueType.VariableRef};
            this.rmSelectVariableEx3.ValueTypeChanged += new cmdcs.RmSelectVariableEx.ValueTypeChangedEventHandler(this.rmSelectVariableEx3_ValueTypeChanged);

            this.rmSelectVariableEx4.ItemWidth1 = 100;
            this.rmSelectVariableEx4.ItemWidth2 = 120;
            this.rmSelectVariableEx4.Location = new System.Drawing.Point(137, 148);
            this.rmSelectVariableEx4.Name = "rmSelectVariableEx4";
            this.rmSelectVariableEx4.NumericButtonClick = null;
            this.rmSelectVariableEx4.NumericValue = 0;
            this.rmSelectVariableEx4.SelectedType = cmdcs.RmSelectVariableEx.ValueType.NumericLiteral;
            this.rmSelectVariableEx4.SelectedTypeIndex = 0;
            this.rmSelectVariableEx4.Size = new System.Drawing.Size(400, 35);
            this.rmSelectVariableEx4.StringButtonClick = null;
            this.rmSelectVariableEx4.StringValue = "";
            this.rmSelectVariableEx4.TabIndex = 8;
            this.rmSelectVariableEx4.ValueRange = ((System.ValueTuple<int, int>)(resources.GetObject("rmSelectVariableEx4.ValueRange")));
            this.rmSelectVariableEx4.ValueTypeArray = new cmdcs.RmSelectVariableEx.ValueType[] {
                cmdcs.RmSelectVariableEx.ValueType.NumericLiteral,
                cmdcs.RmSelectVariableEx.ValueType.Variable,
                cmdcs.RmSelectVariableEx.ValueType.VariableRef};

            this.rmSelectVariableEx5.ItemWidth1 = 100;
            this.rmSelectVariableEx5.ItemWidth2 = 120;
            this.rmSelectVariableEx5.Location = new System.Drawing.Point(137, 189);
            this.rmSelectVariableEx5.Name = "rmSelectVariableEx5";
            this.rmSelectVariableEx5.NumericButtonClick = null;
            this.rmSelectVariableEx5.NumericValue = 0;
            this.rmSelectVariableEx5.SelectedType = cmdcs.RmSelectVariableEx.ValueType.StringLiteral;
            this.rmSelectVariableEx5.SelectedTypeIndex = 0;
            this.rmSelectVariableEx5.Size = new System.Drawing.Size(400, 35);
            this.rmSelectVariableEx5.StringButtonClick = null;
            this.rmSelectVariableEx5.StringValue = "";
            this.rmSelectVariableEx5.TabIndex = 12;
            this.rmSelectVariableEx5.ValueRange = ((System.ValueTuple<int, int>)(resources.GetObject("rmSelectVariableEx5.ValueRange")));
            this.rmSelectVariableEx5.ValueTypeArray = new cmdcs.RmSelectVariableEx.ValueType[] {
                cmdcs.RmSelectVariableEx.ValueType.StringLiteral,
                cmdcs.RmSelectVariableEx.ValueType.Strvar,
                cmdcs.RmSelectVariableEx.ValueType.StrvarRef};
            this.rmSelectVariableEx5.ValueTypeChanged += new cmdcs.RmSelectVariableEx.ValueTypeChangedEventHandler(this.rmSelectVariableEx5_ValueTypeChanged);

            // GroupBox configuration
            this.groupBox1.Controls.Add(this.prettyPrintCheckbox);
            this.groupBox1.Controls.Add(this.extractionLabel);
            this.groupBox1.Controls.Add(this.extractionComboBox);
            this.groupBox1.Controls.Add(this.typePanel);
            this.groupBox1.Controls.Add(this.operationPanel);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.rmSelectVariableEx5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.rmSelectVariableEx4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.rmSelectVariableEx3);
            this.groupBox1.Controls.Add(this.rmSelectVariableEx1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.rmSelectVariableEx2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(560, 280);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Process JSON (Requires EasyRPG Player)";

            // Panel controls
            this.typePanel.Controls.Add(this.typeComboBox);
            this.operationPanel.Controls.Add(this.operationComboBox);

            // Form configuration
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Name = "ProcessJsonControl";
            this.Size = new System.Drawing.Size(600, 300);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.typePanel.ResumeLayout(false);
            this.operationPanel.ResumeLayout(false);
            this.ResumeLayout(false);

            // Designer field declarations
            this.components = components;
        }

        #endregion

        private RmSelectVariableEx rmSelectVariableEx1;
        private RmSelectVariableEx rmSelectVariableEx2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private RmSelectVariableEx rmSelectVariableEx3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private RmSelectVariableEx rmSelectVariableEx5;
        private RmSelectVariableEx rmSelectVariableEx4;
        private System.Windows.Forms.Panel operationPanel;
        private System.Windows.Forms.Panel typePanel;
        private System.Windows.Forms.ComboBox operationComboBox;
        private System.Windows.Forms.ComboBox typeComboBox;
        private System.Windows.Forms.Label extractionLabel;
        private System.Windows.Forms.ComboBox extractionComboBox;
        private System.Windows.Forms.CheckBox prettyPrintCheckbox;
    }
}
