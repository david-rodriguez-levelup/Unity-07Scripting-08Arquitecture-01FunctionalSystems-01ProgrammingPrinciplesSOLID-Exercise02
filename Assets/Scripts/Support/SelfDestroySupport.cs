using UnityEngine;

public class SelfDestroySupport : MonoBehaviour
{

    private enum Type
    {
        TriggerEnter,
        CollisionEnter,
        TriggerExit,
        CollisionExit
    }

    /// Inspector   
    [SerializeField] private Type destroyOn = Type.TriggerEnter;
    [SerializeField] private LayerMask layerMask;

    private void OnTriggerEnter(Collider collider)
    {
        DestroyIfTypeAndLayerMatch(Type.TriggerEnter, collider.gameObject.layer);
    }

    private void OnCollisionEnter(Collision collision)
    {
        DestroyIfTypeAndLayerMatch(Type.CollisionEnter, collision.gameObject.layer);
    }

    private void OnTriggerExit(Collider collider)
    {
        DestroyIfTypeAndLayerMatch(Type.TriggerExit, collider.gameObject.layer);
    }

    private void OnCollisionExit(Collision collision)
    {
        DestroyIfTypeAndLayerMatch(Type.CollisionExit, collision.gameObject.layer);
    }

    private void DestroyIfTypeAndLayerMatch(Type type, int layer)
    {
        if (destroyOn == type && layerMask == (layerMask | (1 << layer)))
        {
            Destroy(gameObject);
        }
    }

}