using UnityEngine;

namespace Scenes._1103
{
    public class NewBehaviourScript : MonoBehaviour
    {
        void Start()
        {
        }
    }
    
    public class SampleClass
    {
        // 値型
        public int IntegerField;
        public double DoubleField;
        public bool BooleanField;
        public char CharField;

        // 列挙型
        public enum EnumField { Red, Blue, Green }
        public EnumField Color;

        // 参照型
        public string StringField;
        public SampleClass ReferenceField;

        // 構造体
        public struct StructField
        {
            public int X;
            public int Y;
        }
        public StructField Point;

        // 配列型
        public int[] IntegerArray;
        public string[] StringArray;
    }
}
