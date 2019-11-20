using System;
using System.Collections.Generic;
using UnityEngine;

public class Context : MonoBehaviour
{
    [Header("References")]
    [SerializeField] private Data data;

    private static Context instance;

    private void Start()
    {
        instance = this;
    }

    public static DataBool Bool(DataBool node)
    {
        return instance.data.Bool(node);
    }

    public static DataVector2 Vector2(DataVector2 node)
    {
        return instance.data.Vector2(node);
    }
}