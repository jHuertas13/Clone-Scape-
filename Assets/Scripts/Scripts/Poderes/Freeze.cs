using UnityEngine;

public class Freeze : MonoBehaviour
{
    public Control control;

    void Update()
    {
        if (Input.GetKeyDown(control.teclaFreeze))
        {
            Rigidbody2D rb = GetComponent<Rigidbody2D>();

            if (rb != null)
            {
                Destroy(rb);
            }

            MoverWASD moverWASD = GetComponent<MoverWASD>();

            if (moverWASD != null)
            {
                moverWASD.enabled = false;
            }
        }
    }
}
