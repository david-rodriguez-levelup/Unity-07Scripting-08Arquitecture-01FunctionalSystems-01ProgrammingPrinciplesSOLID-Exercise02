using UnityEngine;

[RequireComponent(typeof(MoveRigidbodyPosition))]
public class EnemyMotion : MonoBehaviour
{

    /// Dependencies
    private MoveRigidbodyPosition moveRigidbodyPosition;
    private Engine engine;

    private void Awake()
    {
        moveRigidbodyPosition = GetComponent<MoveRigidbodyPosition>();
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
        moveRigidbodyPosition.Move(Vector3.down);
    }

}
