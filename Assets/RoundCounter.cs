using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RoundCounter : MonoBehaviour
{
    public Text roundCounterText;
    private int currentRound = 1;
    private float timeBetweenRounds = 10f;
    private float timeSinceLastRound = 0f;
    private int maxRounds = 4;

    // Start is called before the first frame update
    void Start()
    {
        UpdateRoundCounter();
    }

    // Update is called once per frame
    void Update()
    {
        timeSinceLastRound += Time.deltaTime;

        if (timeSinceLastRound >= timeBetweenRounds && currentRound < maxRounds) {
            currentRound++;
            UpdateRoundCounter();
            timeSinceLastRound = 0f;
        }
    }

    void UpdateRoundCounter() {
        roundCounterText.text = "Round: " + currentRound;
    }
}
