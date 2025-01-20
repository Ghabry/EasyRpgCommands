
namespace EasyRpgCommands
{
    partial class ProcessJsonControl
    {
        /// <summary> 
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Komponenten-Designer generierter Code

        /// <summary> 
        /// Erforderliche Methode für die Designerunterstützung. 
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProcessJsonControl));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.typePanel = new System.Windows.Forms.Panel();
            this.stringButton = new System.Windows.Forms.RadioButton();
            this.varButton = new System.Windows.Forms.RadioButton();
            this.switchButton = new System.Windows.Forms.RadioButton();
            this.jsonPanel = new System.Windows.Forms.Panel();
            this.writeButton = new System.Windows.Forms.RadioButton();
            this.readButton = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.rmSelectVariableEx5 = new EasyRpgCommands.RmSelectVariableEx();
            this.label4 = new System.Windows.Forms.Label();
            this.rmSelectVariableEx4 = new EasyRpgCommands.RmSelectVariableEx();
            this.label3 = new System.Windows.Forms.Label();
            this.rmSelectVariableEx3 = new EasyRpgCommands.RmSelectVariableEx();
            this.rmSelectVariableEx1 = new EasyRpgCommands.RmSelectVariableEx();
            this.rmSelectVariableEx2 = new EasyRpgCommands.RmSelectVariableEx();
            this.groupBox1.SuspendLayout();
            this.typePanel.SuspendLayout();
            this.jsonPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Operation:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "JSON String Var:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.typePanel);
            this.groupBox1.Controls.Add(this.jsonPanel);
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
            this.groupBox1.Size = new System.Drawing.Size(916, 240);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Process JSON (Requires EasyRPG Player)";
            // 
            // typePanel
            // 
            this.typePanel.Controls.Add(this.stringButton);
            this.typePanel.Controls.Add(this.varButton);
            this.typePanel.Controls.Add(this.switchButton);
            this.typePanel.Location = new System.Drawing.Point(543, 107);
            this.typePanel.Name = "typePanel";
            this.typePanel.Size = new System.Drawing.Size(345, 42);
            this.typePanel.TabIndex = 17;
            // 
            // stringButton
            // 
            this.stringButton.AutoSize = true;
            this.stringButton.Location = new System.Drawing.Point(214, 4);
            this.stringButton.Name = "stringButton";
            this.stringButton.Size = new System.Drawing.Size(76, 24);
            this.stringButton.TabIndex = 2;
            this.stringButton.TabStop = true;
            this.stringButton.Text = "String";
            this.stringButton.UseVisualStyleBackColor = true;
            this.stringButton.CheckedChanged += new System.EventHandler(this.switchButton_CheckedChanged);
            // 
            // varButton
            // 
            this.varButton.AutoSize = true;
            this.varButton.Location = new System.Drawing.Point(104, 3);
            this.varButton.Name = "varButton";
            this.varButton.Size = new System.Drawing.Size(92, 24);
            this.varButton.TabIndex = 1;
            this.varButton.TabStop = true;
            this.varButton.Text = "Variable";
            this.varButton.UseVisualStyleBackColor = true;
            this.varButton.CheckedChanged += new System.EventHandler(this.switchButton_CheckedChanged);
            // 
            // switchButton
            // 
            this.switchButton.AutoSize = true;
            this.switchButton.Location = new System.Drawing.Point(4, 4);
            this.switchButton.Name = "switchButton";
            this.switchButton.Size = new System.Drawing.Size(81, 24);
            this.switchButton.TabIndex = 0;
            this.switchButton.TabStop = true;
            this.switchButton.Text = "Switch";
            this.switchButton.UseVisualStyleBackColor = true;
            this.switchButton.CheckedChanged += new System.EventHandler(this.switchButton_CheckedChanged);
            // 
            // jsonPanel
            // 
            this.jsonPanel.Controls.Add(this.writeButton);
            this.jsonPanel.Controls.Add(this.readButton);
            this.jsonPanel.Location = new System.Drawing.Point(543, 25);
            this.jsonPanel.Name = "jsonPanel";
            this.jsonPanel.Size = new System.Drawing.Size(345, 42);
            this.jsonPanel.TabIndex = 16;
            // 
            // writeButton
            // 
            this.writeButton.AutoSize = true;
            this.writeButton.Location = new System.Drawing.Point(159, 4);
            this.writeButton.Name = "writeButton";
            this.writeButton.Size = new System.Drawing.Size(117, 24);
            this.writeButton.TabIndex = 1;
            this.writeButton.TabStop = true;
            this.writeButton.Text = "Write JSON";
            this.writeButton.UseVisualStyleBackColor = true;
            this.writeButton.CheckedChanged += new System.EventHandler(this.readButton_CheckedChanged);
            // 
            // readButton
            // 
            this.readButton.AutoSize = true;
            this.readButton.Location = new System.Drawing.Point(4, 4);
            this.readButton.Name = "readButton";
            this.readButton.Size = new System.Drawing.Size(119, 24);
            this.readButton.TabIndex = 0;
            this.readButton.TabStop = true;
            this.readButton.Text = "Read JSON";
            this.readButton.UseVisualStyleBackColor = true;
            this.readButton.CheckedChanged += new System.EventHandler(this.readButton_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 189);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "JSON Path:";
            // 
            // rmSelectVariableEx5
            // 
            this.rmSelectVariableEx5.ItemWidth1 = 100;
            this.rmSelectVariableEx5.ItemWidth2 = 120;
            this.rmSelectVariableEx5.Location = new System.Drawing.Point(137, 189);
            this.rmSelectVariableEx5.Name = "rmSelectVariableEx5";
            this.rmSelectVariableEx5.NumericButtonClick = null;
            this.rmSelectVariableEx5.NumericValue = 0;
            this.rmSelectVariableEx5.SelectedType = cmdcs.RmSelectVariableEx.ValueType.StringLiteral;
            this.rmSelectVariableEx5.SelectedTypeIndex = 0;
            this.rmSelectVariableEx5.Size = new System.Drawing.Size(751, 35);
            this.rmSelectVariableEx5.StringButtonClick = null;
            this.rmSelectVariableEx5.StringValue = "";
            this.rmSelectVariableEx5.TabIndex = 12;
            this.rmSelectVariableEx5.ValueRange = ((System.ValueTuple<int, int>)(resources.GetObject("rmSelectVariableEx5.ValueRange")));
            this.rmSelectVariableEx5.ValueTypeArray = new cmdcs.RmSelectVariableEx.ValueType[] {
        cmdcs.RmSelectVariableEx.ValueType.StringLiteral,
        cmdcs.RmSelectVariableEx.ValueType.Strvar,
        cmdcs.RmSelectVariableEx.ValueType.StrvarRef};
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Target Var ID:";
            // 
            // rmSelectVariableEx4
            // 
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
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Target Var Type:";
            // 
            // rmSelectVariableEx3
            // 
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
            // 
            // rmSelectVariableEx1
            // 
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
            // 
            // rmSelectVariableEx2
            // 
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
            // 
            // ProcessJsonControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Name = "ProcessJsonControl";
            this.Size = new System.Drawing.Size(927, 254);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.typePanel.ResumeLayout(false);
            this.typePanel.PerformLayout();
            this.jsonPanel.ResumeLayout(false);
            this.jsonPanel.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.Panel jsonPanel;
        private System.Windows.Forms.RadioButton readButton;
        private System.Windows.Forms.RadioButton writeButton;
        private System.Windows.Forms.Panel typePanel;
        private System.Windows.Forms.RadioButton varButton;
        private System.Windows.Forms.RadioButton switchButton;
        private System.Windows.Forms.RadioButton stringButton;
    }
}
