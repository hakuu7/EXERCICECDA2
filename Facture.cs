using System;

public class Facture : IImprimable, IExportable
{
    public int Numero { get; set; }
    public decimal Montant { get; set; }

    public Facture(int numero, decimal montant)
    {
        Numero = numero;
        Montant = montant;
    }

    public void Imprimer()
    {
        Console.WriteLine($"Impression de la facture n°{Numero}");
    }

    public void Exporter(string fichier)
    {
        Console.WriteLine($"Facture n°{Numero} exportée vers {fichier}");
    }
}