using UnityEngine;
using System.Collections;

public class followCam : MonoBehaviour {
	static public followCam S;
	public float easing = .05f;
	public Vector2 minXY;
	public bool _________________;
	public GameObject poi;
	public float camZ;
	
	void Awake(){
		S = this;
		camZ = this.transform.position.z;
	}
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 destination;
		destination = this.transform.position; 
		destination.x += 1f; 
		destination = Vector3.Lerp (transform.position, destination, easing);
		destination.z = camZ;
		transform.position = destination;
		//this.camera.orthographicSize = destination.y + 10;
	}
	
}
