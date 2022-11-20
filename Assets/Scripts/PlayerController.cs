using System.Collections;
using System.Collections.Generic;
using UnityEngine;

internal sealed class PlayerController
{
    private float _speed;
    private float _acceleration;
    private int _maxHealth;
    private Rigidbody2D _bullet;
    private Transform _barrel;
    private Transform _shipTransform;
    private float _force;

    private Camera _camera;
    private Ship _ship;
    private ShootBullet _shoot;
    private Healh _health;

    private PlayerView _playerView;  

    public void Start()
    {
        _speed = _playerView.speed;
        _acceleration = _playerView.acceleration;
        _maxHealth = _playerView.maxHealth;
        _bullet = _playerView.bullet;
        _barrel = _playerView.barrel;
        _shipTransform = _playerView.shipTransform;
        _force = _playerView.force;

        _camera = Camera.main;
        var moveTransform = new AccelerationMove(_shipTransform, _speed,
        _acceleration);
        var rotation = new RotationShip(_shipTransform);
        _ship = new Ship(moveTransform, rotation);
        _shoot = new ShootBullet(_bullet, _barrel, _force);
        _health = new Healh(_maxHealth);
    }

    public void Update()
    {
        var direction = Input.mousePosition - _camera.WorldToScreenPoint(_shipTransform.position);
        _ship.Rotation(direction);
        _ship.Move(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"),
        Time.deltaTime);
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            _ship.AddAcceleration();
        }
        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            _ship.RemoveAcceleration();
        }
        if (Input.GetButtonDown("Fire1"))
        {
            _shoot.Shoot();
        }
    }
    public void OnCollisionEnter2D(Collision2D other)
    {
         _health.GetDamage();
    }
}

