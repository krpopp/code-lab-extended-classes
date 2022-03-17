using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrintSphereInfo : PrintObjectInfo
{
    // Start is called before the first frame update
    void Start()
    {
        //Debug.Log(MakeInfoString());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    protected override string MakeInfoString()
    {
        SphereCollider sc = GetComponent<SphereCollider>();
        string sphereInfo = base.MakeInfoString() +
                            "\nRAdius: " + sc.radius;
        return sphereInfo;
    }
}
