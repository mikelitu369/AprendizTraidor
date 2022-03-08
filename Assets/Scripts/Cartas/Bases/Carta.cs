using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Carta", menuName = "ScriptableObjects/Carta", order = 0)]
public class Carta : ScriptableObject
{
    public enum Tipo
    {
        Hechizo,
        Maniobra,
        Reflexion,
        Debilidad
    }

    public enum Escuela
    {
        Ninguna,
        Fuerza,
        Sigilo,
        Inteligencia,
        Fuego,
        Hielo,
        Rayo,
        Naturaleza,
        Luz,
        Oscuridad,
        Ilusion
    }

    public string nombre, descripcion;
    public int coste;
    public Tipo tipo;
    public Escuela escuela;
    public AccionCarta efecto;
}
