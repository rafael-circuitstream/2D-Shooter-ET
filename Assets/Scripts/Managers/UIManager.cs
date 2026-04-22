using UnityEngine;
using TMPro;
using Unity.VisualScripting;

public class UIManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI healthTextValue;
    [SerializeField] private TextMeshProUGUI scoreTextValue;
    [SerializeField] private TextMeshProUGUI highscoreTextValue;

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
}
