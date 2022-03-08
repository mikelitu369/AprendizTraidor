using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuOpcionesMultiples : MonoBehaviour
{
    public static MenuOpcionesMultiples instance;
    private void Awake()
    {
        if (!instance) instance = this;
        else Destroy(this.gameObject);
    }

    [SerializeField] GameObject prefabBoton;
    List<GameObject> botones = new List<GameObject>();

    public void Reset()
    {
        int botonesCount = botones.Count;
        for (int i = 0; i < botonesCount; i++)
        {
            Destroy(botones[0]);
            botones.RemoveAt(0);
        }
    }

    public void Activar(AccionCarta carta, int opciones)
    {
        Reset();
        for (int i = 0; i < opciones; i++)
        {
            GameObject boton = Instantiate(prefabBoton, transform);
            botones.Add(boton);
            boton.GetComponent<BotonOpcionesMultiples>().Set(carta, i);
        }
    }
}
