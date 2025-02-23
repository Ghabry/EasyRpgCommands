using cmdcs;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace EasyRpgCommands
{
    [Rm2k3CmdControl(2055, "Ghabry", "Process JSON", "Process JSON")]
    public partial class ProcessJsonControl : SingleCommandControl
    {
        private enum JsonOperation
        {
            Get = 0,
            Set = 1,
            GetLength = 2,
            GetKeys = 3,
            GetType = 4,
            Remove = 5,
            Push = 6,
            Pop = 7,
            Contains = 8

        }

        private enum ValueType
        {
            Switch = 0,
            Variable = 1,
            String = 2
        }

        private enum StringExtractionMode
        {
            None = 0,
            AsString = 1,
            AsHex = 2
        }

        public ProcessJsonControl()
        {
            InitializeComponent();
            ConfigureLayout();
        }

        public ProcessJsonControl(List<EventCommand> _ev) : base(_ev, (cmdcs.Code)2055, "")
        {
            InitializeComponent();
            ConfigureLayout();
            InitializeControls();
        }

        private void ConfigureLayout()
        {
            ConfigurePanels();
        }

        private void ConfigurePanels()
        {
            foreach (var panel in new[] { operationPanel, typePanel })
            {
                panel.AutoSize = true;
                panel.Anchor = AnchorStyles.Left | AnchorStyles.Top;
                panel.MinimumSize = new System.Drawing.Size(0, 0);
            }
        }

        private void InitializeControls()
        {
            InitializeDropdowns();
            InitializeVariableControls();
            UpdateControlsVisibility();
        }

        private void InitializeDropdowns()
        {
            // Initialize operation dropdown
            operationComboBox.Items.AddRange(new object[] {
                 "Get Value",
                 "Set Value",
                 "Get Length",
                 "Get Keys",
                 "Get Type",
                 "Remove Key",
                 "Push into Array",
                 "Pop from Array",
                 "Check if Key Exists"
             });
            operationComboBox.SelectedIndex = TargetCommand[1];

            // Initialize type dropdown
            typeComboBox.Items.AddRange(new object[] {
                 "Switch",
                 "Variable",
                 "String"
             });
            typeComboBox.SelectedIndex = TargetCommand[5];

            // Initialize string extraction dropdown
            extractionComboBox.Items.AddRange(new object[] {
                 "Don't Extract",
                 "As String",
                 "As Hex"
             });
            extractionComboBox.SelectedIndex = TargetCommand[10];

            // Initialize pretty print checkbox
            prettyPrintCheckbox.Checked = TargetCommand[11] != 0;
        }

        private void InitializeVariableControls()
        {
            var controls = new[]
            {
                 (rmSelectVariableEx1, 0, 1),
                 (rmSelectVariableEx2, 2, 3),
                 (rmSelectVariableEx3, 4, 5),
                 (rmSelectVariableEx4, 6, 7),
                 (rmSelectVariableEx5, 8, 9)
             };

            foreach (var (control, typeIndex, valueIndex) in controls)
            {
                control.SelectedTypeIndex = TargetCommand[typeIndex];
                control.NumericValue = TargetCommand[valueIndex];
            }

            rmSelectVariableEx5.StringValue = TargetCommand.Text;
        }

        private void UpdateControlsVisibility()
        {
            var isNumericLiteral = RmSelectVariableEx.ValueType.NumericLiteral;

            var operationPanelVisible = rmSelectVariableEx1.SelectedType == isNumericLiteral;
            var typePanelVisible = rmSelectVariableEx3.SelectedType == isNumericLiteral;

            UpdatePanelState(operationPanel, operationPanelVisible);
            UpdatePanelState(typePanel, typePanelVisible);

            UpdatePickerVisibility(rmSelectVariableEx1, !operationPanelVisible);
            UpdatePickerVisibility(rmSelectVariableEx3, !typePanelVisible);

            if (!operationPanelVisible) rmSelectVariableEx1.NumericValue = operationComboBox.SelectedIndex;
            if (!typePanelVisible) rmSelectVariableEx3.NumericValue = typeComboBox.SelectedIndex;

            PerformLayout();
        }

        private void UpdatePanelState(Panel panel, bool visible)
        {
            if (panel.Visible != visible)
            {
                panel.Visible = visible;
                panel.Parent?.PerformLayout();
            }
        }

        private void UpdatePickerVisibility(RmSelectVariableEx control, bool visible)
        {
            if (control == null) return;

            // Update numeric up/down control
            if (control.ud_value != null)
            {
                control.ItemWidth2 = visible ? control.ud_value.PreferredSize.Width + 12 : 0;
                control.Width = visible ? control.ItemWidth1 + control.ItemWidth2 + 138 : control.ItemWidth1;
                control.ud_value.Visible = visible;
                control.ud_value.Width = visible ? control.ud_value.PreferredSize.Width : 0;
            }

            // Update associated buttons
            foreach (Control child in control.Controls)
            {
                if (child is Button button && button != (Control)control.ud_value)
                {
                    button.Visible = !visible;
                }
            }
        }

        protected override (string Text, int[] Args) CommandArgs
        {
            get
            {
                var args = new List<int>
                 {
                     rmSelectVariableEx1.SelectedTypeIndex,
                     operationComboBox.SelectedIndex,
                     rmSelectVariableEx2.SelectedTypeIndex,
                     rmSelectVariableEx2.NumericValue,
                     rmSelectVariableEx3.SelectedTypeIndex,
                     typeComboBox.SelectedIndex,
                     rmSelectVariableEx4.SelectedTypeIndex,
                     rmSelectVariableEx4.NumericValue,
                     rmSelectVariableEx5.SelectedTypeIndex,
                     rmSelectVariableEx5.NumericValue,
                     extractionComboBox.SelectedIndex,
                     prettyPrintCheckbox.Checked ? 1 : 0
                 };

                return (rmSelectVariableEx5.StringValue, args.ToArray());
            }
        }

        private void operationComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            rmSelectVariableEx1.NumericValue = operationComboBox.SelectedIndex;
        }

        private void typeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            rmSelectVariableEx3.NumericValue = typeComboBox.SelectedIndex;
        }

        private void rmSelectVariableEx1_ValueTypeChanged(object sender, RmSelectVariableExEventArgs e)
        {
            UpdateControlsVisibility();
        }

        private void rmSelectVariableEx3_ValueTypeChanged(object sender, RmSelectVariableExEventArgs e)
        {
            UpdateControlsVisibility();
        }

        private void rmSelectVariableEx5_ValueTypeChanged(object sender, RmSelectVariableExEventArgs e)
        {
            UpdateControlsVisibility();
        }
    }
}
