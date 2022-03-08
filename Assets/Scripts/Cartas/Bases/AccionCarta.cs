using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class AccionCarta : MonoBehaviour
{
    public abstract void Accion();
    public virtual void AccionPersistente() { }
    public virtual void AccionAlRoabr() { }
    public virtual void Accion(int indice) { }
}
