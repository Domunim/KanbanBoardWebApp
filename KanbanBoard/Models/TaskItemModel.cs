using System.ComponentModel.DataAnnotations;

namespace KanbanBoard.Models
{
    public class TaskItemModel
    {
        public int ID { get; set; }
        
        public string Title { get; set; }
        
        [DataType(DataType.Date)]
        public DateTime CreationDate { get; set; }

        [DataType(DataType.Date)]
        public DateTime Deadline { get; set; }

        public string Tag { get; set; }
       
        public string Priority { get; set; }

        public string Description { get; set; }

        public string BoardPosition { get; set; }
        
        public UserModel Creator { get; set; }
        
        public UserModel AssignedUser { get; set; }

        public TaskItemModel SubTaskItem { get; set; }

        public TeamModel Team { get; set; }

    }
}
