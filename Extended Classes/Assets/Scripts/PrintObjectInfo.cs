using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrintObjectInfo : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(MakeInfoString());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public string MakeDebugString() {
        return MakeInfoString();
    }

    //protected = can be used by that class and extended class
    //virtual = means an extended classes will use this function by default (if you don't recreate its own)
    //abstract = means an extended class HAS to have a new version of this function
    protected virtual string MakeInfoString() {
        string infoString;
        infoString = "Name: " + gameObject.name +
                    "\nPosition: " + transform.position +
                    "\nRotation: " + transform.rotation +
                    "\nScale: " + transform.localScale;

        return infoString;
    }
}
