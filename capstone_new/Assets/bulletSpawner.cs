using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletSpawner : MonoBehaviour
{
    public GameObject bullet;
    public Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.S))
        {
            animator.SetBool("isShooting", true);
            Instantiate(bullet,transform.position, transform.rotation);
        }
        if (!Input.GetKeyDown(KeyCode.S))
        {
            animator.SetBool("isShooting", false);
        }
    }
}
