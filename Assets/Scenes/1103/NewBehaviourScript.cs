using UnityEngine;

namespace Scenes._1103
{
    public class NewBehaviourScript : MonoBehaviour
    {
        void Start()
        {
            // クラスのインスタンスを作成
            SampleClass sample = new SampleClass();

            // 値型のフィールドにアクセス
            sample.IntegerField = 10;
            sample.DoubleField = 3.14;
            sample.BooleanField = true;
            sample.CharField = 'A';

            // 列挙型フィールドにアクセス
            sample.Color = SampleClass.EnumField.Red;

            // 参照型のフィールドにアクセス
            sample.StringField = "Hello, World!";
            sample.ReferenceField = new SampleClass { IntegerField = 20 };

            // 構造体フィールドにアクセス
            sample.Point = new SampleClass.StructField { X = 5, Y = 7 };

            // 配列型のフィールドにアクセス
            sample.IntegerArray = new int[] { 1, 2, 3, 4, 5 };
            sample.StringArray = new string[] { "Hello", "World" };
            
            Debug.Log(sample);
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
        
        // ToStringメソッドのオーバーライドして、フィールドの値を文字列にして返す
        public override string ToString()
        {
            return $"IntegerField: {IntegerField}\nDoubleField: {DoubleField}\nBooleanField: {BooleanField}\nCharField: {CharField}\nColor: {Color}\nStringField: {StringField}\nReferenceField: {ReferenceField}\nPoint: {Point}\nIntegerArray: {IntegerArray}\nStringArray: {StringArray}";
        }
    }
}
