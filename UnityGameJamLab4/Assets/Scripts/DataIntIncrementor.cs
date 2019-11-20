using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataIntIncrementor : MonoBehaviour
{
    [Header("Data")]
    [SerializeField] private DataInt integer;
    [Header("References")]
    [SerializeField] private Data data;

    private void Start()
    {
        integer = data.Int(integer);
    }

    public void Increment(int increment)
    {
        integer += increment;
    }
}
