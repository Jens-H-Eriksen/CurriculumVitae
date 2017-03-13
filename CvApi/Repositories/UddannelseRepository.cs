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
                new Uddannelse() { Id = 1, Navn = "G�ser�d lilleskole", Beskrivelse = "Bestod med udem�rkelse"},
                new Uddannelse() { Id = 2, Navn = "Andeby folkeskole"},
                new Uddannelse() { Id = 3, Navn = "Andeby Dovneuniversitet", Beskrivelse = "5 �rs dovenskab og sl�seri"}
            };
        }
    }
}