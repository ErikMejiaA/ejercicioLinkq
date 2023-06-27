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
                where book.PublishedDate.Year > yearI && book.PublishedDate.Year > yearF
                select book;
        }

    }
}