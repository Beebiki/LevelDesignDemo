using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSpawner : MonoBehaviour
{
    [SerializeField] int ballIndex = 0;
    [SerializeField]Transform SpawnPoint;
    [SerializeField] float ballSpawningTime = 4;
    [SerializeField] Vector3 ballForceDir;
    [SerializeField] float ballForce;

    Rigidbody rb;
    private int differentIndex;
    private ObjectPooler OP;


    private void Start()
    {
        OP = ObjectPooler.SharedInstance;       
    }

    void Update()
    {
        StartCoroutine(BallSpawnTimer());
    }

    IEnumerator BallSpawnTimer()
    {
        yield return new WaitForSeconds(ballSpawningTime);
        GameObject ball = OP.GetPooledObject(ballIndex);
        //int RandomInt = Random.Range(0, SpawnPoint.Length);
        if(ball != null)
        {
            ball.SetActive(true);
            ball.transform.position = SpawnPoint.transform.position;
            rb = ball.GetComponent<Rigidbody>();
            rb.AddForce(ballForceDir * ballForce, ForceMode.Impulse);
        }
       

    }
}
