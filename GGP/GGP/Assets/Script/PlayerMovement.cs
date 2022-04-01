using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private CharacterController controller;
    public float Speed = 10f;
    // Start is called before the first frame update
    void Start()
    {
        controller = transform.GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        MoveLikeWow();
    }

    private void MoveLikeWow() {
        var horizontal =    Input.GetAxis("Horizontal");
        var vertical   =    Input.GetAxis("Vertical");

        var move = transform.forward * Speed * vertical * Time.deltaTime;
        controller.Move(move);

    }
}
