using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class badalscript : MonoBehaviour
{
    public GameObject badal;
   
    public float spwanrate = 4;
    private float timer = 0;

    // Start is called before the first frame update
    void Start()
    {
        spawnbadal();
    }

    // Update is called once per frame
    void Update()
    {

        if (timer < spwanrate)
        {

            timer = timer + Time.deltaTime;

        }

        else
        {
            spawnbadal();
            timer = 0;
        }
    }

    public void spawnbadal()
    {
        Instantiate(badal, transform.position, transform.rotation);


    }
}
