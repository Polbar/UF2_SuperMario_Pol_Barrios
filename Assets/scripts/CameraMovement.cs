using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public Transform playerTramsform;
    public Vector3 offset;
             //vector3 es para tema de cordenadas asi que el vector 3 guarda para modificar el eje x y z
    public Vector2 minCameraPosition;
    public Vector2 maxCameraPosition;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 desiredPosition = playerTramsform.position + offset;

        float clampX = Mathf.Clamp(desiredPosition.x, minCameraPosition.x, maxCameraPosition.x);
        float clampY = Mathf.Clamp(desiredPosition.y, minCameraPosition.y, maxCameraPosition.y);
        //la linia anterior limita los ejes a los valores que le he dado en especifico el limitador es el Mathf.Clamp

        Vector3 clampedPosition = new Vector3(clampX, clampY, desiredPosition.z);
        transform.position = clampedPosition;
    }
}
