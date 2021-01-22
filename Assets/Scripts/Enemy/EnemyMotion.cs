using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class EnemyMotion : MonoBehaviour
{

    /// Inspector
    [SerializeField]
    private float speed = -5f;

    /// Dependencies
    private Rigidbody _rigidbody;
    private Engine engine;

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>();
        engine = GetComponentInChildren<Engine>();
    }

    private void Start()
    {
        if (engine)
        {
            engine.Move();
        }
    }

    private void Update()
    {
        Move();
    }

    private void Move()
    {
        _rigidbody.position += Vector3.up * speed * Time.deltaTime;
    }

}
