using CsvHelper.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsvApp
{
    public class ClientMap : ClassMap<Client>
    {
        public ClientMap() {
            Map(x => x.Email)
                .Index(2)
                .Name("E-mail");

            Map(x => x.Name)
                .Index(1)
                .Name("Imię");

            Map(x => x.AddedData)
                .Index(0)
                .TypeConverterOption.Format("dd-MM-yyyy")
                .Name("Data dodania");

            Map(x => x.IsConfirmed)
                .Index(3)
                .Name("Czy potwierdzony?");

        }
    }
}
