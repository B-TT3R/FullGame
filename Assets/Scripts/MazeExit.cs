using UnityEngine;
using UnityEngine.SceneManagement;

public class MazeExit : MonoBehaviour

{
    // Name of the scene to load when player hits this wall
    [SerializeField] private string sceneToLoad = "WomensbathroomScene";

    private void OnTriggerEnter2D(Collider2D other)
    {
        // Check if the player touched the wall
        if (other.CompareTag("Player"))
        {
            // Load the specified scene
            SceneManager.LoadScene(sceneToLoad);
        }
    }
}

