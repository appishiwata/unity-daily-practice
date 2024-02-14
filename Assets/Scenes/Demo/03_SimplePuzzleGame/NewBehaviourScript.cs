using System.Collections.Generic;
using UnityEngine;

namespace Scenes.Demo._03_SimplePuzzleGame
{
    public class NewBehaviourScript : MonoBehaviour
    {
        // 全ピース
        [SerializeField] List<GameObject> pieces;
        // ピースのシャッフル回数
        [SerializeField] int shuffleCount;
        // 初期位置
        List<Vector2> startPositions;
        // 選択しているピース
        GameObject selectPiece;

        // Start is called before the first frame update
        void Start()
        {
            // 初期位置保存
            startPositions = new List<Vector2>();

            foreach (var item in pieces)
            {
                Vector2 position = item.transform.position;
                startPositions.Add(position);
            }

            // ピース並び替え
            for (int i = 0; i < shuffleCount; i++)
            {
                int indexA = Random.Range(0, pieces.Count);
                int indexB = Random.Range(0, pieces.Count);

                Vector2 tmp = pieces[indexA].transform.position;
                pieces[indexA].transform.position = pieces[indexB].transform.position;
                pieces[indexB].transform.position = tmp;
            }
        }
        
        void Update()
        {
            // ピースを入れ換える
            if(Input.GetMouseButtonUp(0))
            {
                // タッチした場所にレイを飛ばす
                Vector2 worldPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                // 第2引数はレイがどの方向に進むか（zeroにすると指定された点）
                RaycastHit2D hit2d = Physics2D.Raycast(worldPosition, Vector2.zero);

                print("mousePosition: "+Input.mousePosition);
                print("worldPosition: "+worldPosition);

                // 当たり判定が合った場合
                if(hit2d)
                {
                    // 当たり判定があったオブジェクトを取得
                    GameObject hitPiece = hit2d.collider.gameObject;

                    Debug.Log("当たり判定があったピース "+hitPiece);
                }
            }
        }
    }
}
