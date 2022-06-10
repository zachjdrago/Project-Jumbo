using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingGrenade : MonoBehaviour
{
  
    Rigidbody grenade;
    public GameObject Smoke;
    bool isTriggered;
    // Start is called before the first frame update

    private void Start()
    {
        grenade = GetComponent<Rigidbody>();
    }
    // Update is called once per frame
    public void Update()
    {
        if (!isTriggered) 
            gameObject.transform.Rotate(0, 0, 6);
    }

    private void OnCollisionEnter(Collision collision)
    {
        grenade.isKinematic = true;
        Debug.Log(collision.gameObject);
        isTriggered = true;
        Smoke.SetActive(true);
    }
}

