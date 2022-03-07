using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Distancia
{
    public enum Distancias
    {
        Cerca,
        Media,
        Lejos
    }

    static int intDistancia;

    static Distancias distancia
    {
        get
        {
            switch (intDistancia)
            {
                case 0: return Distancias.Cerca;
                case 1: return Distancias.Media;
                case 2: return Distancias.Lejos;
                default: return Distancias.Media;
            }
        }
    }

    public static void Acercar(int pasos)
    {
        intDistancia -= pasos;
        if (intDistancia < 0) intDistancia = 0;
    }
    public static void Alejar(int pasos)
    {
        intDistancia += pasos;
        if (intDistancia > 2) intDistancia = 2;
    }
}
