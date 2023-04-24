// Cadastrar os dados de um aluno.

// Criar uma classe Aluno, com as seguintes propriedades: Nome, Curso, Idade, RG, Bolsista(Bool), Média Final, Valor da mensalidade.

// bolsista e média final maior ou igual a 8 conceder 50% de desconto na mensalidade
// bolsista e média final maior que 6 e menor que 8 conceder 30% de desconto na mensalidade 
// outros casos a mensalidade será integral

// Receba os dados do cadastro via console e crie um menu para o usuário escolher se quer visualizar a média ou o valor da mensalidade.
using cadastro_aluno;

Aluno aluno1 = new Aluno();
string escolhaBolsista;

Console.WriteLine(@$"

     Bem vindo ao sistema de cadastro de alunos!
        
     Digite o seu nome:
");
aluno1.nome = Console.ReadLine();

Console.WriteLine($"Digite o curso que gostaria de cursar: ");
aluno1.curso = Console.ReadLine();

Console.WriteLine($"Digite a sua idade: ");
aluno1.idade = Console.ReadLine();

Console.WriteLine($"Digite o seu RG: ");
aluno1.rg = Console.ReadLine();

Console.WriteLine($"Você é bolsista? Digite '1' para sim ou '2' para não.");
escolhaBolsista = Console.ReadLine();

if(escolhaBolsista == "1"){
     aluno1
}



