using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private CharacterController controller;

    public static float Speed = 5f;
    public float CheckRadus = 0.2f;
    public float Gravity = -9.8f;
    public float jumpHeight = 2;
    public LayerMask layerMask;
    public Transform GroundCheck;

    private Vector3 velocity = Vector3.zero;
    private bool isGround;

    // Start is called before the first frame update
    void Start()
    {
        controller = transform.GetComponent<CharacterController>();
    }

     void Update() {
        //CheckGravity
        isGround = Physics.CheckSphere(GroundCheck.position, CheckRadus, layerMask);
        if (isGround && velocity.y < 0)
            velocity.y = 0;
        velocity.y += Gravity * Time.deltaTime;
        controller.Move(velocity * Time.deltaTime);

        //PlayerJump
        //if (isGround && Input.GetButtonDown("Jump"))
           // velocity.y += Mathf.Sqrt(jumpHeight * -2 * Gravity);
       // velocity.y += Gravity * Time.deltaTime;
        //controller.Move(velocity * Time.deltaTime);

        //PlayerMove
        var input = new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical")).normalized;
        var move = input * Speed * Time.deltaTime;

        controller.Move(move);
        
        var playerScreenPoint = Camera.main.WorldToScreenPoint(transform.position);
        
        var point = Input.mousePosition - playerScreenPoint;
        var angle = Mathf.Atan2(point.x, point.y) * Mathf.Rad2Deg;
        transform.eulerAngles = new Vector3(transform.eulerAngles.x, angle, transform.eulerAngles.z);


    }


   

}
