using ListaIndirizzi;
using System.Net;

List<Indirizzo> listaIndirizzi = new List<Indirizzo>();


try
{
    StreamReader file = File.OpenText("C:\\Users\\Utente\\Contacts\\Desktop\\Esercizi Github\\csharp-lista-indirizzi\\ListaIndirizzi\\addresses.csv");

    file.ReadLine();
    while (!file.EndOfStream)
    {

        string riga = file.ReadLine();


        string[] informazioniIndirizzo = riga.Split(",");
        if (informazioniIndirizzo.Length >= 6)
        {

            string nome = informazioniIndirizzo[0];
            string cognome = informazioniIndirizzo[1];
            string via = informazioniIndirizzo[2];
            string città = informazioniIndirizzo[3];
            string provincia = informazioniIndirizzo[4];
            string zip = informazioniIndirizzo[5];


            Indirizzo indirizzoEstratto = new Indirizzo(nome, cognome, via, città, provincia, zip);
            listaIndirizzi.Add(indirizzoEstratto);
            Console.WriteLine(riga);
        }
    }
    file.Close();
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}

