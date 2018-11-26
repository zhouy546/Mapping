using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeTheValue : MonoBehaviour {
    public Projector projector;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKey(KeyCode.UpArrow)) {
            projector.fieldOfView += 0.1f;

        } else if (Input.GetKey(KeyCode.DownArrow)) {
            projector.fieldOfView -= 0.1f;

        } else if (Input.GetKey(KeyCode.E)){

            projector.transform.position = new Vector3(projector.transform.position.x, projector.transform.position.y, projector.transform.position.z + 0.5f);

        }
        else if (Input.GetKey(KeyCode.Q))
        {
            projector.transform.position = new Vector3(projector.transform.position.x, projector.transform.position.y, projector.transform.position.z - 0.5f);
        }


    }
}
