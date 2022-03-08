using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "ListaCartas", menuName = "ScriptableObjects/ListaCartas", order = 0)]
public class ListaCartas : ScriptableObject
{
    public List<Carta> lista;
}
