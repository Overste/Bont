using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using UnityEngine;

public class LoadingScreen : MonoBehaviour
{
    // Start is called before the first frame update
    async void Start()
    {
        await Task.Delay(TimeSpan.FromSeconds(3));
        SceneHandler.LoadNextScene();
    }

}
