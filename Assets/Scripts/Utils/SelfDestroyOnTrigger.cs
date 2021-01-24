using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class SelfDestroyOnTrigger : MonoBehaviour
{

    private enum Type
    {
        OnTriggerEnter,
        OnTriggerExit
    }

    /// Inspector   
    [SerializeField] private LayerMask layerMask;
    [SerializeField] private Type type = Type.OnTriggerEnter;


    private void OnTriggerEnter(Collider collider)
    {
        if (type == Type.OnTriggerEnter && layerMask == (layerMask | (1 << collider.gameObject.layer)))
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerExit(Collider collider)
    {
        if (type == Type.OnTriggerExit && layerMask == (layerMask | (1 << collider.gameObject.layer)))
        {
            Destroy(gameObject);
        }
    }

}