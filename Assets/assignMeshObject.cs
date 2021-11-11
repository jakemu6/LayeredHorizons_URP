using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class assignMeshObject : MonoBehaviour
{
    public GameObject mesh;

    ToggleComponent thisToggle;

    void Start()
    {
        thisToggle = GetComponent<ToggleComponent>();
    }

    void Update()
    {
        thisToggle.toggleName = mesh.name;

        if (thisToggle.active)
        {
            mesh.SetActive(true);
        } else
        {
            mesh.SetActive(false);
        }
    }
}
