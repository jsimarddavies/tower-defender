using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ice : FollowingProjectile {

    // Use this for initialization
    protected override void OnHitEnemy()
    {
        enemyToFollow.Freeze();
        Destroy(gameObject);
    }
}
