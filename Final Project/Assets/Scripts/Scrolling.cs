using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scrolling : MonoBehaviour
{

    private Rigidbody rb2;
    public float Speed = -.3f;
    [SerializeField] private bool StopScrolling;

    public GameControl GameControlScript;

    private void Start()
    {
        rb2 = GetComponent<Rigidbody>();
        rb2.velocity = new Vector3(0, 0,Speed);

    }

    private void Update()
    {
        if (GameControlScript.gameOver == true)
            rb2.velocity = Vector2.zero;
        else
            rb2.velocity = new Vector3(0,0, Speed);
    }


}