using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private float _minX;
    [SerializeField] private float _maxX;
    [SerializeField] private float _minZ;
    [SerializeField] private float _maxZ;
    [SerializeField] private float yPosition;

    private Vector3 targetPosition;

    private void Start()
    {
        GetRandomTarget();
    }

    private void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, targetPosition, _speed * Time.deltaTime);
        if (transform.position == targetPosition)
        {
            GetRandomTarget();
        }
    }

    private void GetRandomTarget()
    {
        float randomX = UnityEngine.Random.Range(_minX, _maxX);
        float randomZ = UnityEngine.Random.Range(_minZ, _maxZ);
        targetPosition = new Vector3(randomX, yPosition, randomZ);
    }
}
