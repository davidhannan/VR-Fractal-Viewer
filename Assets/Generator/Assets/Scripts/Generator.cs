using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Random = UnityEngine.Random;

public class Generator : MonoBehaviour
{
    public Vector3[] generators = new Vector3[0];
    public int maxIteration;
    public float width, noise;

    public int genSize
    {
        get
        {
            return generators.Length;
        }
        set
        {
            generators = new Vector3[value];
            for(int i = 0; i < value; i++)
            {
                generators[i] = new Vector3(Random.Range(-1.0f, 1.0f), Random.Range(-1.0f, 1.0f), Random.Range(-1.0f, 1.0f));
            }
        }
    }
}
