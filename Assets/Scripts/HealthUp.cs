using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthUp : MonoBehaviour
{
    public int healthBonus = 10;
    private PlayerHealth playerHealth;

    private void Awake()
    {
        transform.Translate(0, 0.5f, 0);
    }

    void OnTriggerEnter(Collider other)
    {
        PowerUpCollected(other.gameObject);
    }

    private void Update()
    {
        transform.Rotate(new Vector3(0, 50, 0) * Time.deltaTime);
    }

    void PowerUpCollected(GameObject gameObjectCollectingPowerUp)
    {
        playerHealth = gameObjectCollectingPowerUp.GetComponent<PlayerHealth>();

        // We only care if we've been collected by the player
        if (gameObjectCollectingPowerUp.tag == "Player")
        {
            playerHealth.SetHealthAdjustment(healthBonus);

            Debug.Log("Health Up collected, Mantep hp+10");

            Destroy(gameObject);
        }
    }
}
