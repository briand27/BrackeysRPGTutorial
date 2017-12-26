using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class CharacterAnimator : MonoBehaviour {

    Animator animator;
    NavMeshAgent agent;

    const float locomotionAnimationSmoothTime = .1f;

	// Use this for initialization
	void Start () {
        agent = GetComponent<NavMeshAgent>();
        animator = GetComponentInChildren<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
        float speedPercentVal = agent.velocity.magnitude / agent.speed;
        animator.SetFloat("speedPercent", speedPercentVal, 
                          locomotionAnimationSmoothTime, Time.deltaTime);
	}
}
