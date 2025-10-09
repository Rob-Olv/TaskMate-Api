using System.ComponentModel;

namespace TaskMate.Domain
{
    public enum StatusImageEnum : byte
    {
        [Description("Pending")]
        Pending,
        [Description("Processing")]
        Processing,
        [Description("Completed")]
        Completed,
        [Description("Failed")]
        Failed
    }
}
