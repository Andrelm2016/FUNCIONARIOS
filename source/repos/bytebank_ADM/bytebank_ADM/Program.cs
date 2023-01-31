using bytebank_ADM.Funcionarios;
using bytebank_ADM.Utilitario;

Funcionario pedro = new Funcionario("123456789",2000);

pedro.Nome = "Pedro malazartes";

Console.WriteLine("Nome: " + pedro.Nome);
Console.WriteLine("Bonificação do Funcionário R$:" + pedro.GetBonificacao()+ "\n");

//-------------------------------------------------------------------------------

Diretor roberta = new Diretor("987654321",5000);

roberta.Nome = "Roberta Silva";

Console.WriteLine("Nome: " + roberta.Nome);
Console.WriteLine("Bonificação do Diretor R$:" + roberta.GetBonificacao()+ "\n");

//--------------------------------------------------------------------------


GerenciadorDeBonificacao Gerenciador = new GerenciadorDeBonificacao();
Gerenciador.Registrar(pedro);
Gerenciador.Registrar(roberta);

Console.WriteLine("Total de Bonificações: "+Gerenciador.TotalDeBonificacao);

Console.WriteLine("Total de Funcionário: "+Funcionario.TotalDeFuncionarios + "\n");

//--------------------------------------------------------------------------

pedro.AumentarSalario();
roberta.AumentarSalario();  

Console.WriteLine("Novo salário do Pedro: " + pedro.Salario);
Console.WriteLine("Novo salário do Roberta: " + roberta.Salario);


