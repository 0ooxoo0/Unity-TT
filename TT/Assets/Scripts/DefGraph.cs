using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefGraph : MonoBehaviour
{
    public LineRenderer lineRenderer;
    public GameObject[] GO;
    // Start is called before the first frame update
    void Start()
    {
        lineRenderer.positionCount = GO.Length;
        for (int i = 0;i<lineRenderer.positionCount;i++)
        {
            lineRenderer.SetPosition(i, new Vector3(GO[i].transform.position.x, -0.1f, GO[i].transform.position.z));
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
