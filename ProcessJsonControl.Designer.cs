
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
            this.checkBox_keys = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButton_parse2 = new System.Windows.Forms.RadioButton();
            this.radioButton_parse1 = new System.Windows.Forms.RadioButton();
            this.radioButton_parse0 = new System.Windows.Forms.RadioButton();
            this.checkBox_pp = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.rmSelectVariableEx5 = new EasyRpgCommands.RmSelectVariableEx();
            this.label4 = new System.Windows.Forms.Label();
            this.rmSelectVariableEx4 = new EasyRpgCommands.RmSelectVariableEx();
            this.label3 = new System.Windows.Forms.Label();
            this.rmSelectVariableEx3 = new EasyRpgCommands.RmSelectVariableEx();
            this.rmSelectVariableEx1 = new EasyRpgCommands.RmSelectVariableEx();
            this.rmSelectVariableEx2 = new EasyRpgCommands.RmSelectVariableExJson();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
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
            this.label2.Size = new System.Drawing.Size(101, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "JSON String:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBox_keys);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.checkBox_pp);
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
            this.groupBox1.Size = new System.Drawing.Size(916, 365);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Process JSON (Requires EasyRPG Player)";
            // 
            // checkBox_keys
            // 
            this.checkBox_keys.AutoSize = true;
            this.checkBox_keys.Location = new System.Drawing.Point(425, 260);
            this.checkBox_keys.Name = "checkBox_keys";
            this.checkBox_keys.Size = new System.Drawing.Size(275, 24);
            this.checkBox_keys.TabIndex = 17;
            this.checkBox_keys.Text = "Wrap \"Get Keys\" list in { \"keys\": [] }";
            this.checkBox_keys.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButton_parse2);
            this.groupBox2.Controls.Add(this.radioButton_parse1);
            this.groupBox2.Controls.Add(this.radioButton_parse0);
            this.groupBox2.Location = new System.Drawing.Point(10, 224);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(409, 135);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Parser settings";
            // 
            // radioButton_parse2
            // 
            this.radioButton_parse2.AutoSize = true;
            this.radioButton_parse2.Location = new System.Drawing.Point(7, 88);
            this.radioButton_parse2.Name = "radioButton_parse2";
            this.radioButton_parse2.Size = new System.Drawing.Size(387, 24);
            this.radioButton_parse2.TabIndex = 2;
            this.radioButton_parse2.TabStop = true;
            this.radioButton_parse2.Text = "Parse Command Codes (\\V[] etc., numbers in Hex)";
            this.radioButton_parse2.UseVisualStyleBackColor = true;
            // 
            // radioButton_parse1
            // 
            this.radioButton_parse1.AutoSize = true;
            this.radioButton_parse1.Location = new System.Drawing.Point(7, 57);
            this.radioButton_parse1.Name = "radioButton_parse1";
            this.radioButton_parse1.Size = new System.Drawing.Size(265, 24);
            this.radioButton_parse1.TabIndex = 1;
            this.radioButton_parse1.TabStop = true;
            this.radioButton_parse1.Text = "Parse Command Codes (\\V[] etc)";
            this.radioButton_parse1.UseVisualStyleBackColor = true;
            // 
            // radioButton_parse0
            // 
            this.radioButton_parse0.AutoSize = true;
            this.radioButton_parse0.Location = new System.Drawing.Point(7, 26);
            this.radioButton_parse0.Name = "radioButton_parse0";
            this.radioButton_parse0.Size = new System.Drawing.Size(111, 24);
            this.radioButton_parse0.TabIndex = 0;
            this.radioButton_parse0.TabStop = true;
            this.radioButton_parse0.Text = "No Parsing";
            this.radioButton_parse0.UseVisualStyleBackColor = true;
            // 
            // checkBox_pp
            // 
            this.checkBox_pp.AutoSize = true;
            this.checkBox_pp.Location = new System.Drawing.Point(425, 230);
            this.checkBox_pp.Name = "checkBox_pp";
            this.checkBox_pp.Size = new System.Drawing.Size(158, 24);
            this.checkBox_pp.TabIndex = 15;
            this.checkBox_pp.Text = "Pretty Print JSON";
            this.checkBox_pp.UseVisualStyleBackColor = true;
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
            this.rmSelectVariableEx3.SelectedType = cmdcs.RmSelectVariableEx.ValueType.Anim2Id;
            this.rmSelectVariableEx3.SelectedTypeIndex = 0;
            this.rmSelectVariableEx3.Size = new System.Drawing.Size(400, 35);
            this.rmSelectVariableEx3.StringButtonClick = null;
            this.rmSelectVariableEx3.StringValue = "";
            this.rmSelectVariableEx3.TabIndex = 6;
            this.rmSelectVariableEx3.ValueRange = ((System.ValueTuple<int, int>)(resources.GetObject("rmSelectVariableEx3.ValueRange")));
            this.rmSelectVariableEx3.ValueTypeArray = new cmdcs.RmSelectVariableEx.ValueType[] {
        cmdcs.RmSelectVariableEx.ValueType.Anim2Id,
        cmdcs.RmSelectVariableEx.ValueType.Variable,
        cmdcs.RmSelectVariableEx.ValueType.VariableRef};
            // 
            // rmSelectVariableEx1
            // 
            this.rmSelectVariableEx1.ItemWidth1 = 100;
            this.rmSelectVariableEx1.ItemWidth2 = 120;
            this.rmSelectVariableEx1.Location = new System.Drawing.Point(137, 25);
            this.rmSelectVariableEx1.Name = "rmSelectVariableEx1";
            this.rmSelectVariableEx1.NumericButtonClick = null;
            this.rmSelectVariableEx1.NumericValue = 0;
            this.rmSelectVariableEx1.SelectedType = cmdcs.RmSelectVariableEx.ValueType.Anim2Id;
            this.rmSelectVariableEx1.SelectedTypeIndex = 0;
            this.rmSelectVariableEx1.Size = new System.Drawing.Size(400, 35);
            this.rmSelectVariableEx1.StringButtonClick = null;
            this.rmSelectVariableEx1.StringValue = "";
            this.rmSelectVariableEx1.TabIndex = 2;
            this.rmSelectVariableEx1.ValueRange = ((System.ValueTuple<int, int>)(resources.GetObject("rmSelectVariableEx1.ValueRange")));
            this.rmSelectVariableEx1.ValueTypeArray = new cmdcs.RmSelectVariableEx.ValueType[] {
        cmdcs.RmSelectVariableEx.ValueType.Anim2Id,
        cmdcs.RmSelectVariableEx.ValueType.Variable,
        cmdcs.RmSelectVariableEx.ValueType.VariableRef};
            // 
            // rmSelectVariableEx2
            // 
            this.rmSelectVariableEx2.ItemWidth1 = 100;
            this.rmSelectVariableEx2.ItemWidth2 = 120;
            this.rmSelectVariableEx2.Location = new System.Drawing.Point(137, 66);
            this.rmSelectVariableEx2.Name = "rmSelectVariableEx2";
            this.rmSelectVariableEx2.NumericButtonClick = null;
            this.rmSelectVariableEx2.NumericValue = 0;
            this.rmSelectVariableEx2.SelectedType = cmdcs.RmSelectVariableEx.ValueType.StringLiteral;
            this.rmSelectVariableEx2.SelectedTypeIndex = 0;
            this.rmSelectVariableEx2.Size = new System.Drawing.Size(400, 35);
            this.rmSelectVariableEx2.StringButtonClick = null;
            this.rmSelectVariableEx2.StringValue = "";
            this.rmSelectVariableEx2.TabIndex = 3;
            this.rmSelectVariableEx2.ValueRange = ((System.ValueTuple<int, int>)(resources.GetObject("rmSelectVariableEx2.ValueRange")));
            this.rmSelectVariableEx2.ValueTypeArray = new cmdcs.RmSelectVariableEx.ValueType[] {
        cmdcs.RmSelectVariableEx.ValueType.StringLiteral,
        cmdcs.RmSelectVariableEx.ValueType.Strvar,
        cmdcs.RmSelectVariableEx.ValueType.StrvarRef};
            // 
            // ProcessJsonControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Name = "ProcessJsonControl";
            this.Size = new System.Drawing.Size(927, 381);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private RmSelectVariableEx rmSelectVariableEx1;
        private RmSelectVariableExJson rmSelectVariableEx2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private RmSelectVariableEx rmSelectVariableEx3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private RmSelectVariableEx rmSelectVariableEx5;
        private RmSelectVariableEx rmSelectVariableEx4;
        private System.Windows.Forms.CheckBox checkBox_pp;
        private System.Windows.Forms.CheckBox checkBox_keys;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButton_parse2;
        private System.Windows.Forms.RadioButton radioButton_parse1;
        private System.Windows.Forms.RadioButton radioButton_parse0;
    }
}
