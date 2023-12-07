using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletSpawnerEnemy : MonoBehaviour
{
	public GameObject bullet;
    public float fireDelay = 0;
    private float timePassed = 0;
	// Start is called before the first frame update
	void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timePassed += Time.deltaTime;
        if (timePassed > fireDelay)
        {
			Instantiate(bullet, new Vector3(transform.position.x-3,transform.position.y), transform.rotation);
			timePassed = 0;
        }
    }
}
