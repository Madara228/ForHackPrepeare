using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TableScript : MonoBehaviour
{
    bool zakaz = true;
    private void Start()
    {
        Check();
    }
    public void OnTableClick()
    {
        Check();
        if (zakaz)
        {
            this.gameObject.tag = "Table";
        }
        Debug.Log("CLICK");
    }
    void Check()
    {
        if (this.gameObject.tag == "Table")
        {
            Debug.Log("Zakaz");
            zakaz = false;
        }
        else
        {
            zakaz = true;
        }
    }
}
