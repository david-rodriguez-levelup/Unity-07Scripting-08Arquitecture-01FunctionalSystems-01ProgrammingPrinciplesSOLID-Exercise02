using UnityEngine;

[RequireComponent(typeof(MoveRigidbodyPosition))]
[RequireComponent(typeof(SetRigidbodyRotation))]
public class PlayerMotion : MonoBehaviour
{
    /// Inspector
    [SerializeField] private string axisName = "Horizontal";

    /// Dependencies
    private MoveRigidbodyPosition moveRigidbodyPosition;
    private SetRigidbodyRotation setRigidbodyRotation;
    private Engine engine;

    /// Internal
    private float horizontalInput;

    private void Awake()
    {
        moveRigidbodyPosition = GetComponent<MoveRigidbodyPosition>();
        setRigidbodyRotation = GetComponent<SetRigidbodyRotation>();
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
        moveRigidbodyPosition.Move(Vector3.right * horizontalInput);

        setRigidbodyRotation.Set(new Vector3(0f, -horizontalInput * 10f, 0f));
    }    

}
