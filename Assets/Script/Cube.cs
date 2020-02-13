using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Cube : MonoBehaviour
{
    
    [SerializeField]
    GameObject pref = null;

    [SerializeField]
    Button butt = null;

    void Start()
    {
        butt.onClick.AddListener(Spawn);
    }

    void Spawn()
    {
        Instantiate(pref);
    }

 


    /*public void onClick()
    {
        Vector3 pos = new Vector3(1, 1, 1); //координаты где появ
        GameObject newCub = Instantiate(cube, pos, Quaternion.identity) as GameObject; //Создаем новый куб на сцене
        
    }*/
}
