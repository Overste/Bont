using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Intro screen
    // CharacterSelection
    private BonteCastle bonteCastle;
    private BonteBos bonteBos;
    private BonteBosChallenge bonteBosChallenge;
    
    void Start()
    {
        bonteCastle = FindObjectOfType<BonteCastle>();
        // bonteBos = FindObjectOfType<BonteBos>();
        // bonteBosChallenge = FindObjectOfType<BonteBosChallenge>();
        
        bonteCastle.gameObject.SetActive(true);
        // bonteBos.gameObject.SetActive(false);
        // bonteBosChallenge.gameObject.SetActive(false);
    }

    void Update()
    {
        
    }
}
