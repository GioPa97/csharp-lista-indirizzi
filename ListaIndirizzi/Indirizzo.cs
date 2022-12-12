namespace ListaIndirizzi;

public class Indirizzo
{
    string nome;
    string cognome;
    string via;
    string città;
    string provincia;
    string zip;

    public Indirizzo(string nome, string cognome, string via, string città, string provincia, string zip)
    {
        this.nome = nome;
        this.cognome = cognome;
        this.via = via;
        this.città = città;
        this.provincia = provincia;
        this.zip = zip;
    }
    public string getNome()
    {
        return nome;
    }
    public string getCognome()
    {
        return cognome;
    }

    public string getVia()
    {
        return città;
    }

    public string getCittà()
    {
        return città;
    }

    public string getProvincia()
    {
        return città;
    }

    public string getZip()
    {
        return zip;
    }

    public void setNome(string nome)
    {
        nome = this.nome;
    }

    public void setCognome(string cognome)
    {
        cognome = this.cognome;
    }

    public void setVia(string via)
    {
        via = this.via;
    }

    public void setCittà(string città)
    {
        città = this.città;
    }

    public void setProvincia(string provincia)
    {
        provincia = this.provincia;
    }

    public void setZip(string zip)
    {
        zip = this.zip;
    }

};
