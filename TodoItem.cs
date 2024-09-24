namespace BlazorTutorial
{
    public enum Status
    {
        NotStarted,
        InProgress,
        Completed
    }
    
    public class TodoItem
    {
        public string? Title { get; set; }
        public bool IsDone { get; set; }
        public Status Status { get; set; }
    }
}
