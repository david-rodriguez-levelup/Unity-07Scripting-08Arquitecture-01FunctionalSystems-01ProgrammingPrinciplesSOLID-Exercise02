using UnityEngine;

public class SingleLauncher : BaseLauncher
{

    public override void Shoot()
    {
        var projectile = Instantiate(base.projectilePrefab, transform.position, transform.rotation);
        projectile.AddForce(projectile.transform.up * base.fireForce);
    }

}
