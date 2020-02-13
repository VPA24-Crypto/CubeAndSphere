using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectView : MonoBehaviour
{
    
    private Color _color;

    public Color Color
    {
        set
        {
            _color = value;
            UpdateView();
        }
        get
        {
            return _color;
        }
    }

    public void UpdateView()
    {
        GetComponent<Renderer>().material.color = Color;
    }

        public void Slider_Changed(float newValue)
    {
        Vector3 pos = transform.localScale;
        pos.x = newValue;
        pos.y = newValue;
        pos.z = newValue;
        transform.localScale = pos;
    }
}
