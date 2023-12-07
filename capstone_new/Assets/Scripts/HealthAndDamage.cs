using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthAndDamage : MonoBehaviour
{
    //public GameObject player;
    public HealthManager healthManager;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

	private void OnTriggerEnter2D(Collider2D collision)
	{
        healthManager.TakeDamaege(10);
	}
}
