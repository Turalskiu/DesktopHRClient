using Microsoft.Maui.Platform;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRClient.Triggers
{
    public class EntryEmptyValidation : TriggerAction<Entry>
    {
        protected override void Invoke(Entry sender)
        {
            if (sender.Text.Length == 0)
                sender.PlaceholderColor = Colors.Red;
            else
                sender.PlaceholderColor = Colors.White;
        }
    }
}
