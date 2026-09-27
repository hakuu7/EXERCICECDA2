using System;

public class Rapport : IExportable
{
    public string Titre { get; set; }

    public Rapport(string titre)
    {
        Titre = titre;
    }

    public void Exporter(string fichier)
    {
        Console.WriteLine($"Rapport '{Titre}' exporté vers {fichier}");
    }
}