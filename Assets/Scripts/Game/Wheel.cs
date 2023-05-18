using UnityEngine;

public class Wheel : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private CircleCollider2D collider2D;
    [SerializeField] private WheelJoint2D wheel2D;

    public Rigidbody2D Rb => rb;
    public CircleCollider2D Collider2D => collider2D;
    public WheelJoint2D Wheel2D => wheel2D;
}
