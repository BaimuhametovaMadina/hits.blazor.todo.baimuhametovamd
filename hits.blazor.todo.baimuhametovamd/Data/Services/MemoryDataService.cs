using hits.blazor.todo.baimuhametovamd.Data.Interfaces;

namespace hits.blazor.todo.baimuhametovamd.Data.Services
{
    public class MemoryDataService : IDataService
    {
        IEnumerable<TaskItem> tasks = new List<TaskItem>
        {
            new() { Id = 1, Title = "Задача 1", Description = "Описание задачи 1", CreatedDate = DateTime.Now },
            new() { Id = 1, Title = "Задача 2", Description = "Описание задачи 2", CreatedDate = DateTime.Now },
            new() { Id = 1, Title = "Задача 3", Description = "Описание задачи 3", CreatedDate = DateTime.Now },
        };

		public Task DeleteAsync(int id)
		{
			throw new NotImplementedException();
		}

		public Task<TaskItem> GetTaskAsync(int id)
		{
			throw new NotImplementedException();
		}

		public Task<IEnumerable<TaskItem>> GetAllAsync()
        {
            return Task.FromResult(tasks);
        }

		public Task SaveAsync(TaskItem item)
		{
			throw new NotImplementedException();
		}
	}
}
