using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ejercicioLinkq
{
    public class linqQueries
    {
        List<Book> lstBooks = new List<Book>();
        
        public linqQueries(){
            using(StreamReader reader = new StreamReader("books.json")){
                string json = reader.ReadToEnd();
                this.lstBooks = System.Text.Json.JsonSerializer
                    .Deserialize<List<Book>>(json, new System.Text.Json.JsonSerializerOptions(){PropertyNameCaseInsensitive = true}) ?? new List<Book>();
            }
        }

        public IEnumerable<Book> AllCollection(){
            return lstBooks;
        }

        public IEnumerable<Book> LibrosDespuesDe(){
            return from book in lstBooks
                where book.PublishedDate.Year > 2000
                    select book;
        }

        public IEnumerable<Book> LibrosDespuesDe(int yearI){
            return from book in lstBooks
                where book.PublishedDate.Year > yearI
                    select book;
        }

        public IEnumerable<Book> LibrosDespuesDe(int yearI, int yearF){
            return from book in lstBooks
                where book.PublishedDate.Year > yearI 
                    && book.PublishedDate.Year > yearF
                        select book;
        }

        /// <summary>
        /// Funcion que permite buscar los libros que contiene mas de 250 paginas y cuyo nombre contiene la palabra Action
        /// </summary>
        /// <returns> retorna una lista de libros que cumplen la condicion anteriormente pag>250 </returns>
        public IEnumerable<Book> LibrosMas250Pag(){
            return from book in lstBooks
                where book.PageCount > 250
                    && (book.Title ?? String.Empty).Contains("in Action")
                        select book;
        }

        /// <summary>
        /// Funcion que permite buscar los libros que contiene mas de n paginas y cuyo titulo del lidro contiene una palabra n que es ingresada por teclado por el usuario al igual que el numero de paginas.
        /// </summary>
        /// <param name="totalPag"> Numero de paginas a buscar por parte del usuario</param>
        /// <param name="palabra"> palabra ingresada por el usuario a buscar dentro del titulo del libro</param>
        /// <returns> Retorna una lista con los titulos de los libros que cumplean con la anterior condicion </returns>
        public IEnumerable<Book> LibrosMasDeNPag (int totalPag, string palabra){
            return from book in lstBooks
                where book.PageCount > totalPag
                    && (book.Title ?? String.Empty).Contains(palabra)
                        select book;
        }





    }
}