using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    public Image healthBar;
    public float healthAmount = 100;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(healthAmount <= 0)
        {
            Application.LoadLevel(Application.loadedLevel); 
        }

         healthAmount = Mathf.Clamp(healthAmount, 0, 100);

         healthBar.fillAmount = healthAmount / 100;
    }

    public void TakeDamage(float Damage)
    {
        healthAmount -= Damage;
        healthBar.fillAmount = healthAmount / 100;
    }

    public void Healing(float healPoints)
    {
        healthAmount += healPoints;
       
    }
}
