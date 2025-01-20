using cmdcs;
using System;
using System.Collections;
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
    [Rm2k3CmdControl(2003, "Ghabry", "Path Finder", "Path Finder")]
    public partial class PathFinderControl : SingleCommandControl
    {
        public PathFinderControl()
        {
            InitializeComponent();
        }
        public PathFinderControl(List<EventCommand> _ev) : base(_ev, (cmdcs.Code)2003, "")
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

            checkAllowDiag.Checked = (TargetCommand[10] & 2) > 0;
            checkDebug.Checked = (TargetCommand[10] & 4) > 0;
            checkSkip.Checked = (TargetCommand[10] & 16) > 0;

            if ((TargetCommand[10] & 1) > 0) {
                radioWait.Checked = true;
            } else if ((TargetCommand[10] & 8) > 0) {
                radioSkip.Checked = true;
            }
            else {
                radioFind.Checked = true;
            }

            rmSelectVariableEx6.SelectedTypeIndex = TargetCommand[11];
            rmSelectVariableEx6.NumericValue = TargetCommand[12];

            int ni = 13;
            if (TargetCommand[12] > 0 && TargetCommand[11] == 0) {
                for (int i = 0; i < TargetCommand[12]; ++i) {
                    if (i > 0) eventidText.Text += ",";
                    eventidText.Text += TargetCommand[ni].ToString();
                    ++ni;
                }
            }

            rmSelectVariableEx7.SelectedTypeIndex = TargetCommand[ni];
            rmSelectVariableEx7.NumericValue = TargetCommand[ni+1];

            eventidText.Enabled = (rmSelectVariableEx6.SelectedType == cmdcs.RmSelectVariableEx.ValueType.NumericLiteral);
            rmSelectVariableEx6.ud_value.Enabled = !eventidText.Enabled;
        }

        protected override (string Text, int[] Args) CommandArgs
        {
            get
            {
                List<int> events = new List<int>();
                events.AddRange(new int[] {
                    rmSelectVariableEx1.SelectedTypeIndex, rmSelectVariableEx1.NumericValue,
                    rmSelectVariableEx2.SelectedTypeIndex, rmSelectVariableEx2.NumericValue,
                    rmSelectVariableEx3.SelectedTypeIndex, rmSelectVariableEx3.NumericValue,
                    rmSelectVariableEx4.SelectedTypeIndex, rmSelectVariableEx4.NumericValue,
                    rmSelectVariableEx5.SelectedTypeIndex, rmSelectVariableEx5.NumericValue
                });

                int flag = 0;
                flag += radioWait.Checked ? 1 : 0;
                flag += checkAllowDiag.Checked ? 2 : 0;
                flag += checkDebug.Checked ? 4 : 0;
                flag += radioSkip.Checked ? 8 : 0;
                flag += checkSkip.Checked ? 16 : 0;
                events.Add(flag);

                events.AddRange(new int[]
                {
                    rmSelectVariableEx6.SelectedTypeIndex, rmSelectVariableEx6.NumericValue
                });

                if (rmSelectVariableEx6.SelectedType == cmdcs.RmSelectVariableEx.ValueType.NumericLiteral)
                {
                    var items = eventidText.Text.Split(',');

                    int len_index = events.Count - 1;
                    int ev_added = 0;

                    foreach (var ev in items)
                    {
                        String evt = ev.Trim();
                        if (int.TryParse(evt, out int result))
                        {
                            if (result > 0) {
                                events.Add(result);
                                ++ev_added;
                            }
                        }
                    }

                    events[len_index] = ev_added;
                }

                events.AddRange(new int[]
                {
                    rmSelectVariableEx7.SelectedTypeIndex, rmSelectVariableEx7.NumericValue
                });

                return (TargetCommand.Text, events.ToArray());
            }
        }

        private void rmSelectVariableEx6_ValueTypeChanged(object sender, RmSelectVariableExEventArgs e)
        {
            eventidText.Enabled = (e.Type == cmdcs.RmSelectVariableEx.ValueType.NumericLiteral);
            rmSelectVariableEx6.ud_value.Enabled = !eventidText.Enabled;
        }

        private void buttonMoveRoute_Click(object sender, EventArgs e)
        {
            rmSelectVariableEx4.SelectedTypeIndex = 0;
            rmSelectVariableEx4.NumericValue = 500;

            rmSelectVariableEx5.SelectedTypeIndex = 0;
            rmSelectVariableEx5.NumericValue = -1;

            radioFind.Checked = true;
        }

        private void buttonStepForward_Click(object sender, EventArgs e)
        {
            rmSelectVariableEx4.SelectedTypeIndex = 0;
            rmSelectVariableEx4.NumericValue = 150;

            rmSelectVariableEx5.SelectedTypeIndex = 0;
            rmSelectVariableEx5.NumericValue = 1;

            radioWait.Checked = true;
        }

        private void eventidText_TextChanged(object sender, EventArgs e)
        {
            if (rmSelectVariableEx6.SelectedType != cmdcs.RmSelectVariableEx.ValueType.NumericLiteral)
            {
                return;
            }

            var items = eventidText.Text.Split(',');

            int ev_added = 0;

            foreach (var ev in items)
            {
                String evt = ev.Trim();
                if (int.TryParse(evt, out int result))
                {
                    if (result > 0)
                    {
                        ++ev_added;
                    }
                }
            }

            rmSelectVariableEx6.NumericValue = ev_added;
        }

        private void radioFind_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
