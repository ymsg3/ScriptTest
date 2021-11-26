using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kadai : MonoBehaviour
{

    void Start()
    {
        Debug.Log("■ 課題です。");

        // 要素の個数が5の、int型の配列arrayを宣言して好きな値で初期化
        int[] array = { 1, 4, 10, 40, 20 };

        Debug.Log("---順番に表示します。---");

        // for文を使い、配列の各要素の値を順番に表示
        for (int i = 0; i < array.Length; i++)
        {
            Debug.Log(array[i]);
        }

        Debug.Log("---逆順に表示します。---");

        // for文を使い、配列の各要素の値を逆順に表示
        for (int i = array.Length - 1; i >= 0; i--)
        {
            Debug.Log(array[i]);
        }

    }

}
