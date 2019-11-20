using UnityEngine;

public static class VectorExtensions
{
    public static Vector2 XY(this Vector3 v)
    { return new Vector2(v.x, v.y); }

    public static Vector3 Multiply(this Vector3 v, Vector3 v2)
    { return new Vector3(v.x * v2.x, v.y * v2.y, v.z * v2.z); }
}
