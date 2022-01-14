using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public Image PlayerImage { get; set; }
    public int PlayersLife { get; set; }
    
    public static Player Instance { get; private set; }

    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            // Destroy(gameObject);
        } else {
            // Debug.Log(this.PlayerImage);
            DontDestroyOnLoad(gameObject);
            Instance = this;
        }
    }
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    // public static Player Instance => _instance;
    //
    // private void Awake()
    // {
    //     if (_instance != null && _instance != this)
    //     {
    //         Debug.Log("Destroy");
    //         // Destroy(gameObject);
    //         DestroyImmediate(this);
    //         throw new System.Exception("There shall only be one");
    //     } else {
    //         Debug.Log("Is set");
    //         Debug.Log(this);
    //         _instance = this;
    //     }
    // }
    //
    // public static Player GetInstance()
    // {
    //     return _instance;
    // }
    //
    // void OnDestroy() { if (this == _instance) { _instance = null; } }
    
    
    // public Image playerImage;
    // public int playersLife;
    // public int playersKeys;
    // public string dummy = "dummy tekst";

    // public static Player Instance { 
    //     get   {
    //         if (!playerInstance || playerInstance == null) {
    //             playerInstance = FindObjectOfType<Player>();
    //         } return playerInstance;
    //     } 
    // }
    //
    
    // public static Player Instance { get { return playerInstance; } }
    
    
    // private void Awake()
    // {
    //     if (playerInstance != null && playerInstance != this)
    //     {
    //         Destroy(gameObject);
    //     } else {
    //         playerInstance = this;
    //     }
    // }
    //
    //
    // private static Player instance;
    // public static Player Instance {
    //     get {
    //         if (instance == null) {
    //             instance = FindObjectOfType<Player> ();
    //             if (instance == null) {
    //                 GameObject obj = new GameObject ();
    //                 obj.name = typeof(Player).Name;
    //                 instance = obj.AddComponent<Player>();
    //             }
    //         }
    //         return instance;
    //     }
    // }
    //
    // public virtual void Awake ()
    // {
    //     if (instance == null) {
    //         instance = this as Player;
    //         DontDestroyOnLoad (this.gameObject);
    //     } else {
    //         Destroy (gameObject);
    //     }
    // }

    // public void SetPlayerImage(Image image)
    // {
    //     Debug.Log(image.GetType());
    //     
    //     PlayerImage = image;
    //     Debug.Log(PlayerImage);
    // }
    //
    // public Image GetPlayerImage()
    // {
    //     return PlayerImage;
    // }
}
