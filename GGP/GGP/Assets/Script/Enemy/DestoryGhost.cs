using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestoryGhost : MonoBehaviour
{

    public AudioClip deadClip;

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            AudioManager.current.PlaySound(deadClip, transform.position);
            this.gameObject.SetActive(false);
            Destroy(this.gameObject);
        }

    }
}
