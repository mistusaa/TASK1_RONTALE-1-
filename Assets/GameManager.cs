using UnityEngine;
using UnityEngine.SceneManagement;  // Allows scene loading

public class GameManager : MonoBehaviour
{
    // This function is called when the player touches the goal
    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Check if the player has touched the object tagged as "Goal"
        if (collision.gameObject.tag == "Goal")
        {
            Debug.Log("Goal reached!");  // Debug message to test if it detects the goal
            SceneManager.LoadScene("WinScene");  // Make sure "WinScene" is the correct name of your win scene
        }
        else if (collision.gameObject.tag == "Enemy")  // Optional: For loss condition
        {
            Debug.Log("Hit Enemy!");  // Debug message to test loss condition
            SceneManager.LoadScene("LossScene");  // Make sure "LossScene" is the correct name of your loss scene
        }
    }
}
