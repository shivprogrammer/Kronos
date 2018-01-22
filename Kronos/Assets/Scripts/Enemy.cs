using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

    [SerializeField] GameObject deathFX;
    [SerializeField] Transform parent;
    [SerializeField] int scorePerHit = 12;
    [SerializeField] int healthPoints = 100;

    ScoreBoard scoreBoard;

	// Use this for initialization
	void Start () {
        AddBoxCollider();
        scoreBoard = FindObjectOfType<ScoreBoard>();
	}

    private void AddBoxCollider() {
        Collider boxCollider = gameObject.AddComponent<BoxCollider>();
        boxCollider.isTrigger = false;
    }

    void OnParticleCollision(GameObject other) {
        scoreBoard.ScoreHit(scorePerHit);
        if (healthPoints <= 0) {
            KillEnemy();
        }

    }

    private void KillEnemy() {
        GameObject fx = Instantiate(deathFX, transform.position, Quaternion.identity);
        fx.transform.parent = parent;
        Destroy(gameObject);
    }
}
