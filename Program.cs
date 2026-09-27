using System;

public class Program
{
    public static void Main(string[] args)
    {
        var produit = new Produit("Clavier", 49.90m);
        var client = new Client("Alice", "alice@example.com");

        AfficherElement(produit);
        AfficherElement(client);

        AfficherElement(new Commande(1, 129.99m));
    }

    public static void AfficherElement(IAffichage element)
    {
        element.Afficher();
    }
}