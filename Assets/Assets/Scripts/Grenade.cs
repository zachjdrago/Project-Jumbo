using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grenade : MonoBehaviour
{
    public Transform Hand;
    public float throwForce;
    public GameObject grenadPrefab;
    public KeyCode key;
    public Rigidbody projectile;
    public Animator anim;
    public float speed = 20;
    public float delay = 3f;
    public float radius = 5f;
    public float force = 700f;
    public float countdown;
    public float grenadeDelay;
    public float GrenadeCooldown;
    bool isThrowing;

    // Start is called before the first frame update
    void Start()
    {
        countdown = delay;
    }

    // Update is called once per frame
    void Update()
    {
        

        if (Input.GetKeyDown(KeyCode.E) && !isThrowing)
        {
            isThrowing = true; 
            anim.SetTrigger("Grenade");
            Invoke("ThrowGrenade", grenadeDelay);
            Invoke("ResetGrenadeCooldown", GrenadeCooldown);


        }
    }
    void ThrowGrenade()
    {
        Rigidbody instantiatedProjectile = Instantiate(projectile, transform.position, transform.rotation) as Rigidbody;
        instantiatedProjectile.velocity = transform.TransformDirection(new Vector3(0, 0, speed));
    }

    void ResetGrenadeCooldown()
    {
        isThrowing = false;
    }
}
