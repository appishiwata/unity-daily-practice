using System;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

namespace Scenes.Template._03_MultiSceneGame
{
    public class AnimationManager : MonoBehaviour
    {
        public static AnimationManager Instance = null;
        
        [SerializeField] Image _fade;
        
        void Awake()
        {
            if (Instance == null)
            {
                Instance = this;
                DontDestroyOnLoad(this.gameObject);
            }
            else
            {
                if (this != Instance)
                {
                    Destroy(this.gameObject);
                }
            }
        }
        
        public void ShowFade(Action onComplete)
        {
            _fade.DOFade(1f, 0.5f)
                .OnComplete(() =>
                {
                    onComplete();
                    _fade.DOFade(0f, 0.5f);
                });
        }
    }
}
