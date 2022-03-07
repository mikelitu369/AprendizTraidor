using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuizasAccion : AccionCarta
{
    public override void Accion()
    {
        Jugador.GivePR(1);
    }
}
