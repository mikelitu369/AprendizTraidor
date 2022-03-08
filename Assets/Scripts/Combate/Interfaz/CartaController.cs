using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CartaController : MonoBehaviour
{
    Carta carta;

    public void Set(Carta carta)
    {
        this.carta = carta;
        GetComponentInChildren<Text>().text = carta.nombre;
    }

    public void JugarCarta()
    {
        carta.efecto.Accion();
    }
}
