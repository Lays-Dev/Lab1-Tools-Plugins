using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class board : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.white;

        for(int i = 0; i < 9; i++)
        {
            Gizmos.DrawLine(new Vector3(i, 0, 0), new Vector3(i, 8f, 0));
        }

        for(int j = 0; j < 9; j++)
        {
            Gizmos.DrawLine(new Vector3(0, j, 0), new Vector3(8f, j, 0));
        }
    }
}
