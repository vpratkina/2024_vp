using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class birdController : MonoBehaviour
{
    public float JumpForce;
    public Rigidbody2D Rigidbody2D;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hello world!!!");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {

            Rigidbody2D.AddForce(new Vector2(0, JumpForce), ForceMode2D.Impulse);
        }
    }
}
