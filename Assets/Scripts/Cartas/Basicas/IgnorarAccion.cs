using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IgnorarAccion : AccionCarta
{
    public override void Accion()
    {
        Jugador.GivePR(1);
        Jugador.estadisticas.SetBloqueo(Estadisticas.GradoDefensa.Inferior);
    }
}
