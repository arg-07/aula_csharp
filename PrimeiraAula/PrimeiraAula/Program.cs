using System;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {


            byte n1 = 126;

            n1++;

            Console.WriteLine(n1);

            Console.ReadLine();

        }

    }

}





//using System;
//using System.Globalization;

//namespace Course
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {


//            int M, N;
//            int[,] A; // declarando variável do tipo matriz

//            String[] s1 = Console.ReadLine().Split(' ');
//            M = int.Parse(s1[0]);
//            N = int.Parse(s1[1]);

//            A = new int[M, N]; // instanciando a varável do tipo matriz

//            for (int i = 0; i < M; i++) // esse for percorre as linhas da minha matriz coletando os valores
//            {


//                String[] s = Console.ReadLine().Split(' ');

//                for (int j = 0; j < N; j++) // esse for percorre as colunas da minha matriz coletando os valores
//                {


//                    A[i, j] = int.Parse(s[j]);

//                }


//            }

//            for (int i = 0; i < M; i++) // esse for percorre as linhas da matriz gerdada e apresenta na tela os resultados
//            {


//                for (int j = 0; j < N; j++) // esse for percorre as colunas da matriz gerada e apresenta na tela os resultados
//                {


//                    Console.Write(A[i, j] + " ");


//                }

//                Console.WriteLine();



//            }

//            Console.ReadLine();

//        }

//    }

//}
































//using System;
//using System.Globalization;

//namespace Course
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {


//            int M, N;
//            int[,] A; // declarando variável do tipo matriz

//            M = int.Parse(Console.ReadLine());
//            N = int.Parse(Console.ReadLine());

//            A = new int[M, N]; // instanciando a varável do tipo matriz

//            Console.ReadLine();

//            for (int i = 0; i < N; i++) { }



//        }

//    }

//}







//using System;
//using System.Globalization;

//namespace Course
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {


//            int N;
//            N = int.Parse(Console.ReadLine());
//            string[] vet = new string[N];

//            for (int i = 0; i < N; i++)
//            {
//                vet[i] = Console.ReadLine();

//            }

//            Console.WriteLine("Nomes lidos:");

//            foreach(string x in vet) // para cada elemento x que é o apelido contido no vetor vet... eu vou fazer uma coisa
//            {

//                Console.WriteLine(vet[i]);

//            }

//            Console.ReadLine();


//        }

//    }

//}






















//using System;
//using System.Globalization;

//namespace Course
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {


//            int N;
//            N = int.Parse(Console.ReadLine());
//            string[] vet = new string[N];

//            for (int i = 0; i < N; i++) 
//            {
//                vet[i] = Console.ReadLine();

//            }

//            Console.WriteLine("Nomes lidos:");

//            for (int i = 0; i < N; i++) 
//            {

//                Console.WriteLine(vet[i]);

//            }

//            Console.ReadLine();


//        }

//    }

//}








//using System;
//using System.Globalization;

//namespace Course
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {

//            int N;
//            N = int.Parse(Console.ReadLine());

//            String[] nomes = new string[N];
//            int[] idades = new int[N];
//            double[] altura = new double[N];


//            // Leituras dos dados
//            for (int i = 0; i < N; i++)
//            {

//                string[] s = Console.ReadLine().Split(' ');
//                nomes[i] = s[0];
//                idades[i] = int.Parse(s[1]);
//                altura[i] = double.Parse(s[2], CultureInfo.InvariantCulture);


//            }

//            // Calculo da altura media das pessoas
//            double soma = 0.0;
//            for (int i = 0; i < N; i++)
//            {

//                soma = soma + altura[i];


//            }

//            double media = soma / N;
//            Console.WriteLine("Altura media: " + media.ToString("F2", CultureInfo.InvariantCulture));

//            // Porcentagem de pessoas abaixo de 16 anos
//            int cont = 0;
//            for (int i = 0; i < N; i++)
//            {


//                if (idades[i] < 16)
//                {

//                    cont++; // isso é igual a cont = cont + 1


//                }


//            }

//            double porcentagem = (double)cont / N * 100.0; // (double) isso garante que os dados não sejam truncados
//            Console.WriteLine("Pessoas com menos de 16 anos: " + porcentagem.ToString("F1", CultureInfo.InvariantCulture) + "%");

//            Console.Read();



//        }

//    }

//}
















//using System;
//using System.Globalization;

//namespace Course
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {


//            int N;
//            double[] vet; //declaração da variavel vetor

//            N = int.Parse(Console.ReadLine());

//            vet = new double[N]; //instanciação da variavel vetor

//            // OBS: a instanciação da variavel vetor deverá ser ocorrer depois da coleta das informações da 
//            // mesma

//            for (int i = 0; i < N; i++) 
//            {


//                vet[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


//            }

//            for (int i = 0; i < N;i++) 
//            {


//                Console.WriteLine(vet[i].ToString("F1", CultureInfo.InvariantCulture));


//            }

//        Console.ReadLine();

//        }

//    }

//}




















//using System;
//using System.Globalization;

//namespace Course
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {


//            double idade, soma, media;
//            int cont;

//            idade = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

//            soma = 0.0;
//            cont = 0;

//            while (idade >= 0) 
//            {

//                soma += idade;
//                cont = cont + 1;
//                idade = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

//            }
//            if (cont == 0) 
//            {

//                Console.WriteLine("Impossível calcular");

//            }
//            else 
//            {

//                media = soma / cont;
//                Console.WriteLine(media.ToString("F2", CultureInfo.InvariantCulture));
//                Console.ReadLine();


//            }


//        }

//    }

//}








//using System;
//using System.Globalization;

//namespace Course
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {

//            int x, y;

//            String[] vet = Console.ReadLine().Split(' ');
//            x = int.Parse(vet[0]);
//            y = int.Parse(vet[1]);

//            while (x != y) 
//            { 

//                if (x < y) 
//                {

//                    Console.WriteLine("Crescente");

//                }
//                else 
//                {

//                    Console.WriteLine("Decrescente");

//                }

//                vet = Console.ReadLine().Split(' ');
//                x = int.Parse(vet[0]);
//                y = int.Parse(vet[1]);


//            }


//        }

//    }

//}


















//using System;
//using System.Globalization;
//using System.Runtime.Serialization;

//namespace Course
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {

//            int x, soma;

//            x = int.Parse(Console.ReadLine());
//            soma = 0;

//            while (x != 0) 
//            {
//                soma += x;
//                x = int.Parse(Console.ReadLine());

//            }

//            Console.WriteLine(soma);
//            Console.ReadLine();

//        }

//    }

//}




















//using System;
//using System.Globalization;

//namespace Course
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {


//            int x = int.Parse(Console.ReadLine());
//            string dia;

//            switch (x) 
//            {
//                case 1:
//                    dia = "domingo";
//                    break;
//                case 2:
//                    dia = "segunda-feira";
//                    break;
//                case 3:
//                    dia = "terça-feira";
//                    break;
//                case 4:
//                    dia = "quarta-feira";
//                    break;
//                case 5:
//                    dia = "quinta-feira";
//                    break;
//                case 6:
//                    dia = "quinta-feira";
//                    break;
//                case 7:
//                    dia = "sexta-feira";
//                    break;
//                default:
//                    dia = "valor inválido";
//                    break;

//            }

//            Console.WriteLine("dia da semana: " + " " + dia);
//            Console.ReadLine();

//        }

//    }

//}



























//using System;
//using System.Globalization;

//namespace Course
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {

//            int x = int.Parse(Console.ReadLine());
//            string dia;


//            if (x == 1) 
//            {

//                dia = "domingo";

//            }
//            else if (x == 2)
//            {

//                dia = "segunda-feira";

//            }
//            else if (x == 3) 
//            {

//                dia = "terça-feira";

//            }
//            else if (x == 4) 
//            {

//                dia = "quarta-feira";

//            }
//            else if (x == 5) 
//            {

//                dia = "quinta-feira";


//            }
//            else if (x == 6) 
//            {

//                dia = "sexta-feira";


//            }
//            else if (x == 7) 
//            {

//                dia = "sabado";

//            }
//            else 
//            {

//                dia = "valor inválido";

//            }

//            Console.WriteLine("dia da semana: " + " " + dia);
//            Console.ReadLine();

//        }

//    }

//}



















//using System;
//using System.Globalization;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;


//namespace Course
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {


//            int minutos;
//            double conta;

//            minutos = int.Parse(Console.ReadLine());

//            conta = 50.0;

//            if (minutos > 100) 
//            { 

//                conta += (minutos - 100) * 2.0;   

//            }

//            Console.WriteLine("Valor a pagar: R$ " + conta.ToString("F2", CultureInfo.InvariantCulture));
//            Console.ReadLine();


//        }

//    }

//}






















//using System;
//using System.Globalization;

//namespace Course
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {

//            int x, y, z;

//            String[] vet = Console.ReadLine().Split(' ');

//            x = int.Parse(vet[0]);
//            y = int.Parse(vet[1]);
//            z = int.Parse(vet[2]);

//            if (x < y && x < z)

//            {

//                Console.WriteLine("Menor = " + x);

//            }

//            else

//            {

//                if (y < z)
//                {

//                    Console.WriteLine("Menor = " + y);

//                }
//                else
//                {

//                    Console.WriteLine("MENOR = " + z);

//                }


//            }


//        }

//    }

//}





















//using System;
//using System.Globalization;

//namespace Course
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {

//            double a, b, c, delta, r1, r2;

//            Console.WriteLine("Calculo do teorema do baskara");

//            Console.WriteLine("Digite o valor de A:");
//            a = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
//            Console.WriteLine("Digite o valor de B:");
//            b = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
//            Console.WriteLine("Digite o valor de C:");
//            c = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

//            delta = Math.Pow(b, 2.0) - 4 * a * c;

//            if (a == 0.0 || delta < 0.0)  

//            {

//                Console.WriteLine("Impossível calcular!");

//            }
//            else 

//            {

//                r1 = (-b + Math.Sqrt(delta)) / (2.0 * a);
//                r2 = (-b - Math.Sqrt(delta)) / (2.0 * a);

//                Console.WriteLine("O valor do delta é :" + " " + delta.ToString("F5", CultureInfo.InvariantCulture));
//                Console.WriteLine("R1 = " + " " + r1.ToString("F5", CultureInfo.InvariantCulture));
//                Console.WriteLine("R2 = " + " " + r1.ToString("F5", CultureInfo.InvariantCulture));

//            }

//        }

//    }

//}




















//using System;
//using System.Globalization;

//namespace Course
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {

//            double nota1, nota2, soma;

//            Console.WriteLine("Digite a primeira nota:");
//            nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

//            Console.WriteLine("Digite a segunda nota:");
//            nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

//            soma = (nota1 + nota2) / 2;

//            Console.WriteLine("Média Final = " + " " + soma.ToString("F1", CultureInfo.InvariantCulture));

//            if (soma > 60.0)
//            {

//                Console.WriteLine("Aprovada");

//            }

//            else 

//            {

//                Console.WriteLine("Reprovado");

//            }



//        }

//    }

//}






















//using System;
//using System.Globalization;

//namespace Course
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {

//            int horas;

//            Console.WriteLine("Digitar quantas horas?");
//            horas = int.Parse(Console.ReadLine());

//            if (horas < 12) 

//            {

//                Console.WriteLine("Bom Dia!");

//            }

//            else
//            {
//                if (horas < 18) 
//                    {

//                    Console.WriteLine("Boa Tarde!");

//                }
//                else
//                { 
//                    Console.WriteLine("Boa Noite!"); 

//                }

//            }

//        }

//    }

//}















//using System;
//using System.Globalization;

//namespace Course
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {

//            int N, horas, resto, minutos, segundos; 

//            N = int.Parse(Console.ReadLine());

//            horas = N / 3600;
//            resto = N % 3600;

//            minutos = resto / 60;
//            segundos = resto % 60;



//            Console.WriteLine(horas + ":" + minutos + ":" + segundos);


//        }

//    }

//}







//using System;
//using System.Globalization;

//namespace Course
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {

//            string nome;

//            double s, tv, total;

//            nome = Console.ReadLine();
//            s = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
//            tv = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

//            total = (double) ((tv * 15.0) / 100) + s;

//            Console.WriteLine("Total = R$" + " " + total.ToString("F2", CultureInfo.InvariantCulture));


//        }

//    }

//}



















//using System;
//using System.Globalization;

//namespace Course
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {

//            string m, n;
//            int A, B;
//            double C;

//            string[] vet;

//            vet = Console.ReadLine().Split(' ');
//            m = vet[0];
//            A = int.Parse(vet[1]);

//            vet = Console.ReadLine().Split(' ');
//            n = vet[0];
//            B = int.Parse(vet[1]);

//            C = (double) (A + B) / 2.0;


//            Console.WriteLine("A idade média de " + " " + n + " e " + " " + m +  " " + " é " + " " + C.ToString("F2", CultureInfo.InvariantCulture));


//        }

//    }

//}



//A = horas trabalhadas
//B = valor das horas trabalhadas
//NUMBER = numero do funcionario
//SALARY = calculo do salario


//using System;
//using System.Globalization;

//namespace Course
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {

//            double R, A, pi = 3.14159 ;

//            R = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


//            A =  pi * R * R; 


//            Console.WriteLine("A=" + A.ToString("F4", CultureInfo.InvariantCulture));


//        }

//    }

//}




//B = Math.Pow(N, 2.0);




//using System;

//namespace Course
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {

//            int A, B, X;


//            A = int.Parse(Console.ReadLine());
//            B = int.Parse(Console.ReadLine());


//            X = A + B;

//            Console.WriteLine("X =" + " " + X );


//        }

//    }

//}
















//using System;
//using System.Globalization;

//namespace Course
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {

//            Double X, Y, c, l, v;

//            Console.ReadLine();

//            Console.WriteLine("Entre com o valor do comprimento do terreno:");
//            l = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
//            Console.ReadLine();

//            Console.WriteLine("Entre com o valor da largura do terreno:");
//            c = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
//            Console.ReadLine();

//            Console.WriteLine("Qual o valor do metro quadrado do terreno?");
//            v = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
//            Console.ReadLine();

//            X = c * l;
//            Y = X * v;


//Console.WriteLine("A Área do terreno é:" + " " + X.ToString("F2", CultureInfo.InvariantCulture));
//Console.WriteLine("O preço do terreno é:" + " " + Y.ToString("F2", CultureInfo.InvariantCulture));

//            Console.ReadLine();

//        }

//    }

//}
















//using System;

//Double A, B, C;
//Double x = 3.0;
//Double y = 4.0;
//Double z = -5.0;

//A = Math.Sqrt(x);
//B = Math.Pow(y, 2.0);
//C = Math.Abs(z);

//Console.WriteLine("Raiz quadrada de X:" + " " + x + " " + A);
//Console.WriteLine("Elevado ao quadrado Y:" + " " + y + " " + B);
//Console.WriteLine("Valor absoluto de:" + " " + z + " " + C);
//Console.ReadLine();




//using System;
//using System.Globalization;


//namespace Course
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Entre com seu nome completo:");

//            String nome = Console.ReadLine();

//            Console.WriteLine("Quantos quartos tem sua casa?");

//            int numero = int.Parse(Console.ReadLine());

//            Console.WriteLine("Entre com o preço de um produto:");

//            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

//            Console.WriteLine("Entre com o seu ultimo nome, idade e altura (mesma linha):");

//            string s = Console.ReadLine();
//            string[] vet = s.Split(' ');

//            string unome = vet[0];
//            int idade = int.Parse(vet[1]);
//            double altura = double.Parse(vet[2], CultureInfo.InvariantCulture);
//            Console.ReadLine();

//            Console.WriteLine("seu nome é:" + " " + nome + " " + unome);
//            Console.WriteLine("sua idade é:" + "" + idade);
//            Console.WriteLine("sua altura é:" + "" + altura);

//            Console.ReadLine();

//            //Console.WriteLine("Entre com seu nome completo:");
//            //Console.ReadLine();
//            //Console.WriteLine(nome);
//            //Console.WriteLine("Quantos quartos tem sua casa?");
//            //Console.ReadLine();
//            //Console.WriteLine(numero);
//            //Console.WriteLine("Entre com o preço de um produto:");
//            //Console.ReadLine();
//            //Console.WriteLine(preco);

//            //Console.ReadLine();



//        }

//    }

//}























//using System;
//using System.Globalization;


//namespace Course
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {

//            int n1 = int.Parse(Console.ReadLine());
//            char ch = char.Parse(Console.ReadLine());
//            double n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

//            string s = Console.ReadLine();
//            string[] vet = s.Split(' ');

//            string nome = vet[0];
//            char sexo = char.Parse(vet[1]);
//            int idade = int.Parse(vet[2]);
//            double altura = double.Parse(vet[3], CultureInfo.InvariantCulture);

//            Console.WriteLine("voce digitou:");
//            Console.WriteLine(n1);
//            Console.WriteLine(ch);
//            Console.WriteLine(n2);
//            Console.WriteLine(nome);
//            Console.WriteLine(sexo);
//            Console.WriteLine(altura);
//            Console.WriteLine(idade);
//            Console.ReadLine();



//        }

//    }

//}







//namespace Course
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {

//            string frase = Console.ReadLine();
//            string x = Console.ReadLine();
//            string y = Console.ReadLine();
//            string z = Console.ReadLine();

//            string s = Console.ReadLine();
//            string[] vet = s.Split(' ');
//            string a = vet[0];
//            string b = vet[1];
//            string c = vet[2];


//          Console.WriteLine("vc digitou: ");
//            Console.WriteLine(frase);
//            Console.WriteLine(x);
//            Console.WriteLine(y);
//            Console.WriteLine(z);
//            Console.WriteLine("vc digitou: ");
//            Console.WriteLine(a);
//            Console.WriteLine(b);
//            Console.WriteLine(c);
//            Console.ReadLine();


//        }

//    }

//}


















////double x = 10.35784;
//int x, y, z, area;

//x = 6; y = 8; z = 5;

//area = (x + y) / 2 * z;



//Console.WriteLine("Área = " + area);

//Console.ReadLine();


//float b, B, h, area;

//b = 6f;
//B = 8f;
//h = 5f;

//area = (b + B) / 2f * h;

//Console.WriteLine("Área = " + area);

//Console.ReadLine();


//int a, b;
//double resultado;

//a = 5;
//b = 2;

//resultado = (double)a / b;

//Console.WriteLine("Área = " + resultado);

//Console.ReadLine();


//double a;
//int b;

//a = 5.0;
//b = (int) a;

//Console.WriteLine(b);

//Console.ReadLine();

//Console.WriteLine(x.ToString("F2", CultureInfo.InvariantCulture));


//Console.WriteLine(x);

//Console.WriteLine(x.ToString("F2"));
//Console.WriteLine(x.ToString("F4"));

//Console.WriteLine("resultado = " + x);

//Console.WriteLine("resultado = " + y + "" + x + " reais");

//Console.WriteLine("O valor do troco é = " + y + x.ToString("F2") + " reais");


