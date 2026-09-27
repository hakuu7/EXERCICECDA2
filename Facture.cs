public class Facture : Document, IImprimable
{
    public decimal Montant { get; set; }

    public Facture(string titre, decimal montant)
    {
        Titre = titre;
        Montant = montant;
    }

    public void Imprimer()
    {
        Console.WriteLine($"Impression de la facture '{Titre}', Montant: {Montant:C}");
    }
}