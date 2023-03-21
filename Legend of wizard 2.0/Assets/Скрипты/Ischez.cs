using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ischez : MonoBehaviour
{
    public float timeDie;
    public int Ischeznovenie;
    void Start()
    {
    InvokeRepeating("Annihilator", timeDie, Ischeznovenie);
	}

	void Annihilator()
    { 
    	Destroy(gameObject);
    }
}