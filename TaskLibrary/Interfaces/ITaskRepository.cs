
namespace TaskLibrary.Interfaces
{
    public interface ITaskRepository
    {
        List<TaskModel> LoadTasks();
        Task<TaskModel> SearchTaskForIdAsync(Guid id);
        Task<StatusModel> SearchStatusAsync(StatusForTask status);
        Task<TaskModel> CreateTaskAsync(string text, string assignee, StatusModel status);
        Task SaveChangesAsync();
        Task RemoveTask(TaskModel task);
    }
}
