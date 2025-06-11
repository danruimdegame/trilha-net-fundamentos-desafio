namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private List<string> veiculos = new List<string>();

        /// <summary>
        /// Classe responsável por gerenciar o estacionamento.
        /// </summary>
        /// <param name="precoInicial"> Decimal responsável pelo preço fixo inicial</param>
        /// <param name="precoPorHora"> Decimal responsável pelo preço por hora </param>
        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        /// <summary>
        /// Adiciona um veículo à lista de veículos estacionados.
        /// </summary>
        public void AdicionarVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para estacionar:");
            veiculos.Add(Console.ReadLine().ToUpper());
        }

        /// <summary>
        /// Remove um veículo da lista de veículos estacionados e calcula o valor total a ser pago.
        /// </summary>
        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo que deseja remover:");
            string placa = Console.ReadLine().ToUpper();

            // Verifica se o veículo existe
            if (veiculos.Any(x => x == placa))
            {
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");
                int horas = Convert.ToInt32(Console.ReadLine());
                decimal valorTotal = precoInicial + (precoPorHora * horas);
                // Remove o veículo da lista
                veiculos.Remove(placa);
                Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}");
            }
            else
            {
                Console.WriteLine("Desculpe, o veículo não foi encontrado. Verifique a placa digitada.");
            }
        }

        /// <summary>
        /// Lista todos os veículos estacionados no estacionamento.
        /// </summary>
        public void ListarVeiculos()
        {
            // Verifica se há veículos no estacionamento
            if (veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são:");
                foreach (string veiculo in veiculos) {
                    Console.WriteLine(veiculo);   
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}
