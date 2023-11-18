using System;

namespace uri1003 {
    class Program {
        static void Main(string[] args) {

        //Example 1 - Parse Function
            int A, B, soma;

            A = int.Parse(Console.ReadLine());
            B = int.Parse(Console.ReadLine());
            soma = A + B;
            Console.WriteLine("SOMA = " + soma);


		//Example 2 - ToString Function
            double R, A, pi = 3.14159;

            R = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            A = pi * R * R;
            Console.WriteLine("A=" + A.ToString("F4", CultureInfo.InvariantCulture));

        //Example 3 - Split Function / Vetor
            int cod1, cod2, qte1, qte2;
            double preco1, preco2, total;

            string[] valores = Console.ReadLine().Split(' ');
            cod1 = int.Parse(valores[0]);
            qte1 = int.Parse(valores[1]);
            preco1 = double.Parse(valores[2], CultureInfo.InvariantCulture);
            valores = Console.ReadLine().Split(' ');
            cod2 = int.Parse(valores[0]);
            qte2 = int.Parse(valores[1]);
            preco2 = double.Parse(valores[2], CultureInfo.InvariantCulture);
            total = preco1 * qte1 + preco2 * qte2;
            Console.WriteLine("VALOR A PAGAR: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));

        //Example 4
            double A, B, C, triangulo, circulo, trapezio, quadrado, retangulo;

            string[] valores = Console.ReadLine().Split(' ');
            A = double.Parse(valores[0], CultureInfo.InvariantCulture);
            B = double.Parse(valores[1], CultureInfo.InvariantCulture);
            C = double.Parse(valores[2], CultureInfo.InvariantCulture);
            triangulo = A * C / 2.0;
            circulo = 3.14159 * C * C;
            trapezio = (A + B) / 2.0 * C;
            quadrado = B * B;
            retangulo = A * B;
            Console.WriteLine("TRIANGULO: " + triangulo.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("CIRCULO: " + circulo.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("TRAPEZIO: " + trapezio.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("QUADRADO: " + quadrado.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("RETANGULO: " + retangulo.ToString("F3", CultureInfo.InvariantCulture));

        // Example 5 - If Function
            int N = int.Parse(Console.ReadLine());

            if (N < 0) {
                Console.WriteLine("NEGATIVO");
            }
            else {
                Console.WriteLine("NAO NEGATIVO");
            }

        //Example 6 - If function / Vetor
            string[] valores = Console.ReadLine().Split(' ');
            int codigo = int.Parse(valores[0]);
            int quantidade = int.Parse(valores[1]);

            double total;
            if (codigo == 1) {
                total = quantidade * 4.0;
            }
            else if (codigo == 2) {
                total = quantidade * 4.5;
            }
            else if (codigo == 3) {
                total = quantidade * 5.0;
            }
            else if (codigo == 4) {
                total = quantidade * 2.0;
            }
            else {
                total = quantidade * 1.5;
            }
            Console.WriteLine("Total: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));

        //Example 7 - While Function
            int senha = int.Parse(Console.ReadLine());

            while (senha != 2002) {
                Console.WriteLine("Senha Invalida");
                senha = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Acesso Permitido");


            string[] valores = Console.ReadLine().Split(' ');
            int x = int.Parse(valores[0]);
            int y = int.Parse(valores[1]);

            while (x != 0 && y != 0) {
                if (x > 0 && y > 0) {
                    Console.WriteLine("primeiro");
                }
                else if (x < 0 && y > 0) {
                    Console.WriteLine("segundo");
                }
                else if (x < 0 && y < 0) {
                    Console.WriteLine("terceiro");
                }
                else {
                    Console.WriteLine("quarto");
                }
                valores = Console.ReadLine().Split(' ');
                x = int.Parse(valores[0]);
                y = int.Parse(valores[1]);
            }

            //Example 8 - For Function
                int x = int.Parse(Console.ReadLine());

            	for (int i = 1; i <= x; i++) {
                	if (i % 2 != 0) {
                    Console.WriteLine(i);
                	}
                }

                
                int n = int.Parse(Console.ReadLine());

            	for (int i = 0; i < n; i++) {
	                string[] line = Console.ReadLine().Split(' ');
	                double a = double.Parse(line[0], CultureInfo.InvariantCulture);
	                double b = double.Parse(line[1], CultureInfo.InvariantCulture);
	                double c = double.Parse(line[2], CultureInfo.InvariantCulture);
	                double media = (a * 2.0 + b * 3.0 + c * 5.0) / 10.0;
	                Console.WriteLine(media.ToString("F1", CultureInfo.InvariantCulture));
	            }

	        //Example 9 - F String like Python
            	int n = int.Parse(Console.ReadLine());

            	for (int i = 1; i <= n; i++) {

	                int primeiro = i;
	                int segundo = i * i;
	                int terceiro = i * i * i;
                	Console.WriteLine($"{primeiro} {segundo} {terceiro}");
                }

        }//static void Main
    }//class Program 
}//namespace