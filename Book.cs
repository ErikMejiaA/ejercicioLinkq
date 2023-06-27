using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ejercicioLinkq
{
    public class Book
    {
        string ? title;
        int pageCount;
        DateTime publisheDate;
        string ? status;
        string[] ? authors;
        string[] ? categories;

        public string ? Title { get => title; set => title = value; }
        public int PageCount { get => pageCount; set => pageCount = value; }
        public DateTime PublisheDate { get => publisheDate; set => publisheDate = value; }
        public string ? Status { get => status; set => status = value; }
        public string[] ? Authors { get => authors; set => authors = value; }
        public string[] ? Categories { get => categories; set => categories = value; }

        public Book(){
            
        }
        
    }
}