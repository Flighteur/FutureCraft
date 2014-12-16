using UnityEngine;
using System;
using System.Collections;

[RequireComponent(typeof(CharacterController))]
public class MovPlus : MonoBehaviour
{
    public GameObject player;
    public float speed = 1.0F;
    public float rotateSpeed = 3.0F;
    public float sprint = 5.0F;
    
    void Start()
    {
        while (true) {
            CharacterController controller = GetComponent<CharacterController>();
            transform.Rotate(0, Input.GetAxis("Horizontal") * rotateSpeed, 0);
            Vector3 forward = transform.TransformDirection(Vector3.forward);
            float curSpeed = speed * Input.GetAxis("Vertical");
            controller.SimpleMove(forward * curSpeed);
            if (Input.GetKey(KeyCode.Z) && Input.GetKey(KeyCode.LeftShift))
            {
                transform.Rotate(0, Input.GetAxis("Horizontal") * rotateSpeed, 0);
                forward = transform.TransformDirection(Vector3.forward);
                curSpeed = sprint * Input.GetAxis("Vertical");
                controller.SimpleMove(forward * curSpeed);
            }
        }
    }
}