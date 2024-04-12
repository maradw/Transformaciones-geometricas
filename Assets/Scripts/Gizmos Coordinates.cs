using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GizmosCoordinates : MonoBehaviour
{

    private void OnDrawGizmos()
    {
        //z
        Gizmos.color = Color.blue;
        Vector3 start = new Vector3(0, 0, -30);
        Vector3 end = new Vector3(0, 0, 30);
        Gizmos.DrawLine(start, end);
        //x
        Gizmos.color = Color.red;
        Vector3 from = new Vector3(-30, 0, 0);
        Vector3 to = new Vector3(30, 0, 0);
        Gizmos.DrawLine(from, to);
        //y
        Gizmos.color = Color.green;
        Vector3 begin = new Vector3(0, -30, 0);
        Vector3 drawUp = new Vector3(0, 30, 0);
        Gizmos.DrawLine(begin, drawUp);
    }

}
