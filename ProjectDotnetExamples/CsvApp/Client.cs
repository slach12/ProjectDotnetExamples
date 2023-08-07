using CsvHelper.Configuration.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsvApp
{
    public class Client
    {

        //[Name("E-mail")]
        //[Index(2)]
        public string Email { get; set; }
        //[Name("Imię")]
        //[Index(1)]
        public string Name { get; set; }
        //[Format("dd-MM-yyyy")]
        //[Name("Data dodania")]
        //[Index(0)]
        public DateTime AddedData { get; set; }
        //[Name("Czy potwierdzony")]
        //[Index(3)]
        public Boolean IsConfirmed { get; set; }
    }
}
