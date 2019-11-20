using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Goal redGoal,blueGoal; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       if(redGoal.GetFire() == true &&
          blueGoal.GetFire() == true)
        {

        }
    }
}
