using UnityEngine;
using TMPro;
using Unity.VisualScripting;

public class UIManager : MonoBehaviour
{
    [Header("Gameplay")]
    [SerializeField] private GameObject gameplayScreen;
    [SerializeField] private TextMeshProUGUI healthTextValue;
    [SerializeField] private TextMeshProUGUI scoreTextValue;
    [SerializeField] private TextMeshProUGUI highscoreTextValue;

    [Header("Game Over")]
    [SerializeField] private GameObject gameOverScreen;


    private Player localPlayer;
    private GameManager localGameManager;
    
    void Start()
    {
        localPlayer = FindAnyObjectByType<Player>();
        localGameManager = FindAnyObjectByType<GameManager>();

        
    }

    void Update()
    {
        healthTextValue.text = "HEALTH:" + localPlayer.healthModule.GetHealthPoints().ToString("F1") + "%";
        scoreTextValue.text = localGameManager.GetCurrentScore().ToString();

        
        highscoreTextValue.text = PlayerPrefs.GetInt("HighestScore").ToString();


        healthTextValue.color = Color.Lerp(Color.red, Color.green, localPlayer.healthModule.GetHealthPoints() / 100f);
    }

    public void ShowGameOver()
    {
        gameplayScreen.SetActive(false);
        gameOverScreen.SetActive(true);

    }
}
