using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Sphere : MonoBehaviour
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


}
