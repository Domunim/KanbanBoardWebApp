namespace KanbanBoard.Models
{
    public class UserModel
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public TeamModel Team { get; set; }
        public bool EmailConfirmed { get; set; } = false;
    }
}
