using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class SetRigidbodyRotation : MonoBehaviour
{

    private Rigidbody _rigidbody;

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    public void Set(Vector3 eulerRotation)
    {
        _rigidbody.rotation = Quaternion.Euler(eulerRotation);
    }

}
