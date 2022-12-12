using ListaIndirizzi;

List<Indirizzo> listaIndirizzi = new List<Indirizzo>();


try
{
    StreamReader file = File.OpenText("C:\\Users\\Utente\\Contacts\\Desktop\\Esercizi Github\\csharp-lista-indirizzi\\ListaIndirizzi\\ListaIndirizzi.csproj");

    while (!file.EndOfStream)
    {

#pragma warning disable CS8600 // Conversione del valore letterale Null o di un possibile valore Null in un tipo che non ammette i valori Null.
        string riga = file.ReadLine();
#pragma warning restore CS8600 // Conversione del valore letterale Null o di un possibile valore Null in un tipo che non ammette i valori Null.


        string[] informazioniIndirizzo = riga.Split(" ,");
        string nome = informazioniIndirizzo[0];
        string cognome = informazioniIndirizzo[1];
        string via = informazioniIndirizzo[2];
        string città = informazioniIndirizzo[3];
        string provincia = informazioniIndirizzo[4];
        string zip = informazioniIndirizzo[5];


        Indirizzo indirizzoEstratto = new Indirizzo(nome, cognome, via, città, provincia, zip);
        listaIndirizzi.Add(indirizzoEstratto);
        // Console.WriteLine(riga);
    }

    file.Close();
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}


foreach (Indirizzo indirizzo in listaIndirizzi)
{
    Console.WriteLine(indirizzo);
}