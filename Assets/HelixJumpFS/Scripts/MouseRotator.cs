using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseRotator : MonoBehaviour
{
    [SerializeField] private string mouseInputAxis;
    [SerializeField] private float sensetive;
   
    private void Update()
    {
        if (Input.GetMouseButton(0)==true)
        {
            transform.Rotate(0, Input.GetAxis(mouseInputAxis)*-sensetive,0);
        }
     }
}
