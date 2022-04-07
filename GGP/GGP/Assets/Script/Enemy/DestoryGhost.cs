using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestoryGhost : MonoBehaviour
{
    public void OnCollisionEnter(Collision collision) {
        if (collision.gameObject.tag == "Player") {
            this.gameObject.SetActive(false);
            Destroy(this.gameObject);
        }

    }
}
