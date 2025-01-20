using cmdcs;

namespace EasyRpgCommands
{
    [Rm2k3CmdControl(1234, "Ghabry", "Bla Control", "Blabla Control")]
    partial class RmSelectVariableEx
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
            ((System.ComponentModel.ISupportInitialize)(this.ud_value)).BeginInit();
            this.SuspendLayout();
            // 
            // RmSelectVariableEx
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "RmSelectVariableEx";
            ((System.ComponentModel.ISupportInitialize)(this.ud_value)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
    }
}
