using System;

namespace Facec.Fundamentos._2023
{
    internal class Program
    {
        #region variaveis privadas

        private ICarrinhoCompra _carrinhoCompra;
        private const string C_NOME_DEV = "Juliano";
        private readonly int _valor = 10;

        #endregion variaveis privadas

        #region construtores

        public Program(int valor)
        {
            _valor = valor;
        }

        public Program()
        {
            _valor = 11;
        }

        #endregion construtores

        #region metodos

        //void teste()
        //{
        //    _valor = 13;
        //}

        static void Main(string[] args)
        {
            ICarrinhoCompra carrinhoCompra;

            #region tipos primitivos inteiros

            //Console.WriteLine("byte:" + byte.MinValue + " " + byte.MaxValue);
            //Console.WriteLine("short:" + short.MinValue + " " + short.MaxValue);
            //Console.WriteLine("ushort:" + ushort.MinValue + " " + ushort.MaxValue);
            //Console.WriteLine("int:" + int.MinValue + " " + int.MaxValue);
            //Console.WriteLine("uint:" + uint.MinValue + " " + uint.MaxValue);
            //Console.WriteLine("long:" + long.MinValue + " " + long.MaxValue);

            #endregion tipos primitivos inteiros

            #region tipos primitivos pontos flutuantes

            //Console.WriteLine("float:" + float.MinValue + " " + float.MaxValue);
            //Console.WriteLine("double:" + double.MinValue + " " + double.MaxValue);
            //Console.WriteLine("decimal:" + decimal.MinValue + " " + decimal.MaxValue);

            try
            {
                var double1 = 10.10;
                var double2 = 20.20;

                Console.WriteLine("double1 + double2 = " + (double1 + double2));
                Console.WriteLine("double1 + double2 (com Math.Round)= " + Math.Round(double1 + double2, 2));

                var decimal1 = 10.10m;
                var decimal2 = 20.20m;

                Console.WriteLine("decimal1 + decimal2 = " + (decimal1 + decimal2));

                Console.WriteLine("Informe valor um : ");
                var valor1 = decimal.Parse(Console.ReadLine());

                Console.WriteLine("valor1: " + valor1);

                Console.WriteLine("Informe valor dois : ");
                decimal.TryParse(Console.ReadLine(), out decimal valor2);

                Console.WriteLine("valor2: " + valor2);

                Console.WriteLine("Soma valor1 + valor2: " + (valor1 + valor2));
            }
            catch (Exception ex) 
            {
                Console.WriteLine(ex.Message);
            }

            #endregion tipos primitivos pontos flutuantes

            #region tipo primitivo boolean

            //bool boolUm = false;
            //var boolDois = true;

            //Console.WriteLine("bool:" +  boolUm + " " + boolDois);

            #endregion tipo primitivo boolean;

            #region tratamento de exception e strings

            //try
            //{
            //    Console.WriteLine("Digite seu nome: ");
            //    //var caractere = Console.ReadKey();
            //    var nome = Console.ReadLine()
            //        ?? throw new ArgumentNullException("Nome não pode ser nulo!");
                
            //    // o ?? substitui o if abaixo
            //    //if (nome == null)
            //    //    throw new ArgumentNullException("Nome não pode ser nulo!");

            //    if (string.IsNullOrWhiteSpace(nome))
            //        throw new ArgumentException("Nome não pode ser vazio");

            //    var mensagem = nome == "juliano" 
            //        ? "Olá " + nome : "Até logo " + nome;

            //    //if (nome == "juliano")
            //    //    mensagem = "Olá " + nome;
            //    //else
            //    //    mensagem = "Até logo " + nome;

            //    Console.WriteLine(mensagem);
            //}
            //catch (ArgumentNullException ex)
            //{
            //    Logger(ex);
            //    throw;
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}

            #endregion tratamento de exception e strings 
        }

        private static void Logger(Exception ex)
        {
            Console.WriteLine(ex.Message);
        }

        #endregion metodos
    }
}