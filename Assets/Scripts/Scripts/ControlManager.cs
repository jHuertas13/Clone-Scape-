using UnityEngine;
using System.Collections.Generic;

public class ControlManager : MonoBehaviour
{
    public Control control;
    public GameObject jugadorInicial;
    private List<GameObject> clones = new List<GameObject>();
    private GameObject objetoConControl;

    void Start()
    {
        objetoConControl = jugadorInicial;
        jugadorInicial.GetComponent<MoverWASD>().tieneControl = true;
    }

    void Update()
    {
        if (Input.GetKeyDown(control.teclaRetorno))
        {
            TransferirControl(jugadorInicial);
        }
    }

    public void InvocarPrefab(GameObject prefab, Vector3 posicion, int prefabIndex)
    {
        // Verificar si ya existe un clon del mismo tipo
        GameObject clonExistente = ObtenerClonDelMismoTipo(prefabIndex);

        if (clonExistente != null)
        {
            clones.Remove(clonExistente);
            Destroy(clonExistente);
        }

        GameObject clon = Instantiate(prefab, posicion, Quaternion.identity);
        clones.Add(clon);

        Desaparecer desaparecer = clon.GetComponent<Desaparecer>();
        if (desaparecer != null)
        {
            desaparecer.control = control;
            desaparecer.prefabIndex = prefabIndex;
        }

        //objetoConControl.GetComponent<MoverWASD>().tieneControl = false;
        //objetoConControl = clon;
        //clon.GetComponent<MoverWASD>().tieneControl = true;
    }

    private GameObject ObtenerClonDelMismoTipo(int prefabIndex)
    {
        foreach (GameObject clon in clones)
        {
            Desaparecer desaparecer = clon.GetComponent<Desaparecer>();
            if (desaparecer != null && desaparecer.prefabIndex == prefabIndex)
            {
                return clon;
            }
        }
        return null;
    }

    public void TransferirControl(GameObject nuevoObjetoConControl)
    {
        objetoConControl.GetComponent<MoverWASD>().tieneControl = false;
        objetoConControl = nuevoObjetoConControl;
        nuevoObjetoConControl.GetComponent<MoverWASD>().tieneControl = true;
    }
}