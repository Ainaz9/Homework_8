using Microsoft.EntityFrameworkCore;
using TaskLibrary;
using TaskLibrary.Interfaces;

public class TaskLib : ITaskRepository
{
    private readonly MyDbContext db;

    public TaskLib()
    {
        db = new MyDbContext();
    }

    public List<TaskModel> LoadTasks()
    {
        try
        {
            return db.Tasks
                     .Include(t => t.Status)
                     .AsNoTracking()
                     .ToList();
        }
        catch
        {
            throw new Exception("База данных не инициализирована");
        }
    }

    public async Task<TaskModel> SearchTaskForIdAsync(Guid taskId)
    {
        return await db.Tasks.Include(t => t.Status).FirstOrDefaultAsync(t => t.Id == taskId);
    }

    public async Task<StatusModel> SearchStatusAsync(StatusForTask status)
    {
        var statusModel = await db.Statuses.FirstOrDefaultAsync(s => s.Status == status);
        return statusModel;
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

    public async Task SaveChangesAsync()
    {
        await db.SaveChangesAsync();
    }

    public async Task RemoveTask(TaskModel taskToDelete)
    {
        db.Tasks.Remove(taskToDelete);
        await db.SaveChangesAsync();
    }
}
