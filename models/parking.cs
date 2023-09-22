using System.Collections;

public class Estacionamento{
    
    private decimal precoInicial;
    private decimal precoPorHora;
    private List<string> veiculos = new List<string>();

    public Estacionamento(decimal precoInicial, decimal precoPorHora){
        this.precoInicial = precoInicial;
        this.precoPorHora = precoPorHora;
    }

    public void adcionarVeiculo(){
        string placa = "";
        Console.WriteLine("Digite a placa do veiculo a ser adcionado");
        placa = Console.ReadLine();
        veiculos.Add(placa);
        Console.WriteLine("Carro adcinado com sucesso!");
    }

    public void removerVeiculo(){
        Console.WriteLine("Digite a placa do veiculo a ser removido");
        string placa = Console.ReadLine();
        if (veiculos.Any(x => x.ToUpper() == placa.ToUpper())){
             Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");
             decimal horas = Convert.ToDecimal(Console.ReadLine);
             decimal valorTotal = precoInicial + precoPorHora * horas;
                
            foreach (var v in veiculos){
                if (v == placa){
                    veiculos.Remove(v);
                    break;
                }
            }
            Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}");
        }
        else{
            Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
        }
    }

    public void listarVeiculos(){
        if (veiculos.Any()){
            foreach (var v in veiculos){
                Console.WriteLine($"Veiculo: {v}\n");
            }
        }
        else{
            Console.WriteLine("Não há Veiculos aqui");
        }
    }
}