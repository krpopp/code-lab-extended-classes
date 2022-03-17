using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DebugInput : MonoBehaviour
{

    //public GameObject sphere;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject[] gameObjs = GameObject.FindObjectsOfType<GameObject>();
            foreach(GameObject obj in gameObjs)
            {
                PrintObjectInfo infoPrinter = obj.GetComponent<PrintObjectInfo>();
                if(infoPrinter != null)
                {
                    Debug.Log(infoPrinter.MakeDebugString());
                }
            }
        }
    }
}
