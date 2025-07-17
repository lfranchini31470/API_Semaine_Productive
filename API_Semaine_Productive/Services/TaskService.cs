using API_Semaine_Productive.Data;
using API_Semaine_Productive.DTOs;
using API_Semaine_Productive.Models;
using Microsoft.EntityFrameworkCore;

namespace API_Semaine_Productive.Services
{
    public class TaskService
    {
        private readonly ApplicationDbContext _context;

        public TaskService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<TaskItem>> GetAllAsync() => await _context.Tasks.ToListAsync();

        public async Task<TaskItem?> GetByIdAsync(int id) => await _context.Tasks.FindAsync(id);

        public async Task<TaskItem> CreateAsync(TaskItemDTO dto)
        {
            var task = new TaskItem
            {
                Title = dto.Title,
                Description = dto.Description,
                Done = dto.Done
            };

            _context.Tasks.Add(task);
            await _context.SaveChangesAsync();
            return task;
        }

        public async Task<bool> UpdateAsync(int id, TaskItemDTO dto)
        {
            var task = await _context.Tasks.FindAsync(id);
            if (task == null) return false;

            task.Title = dto.Title;
            task.Description = dto.Description;
            task.Done = dto.Done;

            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var task = await _context.Tasks.FindAsync(id);
            if (task == null) return false;

            _context.Tasks.Remove(task);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}
