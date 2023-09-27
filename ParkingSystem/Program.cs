Console.WriteLine("Bem vindo ao nosso estacionamento \n" + 
    "Digite o preço inical"
    );

decimal precoInicial = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Agora o preço por hora");

decimal precoPorHora = Convert.ToDecimal(Console.ReadLine());


Estacionamento es = new Estacionamento(precoInicial, precoPorHora);

string opcao = string.Empty;
bool exibirMenu = true;

while (exibirMenu)
{
    Console.Clear();
    Console.WriteLine("Digite a sua opção:");
    Console.WriteLine("1 - Cadastrar veículo");
    Console.WriteLine("2 - Remover veículo");
    Console.WriteLine("3 - Listar veículos");
    Console.WriteLine("4 - Encerrar");

    switch (Console.ReadLine())
    {
        case "1":
            es.adcionarVeiculo();
            break;

        case "2":
            es.removerVeiculo();
            break;

        case "3":
            es.listarVeiculos();
            break;

        case "4":
            exibirMenu = false;
            break;

        default:
            Console.WriteLine("Opção inválida");
            break;
    }

    Console.WriteLine("Pressione uma tecla para continuar");
    Console.ReadLine();
}

Console.WriteLine("O programa se encerrou");