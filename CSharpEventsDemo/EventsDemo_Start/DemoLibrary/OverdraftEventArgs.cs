using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary
{
    public class OverdraftEventArgs: EventArgs
    {
        public decimal AmmountOverDraft { get; private set; }
        public string MoreInfo { get; private set; }
        public bool CancleTransaction { get; set; } = false;
        public OverdraftEventArgs(decimal ammountOverDraft, string moreInfo)
        {
            AmmountOverDraft = ammountOverDraft;
            MoreInfo = moreInfo;
        }
    }
}
