namespace AppTask.Models
{
    public class TaskModel
    {
        public int Id { get; set; }

        public string Name { get; set; } = String.Empty;

        public string Description { get; set; } = String.Empty;

        public DateTime CreatedAt { get; set; }

        public DateTime PrevisionDate { get; set; }
        
        public bool IsCompeleted { get; set; }

        public List<SubtaskModel> SubTasks { get; set; } = new List<SubtaskModel>();
    }
}