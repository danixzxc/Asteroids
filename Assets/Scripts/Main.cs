using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour
{
   private PlayerController _playerController;
    void Start()
    {
        _playerController.Start();
    }

    void Update()
    {
        _playerController.Update();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        _playerController.OnCollisionEnter2D(collision);
    }
}
