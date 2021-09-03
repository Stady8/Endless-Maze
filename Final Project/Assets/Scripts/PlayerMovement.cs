using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class PlayerMovement : MonoBehaviour
{
    public Swipe swipeControls;
//public float playerSpeed = 120;

    private Rigidbody rb;
    private float Speed = 1f;

    public bool isDead = false;

    public Scrolling ScrollingScript;

    private float scrollSpeed = 0;
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0, 0 ,0 );
        Application.targetFrameRate = 300;
        scrollSpeed = ScrollingScript.Speed;
  

    }

    private void Update()
    {

        if (isDead == true)
        { 
        rb.velocity = Vector3.zero;
        }
        else { 

        if (swipeControls.SwipeLeft)
            {

                rb.velocity = new Vector3(-Speed, scrollSpeed);
            }
            if (swipeControls.SwipeRight)
            {

                rb.velocity = new Vector3(Speed, scrollSpeed);
            }
            if (swipeControls.SwipeUp)
            {

                rb.velocity = new Vector3(0, Speed);
            }
            if (swipeControls.SwipeDown)
            {

                rb.velocity = new Vector3(0, -Speed);

            }




            if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                rb.velocity = new Vector3(-Speed, 0, scrollSpeed);
            }
            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                rb.velocity = new Vector3(Speed, 0, scrollSpeed);
            }
            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                rb.velocity = new Vector3(0, 0,Speed);
            }
            if (Input.GetKeyDown(KeyCode.DownArrow))
            {
                rb.velocity = new Vector3(0, 0,-Speed);
            }
        }
    }
    public void OnTriggerEnter(Collider other)
    { 
           GameControl.instance.Died();
        isDead = true;

    }

}
