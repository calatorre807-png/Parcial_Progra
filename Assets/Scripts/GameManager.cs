using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static int score;
    public TextMeshProUGUI scoreText;

    void Start() => score = 0;
    void Update() { if (scoreText) scoreText.text = "Meteoros: " + score; }
}
