using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class MoveRigidbodyPosition : MonoBehaviour
{

    [SerializeField]
    private float speed;

    private Rigidbody _rigidbody;

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    public void Move(Vector3 direction)
    {       
        Vector3 movement = direction * speed * Time.deltaTime;

        _rigidbody.MovePosition(_rigidbody.position + movement);
    }

}
