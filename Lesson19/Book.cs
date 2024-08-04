using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Net.Http.Headers;
using System.Security;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace Lesson19
{
    public class Book
    {
        private string code;
        public static int _counter {get; set;}
        public int counter {get; set;}
        public string Name {get; set;}
        public string AuthorName {get; set;}
        public int PageCount {get; set;}
        public string Code {get ; set ;}
        public Book(string _name)
        {
            Name=_name;
            _counter++;
            counter=_counter;
            code=MakeCode(Name,counter);
            Code=code;
        }
        
        
        public string MakeCode(string Name , int number)
        {
           string s=Name.Substring(0,2).ToUpper();
           string _code=s+number;
           return _code;
        }
        public override string ToString()
        {
            return $"Adi: {Name}    Yazicisi: {AuthorName}    Sehifelerinin sayi: {PageCount}";
        }

    }
}