using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthManager : MonoBehaviour
{

    public Image Healthbar;
    public float healthAmount = 100f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (healthAmount <= 0)
        {
            Application.LoadLevel(Application.loadedLevel);
        }
        
        if (Input.GetKeyDown(KeyCode.Return))
        {
            TakeDamaege(20);
        }

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            heal(5);
        }
    }

    public void TakeDamaege (float damage)
    {
        healthAmount -= damage;
        Healthbar.fillAmount = healthAmount / 100;
    }

    public void heal(float healingAmount)
    {
        healthAmount += healingAmount;

        healthAmount = Mathf.Clamp(healthAmount, 0, 100);

        Healthbar.fillAmount = healthAmount / 100f;
    }

}
