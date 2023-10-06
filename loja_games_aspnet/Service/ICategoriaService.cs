﻿using loja_games.Model;

namespace loja_games.Service
{
    public interface ICategoriaService
    {
        Task<IEnumerable<Categoria>> GetAll();

        Task<Categoria?> GetById(long id);

        Task<IEnumerable<Categoria>> GetByNome(string nome);

        Task<Categoria?> Create(Categoria categoria);

        Task<Categoria?> Update(Categoria categoria);

        Task Delete(Categoria categoria);
    }
}
