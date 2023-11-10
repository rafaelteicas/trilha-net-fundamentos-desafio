using C_.models;

Console.Clear();
Console.WriteLine("Seja bem vindo ao sistema de estacionamento!");

bool loop = true;

Estacionamentos estacionamento = new Estacionamentos();

try
{
    Console.WriteLine("Digite o preco inicial: ");
    estacionamento.precoInicial = decimal.Parse(Console.ReadLine());
    Console.WriteLine("Digite o preco por hora:");
    estacionamento.precoPorHora = decimal.Parse(Console.ReadLine());
    Console.Clear();

}
catch (Exception err)
{
  Console.WriteLine(err.Message);
}

static void digiteParaContinuar()
{
    Console.WriteLine("Pressione uma tecla para continuar");
    Console.ReadLine();
    Console.Clear();
}

while(loop)
{
  Console.WriteLine("Digite sua opcao");
  Console.WriteLine("1 - Cadastrar veiculo");
  Console.WriteLine("2 - Remover veiculo");
  Console.WriteLine("3 - Listar veiculo");
  Console.WriteLine("4 - Encerrar");

  string opcao = Console.ReadLine();

  switch(opcao)
  {
    case "1":
    {
        Console.WriteLine("Digite a placa do veiculo para estacionar:");
        string veiculo = Console.ReadLine();
        estacionamento.veiculos.Add(veiculo);
        digiteParaContinuar();
        break;
    }
    case "2":
    {
        Console.WriteLine("Digite a placa do veiculo para remover:");
        string veiculo = Console.ReadLine();
        estacionamento.Remover(veiculo);
        break;
    }
    case "3":
    {
        estacionamento.Listar();
        digiteParaContinuar();
        break;
    }
    case "4": 
    {
        loop = false;
        break;
    }
  }
}