// See https://aka.ms/new-console-template for more information
Console.WriteLine("Exercicio 2");



Questao1();
Questao2();
Questao3();
Questao4();
Questao5();
Questao6();
Questao7();
Questao8();
Questao9();
Questao10();



static void Questao1(){

Console.Write("digite o 1º numero: ");

double num1 = double.Parse(Console.ReadLine());

Console.Write("digite o 2º numero: ");

double num2 = double.Parse(Console.ReadLine());

double soma = num1+num2 ;

Console.WriteLine($"{num1}+{num2}={soma}");
Console.WriteLine("------------------------------------------");

double sub = num1-num2 ;

Console.WriteLine($"{num1}-{num2}={sub}");
Console.WriteLine("------------------------------------------");

double mult= num1*num2 ;

Console.WriteLine($"{num1}*{num2}={mult}");
Console.WriteLine("------------------------------------------");

double div = num1/num2 ;

Console.WriteLine($"{num1}/{num2}={div}");
Console.WriteLine("------------------------------------------");

}

static void Questao2(){

Console.Write("Digite o lado do quadrado: ");

double lado = double.Parse(Console.ReadLine());
double area = lado*lado;
double per = lado *4 ;
Console.WriteLine($"A área do quadrado é : {area}");
Console.WriteLine("------------------------------");
Console.WriteLine($"O seu perímetro é : {per}");


}

static void Questao3(){

Console.Write("Digite a base do retangulo: ");
double B = double.Parse(Console.ReadLine());
Console.WriteLine("-----------------------------");
Console.Write("Digite a altura do retangulo: ");
double H = double.Parse(Console.ReadLine());
Console.WriteLine("-----------------------------");
double area = B*H ;

double per = 2*B + 2*H ;

Console.WriteLine($"a área do retangulo é : {area}");
Console.WriteLine("-----------------------------");
Console.WriteLine($"o perímetro do retangulo é : {per}");

}

static void Questao4(){
    
Console.Write("Digite o valor do salario minimo: ");
double salario = double.Parse(Console.ReadLine());
Console.WriteLine("----------------------------");
Console.Write("Digite o valor gasto de kw: ");
double kw = double.Parse(Console.ReadLine());
Console.WriteLine("-----------------------------");

double val_kw = (salario/7)/100;
double valor_pago = val_kw*kw ;
double valor_com_desconto = valor_pago-(valor_pago*0.1) ;


Console.WriteLine($"O valor do kw é de R$ {val_kw} por kw/h");
Console.WriteLine("-----------------------------");
Console.WriteLine($"O valor da conta a ser pago é R$ {valor_pago}");
Console.WriteLine("-----------------------------");
Console.WriteLine($"O valor da conta a ser pago com destonco de 10% é R$ {valor_com_desconto}");
Console.WriteLine("-----------------------------");

}

static void Questao5(){

Console.Write("Digite um valor inteiro: ");
int num = int.Parse(Console.ReadLine());

if(num >=20 && num <=90){
    Console.WriteLine("O numero está entre 20 e 90");
}else{
    Console.WriteLine("O numero não está entre 20 e 90");
}



}

static void Questao6(){
    Console.Write("Digite o primeiro num: ");
    int num1 = int.Parse(Console.ReadLine());
    Console.WriteLine("-----------------------------");
    Console.Write("Digite o segundo num: ");
      int num2 = int.Parse(Console.ReadLine());
    Console.WriteLine("-----------------------------");

    if(num1 == num2){
         Console.WriteLine("numeros iguais");
    }else 
    {
        if(num1 > num2){
             Console.WriteLine("O primeiro número é maior");
        }else{
             Console.WriteLine("O segundo número é maior");
        }
        }
    }

static void Questao7(){


Console.Write("Digite o salario do funcionario: ");
double salario_ = double.Parse(Console.ReadLine());
Console.WriteLine("-----------------------------");
Console.WriteLine("Digite uma opção: \n 1)Aumento de 30%  \n 2)Aumento de 20%");
int opc = int.Parse(Console.ReadLine());
Console.Write("Sua opção:");
Console.WriteLine("-----------------------------");

double sal_novo = 0;
if(opc ==1){
 sal_novo = salario_+(salario_ * 0.3);
}else{
    sal_novo = salario_+(salario_*0.2);
}



Console.WriteLine($"O salário novo é : {sal_novo} ");


}

static void Questao8(){

Console.Write("Digite o ano de nascimento do funcionario :");
int ano_nasc = int.Parse(Console.ReadLine());

Console.Write("Digite o ano de ingresso na empresa :");
int ano_emp = int.Parse(Console.ReadLine());

string data_atual = DateTime.Now.ToString("yyyy");
int data_hoje = int.Parse(data_atual);    /// função para pegar o ano atual do sistema 
int tempo_servico =  data_hoje-ano_emp;
int idade = data_hoje - ano_nasc;

Console.WriteLine($"O funcionário tem {idade} anos");


Console.WriteLine($"O funcionário tem {tempo_servico} anos de serviço prestado");

if((idade >= 60 && tempo_servico>=25) ||(idade >= 65) || (tempo_servico >=30)){
   Console.WriteLine("Requer aposentadoria"); 
}else{
     Console.WriteLine("Não requer aposentadoria, pode trabalhar"); 
}

}

static void Questao9(){
     int i;
     for (i=10 ;i <= 100 ;i++){

         if(i%7==0){
             Console.WriteLine($"{i}");
         }


     }


}

static void Questao10(){

int i = 50 ;

int soma = 0 ;

 //soma = 50* ((50+100)/2); // utilizando método de progressão aritimetica S = n(a1+a2)/2
   
   for (i=50 ;i<101 ; i++){

       soma = i + soma ;

   }


     int media = soma /50 ;

     Console.WriteLine($"A soma dos numeros de 50 a 100 é :{soma}") ;
    Console.WriteLine($"A media dos numeros de 50 a 100 é :{media}") ;

}