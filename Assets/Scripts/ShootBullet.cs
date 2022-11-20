using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

internal class ShootBullet : MonoBehaviour, IShoot
{
    private Rigidbody2D _bullet;
    private Transform _barrel;
    private float _force;

    public ShootBullet(Rigidbody2D bullet, Transform barrel, float force)
   {
        _bullet = bullet;
        _barrel = barrel;
        _force = force;
    }
    public void Shoot()
    {
        var temAmmunition = Instantiate(_bullet, _barrel.position,
           _barrel.rotation);
        temAmmunition.AddForce(_barrel.up * _force);
    }
}
