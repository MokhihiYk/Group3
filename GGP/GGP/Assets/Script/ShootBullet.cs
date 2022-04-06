using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootBullet : MonoBehaviour
{
    public GameObject prefabBullet;
    public float radius;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        for (float d = 0; d < 360; d += 30)
        {
            float x = radius * Mathf.Cos(d * Mathf.Deg2Rad);
            float y = radius * Mathf.Cos(d * Mathf.Deg2Rad);

            GameObject newObj = Instantiate(prefabBullet);
            newObj.transform.position = new Vector3(x, y, 0);

            Vector3 dir = newObj.transform.position - transform.position;
            newObj.transform.forward = dir;
            newObj.transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
        }
    }
}
