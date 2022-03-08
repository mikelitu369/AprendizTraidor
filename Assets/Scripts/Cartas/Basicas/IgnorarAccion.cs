using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IgnorarAccion : AccionCarta
{
    public override void Accion()
    {
        MenuOpcionesMultiples.instance.Activar(this, 2);
    }

    public override void Accion(int indice)
    {
        switch (indice)
        {
            case 0:
                Jugador.GivePR(1);
                break;
            case 1:
                Jugador.estadisticas.SetBloqueo(Estadisticas.GradoDefensa.Inferior);
                break;
        }
    }
}
