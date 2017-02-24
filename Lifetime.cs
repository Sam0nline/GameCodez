using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lifetime : MonoBehaviour
{
    public float lifeTime = 50;

    void Update()
    {
        Destroy(gameObject, lifeTime);
    }
}
