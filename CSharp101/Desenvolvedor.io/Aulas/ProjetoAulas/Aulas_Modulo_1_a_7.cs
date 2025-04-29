/*
//AULA: Trabalhando com variáveis
Console.WriteLine("Primeiro programa");

//Estrutura básica de declaracao de variaveis
int idade = 33;
//Console.WriteLine é um método que exibe o valor da variável no console
Console.WriteLine(idade);//33
string nomePessoa = "Renato Lucas";//aspas duplas definem string
Console.WriteLine(nomePessoa);

//Por padrão, o C# define valores decimais como double
decimal valor = 200.99m;//m define o valor como decimal
double valorDouble = 200.99;
float valorFloat = 200.99f;//f define o valor como float
Console.WriteLine(valor);
Console.WriteLine(valorDouble);
Console.WriteLine(valorFloat);

//var é uma palavra reservada que define uma variável com base no valor atribuído.
//No final quando tudo é compilado para a linguagem intermediária (IL) não importa se foi declarado com var ou com tipo, o resultado é exatamente o mesmo (comentário aula).
var idadeNova = 34;

char flag = 'Y';//aspas simples definem char
Console.WriteLine(flag);

bool ativo = true;
ativo = false;
Console.WriteLine(ativo);

//constante é um valor armazenado imutável
const string descricao = "Curso CSHARP";
//descricao = "Curso CSHARP 2021";//erro
Console.WriteLine(descricao);

*/

/*
//AULA: Operadores aritméticos
int numero1 = 1;
var numero2 = 2;

int soma = numero1 + numero2;
Console.WriteLine(soma);

int subtracao = numero2 - numero1;
Console.WriteLine(subtracao);

int multiplicacao = (numero2 * numero1) * 10;
Console.WriteLine(multiplicacao);

int divisao = numero2 / numero1;
Console.WriteLine(divisao);
*/

/*
//AULA: Operadores relacionais
int numero1 = 1;
var numero2 = 2;

bool igual = numero1 == numero2;
Console.WriteLine(igual);


bool maior = numero2 > numero1;
Console.WriteLine(maior);

bool menor = numero2 < numero1;
Console.WriteLine(menor);

bool menorOuIgual = numero2 <= numero1;
Console.WriteLine(menorOuIgual);

bool maiorOuIgual = numero2 >= numero1;
Console.WriteLine(maiorOuIgual);

bool diferente = numero2 != numero1;
Console.WriteLine(diferente);
/*/

/*
//AULA: Operadores lógicos
int numero1 = 1;
var numero2 = 2;

bool valido = numero2 > numero1 && 6 > 7;//&& = AND
Console.WriteLine(valido);//false

bool valido2 = numero2 > 10 || 6 > 7;//|| = OR
Console.WriteLine(valido2);//false

bool valido3 = !(numero2 > 3);//! = NOT
Console.WriteLine(valido3);//true
*/

/*
//AULA: Operador ternário
bool ativo = false;
string status = ativo ? "Cadastro Ativo" : "Cadastro inativo";//? = THEN (TRUE), : = ELSE (FALSE)
Console.WriteLine(status);//Cadastro inativo
*/

/*
//AULA: Criando a primeira função
EscreverNome();

void EscreverNome() //void = sem retorno
{
   var nome = NomeCompleto();
   var soma = SomaValores();

   Console.WriteLine(nome);
   Console.WriteLine(soma);
}

string NomeCompleto()
{
   //variáveis de escopo local, no caso, da função NomeCompleto
   string primeiroNome = "Renato Lucas";
   string segundoNome = "Silva";

   return primeiroNome + " " + segundoNome;
}

int SomaValores()
{
   return 8 + 2;
}
*/

/*
//AULA: Criando uma função que recebe parâmetros
var soma = SomaValores(3, 5);
Console.WriteLine(soma);

var nome = NomeEIdade("Renato", 33);
Console.WriteLine(nome);

int SomaValores(int a, int b)//int a, int b = parâmetros
{
   return a + b;
}

string NomeEIdade(string nome, int idade)
{
   return "Meu nome é " + nome + " e tenho " + idade + " anos"; //concatenação de string
}
*/

using System.Collections;

/*
//AULA: ArrayList
var arrayList = new ArrayList();
arrayList.Add(1);//pos = 0
arrayList.Add("Renato");//pos = 1
arrayList.Add(true); //pos = 2

//Console.WriteLine(arrayList[1]); // acesso por indice

//arrayList.RemoveAt(1);//Remove por índice

//Limpando ArrayList
//arrayList = new ArrayList();
//arrayList.Clear();

foreach (var item in arrayList) //percorre todo o arraylist
{
   Console.WriteLine(item);
}
*/

/*
//AULA: Array Tipado
//var arrayTipadoNumero = new int[3] {1, 2, 3}; //define o tipo do array e seu tamanho e já o inicializa com os valores
var arrayTipadoNumero = new int[3]; //define o tipo do array e seu tamanho

arrayTipadoNumero[0] = 5;//atribuindo valor para o array de acordo com o índice
arrayTipadoNumero[1] = 5;
arrayTipadoNumero[2] = 10;

//Array.Resize(ref arrayTipadoNumero, 100); //aumentando o tamho do vetor
//arrayTipadoNumero[10] = 100;//geraria erro caso não houvesse o resize

foreach(var item in arrayTipadoNumero)
{
   Console.WriteLine(item);
}


//var arrayTipadoString = new string[2] {"Rafael", "Almeida"};
var arrayTipadoString = new string[2];
arrayTipadoString[0] = "Renato";
arrayTipadoString[1] = "Lucas";

foreach(var item in arrayTipadoString)
{
   Console.WriteLine(item);
}
*/

/*
//AULA: Lista Genérica
//O desempenho é melhor que ArrayList, seu uso é mais indicado
var lista = new List<string>(10)//define tipo e o tamanho do lista
{
   "Renato",
   "Lucas", //passando valores para a lista ao instanciar
};

//lista.Add("Renato");
//lista.Add("Lucas");
//lista.Add("Curso");

//var nome = lista[0];//acesso por índice
//Console.WriteLine(nome);

//lista.RemoveAt(1);//remove por índice

foreach (var item in lista)//percorre toda a lista
{
   Console.WriteLine(item);
}
*/

/*
//AULA: Dicionário
var dicionario = new Dictionary<string, string>()//chave valor
{
   {"teste", "Teste"},
   {"teste6", "Teste 6"},
};

dicionario.Add("nome", "Renato");

dicionario["curso"] = "Curso";

var nome = dicionario["curso"];
//Console.WriteLine(nome);

foreach(var item in dicionario)//percorre todo o dicionario
{
   Console.WriteLine(item.Value);
} 
*/

/*
//AULA: Queue (Fila FIFO)
var queue = new Queue<string>();//Instanciando a fila já com o tipo
//var queue = new Queue();//Instanciando a fila sem tipo
queue.Enqueue("Renato");//empilha valor na fila
queue.Enqueue("Lucas");

//var nome = queue.Peek();//retorna o primeiro valor da fila sem remover
//var nome1 = queue.Peek();//retorna o primeiro valor da fila sem remover
//Console.WriteLine(nome);//Renato
//Console.WriteLine(nome1);//Renato

var nome = queue.Dequeue(); // Primeira execucao - remove o primeiro valor da fila
var nome1 = queue.Dequeue(); // Segunda execucao - remove o segundo valor da fila

Console.WriteLine(nome);//Renato
Console.WriteLine(nome1);//Lucas

foreach(var item in queue)
{
   Console.WriteLine(item);
} 
*/

/*
//AULA: Stack (Pilha LIFO)
var stack = new Stack<string>();//Instanciando a pilha já com o tipo
//var stack = new Stack();//Instanciando a pilha sem tipo
stack.Push("Renato");//empilha valor na pilha
stack.Push("Lucas");//empilha valor na pilha

var nome = stack.Pop();//remove o primeiro valor da pilha
var nome1 = stack.Pop();//remove o segundo valor da pilha

Console.WriteLine(nome);//Lucas
Console.WriteLine(nome1);//Renato


foreach(var item in stack)
{
   Console.WriteLine(item);
}
*/

/*
//AULA: IF/ELSE IF/ELSE
var diaDaSemana = 0;
var diaDeTrabalho = false;

if(diaDaSemana == 0 && diaDeTrabalho == true)
{
   Console.WriteLine("Hoje é domingo");
}
else if(diaDaSemana == 0 && diaDeTrabalho == false)
{
   Console.WriteLine("Hoje é domingo, mas nao é dia de trabalho");
}
else
{
   Console.WriteLine("Hoje não é domingo");
}

var diaDaSemana = 10;

if(diaDaSemana == 0)
{
   Console.WriteLine("Hoje é domingo");
}
else if(diaDaSemana == 1)
{
   Console.WriteLine("Hoje é Segunda");
}
else if(diaDaSemana == 2)
{
   Console.WriteLine("Hoje é Terça");
}
else if(diaDaSemana == 3)
{
   Console.WriteLine("Hoje é Quarta");
}
else if(diaDaSemana == 4)
{
   Console.WriteLine("Hoje é Quinta");
}
else if(diaDaSemana == 5)
{
   Console.WriteLine("Hoje é Sexta");
}
else if(diaDaSemana == 6)
{
   Console.WriteLine("Hoje é Sábado");
}
else
{
   Console.WriteLine("Dia da semana inválido");
}
*/

/*
//AULA: Switch
var diaDaSemana = 3;
switch(diaDaSemana)
{
   case 0:
   {
      Console.WriteLine("Hoje é domingo");
      break;
   }
   case 1:
      Console.WriteLine("Hoje é segunda");
      break;
   case 2:
      Console.WriteLine("Hoje é terça");
      break;
   case 3:
      Console.WriteLine("Hoje é quarta");
      break;
   case 4:
      Console.WriteLine("Hoje é quinta");
      break;
   case 5:
      Console.WriteLine("Hoje é sexta");
      break;
   case 6:
      Console.WriteLine("Hoje é sábado");
      break;   
   default:      
      Console.WriteLine("Dia da semana inválido");      
      break;
}
*/

/*
//AULA: FOR
var lista = new List<string>() { "Rafael", "Curso", "Csharp"};
var count = lista.Count;

for(var i = 0; i < count; i++)//
{
   var nome = lista[i];

   Console.WriteLine(nome);
}
*/

/*
//AULA: Foreach
//foreach é mais indicado para percorrer listas, arrays, dicionários, etc.
var lista = new List<string>() { "Rafael", "Curso", "Csharp"};

foreach(string item in lista)
{
   Console.WriteLine(item);
}

foreach(var letra in "Renato Lucas")//Percorrendo string
{
   Console.WriteLine(letra);
}
*/

/*
//AULA: WHILE e DO WHILE
var i = 0;
while(i < 2)//entra no loop enquanto a condição for verdadeira. Só entra no loop se a condição for verdadeira.
            //Se a condição for falsa, não entra no loop. Pode não executar o loop.
{
   Console.WriteLine("var i = " + i);
   //i += 1;
   i++;
}

var j = 0;
do //executa pelo menos uma vez, mesmo que a condição seja falsa
{
   Console.WriteLine("var j = " + j);
   j++;
} while (j < 2);
*/

/*
//AULA: BREAK e CONTINUE
var i = 0;
while(i < 5)
{

   if(i < 2)
   {
      Console.WriteLine("Continuando...");
      i++;
      continue;//pula para a próxima iteração, desconsidera o código abaixo e volta para o início do loop.
    }

   Console.WriteLine("var i = " + i);
   i++;

   if(i == 2)
   {
      Console.WriteLine("Valor de i é igual a 2 (dois)");
      break;//sai do loop (laço)
    }
}
*/