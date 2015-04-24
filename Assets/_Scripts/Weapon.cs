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
        var direction = gameObject.GetComponent<Character>();
        Quaternion rotation = new Quaternion();
        rotation.z = -90;
        var instantiatedBullet = Instantiate(bullet, transform.position, rotation) as GameObject;  
        if(direction.facingRight == true)
        {
            instantiatedBullet.rigidbody.AddForce(Vector3.right * speed);
            Destroy(instantiatedBullet, 1);
        }
        else if(direction.facingRight == false)
        {
            instantiatedBullet.rigidbody.AddForce(Vector3.left * speed);
            Destroy(instantiatedBullet, 1);
        }
    }

    void Kick()
    {

    }

    void Punch()
    {

    }

}
