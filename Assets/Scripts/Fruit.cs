using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class Fruit : MonoBehaviour
{
    public GameObject slicedFruitPrefab;


    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void CreateSlicedFruit()
    {
        Instantiate(slicedFruitPrefab, transform.position, transform.rotation);
        Destroy(gameObject);
    }
}