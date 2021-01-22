using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class PlayerMotion : MonoBehaviour
{
    /// Inspector
    [SerializeField] private string axisName = "Horizontal";
    [SerializeField] private float speed = 10f;

    /// Dependencies
    private Rigidbody _rigidbody;
    private Engine engine;

    /// Internal
    private float horizontalInput;

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>();
        engine = GetComponentInChildren<Engine>();
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
            engine.Move();
        }
        else
        {
            engine.Idle();  
        }
    }

    private void Move()
    {
        _rigidbody.position += Vector3.right * horizontalInput * speed * Time.deltaTime;

        float rotation = -10f * horizontalInput;
        _rigidbody.rotation = Quaternion.Euler(0f, rotation, 0f);
    }    

}
