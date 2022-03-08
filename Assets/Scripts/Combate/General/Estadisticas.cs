using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Estadisticas
{
    public enum GradoDefensa
    {
        Nulo,
        Inferior,
        Superior,
        Definitivo
    }
    public static int PorcentageGrado(GradoDefensa grado)
    {
        switch (grado)
        {
            case GradoDefensa.Nulo: return 0;
            case GradoDefensa.Inferior: return 50;
            case GradoDefensa.Superior: return 75;
            case GradoDefensa.Definitivo: return 100;
            default: return 0;
        }
    }

    protected int vida;
    protected GradoDefensa esquiva, bloqueo;
    protected int veneno, quemado, escarcha;

    public Estadisticas(int vida)
    {
        this.vida = vida;
        esquiva = bloqueo = GradoDefensa.Nulo;
        veneno = quemado = escarcha = 0;
    }

    public void Hit(int dmg)
    {
        if (Esquiva()) Debug.Log("Dodge");
        else
        {
            vida -= Bloqueo(dmg);
        }
    }

    bool Esquiva()
    {
        int porcentage = PorcentageGrado(esquiva);
        return (Random.Range(0, 100) < porcentage);
    }

    int Bloqueo(int dmgBase)
    {
        int porcentage = PorcentageGrado(bloqueo);
        return dmgBase - ((dmgBase * porcentage) / 100);
    }

    bool TryMove()
    {
        if (escarcha <= 0) return true;
        else
        {
            --escarcha;
            return false;
        }
    }

    public void Acercarse(int pasos)
    {
        if (TryMove()) Distancia.Acercar(pasos);
    }

    public void Alejarse(int pasos)
    {
        if (TryMove()) Distancia.Alejar(pasos);
    }

    public void SetEsquiva(GradoDefensa grado)
    {
        esquiva = (GradoDefensa)Mathf.Max((int)esquiva, (int)grado);
    }
    public void SetBloqueo(GradoDefensa grado)
    {
        bloqueo = (GradoDefensa)Mathf.Max((int)bloqueo, (int)grado);
    }
    
    public void EndTurn()
    {
        esquiva = bloqueo = GradoDefensa.Nulo;
        if(veneno > 0)
        {
            vida -= veneno;
            --veneno;
        }
        if(quemado > 0)
        {
            vida -= quemado;
            --quemado;
        }
    }
}
