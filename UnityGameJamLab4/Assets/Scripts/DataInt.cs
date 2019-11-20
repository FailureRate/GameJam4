using System;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class DataInt : DataNode
{
    [SerializeField] private int value;

    public int Value { get { return value; } set { this.value = value; } }

    public static DataInt operator +(DataInt left, int right)
    {
        left.Value += right;
        return left;
    }

    public static DataInt operator -(DataInt left, int right)
    {
        left.Value -= right;
        return left;
    }

    public static DataInt operator *(DataInt left, int right)
    {
        left.Value *= right;
        return left;
    }

    public static DataInt operator /(DataInt left, int right)
    {
        left.Value /= right;
        return left;
    }

    public static explicit operator int(DataInt data)
    {
        return data.value;
    }
}
