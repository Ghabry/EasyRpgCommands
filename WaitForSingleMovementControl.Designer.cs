
namespace EasyRpgCommands
{
    partial class WaitForSingleMovementControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WaitForSingleMovementControl));
            this.rmSelectVariableEx1 = new EasyRpgCommands.RmSelectVariableEx();
            this.rmSelectVariableEx2 = new EasyRpgCommands.RmSelectVariableEx();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.rmSelectVariableEx3 = new EasyRpgCommands.RmSelectVariableEx();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rmSelectVariableEx1
            // 
            this.rmSelectVariableEx1.ItemWidth1 = 100;
            this.rmSelectVariableEx1.ItemWidth2 = 120;
            this.rmSelectVariableEx1.Location = new System.Drawing.Point(187, 25);
            this.rmSelectVariableEx1.Name = "rmSelectVariableEx1";
            this.rmSelectVariableEx1.NumericButtonClick = null;
            this.rmSelectVariableEx1.NumericValue = 0;
            this.rmSelectVariableEx1.SelectedType = cmdcs.RmSelectVariableEx.ValueType.EventId;
            this.rmSelectVariableEx1.SelectedTypeIndex = 0;
            this.rmSelectVariableEx1.Size = new System.Drawing.Size(490, 35);
            this.rmSelectVariableEx1.StringButtonClick = null;
            this.rmSelectVariableEx1.StringValue = "";
            this.rmSelectVariableEx1.TabIndex = 2;
            this.rmSelectVariableEx1.ValueRange = ((System.ValueTuple<int, int>)(resources.GetObject("rmSelectVariableEx1.ValueRange")));
            this.rmSelectVariableEx1.ValueTypeArray = new cmdcs.RmSelectVariableEx.ValueType[] {
        cmdcs.RmSelectVariableEx.ValueType.EventId,
        cmdcs.RmSelectVariableEx.ValueType.Variable,
        cmdcs.RmSelectVariableEx.ValueType.VariableRef};
            // 
            // rmSelectVariableEx2
            // 
            this.rmSelectVariableEx2.ItemWidth1 = 100;
            this.rmSelectVariableEx2.ItemWidth2 = 120;
            this.rmSelectVariableEx2.Location = new System.Drawing.Point(187, 66);
            this.rmSelectVariableEx2.Name = "rmSelectVariableEx2";
            this.rmSelectVariableEx2.NumericButtonClick = null;
            this.rmSelectVariableEx2.NumericValue = 0;
            this.rmSelectVariableEx2.SelectedType = cmdcs.RmSelectVariableEx.ValueType.NumericLiteral;
            this.rmSelectVariableEx2.SelectedTypeIndex = 0;
            this.rmSelectVariableEx2.Size = new System.Drawing.Size(490, 35);
            this.rmSelectVariableEx2.StringButtonClick = null;
            this.rmSelectVariableEx2.StringValue = "";
            this.rmSelectVariableEx2.TabIndex = 3;
            this.rmSelectVariableEx2.ValueRange = ((System.ValueTuple<int, int>)(resources.GetObject("rmSelectVariableEx2.ValueRange")));
            this.rmSelectVariableEx2.ValueTypeArray = new cmdcs.RmSelectVariableEx.ValueType[] {
        cmdcs.RmSelectVariableEx.ValueType.NumericLiteral,
        cmdcs.RmSelectVariableEx.ValueType.Variable,
        cmdcs.RmSelectVariableEx.ValueType.VariableRef};
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Event ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Failure count:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.rmSelectVariableEx3);
            this.groupBox1.Controls.Add(this.rmSelectVariableEx1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.rmSelectVariableEx2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(704, 162);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Wait For Single Movement (Requires EasyRPG Player)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Output var:";
            // 
            // rmSelectVariableEx3
            // 
            this.rmSelectVariableEx3.ItemWidth1 = 100;
            this.rmSelectVariableEx3.ItemWidth2 = 120;
            this.rmSelectVariableEx3.Location = new System.Drawing.Point(187, 107);
            this.rmSelectVariableEx3.Name = "rmSelectVariableEx3";
            this.rmSelectVariableEx3.NumericButtonClick = null;
            this.rmSelectVariableEx3.NumericValue = 0;
            this.rmSelectVariableEx3.SelectedType = cmdcs.RmSelectVariableEx.ValueType.NumericLiteral;
            this.rmSelectVariableEx3.SelectedTypeIndex = 0;
            this.rmSelectVariableEx3.Size = new System.Drawing.Size(490, 35);
            this.rmSelectVariableEx3.StringButtonClick = null;
            this.rmSelectVariableEx3.StringValue = "";
            this.rmSelectVariableEx3.TabIndex = 6;
            this.rmSelectVariableEx3.ValueRange = ((System.ValueTuple<int, int>)(resources.GetObject("rmSelectVariableEx3.ValueRange")));
            this.rmSelectVariableEx3.ValueTypeArray = new cmdcs.RmSelectVariableEx.ValueType[] {
        cmdcs.RmSelectVariableEx.ValueType.NumericLiteral,
        cmdcs.RmSelectVariableEx.ValueType.Variable,
        cmdcs.RmSelectVariableEx.ValueType.VariableRef};
            // 
            // WaitForSingleMovementControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Name = "WaitForSingleMovementControl";
            this.Size = new System.Drawing.Size(710, 173);
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
    }
}
