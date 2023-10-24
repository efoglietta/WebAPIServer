using WebAPIServer.Entities;

namespace WebAPIServer.DataSorurce
{
    public static class DataSource
    {
        public static List<Dipendente> Dipendenti()
        {
            List<Dipendente> listaDipendenti = new List<Dipendente>
            {
                new Dipendente{ Id=1, Cognome="Rossi", Nome="Mario",Genere='F', CF="EFGGR23r2e2e", Email="mario@libero.it", Eta=19},
                new Dipendente{Id=2,  Cognome="Bianchi", Nome="Angelo", Genere='M',CF="dfbregre86ehe", Email="aa@libero.it", Eta=41},
                new Dipendente{Id=3,  Cognome="Signorini", Nome="Carla",Genere='F', CF="dfgereherherh", Email="carlo@libero.it", Eta=15},
                new Dipendente{ Id=4, Cognome="Rossi", Nome="Antonio",Genere='M', CF="mteerhrterh", Email="angela@libero.it", Eta=40},
                new Dipendente{ Id=5, Cognome="Benedetti", Nome="Maria",Genere='F', CF="HFFYUF23553", Email="maria@google.it", Eta=13},

            };
            return listaDipendenti;
        }

    }
}
