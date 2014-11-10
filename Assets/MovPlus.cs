using UnityEngine;
using System.Collections;
using System.Threading;

[RequireComponent(typeof(CharacterController))]
public class MovPlus : MonoBehaviour
{
    public GameObject player;
    public float speed = 1.0F;
    public float rotateSpeed = 3.0F;
    public float sprint = 5.0F;
    Thread sprint = new Thread(new ThreadStart(Sprint));
    Thread mouseCapture = new Thread(new ThreadStart(MouseCapture));

    void Start()
    {
        if (Stop)
        {

        }
    }

   static void Sprint()
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