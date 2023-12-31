﻿using ejercicioLinkq;

internal class Program
{
    private static void Main(string[] args)
    {
        linqQueries queries = new linqQueries();
        //IMprimir toda la coleccion de libros 
        //ImprimirValores(queries.AllCollection());

        //Reto operador Where 1
        ImprimirValores(queries.LibrosDespuesDe(2020));

        //Reto operador Where 2 buscar por numeros de paginas
        ImprimirValores(queries.LibrosMas250Pag());
    }

    private static void ImprimirValores(IEnumerable<Book> books)
    {
        int registros = 0;
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine("{0, -70} {1, 7} {2, 20}", "Tutulo", "N. Paginas", "Fecha Publicacion");
        foreach (Book book in books)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            registros += 1;
            Console.WriteLine("{0, -70} {1, 7} {2, 20}", book.Title, book.PageCount, book.PublishedDate.ToShortDateString());

            if(registros % 10 ==0)
            {
                Console.ReadKey();
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("{0, -70} {1, 7} {2, 20}", "Ttulo", "N. Paginas", "Fecha Publicacion");
            }
        }

    }
}