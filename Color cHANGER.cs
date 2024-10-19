using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorcHANGER : MonoBehaviour
{
    public Color newColor;

    void Start()
    {
        // Get the Renderer component of the primitive object
        Renderer renderer = GetComponent<Renderer>();
        // Change the material's color to the new color
        renderer.material.color = newColor;
    }
}
