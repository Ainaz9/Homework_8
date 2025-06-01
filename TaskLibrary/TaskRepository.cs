using TaskLibrary.Interfaces;

namespace TaskLibrary
{
    public class TaskRepository : ITaskRepository
    {
        private readonly TaskLib _db;

        public TaskRepository(TaskLib db) => _db = db;

        public List<TaskModel> LoadTasks() => _db.LoadTasks();

        public Task<TaskModel> SearchTaskForIdAsync(Guid id) => _db.SearchTaskForIdAsync(id);

        public Task<StatusModel> SearchStatusAsync(StatusForTask status) => _db.SearchStatusAsync(status);

        public Task<TaskModel> CreateTaskAsync(string text, string assignee, StatusModel status)
            => _db.CreateTaskAsync(text, assignee, status);

        public Task SaveChangesAsync() => _db.SaveChangesAsync();

        public Task RemoveTask(TaskModel task) => _db.RemoveTask(task);
    }
}
