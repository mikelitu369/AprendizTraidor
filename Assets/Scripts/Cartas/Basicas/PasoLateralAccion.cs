using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PasoLateralAccion : AccionCarta
{
    public override void Accion()
    {
        MenuOpcionesMultiples.instance.Activar(this, 4);
    }

    public override void Accion(int indice)
    {
        switch (indice)
        {
            case 0:
                Jugador.GivePR(1);
                break;
            case 1:
                Jugador.estadisticas.Acercarse(1);
                break;
            case 2:
                Jugador.estadisticas.Alejarse(1);
                break;
            case 3:
                Jugador.estadisticas.SetEsquiva(Estadisticas.GradoDefensa.Inferior);
                break;
        }
    }
}
