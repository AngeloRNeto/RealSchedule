using RealSchedule.Domain.Enum;
using RealSchedule.Domain.Models;
using RealSchedule.Domain.Repositories;
using System;
using System.Linq;

namespace RealSchedule.Entity.Repositories
{
    public class AgendaRepository : BaseRepository<Agenda>, IAgendaRepository
    {
        private readonly RealScheduleContext _context;

        public AgendaRepository(RealScheduleContext context) : base(context)
        {
            _context = context;
        }


    }
}