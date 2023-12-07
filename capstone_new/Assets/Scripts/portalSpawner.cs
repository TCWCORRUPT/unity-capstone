using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class portalSpawner : MonoBehaviour
{
    public GameObject entryPortal, exitPortal;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            GameObject[] checkPortalEntry = GameObject.FindGameObjectsWithTag("EntryPortal");

			if (checkPortalEntry.Length != 0)
            {
                for (int i = 0; i < checkPortalEntry.Length; i++)
                {
                    Destroy(checkPortalEntry[i]);
                }
            }
            Vector2 mousePoint = Camera.main.ScreenToWorldPoint(Input.mousePosition);
			Instantiate(entryPortal, mousePoint, Quaternion.identity);
        } 
        else if (Input.GetKeyDown(KeyCode.Mouse1))
        {
			GameObject[] checkPortalExit = GameObject.FindGameObjectsWithTag("ExitPortal");

			if (checkPortalExit.Length != 0)
			{
				for (int i = 0; i < checkPortalExit.Length; i++)
				{
					Destroy(checkPortalExit[i]);
				}
			}
			Vector2 mousePoint = Camera.main.ScreenToWorldPoint(Input.mousePosition);
			Instantiate(exitPortal, mousePoint, Quaternion.identity);
		}
        else if (Input.GetKeyDown(KeyCode.Mouse2))
        {
			GameObject[] checkPortalEntry = GameObject.FindGameObjectsWithTag("EntryPortal");
			GameObject[] checkPortalExit = GameObject.FindGameObjectsWithTag("ExitPortal");
			for (int i = 0; i < checkPortalEntry.Length; i++)
			{
				Destroy(checkPortalEntry[i]);
			}
			for (int i = 0; i < checkPortalExit.Length; i++)
			{
				Destroy(checkPortalExit[i]);
			}
		}
	}
}
