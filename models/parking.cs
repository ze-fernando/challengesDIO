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
    
}