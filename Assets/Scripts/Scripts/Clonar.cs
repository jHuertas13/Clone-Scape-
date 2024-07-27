using UnityEngine;
using System.Collections.Generic;

public class Clonar : MonoBehaviour
{
    public Control control;
    public List<GameObject> prefabs = new List<GameObject>();
    public ControlManager controlManager;
    public Vector3 desfasePosicion = Vector3.zero;

    void Update()
    {
        for (int i = 0; i < control.teclasInvocacion.Count; i++)
        {
            if (Input.GetKeyDown(control.teclasInvocacion[i]) && i < prefabs.Count)
            {
                controlManager.InvocarPrefab(prefabs[i], transform.position + desfasePosicion, i);
            }
        }
    }
}