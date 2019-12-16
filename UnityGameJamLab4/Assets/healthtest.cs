using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class healthtest : MonoBehaviour
{
    [SerializeField]
    private float health;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (health <= 150) { health++; }
        if (health >= 150) { health = -50; }
    }
}
