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

            rmSelectVariableEx3.SelectedTypeIndex = TargetCommand[4];
            rmSelectVariableEx3.NumericValue = TargetCommand[5];

            rmSelectVariableEx4.SelectedTypeIndex = TargetCommand[6];
            rmSelectVariableEx4.NumericValue = TargetCommand[7];

            rmSelectVariableEx5.StringValue = TargetCommand.Text;
            rmSelectVariableEx5.SelectedTypeIndex = TargetCommand[8];
            rmSelectVariableEx5.NumericValue = TargetCommand[9];

            int flags = TargetCommand[10];
            radioButton_parse0.Checked = true;
            radioButton_parse1.Checked = (flags & 1) == 1;
            radioButton_parse2.Checked = (flags & 2) == 2;
            checkBox_pp.Checked = (flags & 4) == 4;
            checkBox_keys.Checked = (flags & 8) == 8;

            rmSelectVariableEx1.SetItems("Get Value", "Set Value", "Get Length", "Get Keys", "Get Type", "Remove Key", "Array Push", "Array Pop", "Contains");
            rmSelectVariableEx3.SetItems("Switch", "Variable", "String");
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

        protected override (string Text, int[] Args) CommandArgs => (rmSelectVariableEx5.StringValue,
            new int[] {
                rmSelectVariableEx1.SelectedTypeIndex, rmSelectVariableEx1.NumericValue,
                rmSelectVariableEx2.SelectedTypeIndex, rmSelectVariableEx2.NumericValue,
                rmSelectVariableEx3.SelectedTypeIndex, rmSelectVariableEx3.NumericValue,
                rmSelectVariableEx4.SelectedTypeIndex, rmSelectVariableEx4.NumericValue,
                rmSelectVariableEx5.SelectedTypeIndex, rmSelectVariableEx5.NumericValue,
                makeFlags()
            });
    }
}
