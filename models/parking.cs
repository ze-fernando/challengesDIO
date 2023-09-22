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
        Console.WriteLine("Digite a placa do veiculo a ser adcionado");
        string placa = Console.ReadLine();
        veiculos.Add(placa);
        Console.WriteLine("Carro adcinado com sucesso!");
    }

    public void removerVeiculo(string placa){
        foreach (var v in veiculos){
            if (v == placa){
                veiculos.Remove(v);
                Console.WriteLine("Veiculo removido com sucesso!");
            }
        }
    }

    public void listarVeiculos(){
        foreach (var v in veiculos){
            Console.WriteLine($"Veiculo {v}\n");
        }
    }
}