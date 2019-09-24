using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using System;
//using UnityEngine.UI;
//sing UnityEngine.SceneManagement;

namespace Com.MyCompany.MyGame
{
    public class TerreinController : MonoBehaviour
    {
        
        
        void Start()
        {
            
        }


        void Update()
        {
            // transformを取得
            Transform myTransform = this.transform;
            // 現在の座標からのxyz を1ずつ加算して移動
            myTransform.Translate (0.0f, 0.0f,  0.05f);
        }

    }
}