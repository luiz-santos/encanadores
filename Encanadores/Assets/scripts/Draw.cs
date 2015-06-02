using UnityEngine;
using System.Collections;

public class Draw : MonoBehaviour {
	public bool mouseUp = true;
	public int i = 0;
	public int lineSize = 20;
	// Use this for initialization
	void Start () {
		LineRenderer lineRenderer = gameObject.AddComponent<LineRenderer>();
		lineRenderer.SetColors(Color.black, Color.black);
		lineRenderer.SetWidth(50.0F, 50.0F);
		lineRenderer.SetVertexCount(lineSize);
		Debug.Log("Start!!!");
	}

	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown (0))
			mouseUp = false;
		if (Input.GetMouseButtonUp (0))
			mouseUp = true;
		//print position of mouse
		float mousex = (Input.mousePosition.x);
		float mousey = (Input.mousePosition.y);
		Vector3 mouseposition = Camera.main.ScreenToWorldPoint(new Vector3 (mousex,mousey,0));
		if (!mouseUp) {
			LineRenderer lineRenderer = GetComponent<LineRenderer>();
			if (i == 0 || i >= lineSize) {
				lineRenderer = GetComponent<LineRenderer>();
				i = 0;
			}
			mousex = (Input.mousePosition.x);
			mousey = (Input.mousePosition.y);
			mouseposition = Camera.main.ScreenToWorldPoint(new Vector3 (mousex,mousey,0));
			if (i < lineSize) {
				lineRenderer.SetPosition(i, mouseposition);
			}
			++i;
		}

		// Debug.Log (mouseposition);
	}
}
