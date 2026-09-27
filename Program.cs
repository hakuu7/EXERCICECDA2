using System;
using System.Collections.Generic;

public class Program
{
    public static void Main(string[] args)
    {
        IAffichage element = new Produit("Clavier", 49.90m);
        element.Afficher();

        element = new Client("Alice", "alice@example.com");
        element.Afficher();

        var produit = new Produit("Clavier", 49.90m);
        var client = new Client("Alice", "alice@example.com");
        var commande = new Commande(1, 129.99m);

        AfficherElement(produit);
        AfficherElement(client);
        AfficherElement(commande);

        List<IAffichage> elements = new();

        elements.Add(produit);
        elements.Add(client);
        elements.Add(commande);

        foreach (var el in elements)
        {
            el.Afficher();
        }

        var facture = new Facture("Facture Client A", 250.00m);
        facture.Imprimer();
    }

    public static void AfficherElement(IAffichage element)
    {
        element.Afficher();
    }
}