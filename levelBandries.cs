using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static float leftSide;
public static float rightSide;
public static float internalLeft = -3f;
public static float internalright = 3f;


public class levelBandries : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {


        internalLeft = leftSide;
        internalright = rightSide;

    }
}
