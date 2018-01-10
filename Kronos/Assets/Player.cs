using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class Player : MonoBehaviour {

    [Tooltip("In ms^-1")][SerializeField] float xSpeed = 6f;
    [Tooltip("In m")][SerializeField] float xRange = 5f;

    [Tooltip("In ms^-1")] [SerializeField] float ySpeed = 6f;
    [Tooltip("In m")] [SerializeField] float yRange = 5f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        float xThrow = CrossPlatformInputManager.GetAxis("Horizontal");
        float xOffset = xThrow * xSpeed * Time.deltaTime;

        float yThrow = CrossPlatformInputManager.GetAxis("Vertical");
        float yOffset = yThrow * ySpeed * Time.deltaTime;

        float xPos = transform.localPosition.x + xOffset;
        float clampedXPos = Mathf.Clamp(xPos, -xRange, xRange);

        float yPos = transform.localPosition.y + yOffset;
        float clampedYPos = Mathf.Clamp(yPos, -yRange, yRange);

        transform.localPosition = new Vector3(clampedXPos, transform.localPosition.y, transform.localPosition.z);
        transform.localPosition = new Vector3(transform.localPosition.x, clampedYPos, transform.localPosition.z);
	}
}
