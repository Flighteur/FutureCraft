using UnityEngine;
using System.Collections;

public class CameraMov : MonoBehaviour {

    public float speed = 0.5f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.Z))
        {
            Camera.main.transform.position = Camera.main.transform.position + Vector3.up*speed;
        }
        else if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {
            Camera.main.transform.position = Camera.main.transform.position + Vector3.right*speed;
        }
        else if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S))
        {
            Camera.main.transform.position = Camera.main.transform.position + Vector3.down*speed;
        }
        else if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.Q)) {
            Camera.main.transform.position = Camera.main.transform.position + Vector3.left*speed;
        }
	}
}
