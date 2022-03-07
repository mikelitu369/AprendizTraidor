using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DebugCarta : MonoBehaviour
{
    [SerializeField] Carta carta;

    [SerializeField] Text nombretxt, descripciontxt, costetxt;

    private void Start()
    {
        nombretxt.text = carta.nombre;
        descripciontxt.text = carta.descripcion;
        costetxt.text = carta.coste.ToString();
    }

    public void Accionar()
    {
        carta.efecto.Accion();
    }
}
