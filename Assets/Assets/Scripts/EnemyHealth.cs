using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyHealth : MonoBehaviour
{
    
    public float healthAmount = 2;
    public Rigidbody rb;
    public Vector3 Direction;
    

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (healthAmount <= 0)
        {
            rb.AddForce(Direction * Time.deltaTime); 
            
        }
    }

    public void TakeDamage(float Damage)
    {
        if (healthAmount <= 0)
        {
            Invoke("bye", 10);
        }

        GameManager.instance.Addscore();
        healthAmount -= Damage;
    }

    public void bye()
    {
     
       
        Destroy(gameObject);

        
        

    }
}
