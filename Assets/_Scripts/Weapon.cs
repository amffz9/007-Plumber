using UnityEngine;
using System.Collections;

public class Weapon : MonoBehaviour
{

    public GameObject bullet; //= GameObject.Find("Bullet");
    public float speed = 1000;
    public float damageDelt;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }

    public void Shoot()
    {
        var instantiatedBullet = Instantiate(bullet, transform.position, transform.rotation) as GameObject;  
        instantiatedBullet.rigidbody.AddForce(Vector3.right * speed);
    }

    void Kick()
    {

    }

    void Punch()
    {

    }

}
