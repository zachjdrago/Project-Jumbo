using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spAWNaLIENS : MonoBehaviour
{
    public GameObject alien; 
    public float spawntimer;
    private float timer;
    public Transform transformspawn;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= spawntimer)
        {
            timer = 0;
            
            GameObject newAlien = GameObject.Instantiate(alien);

            newAlien.transform.parent = null;

            newAlien.transform.position = transformspawn.position;

            spawntimer = Random.Range(1f, 5f);

        }
    }
}
