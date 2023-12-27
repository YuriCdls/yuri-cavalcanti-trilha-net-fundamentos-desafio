namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private List<string> veiculos = new List<string>();

        //Construtor do Estacionamento
        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        //Metodo que adiciona o veiculo
        public void AdicionarVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para estacionar:");
            //Implementação de adição dos veiculos
            string veiculo = Console.ReadLine();
            veiculos.Add(veiculo.ToUpper());
        }

        //Metodo que remove os veiculos
        public void RemoverVeiculo()
        {
            if (veiculos.Any())
            {
                //Implementação de Exibição das placas antes da remoção
                ListarVeiculos();
                Console.WriteLine("Digite a placa do veículo para remover:");
                //Implementação para o usuario digitar a placa e para que ela fique em maiscula na exibição
                string placa = Console.ReadLine();
                placa.ToUpper();

                if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
                {
                    //Implementação de Entrada pelo usuario e calculo do valor total
                    Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");
                    string entrada = Console.ReadLine();
                    try
                    {
                        int horas = int.Parse(entrada);
                        decimal valorTotal = precoInicial + precoPorHora * horas;

                        veiculos.Remove(placa);

                        Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}");
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Por favor, digite um valor válido para as horas.");
                    }
                }
                else
                {
                    Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }

        }

        //Metodo que lista os veiculos
        public void ListarVeiculos()
        {
            if (veiculos.Any())
            {
                //Implementação do laço de repetição para exibição dos veiculos
                Console.WriteLine("Os veículos estacionados são:");
                foreach (var item in veiculos)
                {
                    Console.WriteLine(item);
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}
