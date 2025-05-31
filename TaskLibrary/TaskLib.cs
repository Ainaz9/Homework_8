using Microsoft.EntityFrameworkCore;

namespace TaskLibrary
{
    public class TaskLib
    {
        private MyDbContext? db;

        public TaskLib()
        {
            db = new MyDbContext();
        }

        public async Task<TaskModel> SearchTaskForIdAsync(Guid taskId)
        {
            return await db.Tasks.Include(t => t.Status).FirstOrDefaultAsync(t => t.Id == taskId);
        }

        public TaskModel SearchTask(TaskModel Task)
        {
            return db.Tasks.Include(t => t.Status).FirstOrDefault(t => t.Id == Task.Id);
        }

        public async Task<StatusModel> SearchStatusAsync(StatusForTask? status)
        {
            var statusModel = await db.Statuses.FirstOrDefaultAsync(s => s.Status == status);
            await db.SaveChangesAsync();
            return statusModel;
        }

        public async Task RemoveTask(TaskModel taskToDelete)
        {
            db.Tasks.Remove(taskToDelete);
            await db.SaveChangesAsync();
        }

        public async Task SaveChangesAsync()
        {
            await db.SaveChangesAsync();
        }

        public async Task<TaskModel> CreateTaskAsync(string text, string assignee, StatusModel status)
        {
            var task = new TaskModel
            {
                Id = Guid.NewGuid(),
                Text = text,
                Assignee = assignee,
                Data = DateTime.Now,
                StatusId = status.Id,
                Status = status
            };

            await db.AddAsync(task);
            await db.SaveChangesAsync();

            return task;
        }

        public List<TaskModel> LoadTasks()
        {
            try
            {
                var tasks = db.Tasks
                             .Include(t => t.Status)
                             .AsNoTracking()
                             .ToList();

                return tasks;
            }
            catch 
            {
                throw new Exception("База данных не инициализированa"); 
            }

        }
    }
}
