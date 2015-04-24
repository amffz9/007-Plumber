using UnityEngine;
using System.Collections;

public class Enemy : Character {

    //Private variables
    private float x = 0f;

    public override void Move()
    {
        x = Input.GetAxis("Horizontal") * forceMultiplier;
        //y = Input.GetAxis("Vertical") * forceMultiplier;
        if (x < 0)
        {
            facingRight = false;

        }
        else if (x > 0)
        {
            facingRight = true;
        }

        rigidbody.AddForce(x, 0, 0);

        if ((Input.GetAxis("Jump") != 0) && OnGround())
        {
            Jump();
        }
        if (Input.GetAxis("Fire1") != 0)
        {
            Shoot();
        }

    }
	
}
