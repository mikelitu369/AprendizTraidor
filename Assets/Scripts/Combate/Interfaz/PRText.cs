using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PRText : MonoBehaviour
{
    private void Update()
    {
        GetComponent<Text>().text = Jugador.PR().ToString();
    }
}
