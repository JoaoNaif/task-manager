using TaskManager.Communication.Requests;

namespace TaskManager.Application.UseCases.Task;

public class RegisterTaskUseCase
{
    public ResponseTaskRegisterJson Execute(RequestTaskJson request)
    {
        return new ResponseTaskRegisterJson
        {
            Id = 3,
            Name = request.Name,
            Limit = request.Limit,
        };
    }
}