using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class Fruit : MonoBehaviour
{
    public GameObject slicedFruitPrefab;

    void Start()
    {
    }

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

        Destroy(gameObject);
    }
}