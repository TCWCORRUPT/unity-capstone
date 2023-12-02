using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class portalTeleportScript : MonoBehaviour
{
    public GameObject exitProtal;
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
		if (collision.gameObject.TryGetComponent<Transform>(out Transform player))
		{
            exitProtal = GameObject.FindWithTag("ExitPortal");
            player.transform.position = new Vector3(exitProtal.transform.position.x+2, exitProtal.transform.position.y, exitProtal.transform.position.z);
		}
	}
}
