using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public float maxSpeed = 1f;
    public Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.RightArrow)){
            rb.velocity += Vector2.right * Time.deltaTime;
        } else if (Input.GetKey(KeyCode.LeftArrow)){
            rb.velocity += -Vector2.right * Time.deltaTime;
        }

        Mathf.Clamp(rb.velocity, 0, maxSpeed);
    }
}
