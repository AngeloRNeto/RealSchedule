using RealSchedule.Domain.Enum;
using RealSchedule.Domain.Models;
using RealSchedule.Domain.Repositories;
using System;

namespace RealSchedule.Entity.Repositories
{
    public class EventoRepository : BaseRepository<Evento>, IEventoRepository
    {
        private readonly RealScheduleContext _context;

        public EventoRepository(RealScheduleContext context) : base(context)
        {
            _context = context;
        }

    }
}