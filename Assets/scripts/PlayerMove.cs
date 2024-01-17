using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour

{
    public Vector3 newPosition = new Vector3(50, 5, 0);
    public float movimentSpeed = 5;
    private float inputHorizontal;
    public bool jump = false;

    // Start is called before the first frame update
    void Start()
    {
        //Teletrasnporta al personaje a la posicion dicha en la varaible
        //transform.position = newPosition;
    }

    // Update is called once per frame
    void Update()
    {
        inputHorizontal = Input.GetAxis("Horizontal");
        //transform.position = transform.position + new Vector3(1, 0, 0) * movimentSpeed * Time.deltaTime;
        transform.position += new Vector3(inputHorizontal, 0, 0) * movimentSpeed * Time.deltaTime;

        if(jump == true)
        {
            Debug.Log("estoy saltando");
        }
        else if(jump == false)
        {
            Debug.Log("estoy en el suelo");
        }
        else
        {
            Debug.Log("yooooo");
        }
    }
}