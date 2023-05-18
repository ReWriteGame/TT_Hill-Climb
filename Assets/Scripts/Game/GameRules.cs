using Modules.Score;
using Modules.Score.Visual;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameRules : MonoBehaviour
{
    [SerializeField] private ScoreCounterVisualText scoreCounterVisualText;
    [SerializeField] private ScoreCounter scoreCounter;

    private void Start()
    {
        scoreCounterVisualText.SetScoreCounter(scoreCounter);
    }

    public void AddValue(int value)
    {
        scoreCounter.IncreaseValue(value);
    }
}
