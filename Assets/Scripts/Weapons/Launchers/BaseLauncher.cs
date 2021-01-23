using UnityEngine;

public abstract class BaseLauncher : MonoBehaviour, ILauncher
{
    [SerializeField]
    protected float fireForce;

    [SerializeField]
    protected Rigidbody projectilePrefab;

    public virtual bool CanShoot()
    {
        return true;
    }

    public abstract void Shoot();

}
