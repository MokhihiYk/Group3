using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIFollow : MonoBehaviour
{
    private GameObject wayPoint;
    private Vector3 wayPointPos;
    //This will be the vox speed. Adjust as necessary.
    public float speed = 1.0f;
    void Start()
    {
        //At the start of the game, the box will find the gameobject called wayPoint.
        wayPoint = GameObject.Find("wayPoint");
    }

    void Update()
    {
        wayPointPos = new Vector3(wayPoint.transform.position.x, transform.position.y, wayPoint.transform.position.z);
        //Here, the vox will follow the waypoint.
        transform.position = Vector3.MoveTowards(transform.position, wayPointPos, speed * Time.deltaTime);
    }
}
