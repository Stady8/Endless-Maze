﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{

    void OnCollisionEnter2D(Collision2D col)
    {

        Debug.Log("working!");

        if (col.gameObject.tag == "Player")
        { 
        Debug.Log("bhjkkkjkhbjbjhbkbjhbkb!");

        }
    }
}