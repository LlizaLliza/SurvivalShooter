using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameOverManager : MonoBehaviour
{
    public PlayerHealth playerHealth;
    public Text warningText;

    Animator anim;

    void Awake()
    {
        anim = GetComponent<Animator>();
    }
    
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
            Debug.Log("out apk");
        }
        if(Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }

        ShowGameOver();
    }

    void ShowGameOver()
    {
        if (playerHealth.currentHealth <= 0)
        {
            anim.SetTrigger("GameOver");
        }
    }

    public void ShowWarning(float enemyDistance)
    {
        warningText.text = string.Format("! {0} m", Mathf.RoundToInt(enemyDistance));
        anim.SetTrigger("Warning");
    }
}