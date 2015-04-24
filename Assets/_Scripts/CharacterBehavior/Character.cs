using UnityEngine;
using System.Collections;

public class Character : MonoBehaviour {

    [Header("Character Movement Info")]
    public float forceMultiplier = 15f;
    public float maxVelocity = 5f;
    public float jumpStrength = 5f;
    public bool facingRight = true;
    public Rigidbody projectile;
    public float speed = 20;

    void Update()
    {
        Move();// will be using inherited implementation
    }
    public virtual void Move()
    {

    }
    public void Jump()//use on GetKeyDown or equivilent
    {
        Debug.Log("Jump");
        rigidbody.AddForce(Vector3.up * jumpStrength);
    }

    public bool OnGround()
    {
        Ray ray = new Ray(transform.position, transform.up * -1);//raycast down
        RaycastHit hit;
        Physics.Raycast(ray, out hit, 20);

        if ((hit.distance) < 1 && (hit.distance != 0) && 
            (hit.collider.gameObject.layer 
            == LayerMask.NameToLayer("Ground")))
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
