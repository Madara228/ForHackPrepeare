using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstanceDelievery : MonoBehaviour
{
    public GameObject gObj;


    private void Start()
    {
        StartCoroutine(FindClient());
    }
    private IEnumerator FindClient()
    {
        while (true)
        {
            yield return new WaitForSeconds(4f);
            try
            {
                SomeFunc();
            }
            catch (IndexOutOfRangeException e){
                Debug.Log("error");
            }
        }
    }

    void SomeFunc()
    {
        var Tables = GameObject.FindGameObjectsWithTag("Table");
        int k = UnityEngine.Random.Range(0, Tables.Length);
        CreateAClient(Tables[k].transform, Tables[k]);
    }

    void CreateAClient(Transform table,GameObject g_table)
    {
        foreach (Transform eachChild in table)
        {
            if (eachChild.name == "InstanceForButton")
            {
                var instance_pos = table.Find("InstanceForButton");
                Instantiate(gObj, instance_pos.position, Quaternion.identity);
                table.gameObject.tag = "NotUse";
                Debug.Log(g_table.tag);
            }
        }
    }
}
