using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class MoveRigidbodyRotation : MonoBehaviour
{

    [SerializeField]
    private float speed;

    private Rigidbody _rigidbody;

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    public void Move(Vector3 eulerRotation)
    {
        Quaternion deltaRotation = Quaternion.Euler(eulerRotation * speed * Time.deltaTime);

        _rigidbody.MoveRotation(_rigidbody.rotation * deltaRotation);
    }

}
