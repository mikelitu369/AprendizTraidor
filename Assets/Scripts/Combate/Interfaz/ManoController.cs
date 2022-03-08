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

    [SerializeField] GameObject cartaPrefab;

    public void Robar(Carta cartaRobada)
    {
        GameObject carta = Instantiate(cartaPrefab, transform);
        carta.GetComponent<CartaController>().Set(cartaRobada);
    }
}
