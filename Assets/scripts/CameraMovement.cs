using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public Transform playerTramsform;
    public Vector3 offset;
             //vector3 es para tema de cordenadas asi que el vector 3 guarda para modificar el eje x y z
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 desiredPosition = playerTramsform.position + offset;
        transform.position = desiredPosition;
    }
}
