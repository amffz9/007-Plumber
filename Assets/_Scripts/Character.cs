using UnityEngine;
using System.Collections;

public class Character : MonoBehaviour {

    [Header("Character Movement Info")]
    public bool facingRight = true;
    public float forceMultiplier = 15f;
    public float maxVelocity = 5f;
    public float jumpStrength = 5f;

    private float scaleX;
    private Vector3 scale;

    void Update()
    {
        if (facingRight == false)
        {
            
            if (transform.localScale.x > 0)
            {
                switchX();
            }  
        }
        else
        {
            if (transform.localScale.x < 0)
            {
                switchX();
            }
        }
    }
    public void switchX()
    {
        scaleX = transform.localScale.x;
        scaleX *= -1;
        scale = transform.localScale;
        scale.x = scaleX;
        transform.localScale = scale;
    }
    public void Jump()//use on GetKeyDown or equivilent
    {
        Debug.Log("Jump");
        rigidbody.AddForce(Vector3.up * jumpStrength);
    }
    public bool OnGround()
    {
        Ray ray = new Ray(transform.position, transform.up);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit, 1 << LayerMask.NameToLayer("Ground")))
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
