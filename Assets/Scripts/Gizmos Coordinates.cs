using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GizmosCoordinates : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        OnDrawGizmos();
    }

    private void OnDrawGizmos()
    {
        
        Gizmos.color = Color.blue;
        Vector3 start = new Vector3(0, 0, 0);
        Vector3 end = new Vector3(0, 0, 15);
        Gizmos.DrawLine(start, end);

        Gizmos.color = Color.red;
        Vector3 from = new Vector3(0, 0, 0);
        Vector3 to = new Vector3(15, 0, 0);
        Gizmos.DrawLine(from, to);

        Gizmos.color = Color.green;
        Vector3 begin = new Vector3(0, 0, 0);
        Vector3 drawUp = new Vector3(0, 15, 0);
        Gizmos.DrawLine(begin, drawUp);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
