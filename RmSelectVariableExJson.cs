using cmdcs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EasyRpgCommands
{
    public partial class RmSelectVariableExJson : RmSelectVariableEx
    {
        public String LastInput = "";

        public class TextEventArgs : EventArgs
        {
            public string Text { get; }

            public TextEventArgs(string message)
            {
                Text = message;
            }
        }

        public delegate void TextEventHandler(object sender, TextEventArgs e);
        public event TextEventHandler JsonTextChanged;

        public Button jsonBtn = new Button();

        public RmSelectVariableExJson() : base()
        {
            ValueTypeChanged += RmSelectVariableExJson_ValueTypeChanged;

            jsonBtn.Text = "Edit JSON";
            jsonBtn.Click += (bsender, bevt) =>
            {
                using (TextInputDialog dialog = new TextInputDialog(LastInput))
                {
                    if (dialog.ShowDialog() == DialogResult.OK)
                    {
                        LastInput = dialog.UserInput;
                        JsonTextChanged?.Invoke(this, new TextEventArgs(dialog.UserInput));
                    }
                }
            };
        }

        private void RmSelectVariableExJson_ValueTypeChanged(object sender, RmSelectVariableExEventArgs e)
        {
            if (e.Type == ValueType.StringLiteral)
            {
                panel.Controls.Add(jsonBtn);
                panel.SetCellPosition(jsonBtn, new TableLayoutPanelCellPosition(1, 0));
                panel.SetColumnSpan(jsonBtn, 2);
            } else
            {
                panel.Controls.Remove(jsonBtn);
            }
        }
    }
}
