using System.Collections.Generic;
using CvApi.Models;

namespace CvApi.Repositories
{
    public class UddannelseRepository : ErfaringBaseRepository<Uddannelse>
    {
        public UddannelseRepository()
        {
            Entities = new List<Uddannelse>()
            {
                new Uddannelse() { Id = 1, Navn = "Gåserød lilleskole", Beskrivelse = "Bestod med udemærkelse"},
                new Uddannelse() { Id = 2, Navn = "Andeby folkeskole"},
                new Uddannelse() { Id = 3, Navn = "Andeby Dovneuniversitet", Beskrivelse = "5 års dovenskab og sløseri"}
            };
        }
    }
}