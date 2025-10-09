using System.ComponentModel;

namespace TaskMate.Domain
{
    public enum StatusTaskEnum : byte
    {
        [Description("Pending")]
        Pending,
        [Description("In Progress")]
        InProgress,
        [Description("Completed")]
        Completed,
        [Description("Expired")]
        Expired,
        [Description("Failed")]
        Failed
    }
}
