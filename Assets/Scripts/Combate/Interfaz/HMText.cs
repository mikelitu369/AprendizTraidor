using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HMText : MonoBehaviour
{
    private void Update()
    {
        GetComponent<Text>().text = Jugador.HuecosMentales().ToString();
    }
}
