using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HuecosMentalesController : MonoBehaviour
{
    public static HuecosMentalesController instance;
    private void Awake()
    {
        if (!instance) instance = this;
        else Destroy(this.gameObject);
    }

    [SerializeField] GameObject hechizoPrefab;

    public void CrearHechizo(Carta carta)
    {
        GameObject newHechizo = Instantiate(hechizoPrefab, transform);
        newHechizo.GetComponent<HechizoController>().SetHechizo(carta);
    }
}
