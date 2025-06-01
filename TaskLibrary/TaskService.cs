using TaskLibrary.Interfaces;

namespace TaskLibrary
{
    public class TaskService : ITaskService
    {
        private readonly ITaskRepository rep;

        public TaskService(ITaskRepository repo) => rep = repo;
        public Task<List<TaskModel>> GetTasksAsync() => Task.FromResult(rep.LoadTasks());

        public Task<TaskModel> GetTaskByIdAsync(Guid id) => rep.SearchTaskForIdAsync(id);

        public async Task<TaskModel> AddTaskAsync(string text, string assignee, StatusForTask status)
        {
            var statusModel = await rep.SearchStatusAsync(status);
            return await rep.CreateTaskAsync(text, assignee, statusModel);
        }

        public async Task UpdateTaskAsync(TaskModel task, string newText, string newAssignee, StatusForTask newStatus)
        {
            task.Text = newText;
            task.Assignee = newAssignee;
            task.StatusId = (await rep.SearchStatusAsync(newStatus)).Id;
            await rep.SaveChangesAsync();
        }

        public async Task DeleteTaskAsync(Guid taskId)
        {
            var task = await rep.SearchTaskForIdAsync(taskId);
            if (task != null)
                await rep.RemoveTask(task);
        }
    }
}
