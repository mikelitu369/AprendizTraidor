using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PasoLateralAccion : AccionCarta
{
    public override void Accion()
    {
        Jugador.GivePR(1);
        if (Random.Range(0, 2) == 0) Jugador.estadisticas.Acercarse(1);
        else Jugador.estadisticas.Alejarse(1);
        Jugador.estadisticas.SetEsquiva(Estadisticas.GradoDefensa.Inferior);
    }
}
