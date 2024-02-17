using System.Collections.Generic;
using DG.Tweening;
using TMPro;
using UnityEngine;

namespace Scenes.Demo._03_SimplePuzzleGame
{
    public class NewBehaviourScript : MonoBehaviour
    {
        /*
         * 3Dプロジェクトの場合は3Dカメラなのでうまく判定されない。
         * カメラのProjectionをOrthographicに変更してうまくいった。
         */
        
        [SerializeField] List<GameObject> _pieces;
        [SerializeField] int _shuffleCount;
        [SerializeField] GameObject _clearPanel;
        [SerializeField] TextMeshProUGUI _clearText;
        readonly List<Vector2> _startPositions = new();
        GameObject _selectPiece;

        void Start()
        {
            // 初期位置保存
            foreach (var item in _pieces)
            {
                Vector2 position = item.transform.position;
                _startPositions.Add(position);
            }

            // ピース並び替え
            for (int i = 0; i < _shuffleCount; i++)
            {
                int indexA = Random.Range(0, _pieces.Count);
                int indexB = Random.Range(0, _pieces.Count);

                Vector2 tmp = _pieces[indexA].transform.position;
                _pieces[indexA].transform.position = _pieces[indexB].transform.position;
                _pieces[indexB].transform.position = tmp;
            }
        }
        
        void Update()
        {
            if(Input.GetMouseButtonUp(0))
            {
                // タッチした場所にレイを飛ばす
                Vector2 worldPosition = Camera.main!.ScreenToWorldPoint(Input.mousePosition);
                // 第2引数はレイがどの方向に進むか（zeroにすると指定された点）
                RaycastHit2D hit2d = Physics2D.Raycast(worldPosition, Vector2.zero);

                if(hit2d)
                {
                    GameObject hitPiece = hit2d.collider.gameObject;

                    // 1枚目選択
                    if(_selectPiece == null)
                    {
                        _selectPiece = hitPiece;
                    }
                    // 2枚目は位置を入れかえて、選択状態を解除
                    else
                    {
                        Vector2 position = hitPiece.transform.position;
                        hitPiece.transform.position = _selectPiece.transform.position;
                        _selectPiece.transform.position = position;
                        _selectPiece = null;
                        
                        if(IsClear())
                        {
                            Debug.Log("クリア！");
                            _clearPanel.SetActive(true);
                            _clearText.DOScale(2f, 0.5f);
                        }
                    }
                }
            }
        }
        
        bool IsClear()
        {
            for (int i = 0; i < _pieces.Count; i++)
            {
                Vector2 position = _pieces[i].transform.position;
                if (_startPositions[i] != position)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
