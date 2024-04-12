using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    
    [Header (" Vertex")]
    public float radius;
    public Vector3 currentPosition;
    //public Vector3 initialPosition;
    [Header (" Transform")]
    public Vector3 Position;
    public Vector3 CurrentPosition;
    public Vector3 Scale;
    public Vector3 CurrentScale;

    [SerializeField] private Cube target1;
    [SerializeField] private Cube target2;
    [SerializeField] private Cube target3;
  
    private void OnDrawGizmos()
    {

        Gizmos.color = Color.yellow;
        Gizmos.DrawSphere(currentPosition, radius);

        Gizmos.color = Color.magenta;

        if( target1 != null || target2 != null || target3 != null)
        {
            Gizmos.DrawLine(currentPosition, target1.currentPosition);
            Gizmos.DrawLine(currentPosition, target2.currentPosition);
            Gizmos.DrawLine(currentPosition, target3.currentPosition);
        }

    }

}
