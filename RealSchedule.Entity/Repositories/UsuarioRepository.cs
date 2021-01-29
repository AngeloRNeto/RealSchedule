using RealSchedule.Domain.Enum;
using RealSchedule.Domain.Models;
using RealSchedule.Domain.Repositories;
using System;
using System.Collections.Generic;

namespace RealSchedule.Entity.Repositories
{
    public class UsuarioRepository : BaseRepository<Usuario>, IUsuarioRepository
    {
        private readonly RealScheduleContext _context;

        public UsuarioRepository(RealScheduleContext context) : base(context)
        {
            _context = context;
        }

    }
}