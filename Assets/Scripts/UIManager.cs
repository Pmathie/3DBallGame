using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public TextMeshProUGUI coinText;
    public static UIManager Instance;
    public GameObject winScreen;
    public TextMeshProUGUI winText;

    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
            return;
        }
        Instance = this;
    }
    public void UpdateCoinCount(int numberOfCoins) 
    {
        coinText.text = "Coins:" + numberOfCoins;

    }
    public void UpdateWinScreenText(int numberOfCoins)
    {
        winText.text = "You collected " + numberOfCoins + " coins!";
    }
    public void EnableWinScreen() // Metode til at aktivere win screen
    {
        winScreen.SetActive(true);
        
        Time.timeScale = 0f; // Stopper tiden i spillet
    }
    public void ReloadCurrentScene()
    {
        Scene currentScene = SceneManager.GetActiveScene();
        Time.timeScale = 1f; // Sørger for at tiden går normalt igen når scenen genindlæses;
        SceneManager.LoadScene(currentScene.name);
    }
}
