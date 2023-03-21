using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vrashenie : MonoBehaviour
{

    void Update()
    {
        transform.Rotate(0,0,20,Space.Self);
    }
}
