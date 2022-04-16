using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class HealthSystem : MonoBehaviour
{
    public int health;
    public int healthMax;
    public int damage;

    public HealthSystem(int healthMax) {
        this.healthMax = healthMax;
        health = healthMax;
    }

    public int GetHealth() {
        return health;
    }
    public void Damage(int damageAmount) {
        health -= damageAmount;
        HealthBar.HealthCurrent = health;
        if (health <= 0) {
            health = 0;
        this.gameObject.SetActive(false);
        }

    }

    public void OnCollisionEnter(Collision collision)
    {
        //Player Get Damage and Destroy Ghost
        if (collision.gameObject.tag == "Ghost")
            Damage(damage);

    }
}
