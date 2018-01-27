using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MonsterPathfinding : MonoBehaviour {

    public float moveSpeed = 3f;
    public float rotationSpeed = 3f;

    private Transform m_Transform;
    private Transform target;
    private NavMeshAgent agent;
    private Vector3 destination;

    private void Awake()
    {
        m_Transform = gameObject.transform;
    }

    void Start ()
    {
        target = GameObject.FindWithTag("Player").transform;
        if (!target)
        {
            Debug.Log("YOU FORGOT TO ADD THE PLAYER OBJECT");
        }

        agent = GetComponent<NavMeshAgent>();
        destination = agent.destination;
	}
	
	void Update ()
    {
        destination = target.position;
        agent.destination = destination;
        /*
        m_Transform.rotation = Quaternion.Slerp(m_Transform.rotation,
            Quaternion.LookRotation(target.position - m_Transform.position),
            rotationSpeed * Time.deltaTime);

        m_Transform.position += m_Transform.forward * moveSpeed * Time.deltaTime;
	    */
    }
}
