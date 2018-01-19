using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.SceneManagement;

public class CollisionHandler : MonoBehaviour {

    [Tooltip("In seconds")][SerializeField] float levelLoadDelay = 1f;
    [Tooltip("FX prefab on player")][SerializeField] GameObject deathfx;

    void OnTriggerEnter(Collider other) {
        StartDeathSequence();
        deathfx.SetActive(true);
    }

    private void StartDeathSequence() {
        SendMessage("OnPlayerDeath"); 
    }
}
