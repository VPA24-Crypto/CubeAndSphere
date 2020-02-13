using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ObjectManager : MonoBehaviour
{
    public ObjectController ObjectController;
    public ObjectView SelectedObject;

    void Start()
    {
        ObjectController = GameObject.Find("GameObjectCube").GetComponent<ObjectController>();
    }


    public void MoveSelect()
    {
        if (Input.GetMouseButtonDown(0) && !EventSystem.current.IsPointerOverGameObject())
        {
            var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out var hit))
            {
                var hitObject = hit.collider.GetComponent<ObjectView>();
                if (hitObject != null)
                {
                    SelectedObject = hitObject;
                }
                else
                {
                    SelectedObject = null;
                }
            }
            else
            {
                SelectedObject = null;
            }
        }

        if (SelectedObject != null)
        {
            if (Input.GetMouseButton(0) && !EventSystem.current.IsPointerOverGameObject())
            {
                var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                if (Physics.Raycast(ray, out var hit))
                {
                    var pos = new Vector3(0f, 1f);
                    pos.z = hit.point.z;
                    pos.x = hit.point.x;
                    SelectedObject.transform.position = pos;
                }
            }
        }
    }

    public void SpawnObjectCube()
    {
        SelectedObject = Instantiate(ObjectController.objectToSpawn).GetComponent<ObjectView>();
    }

    public void SpawnObjectSphere()
    {
        SelectedObject = Instantiate(ObjectController.SpawnSphere).GetComponent<ObjectView>();
    }

    public void DeleteObject()
    {
        if (SelectedObject == null)
            return;

        Destroy(SelectedObject.gameObject);
    }

    public void ChangeColor()
    {
        if (SelectedObject == null)
            return;

        SelectedObject.Color = SelectedObject.Color == Color.white ? Color.black : Color.white;
    }

    public void Slider_Chang(float newValue){
        if(SelectedObject != null){
            if(SelectedObject.gameObject != GameObject.Find("Cube(Clone)"))
            {
                SelectedObject.Slider_Changed(newValue);
            }
            else
            {
                return;
            }
        }
    }
}