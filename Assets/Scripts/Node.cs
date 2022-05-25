using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Node
{
    float _x, _y, _z;
    public Node (float x, float y, float z)
    {
        _x = x;
        _y = y;
        _z = z;
    }
    public float x { get => _x; }
    public float y { get => _y; }
    public float z { get => _z; }

    /// <summary>
    /// Return world position
    /// </summary>
    public Vector3 center { get => new Vector3(_x, _y, _z); }
}
