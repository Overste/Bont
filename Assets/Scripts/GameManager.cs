using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Sprite PlayerSprite { get; set; }

    
    public string PlayerImagePath { get; set; }
    public int PlayersLife { get; set; }
    
    public static GameManager Instance { get; private set; }
    void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Debug.Log("destroy");
            Debug.Log(this);
            Destroy(gameObject); // when gameobject destroy scene
            // Destroy(this); // when gameobject destroy scene
        } else {
            Debug.Log("create");
            Debug.Log(this);
            DontDestroyOnLoad(gameObject);
            Instance = this;
            PlayersLife = 13;
        }
    }

    void Start()
    {

    }

    void Update()
    {
        
    }
}
