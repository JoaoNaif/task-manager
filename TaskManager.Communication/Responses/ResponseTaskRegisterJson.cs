namespace TaskManager.Communication.Requests;

public class ResponseTaskRegisterJson
{
    public int Id { get; set; }

    public string Name { get; set; } = string.Empty;
    
    public DateTime Limit { get; set; }
}