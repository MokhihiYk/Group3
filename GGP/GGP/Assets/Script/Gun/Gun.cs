using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    public Transform muzzle;
    public Projectile projectile;
    public float msBetweenShots = 100;      //ms
    public float muzzleVeloctiy = 35;
    public AudioClip shootAudio;

    float nextShotTime;

    public void Shoot() {

        if (Time.time > nextShotTime) {
           nextShotTime = Time.time + msBetweenShots / 1000;
            Projectile newProjectile = Instantiate(projectile, muzzle.position, muzzle.rotation) as Projectile;
            newProjectile.SetSpeed(muzzleVeloctiy);
        }

        AudioManager.current.PlaySound(shootAudio, transform.position);
    
    }
}
