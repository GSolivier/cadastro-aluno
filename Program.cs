// Cadastrar os dados de um aluno.

// Criar uma classe Aluno, com as seguintes propriedades: Nome, Curso, Idade, RG, Bolsista(Bool), Média Final, Valor da mensalidade.

// bolsista e média final maior ou igual a 8 conceder 50% de desconto na mensalidade
// bolsista e média final maior que 6 e menor que 8 conceder 30% de desconto na mensalidade 
// outros casos a mensalidade será integral

// Receba os dados do cadastro via console e crie um menu para o usuário escolher se quer visualizar a média ou o valor da mensalidade.
using System.Globalization;
using System.Text.RegularExpressions;
using cadastro_aluno;

Aluno aluno1 = new Aluno();
string escolhaBolsista;
string escolhaMenu;
bool loopBreak = true;

do
{
     startOfLoop:
     Console.Clear();
     Console.WriteLine(@$"
          Sistema educacional v1.0

     Escolha o serviço que deseja realizar

     [1] - Cadastrar aluno
     [2] - Mostrar informações de cadastro
     [3] - Ver mensalidade
     [4] - Ver média

     [0] - Encerrar Programa
     
");
escolhaMenu = Console.ReadLine();

switch (escolhaMenu)
{
     case "1":
Console.Clear();
Console.WriteLine(@$"

     Bem vindo ao sistema de cadastro de alunos!
        
     Digite o seu nome:
");
aluno1.nome = Console.ReadLine();

Console.WriteLine($"Digite o curso que gostaria de cursar: ");
aluno1.curso = Console.ReadLine();

Console.WriteLine($"Digite a sua idade: ");
aluno1.idade = Console.ReadLine();

Console.WriteLine($"Digite o seu RG (sem a pontuação): ");
aluno1.rg = Console.ReadLine();

Regex regex = new Regex(@"([0-9]{2}.?[0-9]{3}.?[0-9]{3}-?[0-9]{1})", RegexOptions.IgnoreCase);
            var combinou = regex.Match(aluno1.rg);

            if (aluno1.rg.Length == 9)
            {
                Console.WriteLine("RG no formato válido.");
            }
            else
            {
                    do
                    {
                         Console.WriteLine($"RG inválido, por favor digite o número correto");
                         aluno1.rg = Console.ReadLine();
                         
                    
                    } while (aluno1.rg.Length != 9);
                
            }

Console.WriteLine($"Você é bolsista? Digite '1' para sim ou '2' para não.");
escolhaBolsistaCheck:
escolhaBolsista = Console.ReadLine();

if(escolhaBolsista == "1"){
     aluno1.bolsista = true;
}
else if (escolhaBolsista == "2"){
     aluno1.bolsista = false;
}
else{
     Console.WriteLine($"Digite um número válido!");
     goto escolhaBolsistaCheck;
}

Console.WriteLine($"Qual a média final do aluno?");
aluno1.mediaFinal = float.Parse(Console.ReadLine());

Console.WriteLine($"Qual o valor da mensalidade integral?");
aluno1.valorMensalidade = float.Parse(Console.ReadLine());

Console.WriteLine($"Cadastro efetuado com sucesso!");
Console.WriteLine($"Retonarndo ao menu...");
Thread.Sleep(5000);
     goto startOfLoop;

     case "2":
     if(string.IsNullOrEmpty(aluno1.nome)){
          Console.Clear();
          Console.WriteLine($"Nenhum aluno cadastrado!");
          Console.WriteLine($"Retornando para o menu...");
          Thread.Sleep(3000);
          goto startOfLoop;
     }

Console.Clear();
     Console.WriteLine(@$"
     Informações sobre o(a) aluno(a) {aluno1.nome}

Curso: {aluno1.curso}
Idade: {aluno1.idade} anos
RG: {aluno1.teste(aluno1.rg)}
     ");
     if (aluno1.bolsista == true)
     {
          Console.WriteLine($"O aluno é bolsista!");
     }
     else{
          Console.WriteLine($"O aluno não é bolsista!");
     }
     Console.WriteLine($"Aperte qualquer botão para retornar ao menu!");
     
     Console.ReadKey();
     break;

     case "3":
     if (string.IsNullOrEmpty(aluno1.nome))
     {
          Console.Clear();
          Console.WriteLine($"Nenhuma mensalidade foi informada, por favor, va até o menu e escolha a opção 1 para efetuar o cadastro");
          Thread.Sleep(3000);
          goto startOfLoop;
     }
     Console.Clear();
     Console.WriteLine($"A mensalidade do aluno segundo as informações passadas é de {Math.Round(aluno1.VerMensalidade(),2).ToString("C", new CultureInfo("pt-BR"))}");
     
      Console.WriteLine($"Aperte qualquer botão para retornar ao menu!");
     
     Console.ReadKey();
     break;

     case "4":
     if (string.IsNullOrEmpty(aluno1.nome))
     {
          Console.Clear();
          Console.WriteLine($"Nenhuma média foi informada, por favor, va até o menu e escolha a opção 1 para efetuar o cadastro");
          Thread.Sleep(3000);
          goto startOfLoop;
     }
     Console.Clear();
     Console.WriteLine($"A média do aluno é de {aluno1.mediaFinal}");

      Console.WriteLine($"Aperte qualquer botão para retornar ao menu!");
     
     Console.ReadKey();
     break;

     case "0":
     Console.Clear();
     Console.WriteLine($"Encerrando Programa...");
     Thread.Sleep(3000);
     loopBreak = false;
     break;
     
     default:
     Console.WriteLine($"Digite um valor válido");
     
     goto startOfLoop;
}

     
} while (loopBreak);


