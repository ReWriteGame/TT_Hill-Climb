using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarInput : MonoBehaviour
{
    [SerializeField] private Car car;


    private void Update()
    {
       //car.inputDirection.x = Input.GetAxis("Horizontal");
       //car.inputDirection.y = Input.GetAxis("Vertical");

    }

    public void Move()
    {
        car.inputDirection.x = 1;
    }
    public void MoveStop()
    {
        car.inputDirection.x = 0;
    }

    public void RotateRight()
    {
        car.inputDirection.y = 1;
    }

    public void RotateLeft()
    {
        car.inputDirection.y = -1;
    }

    public void RotateStop()
    {
        car.inputDirection.y = 0;
    }
}
