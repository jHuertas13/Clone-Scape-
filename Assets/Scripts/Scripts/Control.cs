using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Control", menuName = "ScriptableObjects/Control", order = 1)]
public class Control : ScriptableObject
{
    public List<KeyCode> teclasInvocacion = new List<KeyCode>();
    public KeyCode teclaRetorno = KeyCode.Space;
    public KeyCode teclaMoverDerecha = KeyCode.D;
    public KeyCode teclaMoverIzquierda = KeyCode.A;
    public KeyCode teclaSalto = KeyCode.W;
    public KeyCode teclaAnguloAumentar = KeyCode.LeftArrow;
    public KeyCode teclaAnguloDisminuir = KeyCode.RightArrow;
    public KeyCode teclaAumentarFuerza = KeyCode.UpArrow;
    public KeyCode teclaDisminuirFuerza = KeyCode.DownArrow;
    public KeyCode teclaDisparo = KeyCode.KeypadEnter;
    public KeyCode teclaFreeze = KeyCode.Alpha9;
}