using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CartasJugador
{
    public List<Carta> Deck = new List<Carta>();
    public List<Carta> Mano = new List<Carta>();
    public List<Carta> Descarte = new List<Carta>();

    public void Reset()
    {
        Deck.Clear();
        Mano.Clear();
        Descarte.Clear();
    }

    public void SetDeck(List<Carta> lista)
    {
        foreach (Carta carta in lista) Deck.Add(carta);
    }

    public void Robar(int numeroRobo = 1)
    {
        for (int i = 0; i < numeroRobo; i++)
        {
            if (Deck.Count == 0) BarajarDescarte();
            Carta cartaARobar = Deck[Random.Range(0, Deck.Count)];
            Mano.Add(cartaARobar);
            Deck.Remove(cartaARobar);
            if (ManoController.instance) ManoController.instance.Robar(cartaARobar);
        }
    }

    void BarajarDescarte()
    {
        for (int i = 0; i < Descarte.Count; i++)
        {
            Deck.Add(Descarte[0]);
            Descarte.Remove(Descarte[0]);
        }
    }   
}
