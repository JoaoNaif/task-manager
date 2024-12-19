using TaskManager.Communication.Requests;

namespace TaskManager.Application.UseCases.Task;

public class GetAllTaskUseCase
{
    public ResponseAllTaskJson Execute()
    {
        return new ResponseAllTaskJson
        {
            Tasks = new List<ResponseShortTaskJson>
            {
                new ResponseShortTaskJson
                {
                    Id = 1,
                    Name = "John",
                    Limit = new DateTime(year: 2024, month: 12, day: 29),
                    Status = Communication.Enums.TaskStatus.InProgress
                }
            }
        };
    }
}