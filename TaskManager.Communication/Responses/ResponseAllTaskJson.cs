namespace TaskManager.Communication.Requests;

public class ResponseAllTaskJson
{
    public List<ResponseShortTaskJson> Tasks { get; set; } = [];
}