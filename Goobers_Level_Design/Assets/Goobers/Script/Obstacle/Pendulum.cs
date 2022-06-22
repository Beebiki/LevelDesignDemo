using DG.Tweening;
using UnityEngine;
using Random = UnityEngine.Random;

public class Pendulum : MonoBehaviour
{
	
	[SerializeField] private Vector3 swingDirection;
	private float directionMultiplier =1;
	[SerializeField]
	private float swingDur;

	[SerializeField] private Ease swingEase;
	private Rigidbody rb;

	
	void Awake()
	{
		directionMultiplier = Mathf.Sign(Random.Range(-10, 10));
		rb = GetComponent<Rigidbody>();
		StartSwinging();
	}

	void StartSwinging()
	{
		rb.DORotate(swingDirection * directionMultiplier, swingDur).SetEase(swingEase).OnComplete(() =>
		{
			directionMultiplier *= -1f;
			StartSwinging();
		});

		
	}
	

   
}
