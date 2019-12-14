using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class teleporter : MonoBehaviour
{
    // Start is called before the first frame update
    static private bool cooldown;
    public GameObject teleportLocation;
    public GameObject process;
    private GameObject player;
    static private int count;
    void Start()
    {
        cooldown = false;
        process.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
            if (count <= 0) { cooldown = false; count = 100; process.SetActive(false); }
            if (count <= 20) { player.SetActive(true); }
            if (count >= 1 && cooldown == true) { count--; }        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (cooldown == false)
        {
            other.gameObject.transform.position = teleportLocation.transform.position;
            cooldown = true;
            process.SetActive(true);
            player = other.gameObject;
            player.SetActive(false);
        }

        Debug.Log("ahhhh");
    }
}
