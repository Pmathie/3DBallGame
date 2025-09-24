using UnityEngine;
using UnityEngine.SceneManagement;

public class KillCollider : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<BallMovement>())
        {
            // Genindlæser den nuværende scene hvis spilleren kolliderer med killcollideren
            ReloadCurrentScene();
        }
    }
    void ReloadCurrentScene()
    {
        Scene currentScene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(currentScene.name);
    }
}
