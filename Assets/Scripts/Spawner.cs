using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject _fruitToSpawn;

    public Transform[] _spawnPlaces;

    public float minWait = 0.3f;
    public float maxWait = 1f;

    public float minForce = 12;
    public float maxForce = 17;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnFruits());
    }

    // Update is called once per frame
    void Update()
    {
    }

    private IEnumerator SpawnFruits()
    {
        while (true)
        {
            yield return new WaitForSeconds(Random.Range(minWait, maxWait));

            // After the delay
            Transform customTransform = _spawnPlaces[Random.Range(0, _spawnPlaces.Length)];
            GameObject fruit = Instantiate(_fruitToSpawn, customTransform.position, customTransform.rotation);

            fruit.GetComponent<Rigidbody2D>().AddForce(customTransform.transform.up * Random.Range(minForce, maxForce),
                ForceMode2D.Impulse);
            Debug.Log("Fruit Spawned");
            Destroy(fruit, 5);
        }
    }
}