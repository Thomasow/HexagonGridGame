using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class MouseController : MonoBehaviour {

	//private Dictionary<Renderer,GameObject> renderers = new Dictionary<Renderer, GameObject>();
	private List<Renderer> renderers = new List<Renderer>();
	private Color originalColor;
	
	void Start () {
		originalColor = new Color(1f,1f,1f,1f);
	}
	
	// Update is called once per frame
	void Update () {
		ResetColors();
		Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
		RaycastHit hit;
		if(Physics.Raycast(ray,out hit,Mathf.Infinity))
		{
			
			Renderer rend = hit.collider.gameObject.renderer;
			renderers.Add(rend);
			Debug.Log (rend.material.color);
			rend.material.color = Color.Lerp(Color.red,Color.blue,0.0f);
		}
		
		Debug.DrawRay(ray.origin,ray.direction,Color.green);
		
		
	}
	
	void ResetColors()
	{
		for(int i = 0;i<renderers.Count;i++)
		{			
			if(!Input.GetMouseButton(0))
			{
				renderers[i].material.color = originalColor;
				renderers.RemoveAt(i);
			}
		}
	}
}
