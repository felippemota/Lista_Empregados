using System;
using System.Collections.Generic;
using System.Globalization;

namespace Lista_Acrescimo_de_Salario
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quantos empregados serão registrados?: ");
            int n = int.Parse(Console.ReadLine());

            List<Empregados> lista = new List<Empregados>();

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("Empregado #" + i + ":");
                Console.Write("Insira sua Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Insira seu Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Insira o salário: ");
                double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                lista.Add(new Empregados(id, nome, salario));
                Console.WriteLine();
            }

            Console.WriteLine("Digite a ID do funcionário que terá o salário reajustado: ");
            int procura_id = int.Parse(Console.ReadLine());

            Empregados emp = lista.Find(x => x.Id == procura_id);
            if (emp != null)
            {
                Console.Write("Entre com a porcentagem: ");
                double percentage = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                emp.AcrescentarSalario(percentage);
            }

            Console.WriteLine();
            Console.WriteLine("Lista atualizada dos empregados:");
            foreach (Empregados obj in lista)
            {
                Console.WriteLine(obj);
            }
        }
    }
}

