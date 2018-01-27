using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathAndRespawning : MonoBehaviour {

    private bool death = false;
    private Vector3 spawnPosition;
    private IEnumerator coroutine;
    private GameObject deathLocation;

	void Start () {
        spawnPosition = transform.position;
        deathLocation = GameObject.FindWithTag("DeathLocation");
	}
	
	void Update () {

	}

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Monster")
        {
            Debug.Log("Collision occured: initiate death sequence");
            death = true;
            Debug.Log(death);
            coroutine = Respawn();
            StartCoroutine(coroutine);
            //_respawn();
        }
    }

    /*
    private void _respawn()
    {
        if (death)
        {
            transform.position = spawnPosition;
            death = false;
        }
    }
    */

    private IEnumerator Respawn()
    {
        if (death)
        {
            yield return new WaitForSeconds(3);
            transform.position = deathLocation.transform.position;
            death = false;
        }
    }
}
