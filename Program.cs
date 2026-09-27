using System.Collections.Generic;

var produit = new Produit("Clavier", 49.90m);
var client = new Client("Alice", "alice@example.com");
var commande = new Commande(1, 129.99m);

List<IAffichage> elements = new();

elements.Add(produit);
elements.Add(client);
elements.Add(commande);

foreach (var element in elements)
{
    element.Afficher();
}