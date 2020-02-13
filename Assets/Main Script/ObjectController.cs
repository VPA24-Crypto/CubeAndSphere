using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectController : MonoBehaviour
{
    [SerializeField] public GameObject objectToSpawn,SpawnSphere;
    public ObjectManager ObjectManager;

    void Start()
    {
        ObjectManager = GameObject.Find("ViewAndManager").GetComponent<ObjectManager>();
    }
    void Update() => ObjectManager.MoveSelect();

    public void SpawnToObject()
    {
        ObjectManager.SpawnObjectCube();
    }

    public void Sphere()
    {
        ObjectManager.SpawnObjectSphere();
    }

    public void Destroy()
    {
        ObjectManager.DeleteObject();
    }

    public void Color()
    {
        ObjectManager.ChangeColor();
    }

    public void Slider(float new_Value)
    {
        ObjectManager.Slider_Chang(new_Value);
    }

}
