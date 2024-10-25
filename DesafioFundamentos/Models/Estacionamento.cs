using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Dynamic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        public double PrecoInicial { get; set; }
        public double PrecoPorHora { get; set; }
        public List<string> Veiculos = new List<string>();

        string? option;
        bool showMenu = true;


        public void FirstRun() 
        {
            Console.WriteLine("Digite o preço inicial: ");
            PrecoInicial = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite o preço por hora: ");
            PrecoInicial = Convert.ToDouble(Console.ReadLine());
        }

        public void ShowMenu()
        {

            FirstRun();

            while (showMenu)
            {
                Console.WriteLine("Digite a sua opção: ");
                Console.WriteLine("1 - Cadastrar veiculo ");
                Console.WriteLine("2 - Remover veiculo ");
                Console.WriteLine("3 - Listar veiculos ");
                Console.WriteLine("4 - Encerrar ");
                option = Console.ReadLine()!;

                switch (option)
                { 
                    case "1":
                        Console.Clear();
                        AdicionarVeiculo();
                        PressAnyKey();
                        break;

                    case "2":
                        Console.Clear();
                        RemoverVeiculos();
                        PressAnyKey();
                        break;

                    case "3":
                        Console.Clear();
                        ListarVeiculos();
                        PressAnyKey();
                        break;

                    case "4":
                        showMenu = false;
                        break;

                    default:
                        Console.WriteLine("Opção invalida.");
                        Console.Clear();
                        break;

                }
            }
        }

        public void AdicionarVeiculo()
        { 
            Console.WriteLine("Digite a placa do carro: ");
            Veiculos.Add(Console.ReadLine()!);
            Console.WriteLine("Carro adicionado com sucesso!");
        }

        public void ListarVeiculos()
        {
            foreach (string plates in Veiculos)
            {
                Console.WriteLine(plates);
            }
        }

        public void RemoverVeiculos()
        {
            string carPlate;
            double hours;

            Console.WriteLine("Digite a placa do carro que deseja remover: ");
            carPlate = Console.ReadLine()!;
            Console.WriteLine("Digite a quantidade de horas que o veiculo permaneceu estacionado: ");
            hours = Convert.ToDouble(Console.ReadLine());
            Veiculos.Remove(carPlate);
            Console.WriteLine($"O veiculo {carPlate} foi removido com sucesso e o preço total foi de: R$ {PrecoInicial + (PrecoPorHora * hours)}");
        }

        static void PressAnyKey()
        {
            Console.WriteLine("Pressione uma teclar para continuar.");
            Console.ReadLine();
            Console.Clear();
        }
    }
}