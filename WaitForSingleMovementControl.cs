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
    [Rm2k3CmdControl(2051, "Ghabry", "Wait For Single Movement", "Wait For Single Movement")]
    public partial class WaitForSingleMovementControl : SingleCommandControl
    {
        public WaitForSingleMovementControl()
        {
            InitializeComponent();
        }
        public WaitForSingleMovementControl(List<EventCommand> _ev) : base(_ev, (cmdcs.Code)2051, "")
        {
            InitializeComponent();

            rmSelectVariableEx1.SelectedTypeIndex = TargetCommand[0];
            rmSelectVariableEx1.NumericValue = TargetCommand[1];

            rmSelectVariableEx2.SelectedTypeIndex = TargetCommand[2];
            rmSelectVariableEx2.NumericValue = TargetCommand[3];

            rmSelectVariableEx3.SelectedTypeIndex = TargetCommand[4];
            rmSelectVariableEx3.NumericValue = TargetCommand[5];
        }

        protected override (string Text, int[] Args) CommandArgs => (TargetCommand.Text,
            new int[] {
                rmSelectVariableEx1.SelectedTypeIndex, rmSelectVariableEx1.NumericValue,
                rmSelectVariableEx2.SelectedTypeIndex, rmSelectVariableEx2.NumericValue,
                rmSelectVariableEx3.SelectedTypeIndex, rmSelectVariableEx3.NumericValue,
            });

    }
}
