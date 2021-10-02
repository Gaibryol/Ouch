using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GirlHitScript : MonoBehaviour
{
    private EarthquakeScript eScript;

    // Start is called before the first frame update
    void Start()
    {
        eScript = GameObject.FindGameObjectWithTag("Ground").GetComponent<EarthquakeScript>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Object")
        {
            GamestateScript.inGame = false;
            eScript.StopShake();
        }
    }
}
