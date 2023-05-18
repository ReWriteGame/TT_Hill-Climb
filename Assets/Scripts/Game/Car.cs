using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[SelectionBase]
[RequireComponent(typeof(Rigidbody2D))]
public class Car : MonoBehaviour
{
    [HideInInspector] public Vector2 inputDirection;

    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private Wheel wheelRight;
    [SerializeField] private Wheel wheelLeft;
    [SerializeField] private float speedMove = 10;
    [SerializeField] private float speedAcceleration = 10;
    [SerializeField] private float maxWheelRotateSpeed = 1000;
    [SerializeField] private float speedRotate = 10;


    public UnityEvent OnTakeCoin;


    private void FixedUpdate()
    {
        MoveLogic();
    }

    private void MoveLogic()
    {
        if (Mathf.Abs(wheelRight.Wheel2D.jointSpeed) < maxWheelRotateSpeed && Mathf.Abs(rb.velocity.x) < speedMove)
            wheelRight.Rb.AddTorque(-inputDirection.x * speedAcceleration * Time.fixedDeltaTime);

        if (Mathf.Abs(wheelLeft.Wheel2D.jointSpeed) < maxWheelRotateSpeed && Mathf.Abs(rb.velocity.x) < speedMove)
            wheelLeft.Rb.AddTorque(-inputDirection.x * speedAcceleration * Time.fixedDeltaTime);

        rb.AddTorque(inputDirection.y * speedRotate * Time.fixedDeltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.TryGetComponent(out Coin coin))
            OnTakeCoin?.Invoke();
       
    }
}
