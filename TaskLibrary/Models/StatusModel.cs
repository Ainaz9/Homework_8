
namespace TaskLibrary
{
    /// <summary>
    /// Статусы задач
    /// </summary>
    public enum StatusForTask
    {
        /// <summary>
        /// Очередь
        /// </summary>
        Queue,

        /// <summary>
        /// В работе
        /// </summary>
        InProgress,

        /// <summary>
        /// Выполнена
        /// </summary>
        Completed
    }

    /// <summary>
    /// Статус 
    /// </summary>
    public class StatusModel
    {
        /// <summary>
        /// Идентификатор статуса
        /// </summary>
        public Guid Id { get; set; }
        
        /// <summary>
        /// Статус
        /// </summary>
        public StatusForTask Status { get; set; }

        /// <summary>
        /// Идентификатор задачи
        /// </summary>
        public Guid TaskId { get; set; }

        /// <summary>
        /// Задача
        /// </summary>
        public ICollection<TaskModel> Tasks { get; set; }
    }
}
