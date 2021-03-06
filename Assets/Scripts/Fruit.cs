using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;
using Random = UnityEngine.Random;

public class Fruit : MonoBehaviour
{
    public GameObject slicedFruitPrefab;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            CreateSlicedFruit();
    }

    public void CreateSlicedFruit()
    {
        GameObject slicedInstance = Instantiate(slicedFruitPrefab, transform.position, transform.rotation);

        Rigidbody[] rigidbodiesOnSliced = slicedInstance.transform.GetComponentsInChildren<Rigidbody>();

        foreach (Rigidbody rigidbody in rigidbodiesOnSliced)
        {
            rigidbody.transform.rotation = Random.rotation;
            rigidbody.AddExplosionForce(Random.Range(500, 1000), transform.position, 5f);
        }

        Destroy(slicedInstance, 5f);
        Destroy(gameObject);
    }

    private void OnTriggerEnter(Collider other)
    {
        Blade blade = other.GetComponent<Blade>();
        if (!blade)
        {
            return;
        }
        else
        {
            CreateSlicedFruit();
        }
    }
}