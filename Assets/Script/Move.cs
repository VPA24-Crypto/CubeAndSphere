using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    private Ray ray;
    private RaycastHit hit;
    private Vector3 rot = new Vector3(1, 1, 1);

    /*void Update()
    {

        if (Input.GetMouseButton(0))
        {
            ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit))
            {
                rot.z = hit.point.z;
                rot.x = hit.point.x;
                transform.position = new Vector3(rot.x, 1, rot.z);

            }
        }
    }*/

    void OnMouseDrag()
    {
        ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out hit))
        {
            rot.z = hit.point.z;
            rot.x = hit.point.x;
            transform.position = new Vector3(rot.x, 1, rot.z);

        }
    }

}
