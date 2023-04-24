using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner_soldier : MonoBehaviour
{
        public GameObject soldier;
        public float spawnTime = 1f;
        public float limit1 = 0.1f;
        public float limit2 = 0.4f;
        

        void Start()
        {
            InvokeRepeating("Spawn", spawnTime, spawnTime);
        }
    
        void Spawn()
        {
            float distance = Random.Range(limit1, limit2);
            Vector3 spawnPosition = transform.position + transform.forward * distance + new Vector3(0.1f, 0f, 0f);
            Instantiate(soldier, spawnPosition, transform.rotation);
        }
}
