using Alura.Filmes.App.Dados;
using Alura.Filmes.App.Extensions;
using Alura.Filmes.App.Negocio;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace Alura.Filmes.App
{
    class Program
    {
        static void Main(string[] args)
        {
            
            using (var contexto = new AluraFilmesContexto())
            {
                contexto.LogSQLToConsole();

                /*
                //ADICIONAR ATOR
                var ator = new Ator();
                ator.PrimeiroNome = "Tom";
                ator.UltimoNome = "Hanks";
        
                contexto.Atores.Add(ator);
                contexto.SaveChanges();
                */

                /*
                //LISTAR OS ULTIMOS 10 MODIFICADOS
                var atores = contexto.Atores
                    .OrderByDescending(a => EF.Property<DateTime>(a, "last_update"))
                    .Take(10);

                foreach(var ator in atores)
                {
                    Console.WriteLine(ator);
                }                              
                contexto.SaveChanges();
                */

                /*
                //Lista Filmes
                foreach(var filme in contexto.Filmes)
                {
                    Console.WriteLine(filme);
                }
                */

                /*
                // ELENCO PRESENTE EM UM FILME
                var filme = contexto.Filmes
                    .Include(f => f.Atores)
                    .ThenInclude(fa => fa.Ator)
                    .First();

                Console.WriteLine(filme);
                Console.WriteLine("Elenco: ");

                foreach (var ator in filme.Atores)
                {                    
                    Console.WriteLine(ator.Ator);
                }
                */

                /*
                //LISTA DE IDIOMAS
                foreach (var idioma in contexto.Idiomas)
                {
                    Console.WriteLine(idioma);
                }
                */

                /*
                var idiomas = contexto.Idiomas
                    .Include(i => i.FilmesFalados);

                foreach (var idioma in idiomas)
                {
                    Console.WriteLine(idioma);

                    foreach(var filme in idioma.FilmesFalados)
                    {
                        Console.WriteLine(filme);
                    }
                    Console.WriteLine("\n");
                }
                */

                /*
                //INCLUIR FILME e IDIOMA
                //var idioma = new Idioma { Nome = "English" };

                var filme = new Filme();
                filme.Titulo = "Cassino Royale";
                filme.Duracao = 120;
                filme.AnoLancamento = "1998";
                filme.Classificador = ClassificacaoIndicativo.MaioresQue14;
                filme.IdiomaFalado = contexto.Idiomas.First();
                contexto.Entry(filme).Property("last_update").CurrentValue = DateTime.Now;

                contexto.Filmes.Add(filme);
                contexto.SaveChanges();

                var filmeInserido = contexto.Filmes.First(f => f.Titulo == "Cassino Royale");
                Console.WriteLine(filmeInserido.Classificador);
                */

                /*
                var livre = ClassificacaoIndicativo.Livre;
                string textoLivre = "G";

                Console.WriteLine(livre.ParaString());

                Console.WriteLine("G".ParaValor());
                */

                /*
                //LISTAR CLIENTES E FUNCIONARIOS
                foreach(var cliente in contexto.Clientes)
                {
                    Console.WriteLine(cliente);
                }

                foreach (var funcionario in contexto.Funcionarios)
                {
                    Console.WriteLine(funcionario);
                }
                */

            }
        }

    }
}