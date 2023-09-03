using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMovement : MonoBehaviour
{
    public Transform name;

    public float speed = 4f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
{
 name.Translate(-Vector3.right * speed * Time.deltaTime);
}
        if (Input.GetKey(KeyCode.D))
{
 name.Translate(Vector3.right * speed * Time.deltaTime);
}
        if (Input.GetKey(KeyCode.W))
{
 name.Translate(Vector3.forward * speed * Time.deltaTime);
}
        if (Input.GetKey(KeyCode.X))
{
 name.Translate(-Vector3.forward * speed * Time.deltaTime);
}

    }
}
