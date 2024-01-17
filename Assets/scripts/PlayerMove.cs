using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour

{
    public Rigidbody2D rBody;
    public Vector3 newPosition = new Vector3(50, 5, 0);
    public float movementSpeed = 5;
    private float inputHorizontal;
    public bool jump = false;
    public float jumpForce = 5;

    void Awake()
    {
        rBody = GetComponent<Rigidbody2D>();
    }

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
        //transform.position = transform.position + new Vector3(1, 0, 0) * movementSpeed * Time.deltaTime;
        //transform.position += new Vector3(inputHorizontal, 0, 0) * movementSpeed * Time.deltaTime;

            // (rBody.velocity) rBody seria para la nomenclatura: que es. y el punto sirve para empezar poniendo el valor que quedras ver;
        
       /* if(jump == true)
        {
            Debug.Log("estoy saltando");
        }
        else if(jump == false)
        {
            Debug.Log("estoy en el suelo");
        }
        else
        {
            Debug.Log("assda");
        }*/

        if(Input.GetButtonDown("Jump"))
        {
            rBody.AddForce(new Vector2(0,1) * jumpForce, ForceMode2D.Impulse);
        }
    }

        //el fixedupdate no vambia los valores por fps, en cambio el update tiene en cuenta los fps;
    void FixedUpdate()
    {
        rBody.velocity = new Vector2(inputHorizontal * movementSpeed, rBody.velocity.y);
    }




}