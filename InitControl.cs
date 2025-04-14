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
    [EasyCmdControl(2999, "Ghabry", "EasyRPG Plugin Init", "EasyRPG Plugin Init")]
    public partial class InitControl : SingleCommandControl
    {
        public InitControl()
        {
        }
        public InitControl(List<EventCommand> _ev) : base(_ev, (cmdcs.Code)2999, "")
        {
            
        }
    }
}
