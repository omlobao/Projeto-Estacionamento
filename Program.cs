using DIo.Models;

// Coloca o encoding para UTF8 para exibir acentuação
Console.OutputEncoding = System.Text.Encoding.UTF8;

decimal PrecoInicial = 0;
decimal precoPorHora = 0;

Console.WriteLine("Seja bem vindo ao sistema de estacionamento!\n"  +
                  "digite o preço inicial:");
while (!decimal.TryParse(Console.ReadLine(), out PrecoInicial) || PrecoInicial < 0)
{
    Console.WriteLine("Valor inválido. Digite um número decimal positivo.");
}
Console.WriteLine("Digite o preço por hora: ");
while (!decimal.TryParse(Console.ReadLine(), out precoPorHora) || precoPorHora < 0)

{
    Console.WriteLine("Valor inválido. Digite um número decimal positivo:");
}

    Estacionamento es = new Estacionamento(PrecoInicial, precoPorHora);

string opcao = string.Empty;
bool exibirMenu = true;

while (exibirMenu)
{
    Console.Clear();
    Console.WriteLine("Digite a sua opção:");
    Console.WriteLine("1 - Cadastrar Veiculo");
    Console.WriteLine("2 - Remover veículo");
    Console.WriteLine("3 - Listar veículos");
    Console.WriteLine("4 - Encerrar");

    switch (Console.ReadLine())
    {
        case "1":
            es.AdicionarVeiculo();
            break;

        case "2":
            es.RemoverVeiculo();
            break;
        case "3":
            es.ListarVeiculos();
            break;
        case "4":
            exibirMenu = false;
            break;
    }

    Console.WriteLine("Pressione uma tecla para continuar");
    Console.ReadLine();

}
Console.WriteLine("O programa se encerrou.");
