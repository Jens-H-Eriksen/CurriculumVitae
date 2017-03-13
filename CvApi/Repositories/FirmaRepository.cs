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
                new Firma() {Id = 1, Navn = "Von Ands pengetank", Beskrivelse = "Pudsning af flere fantasilliarder m�nter"},
                new Firma() {Id = 2, Navn = "Sm�rfabrikken"},
                new Firma() {Id = 3, Navn = "H�ngek�jen", Beskrivelse = "Selvst�ndig virksomhed som h�ngek�jetester i egen have"}
            };
        }
    }
}