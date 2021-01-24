using UnityEngine;

public class SelfDestroyOnCollision : MonoBehaviour
{
    private enum Type
    {
        OnCollisionEnter,
        OnCollisionExit
    }

    /// Inspector   
    [SerializeField] private LayerMask layerMask;
    [SerializeField] private Type type = Type.OnCollisionEnter;


    private void OnCollisionEnter(Collision collision)
    {
        if (type == Type.OnCollisionEnter && layerMask == (layerMask | (1 << collision.gameObject.layer)))
        {
            Destroy(gameObject);
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (type == Type.OnCollisionExit && layerMask == (layerMask | (1 << collision.gameObject.layer)))
        {
            Destroy(gameObject);
        }
    }
}
