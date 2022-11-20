using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerView : MonoBehaviour
{
    [SerializeField] public float speed;
    [SerializeField] public float acceleration;
    [SerializeField] public int maxHealth;
    [SerializeField] public Rigidbody2D bullet;
    [SerializeField] public Transform barrel;
    [SerializeField] public Transform shipTransform;
    [SerializeField] public float force;
}
