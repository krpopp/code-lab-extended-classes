using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrintCubeInfo : PrintObjectInfo
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

    //override = rewrites OR adds to MakeInfoString
    //including base.FUNCTIONNAMEHERE makes that everything in the base class's function will run
    //without it, we'd just overwrite!
    protected override string MakeInfoString()
    {
        BoxCollider bc = GetComponent<BoxCollider>();
        string cubeInfo = base.MakeInfoString() +
                        "\nSize: " + bc.size +
                        "\nMaterial: " + bc.material +
                        "\nCenter: " + bc.center;
        return cubeInfo;
        //return base.MakeInfoString();
    }

}
