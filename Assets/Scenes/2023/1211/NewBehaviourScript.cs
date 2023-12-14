using UnityEngine;

namespace Scenes._1211
{
    public class NewBehaviourScript : MonoBehaviour
    {
        void Start()
        {
            // Timeクラス : 時間に関する情報を提供するクラス
            // サンプル
            // deltaTime : 前フレームからの経過時間
            Debug.Log(Time.deltaTime);
            
            // fixedDeltaTime : 固定フレームレートの場合の経過時間
            Debug.Log(Time.fixedDeltaTime);
            
            // fixedTime : 固定フレームレートの場合の経過時間
            Debug.Log(Time.fixedTime);
            
            // frameCount : 現在のフレーム数
            Debug.Log(Time.frameCount);
            
            // time : ゲーム開始からの経過時間
            Debug.Log(Time.time);
            
            // timeScale : ゲームの時間の進行速度
            Debug.Log(Time.timeScale);
        }
    }
}
