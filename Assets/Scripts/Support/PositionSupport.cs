using UnityEngine;

public class PositionSupport : MonoBehaviour
{

    private Rigidbody _rigidbody;

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    public void Move(Vector3 direction, float speed)
    {       
        Vector3 movement = direction * speed * Time.deltaTime;

        if (_rigidbody != null)
        {
            if (_rigidbody.isKinematic)
            {
                // Move the kinematic rigidbody towards current position + movement.
                _rigidbody.MovePosition(_rigidbody.position + movement);
            }
            else
            {
                // Move non-kinematic rigidbody.
                _rigidbody.position += movement;
            }
        }
        else
        {
            transform.position += movement;
        }
    }

    /*
    public void Set(Vector3 position)
    {
        // TODO!
    }
    */

}
