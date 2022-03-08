using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BotonOpcionesMultiples : MonoBehaviour
{
    AccionCarta carta;
    int indice;

    public void Set(AccionCarta carta, int indice)
    {
        this.carta = carta;
        this.indice = indice;
    }

    public void Activar()
    {
        carta.Accion(indice);
        GetComponentInParent<MenuOpcionesMultiples>().Reset();
    }
}
