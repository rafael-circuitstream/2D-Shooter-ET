using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI healthTextValue;
    [SerializeField] private TextMeshProUGUI scoreTextValue;

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
    }
}
