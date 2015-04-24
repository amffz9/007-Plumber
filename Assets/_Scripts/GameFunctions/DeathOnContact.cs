using UnityEngine;
using System.Collections;

public class DeathOnContact : MonoBehaviour {


    public void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Death to You!");
        Destroy(collision.gameObject);
    }
}
