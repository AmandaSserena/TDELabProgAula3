//Declare as variáveis nome, idade e nota atribuindo os valores “Paulo”, 17 e 7.5 e exiba a saída no formato : Aluno tem anos e nota usando a concatenação e a interpolação de strings.
 
// string nome = "Paulo";
// int idade = 17;
// double nota = 7.5;

//Usando concatenação de strings
// Console.WriteLine("Aluno " + nome + " tem " + idade + " anos e nota " + nota);

//Usando interpolação de strings
// Console.WriteLine($"Aluno {nome} tem {idade} anos e nota {nota}");

//Para o exercício anterior exiba o nome a idade e a nota em linhas separadas usando as sequências de escapes.

// Console.WriteLine($"O aluno {nome} \n tem {idade} anos de idade  e a  \n {nota} !");


// Para qual tipo de dados você pode converter um float implicitamente ?
// ( ) int
// (X) double
// ( ) long
// (X) decimal 

// Em qual conversão numérica você precisaria realizar o casting (convesão forçada) ?
// ( ) int para long
// (X) double para long *Não tem perca de precisão por isso não é uma converção forçada.
// (X) double para float
// (X) decimal para float
// (X) long para int
// (X) double para decimal

//Escreva um programa que recebe 3 letras via teclado e as exiba na ordem reversa usando
// a concatenação e também a interpolação de strings

// char letra1, letra2, letra3;
// Console.WriteLine("Digite a primeira letra: ");
// letra1 = Convert.ToChar (Console.ReadLine()!);
// Console.WriteLine("Digite a segunda letra: ");
// letra2 = Convert.ToChar (Console.ReadLine()!);
// Console.WriteLine("Digite a terceira letra: ");
// letra3 = Convert.ToChar (Console.ReadLine()!);

// Console.WriteLine($"{letra3}{letra2}{letra1}");
// Console.WriteLine(letra3 +" "+ letra2 + " " + letra1);

// Marque verdadeiro(V) ou falso(F) para os códigos abaixo:
// (F) long resultado = 1.32;
// (V) var nome = “Maria”;
// (V) string resultado = 100.ToString();
// (V) A sequência de escape \n inclui uma nova linha
// (F) float f = 5.45;
// (V) decimal valor = (decimal) 10.99f;
// (F) var status = null;
// (V) object o = 12.45m;
// (V) string titulo = true.ToString();
// (F) A sequencia \t inclui uma tabulação vertical

// Escreva um programa para receber dois valores via teclado do tipo double e a seguir
// realize as operações de soma, subtração, multiplicação, exponenciação, divisão e módulo
// exibindo o resultado:
 
//     Console.WriteLine("Digite o primeiro valor: ");
//     double valor1 = Convert.ToDouble (Console.ReadLine());
//     Console.WriteLine("Digite o segundo valor: ");
//     double valor2 = Convert.ToDouble(Console.ReadLine());

// double soma = valor1 + valor2;
// double subtracao = valor1 - valor2;
// double multiplicacao = valor1 * valor2;
// double exponenciacao = Math.Pow(valor1, valor2);
// double divisao = valor1 / valor2;
// double modulo = valor1 % valor2;
// double raiz = Math.Sqrt(valor1);

// Console.WriteLine($"A soma de {valor1} e {valor2} é {soma}");
// Console.WriteLine($"A subtração de {valor1} e {valor2} é {subtracao}");
// Console.WriteLine($"A multiplicação de {valor1} e {valor2} é {multiplicacao}");
// Console.WriteLine($"A exponenciação de {valor1} elevado a {valor2} é {exponenciacao}");
// Console.WriteLine($"A divisão de {valor1} e {valor2} é {divisao}");
// Console.WriteLine($"O módulo de {valor1} e {valor2} é {modulo}");
// Console.WriteLine($"O raiz quadrada de {valor1} é {raiz}");

// Escreva um programa que receba um nome e uma senha via teclado. Nome é uma string e
// Senha é um inteiro. Se o nome for igual a ‘admin’ ou ‘maria’ e a senha for igual a ‘123’
// então exiba a mensagem ‘Login feito com sucesso’ caso contrário exiba a mensagem ‘Login
// inválido’: (use o operador condicional ternário)

// Console.WriteLine("Digite o nome: ");
// string? nome = Console.ReadLine();
// Console.WriteLine("Digite a senha: ");
// int senha = int.Parse(Console.ReadLine()!);

// string mensagem = (nome == "admin" || nome == "Amanda" && senha == 123) ? "Login feito com sucesso" : "Login inválido";

// Console.WriteLine(mensagem);



// Escreva um programa que recebe via teclado dois números inteiros x e y e imprima no
// console se x é par ou não e se y é par ou não. Use o operador condicional ternário (? :)

Console.WriteLine("Digite o valor de x: ");
int x = Convert.ToInt32 (Console.ReadLine()!);
Console.WriteLine("Digite o valor de y: ");
int y = Convert.ToInt32(Console.ReadLine()!);

string parOuImparX = (x % 2 == 0) ? "par" : "ímpar";
string parOuImparY = (y % 2 == 0) ? "par" : "ímpar";

Console.WriteLine($"O valor de x é {parOuImparX}");
Console.WriteLine($"O valor de y é {parOuImparY}");
