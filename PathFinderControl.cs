using cmdcs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace EasyRpgCommands
{
    [Rm2k3CmdControl(2003, "Ghabry", "Path Finder", "Path Finder")]
    public partial class PathFinderControl : SingleCommandControl
    {
        [Flags]
        private enum PathFinderFlags
        {
            None = 0,
            Wait = 1,
            AllowDiagonal = 2,
            Debug = 4,
            Skip = 8,
            SkipEnabled = 16
        }

        public PathFinderControl()
        {
            InitializeComponent();
            SetupLayoutProperties();
        }

        public PathFinderControl(List<EventCommand> _ev) : base(_ev, (cmdcs.Code)2003, "")
        {
            InitializeComponent();
            SetupLayoutProperties();
            InitializeControls();
        }

        private void SetupLayoutProperties()
        {
            // Set AutoSize for containers to adjust their size when children are hidden
            foreach (Control control in this.Controls)
            {
                if (control is Panel panel)
                {
                    panel.AutoSize = true;
                    panel.Anchor = AnchorStyles.Left | AnchorStyles.Top;
                    panel.MinimumSize = new System.Drawing.Size(0, 0);
                }
            }
        }

        private void InitializeControls()
        {
            InitializeVariableControls();
            InitializeFlags();
            InitializeEventIds();
            UpdateControlsVisibility();
        }

        private void InitializeVariableControls()
        {
            var controls = new[] 
            {
                (rmSelectVariableEx1, 0, 1),
                (rmSelectVariableEx2, 2, 3),
                (rmSelectVariableEx3, 4, 5),
                (rmSelectVariableEx4, 6, 7),
                (rmSelectVariableEx5, 8, 9),
                (rmSelectVariableEx6, 11, 12),
                (rmSelectVariableEx7, -1, -1) // Will be set after event IDs
            };

            foreach (var (control, typeIndex, valueIndex) in controls)
            {
                if (typeIndex >= 0 && valueIndex >= 0)
                {
                    control.SelectedTypeIndex = TargetCommand[typeIndex];
                    control.NumericValue = TargetCommand[valueIndex];
                }
            }
        }

        private void InitializeFlags()
        {
            var flags = (PathFinderFlags)TargetCommand[10];

            checkAllowDiag.Checked = flags.HasFlag(PathFinderFlags.AllowDiagonal);
            checkDebug.Checked = flags.HasFlag(PathFinderFlags.Debug);
            checkSkip.Checked = flags.HasFlag(PathFinderFlags.SkipEnabled);

            if (flags.HasFlag(PathFinderFlags.Wait))
            {
                radioWait.Checked = true;
            }
            else if (flags.HasFlag(PathFinderFlags.Skip))
            {
                radioSkip.Checked = true;
            }
            else
            {
                radioFind.Checked = true;
            }
        }

        private void InitializeEventIds()
        {
            if (rmSelectVariableEx6.NumericValue > 0 && rmSelectVariableEx6.SelectedTypeIndex == 0)
            {
                int startIndex = 13;
                var eventIds = Enumerable.Range(0, rmSelectVariableEx6.NumericValue)
                    .Select(i => TargetCommand[startIndex + i].ToString());
                eventidText.Text = string.Join(",", eventIds);
            }

            int finalIndex = 13 + (rmSelectVariableEx6.NumericValue > 0 ? rmSelectVariableEx6.NumericValue : 0);
            rmSelectVariableEx7.SelectedTypeIndex = TargetCommand[finalIndex];
            rmSelectVariableEx7.NumericValue = TargetCommand[finalIndex + 1];
        }

        protected override (string Text, int[] Args) CommandArgs
        {
            get
            {
                var events = new List<int>();
                events.AddRange(GetBasicVariableValues());
                events.Add(CalculateFlags());
                events.AddRange(GetEventIdValues());
                events.AddRange(new[] { rmSelectVariableEx7.SelectedTypeIndex, rmSelectVariableEx7.NumericValue });

                return (TargetCommand.Text, events.ToArray());
            }
        }

        private int[] GetBasicVariableValues()
        {
            return new[] {
                rmSelectVariableEx1.SelectedTypeIndex, rmSelectVariableEx1.NumericValue,
                rmSelectVariableEx2.SelectedTypeIndex, rmSelectVariableEx2.NumericValue,
                rmSelectVariableEx3.SelectedTypeIndex, rmSelectVariableEx3.NumericValue,
                rmSelectVariableEx4.SelectedTypeIndex, rmSelectVariableEx4.NumericValue,
                rmSelectVariableEx5.SelectedTypeIndex, rmSelectVariableEx5.NumericValue
            };
        }

        private int CalculateFlags()
        {
            var flags = PathFinderFlags.None;
            if (radioWait.Checked) flags |= PathFinderFlags.Wait;
            if (checkAllowDiag.Checked) flags |= PathFinderFlags.AllowDiagonal;
            if (checkDebug.Checked) flags |= PathFinderFlags.Debug;
            if (radioSkip.Checked) flags |= PathFinderFlags.Skip;
            if (checkSkip.Checked) flags |= PathFinderFlags.SkipEnabled;
            return (int)flags;
        }

        private IEnumerable<int> GetEventIdValues()
        {
            var result = new List<int> { rmSelectVariableEx6.SelectedTypeIndex, rmSelectVariableEx6.NumericValue };

            if (rmSelectVariableEx6.SelectedType == RmSelectVariableEx.ValueType.NumericLiteral)
            {
                var validEventIds = eventidText.Text
                    .Split(',')
                    .Select(ev => ev.Trim())
                    .Where(ev => int.TryParse(ev, out int id) && id > 0)
                    .Select(ev => int.Parse(ev))
                    .ToList();

                result[1] = validEventIds.Count; // Update the count
                result.AddRange(validEventIds);
            }

            return result;
        }

        private void UpdateControlsVisibility()
        {
            bool shouldShowEventIdText = rmSelectVariableEx6.SelectedType == RmSelectVariableEx.ValueType.NumericLiteral;
            
            // Update text field visibility
            eventidText.Visible = shouldShowEventIdText;
            
            // Update picker visibility (both numeric value and variable picker button)
            UpdatePickerVisibility(rmSelectVariableEx6, !shouldShowEventIdText);

            // Force layout update
            this.PerformLayout();
        }

        private void UpdatePickerVisibility(RmSelectVariableEx control, bool visible)
        {
            // Hide both the numeric up/down and the variable picker button
            control.ud_value.Visible = visible;
            foreach (Control child in control.Controls)
            {
                if (child is Button && child != control.ud_value)
                {
                    child.Visible = visible;
                }
            }
        }

        private void rmSelectVariableEx6_ValueTypeChanged(object sender, RmSelectVariableExEventArgs e)
        {
            UpdateControlsVisibility();
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
            if (rmSelectVariableEx6.SelectedType != RmSelectVariableEx.ValueType.NumericLiteral)
            {
                return;
            }

            var validEventCount = eventidText.Text
                .Split(',')
                .Select(ev => ev.Trim())
                .Count(ev => int.TryParse(ev, out int result) && result > 0);

            rmSelectVariableEx6.NumericValue = validEventCount;
        }

        // Required by Designer
        private void radioFind_CheckedChanged(object sender, EventArgs e)
        {
            // This event handler is required by the Designer but doesn't need any implementation
        }
    }
}
