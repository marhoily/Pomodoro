using System;
using Microsoft.EntityFrameworkCore;

namespace Pomodoro.Database
{
    public class PomodoroContext : DbContext
    {
        public DbSet<Tomato> Tomatoes { get; set; }

        public PomodoroContext(DbContextOptions<PomodoroContext> options)
            : base(options)
        { }

    }

    public class Tomato
    {
        public int Id { get; set; }
        public DateTime StartedAt { get; set; }
    }
}