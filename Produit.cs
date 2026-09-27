using System;

public class Produit : IAffichage
{
    public string Nom { get; set; }
    public decimal Prix { get; set; }

    public Produit(string nom, decimal prix)
    {
        Nom = nom;
        Prix = prix;
    }

    public void Afficher()
    {
        Console.WriteLine($"Produit: {Nom}, Prix: {Prix:C}");
    }
}