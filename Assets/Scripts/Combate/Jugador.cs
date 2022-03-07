using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Jugador
{
    public static Estadisticas estadisticas = new Estadisticas(100);
    static int pr = 0;

    public static void SetEstadisticas(int vidaMaxima)
    {
        estadisticas = new Estadisticas(vidaMaxima);
    }

    public static void GivePR(int value)
    {
        pr += value;
    }

    public static void EndTurn()
    {
        estadisticas.EndTurn();
        pr = 0;
    }
}
