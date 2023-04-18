namespace KanbanBoard.Models
{
    public class TeamModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<UserModel> Members { get; set; }
        public UserModel Leader { get; set; }
        public List<UserModel> Admins { get; set; }
        public List<TaskItemModel> TaskItems { get; set; }

    }
}
