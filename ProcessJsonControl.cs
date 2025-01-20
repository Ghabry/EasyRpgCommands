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

            jsonPanel.Enabled = (rmSelectVariableEx1.SelectedType == cmdcs.RmSelectVariableEx.ValueType.NumericLiteral);
            typePanel.Enabled = (rmSelectVariableEx3.SelectedType == cmdcs.RmSelectVariableEx.ValueType.NumericLiteral);

            rmSelectVariableEx1.ud_value.Enabled = !jsonPanel.Enabled;
            rmSelectVariableEx3.ud_value.Enabled = !typePanel.Enabled;

            readButton.Checked = rmSelectVariableEx1.NumericValue == 0;
            writeButton.Checked = rmSelectVariableEx1.NumericValue == 1;

            switchButton.Checked = rmSelectVariableEx3.NumericValue == 0;
            varButton.Checked = rmSelectVariableEx3.NumericValue == 1;
            stringButton.Checked = rmSelectVariableEx3.NumericValue == 2;
        }

        protected override (string Text, int[] Args) CommandArgs => (rmSelectVariableEx5.StringValue,
            new int[] {
                rmSelectVariableEx1.SelectedTypeIndex, rmSelectVariableEx1.NumericValue,
                rmSelectVariableEx2.SelectedTypeIndex, rmSelectVariableEx2.NumericValue,
                rmSelectVariableEx3.SelectedTypeIndex, rmSelectVariableEx3.NumericValue,
                rmSelectVariableEx4.SelectedTypeIndex, rmSelectVariableEx4.NumericValue,
                rmSelectVariableEx5.SelectedTypeIndex, rmSelectVariableEx5.NumericValue,
            });

        private void readButton_CheckedChanged(object sender, EventArgs e)
        {
            if (readButton.Checked)
            {
                rmSelectVariableEx1.NumericValue = 0;
            }

            if (writeButton.Checked)
            {
                rmSelectVariableEx1.NumericValue = 1;
            }

        }

        private void rmSelectVariableEx1_ValueTypeChanged(object sender, RmSelectVariableExEventArgs e)
        {
            jsonPanel.Enabled = (e.Type == cmdcs.RmSelectVariableEx.ValueType.NumericLiteral);
            rmSelectVariableEx1.ud_value.Enabled = !jsonPanel.Enabled;
        }

        private void rmSelectVariableEx3_ValueTypeChanged(object sender, RmSelectVariableExEventArgs e)
        {
            typePanel.Enabled = (e.Type == cmdcs.RmSelectVariableEx.ValueType.NumericLiteral);
            rmSelectVariableEx3.ud_value.Enabled = !typePanel.Enabled;
        }

        private void switchButton_CheckedChanged(object sender, EventArgs e)
        {
            if (switchButton.Checked)
            {
                rmSelectVariableEx3.NumericValue = 0;
            }

            if (varButton.Checked)
            {
                rmSelectVariableEx3.NumericValue = 1;
            }

            if (stringButton.Checked)
            {
                rmSelectVariableEx3.NumericValue = 2;
            }
        }
    }
}
