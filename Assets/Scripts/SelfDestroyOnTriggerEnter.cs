using UnityEngine;

/// <summary>
/// Destroys the object this component is attached to when it enters the static trigger collider 
/// defined in the inspector or runtime via <see cref="SetStaticTriggerCollider(UnityEngine.Collider)"/> method.
/// A <see cref="Rigidbody"/> component is required in the object.
/// </summary>
[RequireComponent(typeof(Rigidbody))]
public class SelfDestroyOnTriggerEnter : MonoBehaviour
{
    /// Inspector   
    [SerializeField]
    private Collider staticTriggerCollider;

    private void OnTriggerEnter(Collider collider)
    {
        if (collider == staticTriggerCollider)
        {
            Destroy(gameObject);
        }
    }

    /// <summary>
    /// Updates the static trigger collider with <param name="collider"> at runtime.
    /// You can also set the static trigger collider statically via inspector.
    /// </summary>
    /// <param name="collider">Static collider that triggers the object destruction.</param>
    public void SetStaticTriggerCollider(Collider collider)
    {
        staticTriggerCollider = collider;
    }

}