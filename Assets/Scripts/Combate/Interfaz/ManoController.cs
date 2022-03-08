using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManoController : MonoBehaviour
{
    public static ManoController instance;
    private void Awake()
    {
        if (!instance) instance = this;
        else Destroy(this.gameObject);
    }

    List<GameObject> cartas = new List<GameObject>();

    [SerializeField] GameObject cartaPrefab;

    public void Robar(Carta cartaRobada)
    {
        GameObject carta = Instantiate(cartaPrefab, transform);
        carta.GetComponent<CartaController>().Set(cartaRobada);
        cartas.Add(carta);
    }

    public void Descartar(Carta cartaDescartada)
    {
        int indice = 0;
        foreach (GameObject carta in cartas)
        {
            if (carta.GetComponent<CartaController>().Comparar(cartaDescartada))
            {
                indice = cartas.IndexOf(carta);
            }
        }
        Destroy(cartas[indice]);
        cartas.RemoveAt(indice);
    }
}
