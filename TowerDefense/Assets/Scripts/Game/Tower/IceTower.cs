﻿using UnityEngine;

public class IceTower : Tower
{
    public GameObject icePrefab;

    public override void Update()
    {
        base.Update();

        GetNonFrozenTarget();
    }

    private void GetNonFrozenTarget()
    {
        foreach (Enemy enemy in GetEnemiesInAggroRange())
        {
            if (!enemy.frozen)
            {
                targetEnemy = enemy;
                break;
            }
        }
    }

    protected override void AttackEnemy()
    {
        base.AttackEnemy();

        // Shoot ice
        GameObject ice = (GameObject)Instantiate(icePrefab, towerPieceToAim.position, Quaternion.identity);
        ice.GetComponent<FollowingProjectile>().enemyToFollow = targetEnemy;
    }
}
