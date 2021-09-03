using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RepeatingBG : MonoBehaviour
{

    private void Update()
    {
        if (transform.position.z < -21.98026f)
        {
            RepeatBackground();
        }
    }

    void RepeatBackground() {
        transform.position = new Vector3(0f, 0f, 8.76f);


    }

}