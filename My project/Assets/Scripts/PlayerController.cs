using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody2D rb;
    Vector2 input;
    float shipAngle;

    public float speed;
    public float rotationInterpolation = 0.4f;
    public bool isMoving;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        input.x = Input.GetAxis("Horizontal");
        input.y = Input.GetAxis("Vertical");

        if(input.x !=0 || input.y !=0)
        {
            isMoving = true;
        }
        else
        {
            isMoving = false;
        }
    }

    private void FixedUpdate()
    {
        rb.velocity = input * speed * Time.fixedDeltaTime;
        GetRotation();
    }

    void GetRotation()
    {
        Vector2 lookDir = new Vector2(-input.x, input.y);

        if(isMoving)
        {
            shipAngle = Mathf.Atan2(lookDir.x, lookDir.y) * Mathf.Rad2Deg;
        }
               
        if(rb.rotation <= -90 && shipAngle >=90)
        {
            rb.rotation += 360;
            rb.rotation = Mathf.Lerp(rb.rotation, shipAngle, rotationInterpolation);
        }

        else if (rb.rotation >= 90 && shipAngle <= -90)
        {
            rb.rotation -= 360;
            rb.rotation = Mathf.Lerp(rb.rotation, shipAngle, rotationInterpolation);
        }

        else
        {
            rb.rotation = Mathf.Lerp(rb.rotation, shipAngle, rotationInterpolation);
        }
           
            
    }
}
