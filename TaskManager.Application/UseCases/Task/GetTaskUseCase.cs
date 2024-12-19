using TaskManager.Communication.Requests;

namespace TaskManager.Application.UseCases.Task;

public class GetTaskUseCase
{
    public ResponseTaskJson Execute(int id)
    {
        return new ResponseTaskJson
        {
            Id = id,
            Name = "Jake",
            Description = "Descrição qualquer, só testando mesmo!",
            Limit = new DateTime(2025, 02, 10),
            Priority = Communication.Enums.TaskPriority.Normal,
            Status = Communication.Enums.TaskStatus.Completed,
        };
    }
}