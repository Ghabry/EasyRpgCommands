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
    [Rm2k3CmdControl(2057, "Ghabry", "Destroy Map Event", "Destroy Map Event")]
    public partial class DestroyMapEventControl : SingleCommandControl
    {
        public DestroyMapEventControl()
        {
            InitializeComponent();
        }
        public DestroyMapEventControl(List<EventCommand> _ev) : base(_ev, (cmdcs.Code)2057, "")
        {
            InitializeComponent();

            rmSelectVariableEx1.SelectedTypeIndex = TargetCommand[0];
            rmSelectVariableEx1.NumericValue = TargetCommand[1];
        }

        protected override (string Text, int[] Args) CommandArgs => (TargetCommand.Text,
            new int[] {
                rmSelectVariableEx1.SelectedTypeIndex, rmSelectVariableEx1.NumericValue
            });

    }
}
