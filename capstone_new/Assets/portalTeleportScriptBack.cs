using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class portalTeleportScriptBack : MonoBehaviour
{
    public GameObject entryPortal;
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
			entryPortal = GameObject.FindWithTag("EntryPortal");
			player.transform.position = new Vector3(entryPortal.transform.position.x - 2, entryPortal.transform.position.y, entryPortal.transform.position.z);
		}
	}
}
