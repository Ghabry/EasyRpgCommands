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
    public partial class RmSelectVariableEx : cmdcs.RmSelectVariableEx
    {
        protected ComboBox cb_type = null;
        protected NumericUpDown ud_val = null;
        protected ComboBox cb_item = null;
        protected TableLayoutPanel panel = null;
        protected bool restoreLayout = false;

        public RmSelectVariableEx() : base()
        {
            cb_type = GetComboBox(this);
            ud_val = GetControl<NumericUpDown>(this);
            panel = GetControl<TableLayoutPanel>(this);

            ValueTypeChanged += RmSelectVariableEx_ValueTypeChanged;
        }

        public void SetItems(params String[] items)
        {
            cb_item.Items.Clear();

            for (int i = 0; i < items.Length; ++i)
            {
                cb_item.Items.Add(string.Format("{0:D2}: {1}", i, items[i]));
            }

            //ud_val.Maximum = cb_item.Items.Count - 1;
            //ud_val.Minimum = 0;

            if (ud_val.Value < 0 || ud_val.Value >= cb_item.Items.Count)
            {
                return;
            }

            cb_item.SelectedIndex = (int)ud_val.Value;
        }

        public ComboBox GetComboBox(Control Controls)
        {
            foreach (Control control in Controls.Controls)
            {
                if (control == cb_type)
                {
                    continue;
                }

                if (control is ComboBox comboBox)
                {
                    return comboBox;
                }
                else
                {
                    // Recursively check child controls if any
                    ComboBox result = GetComboBox(control);
                    if (result != null)
                    {
                        return result;
                    }
                }
            }
            return null;
        }
        public T GetControl<T>(Control Controls)
        {
            foreach (Control control in Controls.Controls)
            {
                if (control is T nud)
                {
                    return nud;
                }
                else
                {
                    // Recursively check child controls if any
                    T result = GetControl<T>(control);
                    if (result != null)
                    {
                        return result;
                    }
                }
            }
            return default(T);
        }

        private void RmSelectVariableEx_ValueTypeChanged(object sender, RmSelectVariableExEventArgs e)
        {
            if (e.Type == ValueType.Anim2Id)
            {
                if (cb_item == null)
                {
                    cb_item = GetComboBox(this);
                    cb_item.Items.Clear();
                }
                Control c0 = panel.Controls[0]; // cb_value
                Control c1 = panel.Controls[1]; // numeric up down
                c1.Visible = false;

                TableLayoutPanelCellPosition cellPos = new TableLayoutPanelCellPosition(1, 0);
                panel.SetCellPosition(c0, cellPos);
                panel.SetColumnSpan(c0, 2);

                restoreLayout = true;
            } else
            {
                if (restoreLayout)
                {
                    restoreLayout = false;

                    Control c0 = panel.Controls[0]; // cb_value
                    Control c1 = panel.Controls[1]; // numeric up down
                    c1.Visible = true;

                    TableLayoutPanelCellPosition cellPos = new TableLayoutPanelCellPosition(2, 0);
                    panel.SetCellPosition(c0, cellPos);
                    panel.SetColumnSpan(c0, 1);
                }
            }
        }
    }
}
