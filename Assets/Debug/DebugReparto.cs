using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DebugReparto : MonoBehaviour
{
    [SerializeField] ListaCartas deckInicial;

    private void Start()
    {
        Jugador.cartas.SetDeck(deckInicial.lista);
        Jugador.cartas.Robar(5);
    }
}
