using System;

public class Commande : IAffichage
{
    public int Numero { get; set; }
    public decimal Montant { get; set; }

    public Commande(int numero, decimal montant)
    {
        Numero = numero;
        Montant = montant;
    }

    public void Afficher()
    {
        Console.WriteLine($"Commande n°{Numero}, Montant: {Montant:C}");
    }
}