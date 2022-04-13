using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{
    public Rigidbody2D backTire;
    public Rigidbody2D frontTire;
    public Rigidbody2D carRigidbody;
    public float speed = 20;
    public float carTorque = 10;
    private float movement;
    public float fuel = 1;
    public float fuelconsumption = 0.1f;
    public UnityEngine.UI.Image image;
    void Start()
    {
        
    }

    void Update()
    {
        movement = Input.GetAxis("Horizontal");
        image.fillAmount = fuel;
    }
    private void FixedUpdate()
    {
        if ( fuel > 0)
        {
            backTire.AddTorque(- movement * speed * Time.fixedDeltaTime);
            frontTire.AddTorque(- movement * speed * Time.fixedDeltaTime);
            carRigidbody.AddTorque(- movement * carTorque * Time.fixedDeltaTime);
        }
        fuel -= fuelconsumption * Mathf.Abs( movement ) * Time.fixedDeltaTime;
    }
}
