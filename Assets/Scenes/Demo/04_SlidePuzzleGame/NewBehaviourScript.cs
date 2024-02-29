using System.Collections.Generic;
using UnityEngine;

namespace Scenes.Demo._04_SlidePuzzleGame
{
    public class NewBehaviourScript : MonoBehaviour
    {
        // ピース
        [SerializeField] List<GameObject> pieces;
        // ゲームクリア時に表示されるボタン
        [SerializeField] GameObject buttonRetry;
        // シャッフル回数
        [SerializeField] int shuffleCount;

        // 初期位置
        List<Vector2> startPositions;

        // Start is called before the first frame update
        void Start()
        {
            // 0番と隣接するピース
            List<GameObject> movablePieces = new List<GameObject>();

            // 0番と隣接するピースをリストに追加
            foreach (var item in pieces)
            {
                if(GetEmptyPiece(item) != null)
                {
                    movablePieces.Add(item);
                }    
            }

            // 隣接するピースをランダムで入れかえる
            int rnd = Random.Range(0, movablePieces.Count);
            GameObject piece = movablePieces[rnd];
            SwapPiece(piece, pieces[0]);

            // ボタン非表示
            buttonRetry.SetActive(false);
        }

        // Update is called once per frame
        void Update()
        {
            // タッチ処理
            if(Input.GetMouseButtonUp(0))
            {
                // スクリーン座標からワールド座標に変換
                Vector2 worldPoint = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                // レイを飛ばす
                RaycastHit2D hit2d = Physics2D.Raycast(worldPoint, Vector2.zero);

                // 当たり判定があった
                if(hit2d)
                {
                    // ヒットしたゲームオブジェクト
                    GameObject hitPiece = hit2d.collider.gameObject;
                    // 0番のピースと隣接していればデータが入る
                    GameObject emptyPiece = GetEmptyPiece(hitPiece);
                    // 選んだピースと0番のピースを入れかえる
                    SwapPiece(hitPiece, emptyPiece);
                }
            }
        }

        // 引数のピースが0番のピースと隣接していたら0番のピースを返す
        GameObject GetEmptyPiece(GameObject piece)
        {
            // 2点間の距離を代入
            float dist =
                Vector2.Distance(piece.transform.position, pieces[0].transform.position);

            // 距離が1なら0番のピースを返す（2個以上離れていたり、斜めの場合は1より大きい距離になる）
            if (dist == 1)
            {
                return pieces[0];
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
    }
}
