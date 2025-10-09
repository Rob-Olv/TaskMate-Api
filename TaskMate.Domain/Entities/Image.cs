using System;

namespace TaskMate.Domain
{
    public class Image : BaseDomain
    {
        public string Name { get; set; }
        public ImagePath Path { get; set; }
        public StatusImageEnum Status { get; set; }

        public int TaskId { get; set; }
        public virtual Task Task { get; set; }

        public Image() { }
        public Image(ImagePath path)
        {
            Path = path ?? throw new ArgumentNullException(nameof(path));
        }

        public void UpdateStatus(StatusImageEnum newStatus)
        {
            Status = newStatus;
        }
    }
}
