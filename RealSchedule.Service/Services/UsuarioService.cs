using RealSchedule.Domain.Interfaces;
using RealSchedule.Domain.Models;
using RealSchedule.Domain.Repositories;
using System.Collections.Generic;

namespace RealSchedule.Services
{
    ///Metódos da interface implementados,
    ///Podendo ser alterados para regra de negócio
    ///Feitos na camada de serviço
    public class UsuarioService : IUsuarioService
    {
        private readonly IUsuarioRepository userRepository;
        public UsuarioService(IUsuarioRepository repository)
        {
            userRepository = repository;
        }

        public void Delete(int Id)
        {
            userRepository.Delete(GetById(Id));
        }

        public List<Usuario> GetAll<TEntity>()
        {
            return userRepository.GetAll<Usuario>();
        }

        public Usuario GetById(int id)
        {
            return userRepository.GetById(id);
        }

        public int Insert(Usuario agenda)
        {
           return userRepository.Insert(agenda);
        }

        public void Update(Usuario agenda)
        {
            userRepository.Update(agenda);
        }
    }
}