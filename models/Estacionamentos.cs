using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace C_.models
{
    public class Estacionamentos
    {
        public decimal precoInicial { get; set; }
        public decimal precoPorHora { get; set; }
        public List<string> veiculos { get; set; } = new List<string>();
        public void Remover(string veiculo)
        {
            if(veiculos.IndexOf(veiculo) != 0)
            {
                Console.WriteLine("Veiculo nao existe!\n");
                return;
            }
            Console.WriteLine("Digite as horas que o veiculo permaneceu no estacionamento: ");
            decimal horas = decimal.Parse(Console.ReadLine());
            veiculos.Remove(veiculo);
            decimal resultado = (horas * precoPorHora) + precoInicial;
            Console.WriteLine($"O veiculo {veiculo} foi removido e o preco total foi de: {resultado:C}");
            Console.ReadLine();
            Console.Clear();
        }
        public void Listar()
        {
            foreach(string veiculo in veiculos)
            {
                Console.WriteLine(veiculo);
            }
        }
    }
}