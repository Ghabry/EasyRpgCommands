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
    [Rm2k3CmdControl(2002, "Ghabry", "Trigger Event At", "Trigger Event At")]
    public partial class TriggerEventAtControl : SingleCommandControl
    {
        public TriggerEventAtControl()
        {
            InitializeComponent();
        }
        public TriggerEventAtControl(List<EventCommand> _ev) : base(_ev, (cmdcs.Code)2002, "")
        {
            InitializeComponent();

            rmSelectVariableEx1.SelectedTypeIndex = TargetCommand[0];
            rmSelectVariableEx1.NumericValue = TargetCommand[1];

            rmSelectVariableEx2.SelectedTypeIndex = TargetCommand[2];
            rmSelectVariableEx2.NumericValue = TargetCommand[3];

            checkFace.Checked = (TargetCommand[4] & 1) > 0;
        }

        protected override (string Text, int[] Args) CommandArgs => (TargetCommand.Text,
            new int[] {
                rmSelectVariableEx1.SelectedTypeIndex, rmSelectVariableEx1.NumericValue,
                rmSelectVariableEx2.SelectedTypeIndex, rmSelectVariableEx2.NumericValue,
                checkFace.Checked ? 1 : 0});
    }
}
