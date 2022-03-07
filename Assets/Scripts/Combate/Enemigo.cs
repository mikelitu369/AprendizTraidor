using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Enemigo
{
    public static Estadisticas estadisticas = new Estadisticas(100);

    public static void SetEstadisticas(int vidaMaxima)
    {
        estadisticas = new Estadisticas(vidaMaxima);
    }
}
