using DNTPersianUtils.Core;
using System.ComponentModel.DataAnnotations;

namespace ToDoList.Project.Entities
{
    public class BaseEntity
    {
        public BaseEntity()
        {
            CreationDate = DateTime.Parse(DateTime.Now.ToString("G"));
            PersianDateTime = DateTime.Now.ToShortPersianDateTimeString();
            ModificationDate = null;
            IsRemove = false;
        }
        public int Id { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime? ModificationDate { get; set; }
        [MaxLength(16)]
        public string PersianDateTime { get; set; }
        public bool IsRemove { get; set; } = false;
    }
}