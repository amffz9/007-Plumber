using UnityEngine;
using System.Collections;

public class FollowCam : MonoBehaviour
{

    static public FollowCam S;
    //set by inspector
    [Header("Camera Follow Settings")]
    public float easing = .01f;
    public GameObject poi;//the point of interest
    private Vector3 temp;

    void Awake()
    {
        S = this;
        
    }
    void FixedUpdate()
    {
        if (poi == null)
        {
            return;
        }
        temp = poi.transform.position;
        temp.z = this.camera.transform.position.z;
        this.camera.transform.position = 
            Vector3.Lerp(this.camera.transform.position, temp,easing);
    }
}