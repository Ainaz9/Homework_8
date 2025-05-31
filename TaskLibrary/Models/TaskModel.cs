
namespace TaskLibrary
{
    /// <summary>
    /// Задача
    /// </summary>
    public class TaskModel
    {
        /// <summary>
        /// Уникальный идентификатор
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Сама задача
        /// </summary>
        public string Text { get; set; }

        /// <summary>
        /// Исполнитель задачи
        /// </summary>
        public string Assignee { get; set; }

        /// <summary>
        /// Время задачи
        /// </summary>
        public DateTime Data { get; set; }

        /// <summary>
        /// Идентификатор статуса
        /// </summary>
        public Guid StatusId { get; set; }

        /// <summary>
        /// Статус задачи
        /// </summary>
        public StatusModel Status { get; set; }

    }
}
