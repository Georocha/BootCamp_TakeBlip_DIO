
using System.Collections.Generic;
using RockMovies.Interfaces;

namespace RockMovies
{
	public class MoviesRepositorio : IRepositorio<Movies>
	{
        private List<Movies> listaMovies = new List<Movies>();
		public void Atualiza(int id, Movies objeto)
		{
			listaMovies[id] = objeto;
		}

		public void Exclui(int id)
		{
			listaMovies[id].Excluir();
		}

		public void Insere(Movies objeto)
		{
			listaMovies.Add(objeto);
		}

		public List<Movies> Lista()
		{
			return listaMovies;
		}

		public int ProximoId()
		{
			return listaMovies.Count;
		}

		public Movies RetornaPorId(int id)
		{
			return listaMovies[id];
		}
	}
}