using UnityEngine;

public class ConeLauncher : BaseLauncher
{

    [SerializeField]
    private float numProjectiles = 3;

    [SerializeField]
    private float angle = 45;

    public override void Shoot()
    {
        var projectile1 = Instantiate(base.projectilePrefab, transform.position + Vector3.left, transform.rotation);
        projectile1.AddForce(projectile1.transform.up * base.fireForce);

        var projectile2 = Instantiate(base.projectilePrefab, transform.position + Vector3.right, transform.rotation);
        projectile2.AddForce(projectile2.transform.up * base.fireForce);
    }

}
