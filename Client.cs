public class Client : IAffichage
{
    public string Nom { get; set; }
    public string Mail { get; set; }

    public Client(string nom, string mail)
    {
        Nom = nom;
        Mail = mail;
    }
    public void Afficher()
    {
        Console.WriteLine($"Client: {Nom}, Mail: {Mail}");
    }
}