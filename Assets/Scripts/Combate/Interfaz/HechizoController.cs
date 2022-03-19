using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;


public class HechizoController : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    Hechizo hechizo;

    int preparacion;
    bool preparada = false;

    public void SetHechizo(Carta carta)
    {
        hechizo = (Hechizo)carta;
        preparacion = hechizo.preparacion;
        if (preparacion == 0) preparada = true;
        Text[] textos = GetComponentsInChildren<Text>();
        textos[0].text = preparacion.ToString();
        textos[1].text = hechizo.nombre;
    }

    public void Mantenimiento()
    {
        if (!preparada)
        {
            --preparacion;
            GetComponentsInChildren<Text>()[0].text = preparacion.ToString();
            if (preparacion == 0) preparada = true;
        }

        hechizo.efecto.AccionPersistente();
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        GetComponentsInChildren<Text>()[1].text = hechizo.descripcion;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        GetComponentsInChildren<Text>()[1].text = hechizo.nombre;
    }

    public void Activar()
    {
        if (preparada)
        {
            hechizo.efecto.Accion();
            Jugador.AddHuecoMental(hechizo.espacio);
            Jugador.cartas.Descarte.Add(hechizo);
            Destroy(this.gameObject);
        }
    }
}
