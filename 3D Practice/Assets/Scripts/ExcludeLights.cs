﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExcludeLights : MonoBehaviour
{
    public List<Light> Lights;

    // Start is called before the first frame update
    void Start()
    {

    }

    void OnPreCull()
    {
        foreach (Light light in Lights)
        {
            light.enabled = false;
        }
    }

    void OnPostRender()
    {
        foreach (Light light in Lights)
        {
            light.enabled = true;
        }
    }

}
