using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class CartaController : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    Carta carta;

    public void Set(Carta carta)
    {
        this.carta = carta;
        GetComponentInChildren<Text>().text = carta.nombre;
    }

    public void JugarCarta()
    {
        if(carta.tipo != Carta.Tipo.Hechizo)
        {
            carta.efecto.Accion();
            ManoController.instance.Descartar(carta);
        }
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        GetComponentInChildren<Text>().text = carta.descripcion;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        GetComponentInChildren<Text>().text = carta.nombre;
    }

    public bool Comparar(Carta cartaComparar)
    {
        return carta.name == cartaComparar.name;
    }
}

    
