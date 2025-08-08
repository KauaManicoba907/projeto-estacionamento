using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EstacionamentoDesafio.models
{
    public class SistemaEstacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoPorHoraEstacionada = 0;
        private List<string> veiculos = new List<string>();

        public SistemaEstacionamento(decimal precoInicial, decimal precoPorHoraEstacionada)
        {
            this.precoInicial = precoInicial;
            this.precoPorHoraEstacionada = precoPorHoraEstacionada;
        }

        public void AdicionarVeiculo()
        {

            Console.WriteLine("Adicione a placa do veiculo estacionado: ");

            string placa = Console.ReadLine();
            veiculos.Add(placa);

            Console.WriteLine("Veiculo adicionado com sucesso");

        }

        public void RemoverVeiculo()
        {

            Console.WriteLine("Digite a placa do veiculo que deseja remover:");
            string placa = Console.ReadLine();

            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                Console.WriteLine("Digite a quantidade de horas que o veiculo permaneceu estacionado:");
                int horas = Convert.ToInt32(Console.ReadLine());

                decimal valorTotal = precoInicial + (precoPorHoraEstacionada * horas);
                veiculos.Remove(placa);
                Console.WriteLine($"O preço total do veiculo {placa} é de {valorTotal}R$");


            }
            else
            {
                Console.WriteLine("O veiculo não foi encontrado");
            }

        }

        public void ListarVeiculos()
        {
            if (veiculos.Any())
            {
                Console.WriteLine("Os veiculos estácionados são:");
                foreach (string veiculo in veiculos)
                {
                    Console.WriteLine(veiculo);
                }
            }
            else
            {
                Console.WriteLine("Não há veiculos estacionados no momento");
            }
        }
    } 
}