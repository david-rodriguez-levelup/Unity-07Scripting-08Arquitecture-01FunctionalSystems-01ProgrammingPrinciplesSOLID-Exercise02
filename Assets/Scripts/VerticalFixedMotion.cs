using UnityEngine;

/// <summary>
/// Moves the object's <see cref="Transform"/> vertically
/// at defined speed.
/// </summary>
public class VerticalFixedMotion : MonoBehaviour
{

    [SerializeField]
    private float speed = -5f;

    private void Update()
    {
        Move();
    }

    private void Move()
    {
        transform.Translate(Vector3.up * speed * Time.deltaTime);
    }

}
