using UnityEngine;

public class ChaserLauncher : BaseLauncher
{

    public override void Shoot()
    {
        var projectile = Instantiate(base.projectilePrefab, transform.position, transform.rotation);
        projectile.AddForce(projectile.transform.up * base.fireForce);

        // Add Component Chaser.
    }

}
