namespace ToDoList.Project.Entities
{
    public class Tasks : BaseEntity
    {
        public string Name { get; set; }
        public Status TaskStatus { get; set; } = Status.Canceled;
        public DateTime? StartTime { get; set; } = null;
        public DateTime? ExpireTime { get; set; } = null;
        public PriorityLevel PriorityLevel { get; set; } = PriorityLevel.Low;
        public string? Description { get; set; }
        public Projects Projects { get; set; }

        public Tasks(
            string name,
            DateTime startTime,
            DateTime endTime,
            Projects project,
            PriorityLevel priorityLevel = PriorityLevel.Low,
            Status status = Status.Canceled,
            string description = ""
            )
        {
            NameValidation(name);
            HistoricalPeriodValidation(startTime, endTime);
            Name = name;
            Projects = project;
            TaskStatus = status;
            StartTime = startTime;
            ExpireTime = endTime;
            PriorityLevel = priorityLevel;
            Description = description;
        }

        public void NameValidation(string name)
        {
            if (string.IsNullOrEmpty(name))
                throw new ArgumentNullException("name");
        }

        public void HistoricalPeriodValidation(DateTime start, DateTime end)
        {
            if (start >= end)
                throw new Exception("End date must be after the start date.");
        }
    }
}
