using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReflexionarAccion : AccionCarta
{
    public override void Accion()
    {
        Jugador.GivePR(2);
    }
}
