using UnityEngine;
using System.Collections;

public class Weapon : MonoBehaviour {

    public Rigidbody projectile;
    public float speed = 20;
    public float damageDelt;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
    {
        if(Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }

    public void Shoot()
    {
        Rigidbody instantiatedProjectile = Instantiate(projectile, transform.position, transform.rotation) as Rigidbody;
        instantiatedProjectile.velocity = transform.TransformDirection(new Vector3(0, 0, speed));
    }

    void Kick ()
    {

    }

    void Punch()
    {

    }

}
