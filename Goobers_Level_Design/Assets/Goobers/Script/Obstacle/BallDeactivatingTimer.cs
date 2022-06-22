using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallDeactivatingTimer : MonoBehaviour
{
    [SerializeField] float ballDeactivatingTimer = 5f;
    void Update()
    {
        StartCoroutine(BallDeactivator());
    }

    IEnumerator BallDeactivator()
    {
        yield return new WaitForSeconds(ballDeactivatingTimer);
        this.gameObject.SetActive(false);
    }
}
