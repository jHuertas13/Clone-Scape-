using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OptionMenu : MonoBehaviour
{
    [SerializeField] GameObject Menu;
    public void OnClick()
    {
        if (!Menu.activeSelf)
        {
            Menu.SetActive(true);
        }
        else
        {
            Menu.SetActive(false);
        }
     

    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (!Menu.activeSelf)
            {
                Menu.SetActive(true);
            }else
            {
                Menu.SetActive(false);
            }

        }
    }
}
