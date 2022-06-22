using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
public class Patroling : MonoBehaviour
{
    [SerializeField] Vector3 moveDir;
    [SerializeField] Ease setEase;
    [SerializeField] float movDuration;
    Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.DOMove(rb.position + moveDir, movDuration).SetLoops(-1, LoopType.Yoyo).SetEase(setEase);
    }
   
}
