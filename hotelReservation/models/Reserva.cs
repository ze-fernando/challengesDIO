public class Reserva{
    public List<Pessoa> hospedes {get; set;}
    public Suite suite {get; set;}
    public int diasReservados {get; set;}

    public Reserva() { }

    public Reserva(int diasReservados)
    {
        DiasReservados = diasReservados;
    }

    public void CadastrarHospedes(List<Pessoa> hospedes){
        // TODO: Verificar se a capacidade é maior ou igual ao número de hóspedes sendo recebido
        if (suite.capacidade >= hospedes.Count){
            Hospedes = hospedes;
            Console.WriteLine("Hospedes cadastrados com sucesso!")
        }
        else{
            // TODO: Retornar uma exception caso a capacidade seja menor que o número de hóspedes recebido
            throw new ArgumentOutOfRangeException("Capacidade da suite não suporta o número de hospedes!", e);
        }
    }

    public void CadastrarSuite(Suite suite){
        Suite = suite;
    }

    public int ObterQuantidadeHospedes(){
        // TODO: Retorna a quantidade de hóspedes (propriedade Hospedes)
        int qtdHospede = 0;
        foreach (var hospede in hospedes){
            qtdHospede++;
        }
        return qtdHospede;
    }

    public decimal CalcularValorDiaria(){
        // TODO: Retorna o valor da diária
        // Cálculo: DiasReservados X Suite.ValorDiaria
        decimal valor = diasReservados * suite.valorDiaria;

        // Regra: Caso os dias reservados forem maior ou igual a 10, conceder um desconto de 10%
         if (diasReservados >= 10){
            valor = valor - (diasReservados * suite.valorDiaria / 100);
        }

        return valor;
    }
}