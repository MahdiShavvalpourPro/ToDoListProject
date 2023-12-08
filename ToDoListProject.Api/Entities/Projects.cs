namespace ToDoList.Project.Entities
{
    public class Projects : BaseEntity
    {
        public string Name { get; private set; }
        public Status ProjectStatus { get; private set; } = Status.Canceled;
        public PriorityLevel PriorityLevel { get; private set; } = PriorityLevel.Low;
        public string? Descrption { get; private set; }
        public People Owner { get; set; }

        public Projects(
            string name,
            People owner,
            Status status = Status.Canceled,
            PriorityLevel priorityLevel = PriorityLevel.Low,
            string description = ""
            )
        {
            NameValidation(name);
            Name = name;
            Owner = owner;
            ProjectStatus = status;
            PriorityLevel = priorityLevel;
            Descrption = description;
        }

        public void NameValidation(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentNullException("Name Is Not Valid . Name Is Required");
            }
        }
    }
}
