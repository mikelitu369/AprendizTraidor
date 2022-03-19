using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Jugador
{
    public static Estadisticas estadisticas = new Estadisticas(100);
    public static CartasJugador cartas = new CartasJugador();
    static int pr = 0;
    static int huecosMentales = 1;

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

    public static int PR()
    {
        return pr;
    }

    public static void AddHuecoMental(int cantidad)
    {
        huecosMentales += cantidad;
    }

    public static void SetHuecosMenatlae(int cantidad)
    {
        huecosMentales = cantidad;
    }

    public static bool GastarHuecosMentales(int cantidad)
    {
        if (cantidad > huecosMentales) return false;
        huecosMentales -= cantidad;
        return true;
    }

    public static int HuecosMentales()
    {
        return huecosMentales;
    }
}
