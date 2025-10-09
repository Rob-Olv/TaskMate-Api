using System.ComponentModel;

namespace TaskMate.Domain
{
    public enum PriorityTaskEnum : byte
    {
        [Description("Low")]
        Low,
        [Description("Medium")]
        Medium,
        [Description("High")]
        High
    }
}
