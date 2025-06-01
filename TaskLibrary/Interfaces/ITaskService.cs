
namespace TaskLibrary.Interfaces
{
    public interface ITaskService
    {
        Task<TaskModel> GetTaskByIdAsync(Guid id);
        Task<TaskModel> AddTaskAsync(string text, string assignee, StatusForTask status);
        Task UpdateTaskAsync(TaskModel task, string newText, string newAssignee, StatusForTask newStatus);
        Task DeleteTaskAsync(Guid taskId);
    }
}
