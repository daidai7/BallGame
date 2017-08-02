using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorControl : MonoBehaviour {

	// Use this for initialization
	void Start () {
        
		
	}

    private Vector3 prevMousePos;

	// Update is called once per frame
	void Update () {
        float rx = 0;
        float rz = 0;
		if (Input.GetKey(KeyCode.UpArrow))    rz += 0.1f;
        if (Input.GetKey(KeyCode.DownArrow))  rz -= 0.1f;
        if (Input.GetKey(KeyCode.LeftArrow))  rx += 0.1f;
        if (Input.GetKey(KeyCode.RightArrow)) rx -= 0.1f;


		Vector3 nowMousePos = Input.mousePosition;
		Vector3 diff = (nowMousePos - prevMousePos);
		prevMousePos = nowMousePos;
		if (Input.GetMouseButton(0)) {
            this.transform.eulerAngles += new Vector3(diff.y, 0f, diff.x) * 0.1f;
		}
 
        this.transform.eulerAngles += new Vector3(rx, 0.0f, rz); 
	}
}
