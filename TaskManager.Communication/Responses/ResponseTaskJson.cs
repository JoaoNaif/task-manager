using TaskManager.Communication.Enums;
using TaskStatus = TaskManager.Communication.Enums.TaskStatus;

namespace TaskManager.Communication.Requests;

public class ResponseTaskJson
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public DateTime Limit { get; set; }
    public TaskPriority Priority { get; set; }
    public TaskStatus Status { get; set; }
}