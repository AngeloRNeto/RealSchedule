using RealSchedule.Domain.Interfaces;
using RealSchedule.Domain.Models;
using RealSchedule.Domain.Repositories;
using System.Collections.Generic;

namespace RealSchedule.Services
{
    public class AgendaService : IAgendaService
    {
        private readonly IAgendaRepository agendaRepository;
        public AgendaService(IAgendaRepository repository)
        {
            agendaRepository = repository;
        }

        public int Insert(Agenda agenda)
        {
            return agendaRepository.Insert(agenda);
        }

        public void Update(Agenda agenda)
        {
            agendaRepository.Update(agenda);
        }

        public Agenda GetById(int id)
        {
            return agendaRepository.GetById(id);
        }

        public List<Agenda> GetAll<TEntity>()
        {
            return agendaRepository.GetAll<Agenda>();
        }

        public void Delete(int id)
        {
            agendaRepository.Delete(GetById(id));
        }

    }
}