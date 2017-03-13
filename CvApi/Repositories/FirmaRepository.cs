using System.Collections.Generic;
using CvApi.Models;

namespace CvApi.Repositories
{
    public class FirmaRepository : ErfaringBaseRepository<Firma>
    {
        public FirmaRepository() 
        {
            Entities = new List<Firma>()
            {
                new Firma() {Id = 1, Navn = "Von Ands pengetank", Beskrivelse = "Pudsning af flere fantasilliarder mønter"},
                new Firma() {Id = 2, Navn = "Smørfabrikken"},
                new Firma() {Id = 3, Navn = "Hængekøjen", Beskrivelse = "Selvstændig virksomhed som hængekøjetester i egen have"}
            };
        }
    }
}