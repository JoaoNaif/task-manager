using TaskStatus = TaskManager.Communication.Enums.TaskStatus;

namespace TaskManager.Communication.Requests;

public class ResponseShortTaskJson
{
    public int Id { get; set; }
    public string Name { get; set; }
    public DateTime Limit { get; set; }
    public TaskStatus Status { get; set; }
}