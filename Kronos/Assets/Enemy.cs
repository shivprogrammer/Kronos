using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

    [SerializeField] GameObject deathFx;

	// Use this for initialization
	void Start () {
        Collider boxCollider = gameObject.AddComponent<BoxCollider>();
        boxCollider.isTrigger = false;
	}

    void OnParticleCollision(GameObject other) {
        Destroy(gameObject);
    }
}
