using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SpawnCubes : MonoBehaviour
{
    public float delay = 0.2f;
    public GameObject cube;
    private int amount;

    private void exit()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    void Start()
    {
        amount = 0;
        InvokeRepeating("Spawn", delay, delay);
    }

    void Spawn()
    {
        Instantiate(cube, new Vector3(Random.Range(-9, 9), Random.Range(5,15), Random.Range(5, 25)), Quaternion.identity);
        amount++;
    }

    void Update()
    {   
        if (amount >= 250)
        {
            CancelInvoke();
            exit();
        }
    }

}
