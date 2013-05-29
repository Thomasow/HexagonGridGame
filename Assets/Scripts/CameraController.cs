using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKey(KeyCode.A))
		{
			transform.Translate(new Vector3(-0.1f,0,0));
		}
		if(Input.GetKey(KeyCode.S))
		{
			transform.Translate(new Vector3(0,-0.1f,0));
		}
		if(Input.GetKey(KeyCode.D))
		{
			transform.Translate(new Vector3(0.1f,0,0));
		}
		if(Input.GetKey(KeyCode.W))
		{
			transform.Translate(new Vector3(0,0.1f,0));
		}
	}
}
