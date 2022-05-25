using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NodeGrid : MonoBehaviour
{
    public int gridX;
    public int gridZ;
    public Vector3 gridOffset;

    public float nodeSize;
    Node[,] nodes;

    private void Awake()
    {
        nodes = new Node[gridZ, gridZ];
        for(int x = 0; x < gridX; x++)
        {
            for(int z = 0; z < gridZ; z++)
            {
                nodes[x,z] = new Node((float)x * nodeSize + gridOffset.x, 
                    gridOffset.y, (float)z * nodeSize + gridOffset.z);
            }
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.black;
        for (int x = 0; x < gridX; x++)
        {
            for (int z = 0; z < gridZ; z++)
            {
                Vector3 center = new Vector3((float)x * nodeSize + gridOffset.x,
                    gridOffset.y, (float)z * nodeSize + gridOffset.z);
                Gizmos.DrawWireCube(center, new Vector3(nodeSize, 0, nodeSize));
            }
        }
    }
}
