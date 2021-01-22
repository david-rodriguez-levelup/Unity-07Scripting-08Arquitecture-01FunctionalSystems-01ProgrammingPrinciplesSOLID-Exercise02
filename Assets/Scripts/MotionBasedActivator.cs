using UnityEngine;

/// <summary>
/// Activates the target object if the object with this component attached 
/// is moving or deactivates it otherwise.
/// </summary>
public class MotionBasedActivator : MonoBehaviour
{

    /// Inspector
    [SerializeField] private GameObject target;   

    /// Internal
    private Vector3 previousPosition;

    private void Start()
    {
        previousPosition = transform.position;
    }

    private void Update()
    {
        /// Keep target object active if this object is moving.
        target.SetActive(transform.position != previousPosition);

        /// Update previousPosition to current position.
        previousPosition = transform.position;
    }

}
