using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjF1Entity
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // EQUIPE ***************************************************************************************************
            
            FIA2022Entities context = new FIA2022Entities();
            Equipe e = new Equipe() { nome = "cesar2" };
            context.Equipes.Add(e);
            context.SaveChanges();

            Console.WriteLine("\n\nListando Equipes...");

            var equipes = context.Equipes.ToList();
            foreach (var item in equipes)
                Console.WriteLine(item.ToString());

            Console.WriteLine("\n\nProcesso Finalizado! Pressione [Enter] para continuar...");
            Console.ReadKey();

            // PILOTO ***************************************************************************************************

            context = new FIA2022Entities();
            Piloto p = new Piloto() { nome = "cesar2222" };
            context.Pilotoes.Add(p);
            context.SaveChanges();

            Console.WriteLine("\n\nListando Pilotos...");

            var pilotos = context.Pilotoes.ToList();
            foreach (var item in pilotos)
                Console.WriteLine(item.ToString());

            Console.WriteLine("\n\nProcesso Finalizado! Pressione [Enter] para continuar...");
            Console.ReadKey();

            // CARRO ****************************************************************************************************

            context = new FIA2022Entities();
            Carro c = new Carro() { modelo = "MCL-5", ano = 2022, unidade = 2, id_equipe = 105 };
            context.Carroes.Add(c);
            context.SaveChanges();

            Console.WriteLine("\n\nListando Carros...");

            var carros = context.Carroes.ToList();
            foreach (var item in carros)
                Console.WriteLine(item.ToString());

            Console.WriteLine("\n\nProcesso Finalizado! Pressione [Enter] para continuar...");
            Console.ReadKey();

            // PILOTO_CARRO *********************************************************************************************

            context = new FIA2022Entities();
            PilotoCarro pc = new PilotoCarro() { id_piloto = 1010, id_carro = 2040, data_evento = DateTime.Now};
            context.PilotoCarroes.Add(pc);
            context.SaveChanges();

            Console.WriteLine("\n\nListando Relação (Piloto-Carro)...");

            var pilotosCarros = context.PilotoCarroes.ToList();
            foreach (var item in pilotosCarros)
                Console.WriteLine(item.ToString());

            Console.WriteLine("\n\nProcesso Finalizado!\nFim do Programa! Pressione [Enter] para encerrar...");
            Console.ReadKey();
        }
    }
}
