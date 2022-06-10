using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Abilities : MonoBehaviour
{
    public Transform Hand;
    public KeyCode key;
    public Rigidbody projectile;
    public Animator anim;
    public float speed = 20;
    public float radius = 5f;
    public float force = 700f;

    public float fireRate = 0.05f;
    private float nextShot = 0.0f;

    // Update is called once per frame
    void Update()
    {
        
       


        if (Input.GetButtonDown("Fire1") && Time.time > nextShot)
        {

            anim.SetTrigger("Shooting");
            Rigidbody instantiatedProjectile = Instantiate(projectile, transform.position, transform.rotation) as Rigidbody;
            instantiatedProjectile.velocity = transform.TransformDirection(new Vector3(0, speed, 0));
            nextShot = Time.time + fireRate;


        }

    }

    

   
       
    
};