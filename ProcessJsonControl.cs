using cmdcs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EasyRpgCommands
{
    [Rm2k3CmdControl(2055, "Ghabry", "Process JSON", "Process JSON")]
    public partial class ProcessJsonControl : SingleCommandControl
    {
        private String json_text = "";
        public ProcessJsonControl()
        {
            InitializeComponent();
        }
        public ProcessJsonControl(List<EventCommand> _ev) : base(_ev, (cmdcs.Code)2055, "")
        {
            InitializeComponent();

            rmSelectVariableEx1.SelectedTypeIndex = TargetCommand[0];
            rmSelectVariableEx1.NumericValue = TargetCommand[1];

            rmSelectVariableEx2.SelectedTypeIndex = TargetCommand[2];
            rmSelectVariableEx2.NumericValue = TargetCommand[3];
            rmSelectVariableEx2.JsonTextChanged += RmSelectVariableEx2_JsonTextChanged;

            rmSelectVariableEx3.SelectedTypeIndex = TargetCommand[4];
            rmSelectVariableEx3.NumericValue = TargetCommand[5];

            rmSelectVariableEx4.SelectedTypeIndex = TargetCommand[6];
            rmSelectVariableEx4.NumericValue = TargetCommand[7];

            rmSelectVariableEx5.SelectedTypeIndex = TargetCommand[8];
            rmSelectVariableEx5.NumericValue = TargetCommand[9];

            int flags = TargetCommand[10];
            radioButton_parse0.Checked = true;
            radioButton_parse1.Checked = (flags & 1) == 1;
            radioButton_parse2.Checked = (flags & 2) == 2;
            checkBox_pp.Checked = (flags & 4) == 4;
            checkBox_keys.Checked = (flags & 8) == 8;

            if (rmSelectVariableEx5.SelectedTypeIndex == 0 && rmSelectVariableEx5.NumericValue == 0 && TargetCommand.Text.Length > 0)
            {
                rmSelectVariableEx2.SelectedTypeIndex = TargetCommand[2] + 1;
                rmSelectVariableEx5.StringValue = TargetCommand.Text;
                MessageBox.Show("Command converted to latest version. Click OK to save the fix.");
            }
            else
            {

                int start = 0;
                if (rmSelectVariableEx5.SelectedTypeIndex == 0)
                {
                    rmSelectVariableEx5.StringValue = TargetCommand.Text.SafeSubstring(start, rmSelectVariableEx5.NumericValue);
                    start += rmSelectVariableEx5.NumericValue;
                }

                if (rmSelectVariableEx2.SelectedTypeIndex == 0)
                {
                    rmSelectVariableEx2.StringValue = TargetCommand.Text.SafeSubstring(start, rmSelectVariableEx2.NumericValue);
                    json_text = rmSelectVariableEx2.StringValue;
                }
            }

            rmSelectVariableEx2.LastInput = json_text.Replace("\n", "\r\n");

            rmSelectVariableEx1.SetItems("Get Value", "Set Value", "Get Length", "Get Keys", "Get Type", "Remove Key", "Array Push", "Array Pop", "Contains");
            rmSelectVariableEx3.SetItems("Switch", "Variable", "String");
        }

        private void RmSelectVariableEx2_JsonTextChanged(object sender, RmSelectVariableExJson.TextEventArgs e)
        {
            json_text = e.Text.Replace("\r", "");
        }

        private int makeFlags()
        {
            int flags = 0;

            flags += radioButton_parse1.Checked ? 1 : 0;
            flags += radioButton_parse2.Checked ? 2 : 0;
            flags += checkBox_pp.Checked ? 4 : 0;
            flags += checkBox_keys.Checked ? 8 : 0;

            return flags;
        }
        private String makeStringValue()
        {
            String ret = "";

            if (rmSelectVariableEx5.SelectedTypeIndex == 0)
            {
                rmSelectVariableEx5.NumericValue = rmSelectVariableEx5.StringValue.Length;
                ret += rmSelectVariableEx5.StringValue;
            }

            if (rmSelectVariableEx2.SelectedTypeIndex == 0)
            {
                rmSelectVariableEx2.NumericValue = json_text.Length;
                ret += json_text;
            }

            return ret;
        }

        protected override (string Text, int[] Args) CommandArgs => (makeStringValue(),
            new int[] {
                rmSelectVariableEx1.SelectedTypeIndex, rmSelectVariableEx1.NumericValue,
                rmSelectVariableEx2.SelectedTypeIndex, rmSelectVariableEx2.SelectedTypeIndex == 0 ? json_text.Length : rmSelectVariableEx2.NumericValue,
                rmSelectVariableEx3.SelectedTypeIndex, rmSelectVariableEx3.NumericValue,
                rmSelectVariableEx4.SelectedTypeIndex, rmSelectVariableEx4.NumericValue,
                rmSelectVariableEx5.SelectedTypeIndex, rmSelectVariableEx5.SelectedTypeIndex == 0 ? rmSelectVariableEx5.StringValue.Length : rmSelectVariableEx5.NumericValue,
                makeFlags()
            });
    }
}
