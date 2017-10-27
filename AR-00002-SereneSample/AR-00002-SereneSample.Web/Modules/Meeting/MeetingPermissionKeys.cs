
using Serenity.Extensibility;
using System.ComponentModel;

namespace AR_00002_SereneSample.Meeting
{
    [NestedPermissionKeys]
    public class PermissionKeys
    {
        [Description("[General]")]
        public const string General = "Meeting:General";

        public const string Management = "Meeting:Management";
    }
}
