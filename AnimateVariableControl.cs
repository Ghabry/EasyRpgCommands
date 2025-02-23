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
    [Rm2k3CmdControl(2052, "Ghabry", "Animate Variable", "Animate Variable")]
    public partial class AnimateVariableControl : SingleCommandControl
    {
        public AnimateVariableControl()
        {
            InitializeComponent();
        }
        public AnimateVariableControl(List<EventCommand> _ev) : base(_ev, (cmdcs.Code)2052, "")
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

            rmSelectVariableEx5.SelectedTypeIndex = TargetCommand[8];
            rmSelectVariableEx5.NumericValue = TargetCommand[9];

            rmSelectVariableEx6.SelectedTypeIndex = TargetCommand[10];
            rmSelectVariableEx6.NumericValue = TargetCommand[11];

            ud_in_x1.Value = (decimal)(TargetCommand[12] / 1000.0);
            ud_in_y1.Value = (decimal)(TargetCommand[13] / 1000.0);
            ud_in_x2.Value = (decimal)(TargetCommand[14] / 1000.0);
            ud_in_y2.Value = (decimal)(TargetCommand[15] / 1000.0);
            ud_out_x1.Value = (decimal)(TargetCommand[16] / 1000.0);
            ud_out_y1.Value = (decimal)(TargetCommand[17] / 1000.0);
            ud_out_x2.Value = (decimal)(TargetCommand[18] / 1000.0);
            ud_out_y2.Value = (decimal)(TargetCommand[19] / 1000.0);

            string[] items = new string[]
            {
                "(None)",
                "(Custom Bezier Curve)",
                "Linear",
                "Ease", "Ease In", "Ease Out", "Ease InOut",
                "Quadratic In", "Quadratic Out", "Quatratic InOut",
                "Cubic In", "CubicOut", "CubicInOut",
                "Quart In", "QuartOut", "QuartInOut",
                "QuintIn", "QuintOut", "QuintInOut",
                "Sinusoidal In", "Sinusoidal Out", "Sinusoidal InOut",
                "Expontial In", "Expontial Out", "Expontial InOut",
                "Circular In", "Circular Out", "Circular InOut",
                "Back In", "Back Out", "Back InOut",
                "Elastic In", "Elastic Out", "Elastic InOut",
                "Bounce In", "Bounce Out", "Bouce InOut"
            };

            rmSelectVariableEx1.SetItems(items);
            rmSelectVariableEx2.SetItems(items);
        }

        protected override (string Text, int[] Args) CommandArgs => (rmSelectVariableEx6.StringValue,
            new int[] {
                rmSelectVariableEx1.SelectedTypeIndex, rmSelectVariableEx1.NumericValue,
                rmSelectVariableEx2.SelectedTypeIndex, rmSelectVariableEx2.NumericValue,
                rmSelectVariableEx3.SelectedTypeIndex, rmSelectVariableEx3.NumericValue,
                rmSelectVariableEx4.SelectedTypeIndex, rmSelectVariableEx4.NumericValue,
                rmSelectVariableEx5.SelectedTypeIndex, rmSelectVariableEx5.NumericValue,
                rmSelectVariableEx6.SelectedTypeIndex, rmSelectVariableEx6.NumericValue,
                (int)(ud_in_x1.Value * 1000),
                (int)(ud_in_y1.Value * 1000),
                (int)(ud_in_x2.Value * 1000),
                (int)(ud_in_y2.Value * 1000),
                (int)(ud_out_x1.Value * 1000),
                (int)(ud_out_y1.Value * 1000),
                (int)(ud_out_x2.Value * 1000),
                (int)(ud_out_y2.Value * 1000)
            });
    }
}
