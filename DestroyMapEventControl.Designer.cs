
namespace EasyRpgCommands
{
    partial class DestroyMapEventControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DestroyMapEventControl));
            this.rmSelectVariableEx1 = new EasyRpgCommands.RmSelectVariableEx();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
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
            this.rmSelectVariableEx1.SelectedType = cmdcs.RmSelectVariableEx.ValueType.ExecutableEventId;
            this.rmSelectVariableEx1.SelectedTypeIndex = 0;
            this.rmSelectVariableEx1.Size = new System.Drawing.Size(475, 35);
            this.rmSelectVariableEx1.StringButtonClick = null;
            this.rmSelectVariableEx1.StringValue = "";
            this.rmSelectVariableEx1.TabIndex = 2;
            this.rmSelectVariableEx1.ValueRange = ((System.ValueTuple<int, int>)(resources.GetObject("rmSelectVariableEx1.ValueRange")));
            this.rmSelectVariableEx1.ValueTypeArray = new cmdcs.RmSelectVariableEx.ValueType[] {
        cmdcs.RmSelectVariableEx.ValueType.ExecutableEventId,
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rmSelectVariableEx1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(704, 72);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Destroy Map Event (Requires EasyRPG Player)";
            // 
            // DestroyMapEventControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Name = "DestroyMapEventControl";
            this.Size = new System.Drawing.Size(710, 89);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private RmSelectVariableEx rmSelectVariableEx1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}
