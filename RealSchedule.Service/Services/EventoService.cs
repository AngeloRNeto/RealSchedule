using RealSchedule.Domain.Interfaces;
using RealSchedule.Domain.Models;
using RealSchedule.Domain.Repositories;
using System.Collections.Generic;

namespace RealSchedule.Services
{
    public class EventoService : IEventoService
    {
        private readonly IEventoRepository eventoRepository;
        public EventoService(IEventoRepository repository)
        {
            eventoRepository = repository;
        }

        public void Delete(int id)
        {
            eventoRepository.Delete(GetById(id));
        }

        public List<Evento> GetAll<TEntity>()
        {
            return eventoRepository.GetAll<Evento>();
        }

        public Evento GetById(int id)
        {
            return eventoRepository.GetById(id);
        }

        public int Insert(Evento agenda)
        {
            return eventoRepository.Insert(agenda);
        }

        public void Update(Evento agenda)
        {
            eventoRepository.Update(agenda);
        }
    }
}