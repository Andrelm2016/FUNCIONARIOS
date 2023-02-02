using bytebank_ADM.Funcionarios;
using bytebank_ADM.SistemaInterno;
using bytebank_ADM.Utilitario;

#region
//Funcionario pedro = new Funcionario("123456789",2000);

//pedro.Nome = "Pedro malazartes";

//Console.WriteLine("Nome: " + pedro.Nome);
//Console.WriteLine("Bonificação do Funcionário R$:" + pedro.GetBonificacao()+ "\n");

////-------------------------------------------------------------------------------

//Diretor roberta = new Diretor("987654321");

//roberta.Nome = "Roberta Silva";

//Console.WriteLine("Nome: " + roberta.Nome);
//Console.WriteLine("Bonificação do Diretor R$:" + roberta.GetBonificacao()+ "\n");

////--------------------------------------------------------------------------


//GerenciadorDeBonificacao Gerenciador = new GerenciadorDeBonificacao();
//Gerenciador.Registrar(pedro);
//Gerenciador.Registrar(roberta);

//Console.WriteLine("Total de Bonificações: "+Gerenciador.TotalDeBonificacao);

//Console.WriteLine("Total de Funcionário: "+Funcionario.TotalDeFuncionarios + "\n");

////--------------------------------------------------------------------------

//pedro.AumentarSalario();
//roberta.AumentarSalario();  

//Console.WriteLine("Novo salário do Pedro: " + pedro.Salario);
//Console.WriteLine("Novo salário do Roberta: " + roberta.Salario);
#endregion


//CalcularBonificacao();

UsarSistema();
void CalcularBonificacao()
{   
    GerenciadorDeBonificacao gerenciador = new GerenciadorDeBonificacao();

    Designer ulisses = new Designer("12345679");
    ulisses.Nome = "Ulisses Souza";

    Diretor paula = new Diretor("123213");
    paula.Nome = "Paula Souza";

    Auxiliar igor = new Auxiliar("231323");
    igor.Nome = "Igor Dias";

    GerenteDeContas camila = new GerenteDeContas("23123213");
    camila.Nome = "Camila Oliveira";

    gerenciador.Registrar(ulisses);
    gerenciador.Registrar(paula);
    gerenciador.Registrar(igor);
    gerenciador.Registrar(camila);

    Console.WriteLine("Total de bonificação: " + gerenciador.TotalDeBonificacao);

}

void UsarSistema()
{

    SistemaInterno sistema = new SistemaInterno();

    Diretor ingrid = new Diretor("192837465");

    ingrid.Nome = "Ingrid Novaes";
    ingrid.Senha = "123";

    GerenteDeContas ursula = new GerenteDeContas("812232881");
    ursula.Nome = "Ursula Alcantara";
    ursula.Senha = "321";

    sistema.Logar(ingrid, "123");
    sistema.Logar(ursula, "292");
    {

    }

}

