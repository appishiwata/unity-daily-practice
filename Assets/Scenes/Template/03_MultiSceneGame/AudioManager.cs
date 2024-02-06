using System;
using UnityEngine;

namespace Scenes.Template._03_MultiSceneGame
{
    public class AudioManager : MonoBehaviour
    {
        // シングルトンとして扱うインスタンス
        public static AudioManager Instance = null;

        [SerializeField] AudioSource _buttonSound;
        [SerializeField] AudioSource _bgmSound;
        
        // シングルトンのセットアップ
        void Awake()
        {
            if (Instance == null){
                Instance = this;
                DontDestroyOnLoad(this.gameObject);
            }else{
                if (this != Instance){
                    Destroy(this.gameObject);
                }
            }
        }

        private void Start()
        {
            PlayBgmSound();
        }

        public void PlayButtonSound()
        {
            _buttonSound.Play();
        }
        
        public void PlayBgmSound()
        {
            _bgmSound.Play();
        }
    }
}