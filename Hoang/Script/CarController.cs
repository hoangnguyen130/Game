using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{

    [HideInInspector]
    public float fuel = 1;
    public float fuelconsumption = 0.1f;
    public Rigidbody2D carRigidbody;
    public Rigidbody2D backTire;
    public Rigidbody2D frontTire;
    public float speed = 20;
    public float carTorque = 10;
    private float movement = 0;
    public UnityEngine.UI.Image image;
   

    public void decmovement(){
        movement = -1;
    }

    public void move0(){
        movement = 0;
    }

    public void incmovement(){
        movement =1;
    }

    // Update is called once per frame
    void Update()
    {
        
        image.fillAmount = fuel; // anh xang
    }

    private void FixedUpdate()
    {
        if (fuel > 0)
        {
            backTire.AddTorque(-movement * speed * Time.fixedDeltaTime);
            frontTire.AddTorque(-movement * speed * Time.fixedDeltaTime);
            carRigidbody.AddTorque(-movement * carTorque * Time.fixedDeltaTime);
        }

        fuel -= fuelconsumption * Mathf.Abs(movement) * Time.fixedDeltaTime;
    }
}