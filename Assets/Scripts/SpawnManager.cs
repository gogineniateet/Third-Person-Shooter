using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField] GameObject enemyPrefab;
    [SerializeField] float timer;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer = timer + Time.deltaTime;
        if(timer >= 5f)
        {
            Instantiate(enemyPrefab, this.transform.position, Quaternion.identity);
            timer = 0f;
        }
    }
}
