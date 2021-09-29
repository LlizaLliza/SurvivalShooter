using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedUp : MonoBehaviour
{
    public float speedMultiplier = 2.0f;
    private PlayerMovement playerMovement;

    private void Awake()
    {
        transform.Translate(0, 0.5f, 0);
        StartCoroutine(Gone(7.5f));
    }

    void OnTriggerEnter(Collider other)
    {
        PowerUpCollected(other.gameObject);
    }
    
    void PowerUpCollected(GameObject gameObjectCollectingPowerUp)
    {
        playerMovement = gameObjectCollectingPowerUp.GetComponent<PlayerMovement>();

        // We only care if we've been collected by the player
        if (gameObjectCollectingPowerUp.tag == "Player")
        {
            playerMovement.SetSpeedBoostOn(speedMultiplier);

            Debug.Log("Speed Up + 2, sip");

            Destroy(gameObject);
        }
    }

    private IEnumerator Gone(float second)
    {
        yield return new WaitForSeconds(second);
        Destroy(gameObject);
    }
}
