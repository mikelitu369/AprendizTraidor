using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImprovisarAccion : AccionCarta
{
    public override void Accion()
    {
        Enemigo.estadisticas.Hit(10);
    }
}
