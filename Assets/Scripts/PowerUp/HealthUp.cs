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
        StartCoroutine(Gone(7.5f));
    }

    void OnTriggerEnter(Collider other)
    {
        PowerUpCollected(other.gameObject);
    }

    void PowerUpCollected(GameObject gameObjectCollectingPowerUp)
    {
        playerHealth = gameObjectCollectingPowerUp.GetComponent<PlayerHealth>();
        
        if (gameObjectCollectingPowerUp.tag == "Player")
        {
            playerHealth.SetHealthAdjustment(healthBonus);

            Debug.Log("Health Up collected, Mantep hp+10");

            Destroy(gameObject);
        }
    }

    private IEnumerator Gone(float second)
    {
        yield return new WaitForSeconds(second);
        Destroy(gameObject);
    }
}
