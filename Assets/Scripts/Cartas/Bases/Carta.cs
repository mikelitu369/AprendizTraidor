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

    public string nombre, descripcion;
    public int coste;
    public Tipo tipo;
    public AccionCarta efecto;
}
