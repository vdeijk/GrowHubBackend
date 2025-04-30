namespace Models
{
    public class TodoItem
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public TodoStatus TodoStatus { get; set; }
        public DateTime DueDate { get; set; }
        public Priority Priority { get; set; }
        public Category Category { get; set; }
        public string? Description { get; set; }
    }
}
