
namespace EasyRpgCommands
{
    partial class CloneMapEventControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CloneMapEventControl));
            this.rmSelectVariableEx1 = new EasyRpgCommands.RmSelectVariableEx();
            this.rmSelectVariableEx2 = new EasyRpgCommands.RmSelectVariableEx();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.rmSelectVariableEx6 = new EasyRpgCommands.RmSelectVariableEx();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.rmSelectVariableEx5 = new EasyRpgCommands.RmSelectVariableEx();
            this.rmSelectVariableEx4 = new EasyRpgCommands.RmSelectVariableEx();
            this.label3 = new System.Windows.Forms.Label();
            this.rmSelectVariableEx3 = new EasyRpgCommands.RmSelectVariableEx();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rmSelectVariableEx1
            // 
            this.rmSelectVariableEx1.ItemWidth1 = 100;
            this.rmSelectVariableEx1.ItemWidth2 = 120;
            this.rmSelectVariableEx1.Location = new System.Drawing.Point(212, 25);
            this.rmSelectVariableEx1.Name = "rmSelectVariableEx1";
            this.rmSelectVariableEx1.NumericButtonClick = null;
            this.rmSelectVariableEx1.NumericValue = 0;
            this.rmSelectVariableEx1.SelectedType = cmdcs.RmSelectVariableEx.ValueType.NumericLiteral;
            this.rmSelectVariableEx1.SelectedTypeIndex = 0;
            this.rmSelectVariableEx1.Size = new System.Drawing.Size(456, 35);
            this.rmSelectVariableEx1.StringButtonClick = null;
            this.rmSelectVariableEx1.StringValue = "";
            this.rmSelectVariableEx1.TabIndex = 2;
            this.rmSelectVariableEx1.ValueRange = ((System.ValueTuple<int, int>)(resources.GetObject("rmSelectVariableEx1.ValueRange")));
            this.rmSelectVariableEx1.ValueTypeArray = new cmdcs.RmSelectVariableEx.ValueType[] {
        cmdcs.RmSelectVariableEx.ValueType.NumericLiteral,
        cmdcs.RmSelectVariableEx.ValueType.Variable,
        cmdcs.RmSelectVariableEx.ValueType.VariableRef};
            // 
            // rmSelectVariableEx2
            // 
            this.rmSelectVariableEx2.ItemWidth1 = 100;
            this.rmSelectVariableEx2.ItemWidth2 = 120;
            this.rmSelectVariableEx2.Location = new System.Drawing.Point(212, 66);
            this.rmSelectVariableEx2.Name = "rmSelectVariableEx2";
            this.rmSelectVariableEx2.NumericButtonClick = null;
            this.rmSelectVariableEx2.NumericValue = 0;
            this.rmSelectVariableEx2.SelectedType = cmdcs.RmSelectVariableEx.ValueType.ExecutableEventId;
            this.rmSelectVariableEx2.SelectedTypeIndex = 0;
            this.rmSelectVariableEx2.Size = new System.Drawing.Size(456, 35);
            this.rmSelectVariableEx2.StringButtonClick = null;
            this.rmSelectVariableEx2.StringValue = "";
            this.rmSelectVariableEx2.TabIndex = 3;
            this.rmSelectVariableEx2.ValueRange = ((System.ValueTuple<int, int>)(resources.GetObject("rmSelectVariableEx2.ValueRange")));
            this.rmSelectVariableEx2.ValueTypeArray = new cmdcs.RmSelectVariableEx.ValueType[] {
        cmdcs.RmSelectVariableEx.ValueType.ExecutableEventId,
        cmdcs.RmSelectVariableEx.ValueType.Variable,
        cmdcs.RmSelectVariableEx.ValueType.VariableRef};
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Source Map (0 = current):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Source Event ID:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.rmSelectVariableEx6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.rmSelectVariableEx5);
            this.groupBox1.Controls.Add(this.rmSelectVariableEx4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.rmSelectVariableEx3);
            this.groupBox1.Controls.Add(this.rmSelectVariableEx1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.rmSelectVariableEx2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(704, 310);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Clone Map Event (Requires EasyRPG Player)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 271);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(662, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "When target event ID is 0 a new event is created. In other cases it overwrites th" +
    "e given event.";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 230);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(135, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "New Event Name:";
            // 
            // rmSelectVariableEx6
            // 
            this.rmSelectVariableEx6.ItemWidth1 = 100;
            this.rmSelectVariableEx6.ItemWidth2 = 120;
            this.rmSelectVariableEx6.Location = new System.Drawing.Point(212, 230);
            this.rmSelectVariableEx6.Name = "rmSelectVariableEx6";
            this.rmSelectVariableEx6.NumericButtonClick = null;
            this.rmSelectVariableEx6.NumericValue = 0;
            this.rmSelectVariableEx6.SelectedType = cmdcs.RmSelectVariableEx.ValueType.StringLiteral;
            this.rmSelectVariableEx6.SelectedTypeIndex = 0;
            this.rmSelectVariableEx6.Size = new System.Drawing.Size(456, 35);
            this.rmSelectVariableEx6.StringButtonClick = null;
            this.rmSelectVariableEx6.StringValue = "";
            this.rmSelectVariableEx6.TabIndex = 12;
            this.rmSelectVariableEx6.ValueRange = ((System.ValueTuple<int, int>)(resources.GetObject("rmSelectVariableEx6.ValueRange")));
            this.rmSelectVariableEx6.ValueTypeArray = new cmdcs.RmSelectVariableEx.ValueType[] {
        cmdcs.RmSelectVariableEx.ValueType.StringLiteral,
        cmdcs.RmSelectVariableEx.ValueType.Strvar,
        cmdcs.RmSelectVariableEx.ValueType.StrvarRef};
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 189);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Target Event ID:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Target Y:";
            // 
            // rmSelectVariableEx5
            // 
            this.rmSelectVariableEx5.ItemWidth1 = 100;
            this.rmSelectVariableEx5.ItemWidth2 = 120;
            this.rmSelectVariableEx5.Location = new System.Drawing.Point(212, 189);
            this.rmSelectVariableEx5.Name = "rmSelectVariableEx5";
            this.rmSelectVariableEx5.NumericButtonClick = null;
            this.rmSelectVariableEx5.NumericValue = 0;
            this.rmSelectVariableEx5.SelectedType = cmdcs.RmSelectVariableEx.ValueType.ExecutableEventId;
            this.rmSelectVariableEx5.SelectedTypeIndex = 0;
            this.rmSelectVariableEx5.Size = new System.Drawing.Size(456, 35);
            this.rmSelectVariableEx5.StringButtonClick = null;
            this.rmSelectVariableEx5.StringValue = "";
            this.rmSelectVariableEx5.TabIndex = 9;
            this.rmSelectVariableEx5.ValueRange = ((System.ValueTuple<int, int>)(resources.GetObject("rmSelectVariableEx5.ValueRange")));
            this.rmSelectVariableEx5.ValueTypeArray = new cmdcs.RmSelectVariableEx.ValueType[] {
        cmdcs.RmSelectVariableEx.ValueType.ExecutableEventId,
        cmdcs.RmSelectVariableEx.ValueType.Variable,
        cmdcs.RmSelectVariableEx.ValueType.VariableRef};
            // 
            // rmSelectVariableEx4
            // 
            this.rmSelectVariableEx4.ItemWidth1 = 100;
            this.rmSelectVariableEx4.ItemWidth2 = 120;
            this.rmSelectVariableEx4.Location = new System.Drawing.Point(212, 148);
            this.rmSelectVariableEx4.Name = "rmSelectVariableEx4";
            this.rmSelectVariableEx4.NumericButtonClick = null;
            this.rmSelectVariableEx4.NumericValue = 0;
            this.rmSelectVariableEx4.SelectedType = cmdcs.RmSelectVariableEx.ValueType.NumericLiteral;
            this.rmSelectVariableEx4.SelectedTypeIndex = 0;
            this.rmSelectVariableEx4.Size = new System.Drawing.Size(456, 35);
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
            this.label3.Size = new System.Drawing.Size(74, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Target X:";
            // 
            // rmSelectVariableEx3
            // 
            this.rmSelectVariableEx3.ItemWidth1 = 100;
            this.rmSelectVariableEx3.ItemWidth2 = 120;
            this.rmSelectVariableEx3.Location = new System.Drawing.Point(212, 107);
            this.rmSelectVariableEx3.Name = "rmSelectVariableEx3";
            this.rmSelectVariableEx3.NumericButtonClick = null;
            this.rmSelectVariableEx3.NumericValue = 0;
            this.rmSelectVariableEx3.SelectedType = cmdcs.RmSelectVariableEx.ValueType.NumericLiteral;
            this.rmSelectVariableEx3.SelectedTypeIndex = 0;
            this.rmSelectVariableEx3.Size = new System.Drawing.Size(456, 35);
            this.rmSelectVariableEx3.StringButtonClick = null;
            this.rmSelectVariableEx3.StringValue = "";
            this.rmSelectVariableEx3.TabIndex = 6;
            this.rmSelectVariableEx3.ValueRange = ((System.ValueTuple<int, int>)(resources.GetObject("rmSelectVariableEx3.ValueRange")));
            this.rmSelectVariableEx3.ValueTypeArray = new cmdcs.RmSelectVariableEx.ValueType[] {
        cmdcs.RmSelectVariableEx.ValueType.NumericLiteral,
        cmdcs.RmSelectVariableEx.ValueType.Variable,
        cmdcs.RmSelectVariableEx.ValueType.VariableRef};
            // 
            // CloneMapEventControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Name = "CloneMapEventControl";
            this.Size = new System.Drawing.Size(710, 318);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private RmSelectVariableEx rmSelectVariableEx6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private RmSelectVariableEx rmSelectVariableEx5;
        private RmSelectVariableEx rmSelectVariableEx4;
        private System.Windows.Forms.Label label7;
    }
}
