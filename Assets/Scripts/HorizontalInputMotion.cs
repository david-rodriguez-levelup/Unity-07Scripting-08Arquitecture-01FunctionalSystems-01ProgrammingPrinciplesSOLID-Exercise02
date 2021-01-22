using UnityEngine;

/// <summary>
/// Moves the object's <see cref="Rigidbody"/> based on player's horizontal input
/// multiplied by speed.
/// </summary>
[RequireComponent(typeof(Rigidbody))]
public class HorizontalInputMotion : MonoBehaviour
{
    /// Inspector
    [SerializeField] private string axisName = "Horizontal";
    [SerializeField] private float speed = 10f;

    /// Internal
    private float horizontalInput;
    private Rigidbody _rigidbody;

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        horizontalInput = Input.GetAxis(axisName);
    }

    private void FixedUpdate()
    {
        if (horizontalInput != 0)
        {
            Move();
        }
    }

    private void Move()
    {
        _rigidbody.MovePosition(_rigidbody.position + Vector3.right * horizontalInput * speed * Time.deltaTime);
    }

}
