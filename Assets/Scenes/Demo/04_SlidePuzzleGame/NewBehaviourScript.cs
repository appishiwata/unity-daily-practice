using System.Collections.Generic;
using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Scenes.Demo._04_SlidePuzzleGame
{
    public class NewBehaviourScript : MonoBehaviour
    {
        [SerializeField] List<GameObject> _pieces;
        [SerializeField] GameObject _buttonRetry;
        [SerializeField] int _shuffleCount;
        [SerializeField] GameObject _clearPanel;
        [SerializeField] TextMeshProUGUI _clearText;

        private readonly List<Vector2> _startPositions = new();

        void Start()
        {
            // 初期位置を保存
            foreach (var item in _pieces)
            {
                _startPositions.Add(item.transform.position);
            }

            // 指定回数シャッフル
            for (int i = 0; i < _shuffleCount; i++)
            {
                // 0番と隣接するピース
                List<GameObject> movablePieces = new List<GameObject>();

                // 0番と隣接するピースをリストに追加
                foreach (var item in _pieces)
                {
                    if (GetEmptyPiece(item) != null)
                    {
                        movablePieces.Add(item);
                    }
                }

                // 隣接するピースをランダムで入れかえる
                int rnd = Random.Range(0, movablePieces.Count);
                GameObject piece = movablePieces[rnd];
                SwapPiece(piece, _pieces[0]);
            }

            // ボタン非表示
            _buttonRetry.SetActive(false);
        }

        void Update()
        {
            if(Input.GetMouseButtonUp(0))
            {
                // スクリーン座標からワールド座標に変換
                Vector2 worldPoint = Camera.main!.ScreenToWorldPoint(Input.mousePosition);
                // レイを飛ばす
                RaycastHit2D hit2d = Physics2D.Raycast(worldPoint, Vector2.zero);

                if(hit2d)
                {
                    // ヒットしたゲームオブジェクト
                    GameObject hitPiece = hit2d.collider.gameObject;
                    // 0番のピースと隣接していればデータが入る
                    GameObject emptyPiece = GetEmptyPiece(hitPiece);
                    // 選んだピースと0番のピースを入れかえる
                    SwapPiece(hitPiece, emptyPiece);

                    // クリア判定
                    _buttonRetry.SetActive(true);

                    // 正解の位置と違うピースを探す
                    for (int i = 0; i < _pieces.Count; i++)
                    {
                        // 現在のポジション
                        Vector2 position = _pieces[i].transform.position;
                        // 初期位置と違ったらボタンを非表示
                        if(position != _startPositions[i])
                        {
                            _buttonRetry.SetActive(false);
                        }
                    }

                    // クリア状態
                    if(_buttonRetry.activeSelf)
                    {
                        Debug.Log("クリア！！");
                        _clearPanel.SetActive(true);
                        _clearText.DOScale(2f, 0.5f);
                    }
                }
            }
        }

        // 引数のピースが0番のピースと隣接していたら0番のピースを返す
        GameObject GetEmptyPiece(GameObject piece)
        {
            // 2点間の距離を代入
            float dist =
                Vector2.Distance(piece.transform.position, _pieces[0].transform.position);

            // 距離が1なら0番のピースを返す（2個以上離れていたり、斜めの場合は1より大きい距離になる）
            if (dist == 1)
            {
                return _pieces[0];
            }

            return null;
        }

        // 2つのピースの位置を入れかえる
        void SwapPiece(GameObject pieceA, GameObject pieceB)
        {
            // どちらかがnullなら処理をしない
            if (pieceA == null || pieceB == null)
            {
                return;
            }

            // AとBのポジションを入れかえる
            Vector2 position = pieceA.transform.position;
            pieceA.transform.position = pieceB.transform.position;
            pieceB.transform.position = position;
        }
        
        // リトライボタン
        public void OnClickRetry()
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
