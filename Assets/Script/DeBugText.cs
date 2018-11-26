using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DeBugText : MonoBehaviour {

    public static DeBugText instance;
    public Projector projector;
    public Text DebugText;
	// Use this for initialization
	void Start () {
        if (instance == null) {
            instance = this;
        }
        

    }

    private void Update()
    {
        UpdateDebugText();
    }



    public void UpdateDebugText()
    {
        string str = "field of view: " + projector.fieldOfView.ToString() + "\n" + "Camera z Distance: " + projector.transform.position.z.ToString();

        DebugText.text = str;
    }
}
