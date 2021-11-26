using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HattenKadai : MonoBehaviour
{

    // Lesson4で作成したプロジェクトScriptTestに追記しましょう

    // Bossクラスについて下記の条件を満たしてください

    // Lesson4で作成したBossクラスをもとに作成してください
    // int型の変数mpを宣言し、53で初期化してください
    // mpを消費して魔法攻撃をするMagic関数を作ってください
    // Magic関数内でmpを5以上の場合は5減らし、コンソールに 魔法攻撃をした。残りMPは〇〇。 と表示してください
    // mpが足りない場合、MPが足りないため、魔法が使えない。 と表示してください

    public class Boss
    {
        private int hp = 100; // 体力
        private int power = 25; // 攻撃力
        private int mp = 53; // MP

        // 攻撃用の関数
        public void Attack()
        {
            Debug.Log(this.power + "のダメージを与えた");
        }

        // 防御用の関数
        public void Defence(int damage)
        {
            Debug.Log(damage + "のダメージを受けた");
            // 残りhpを減らす
            this.hp -= damage;
        }

        // 魔法攻撃用の関数
        public void Magic()
        {
            int usage = 5; // 一回分の消費量

            if (usage <= this.mp)
            {
                // 残りmpが足りる場合、mpを減らして、メッセージを表示
                this.mp -= usage;
                Debug.Log("魔法攻撃をした。残りMPは" + this.mp + "。");
            }
            else
            {
                // 残りmpが足りない場合、メッセージを表示
                Debug.Log("MPが足りないため、魔法が使えない。");
            }
        }

    }

    // Start関数で下記の条件を満たしてください

    // Magic関数を呼び出して、魔法を使ってください
    // Magic関数を10回使った後に、さらにMagic関数を呼び出すと、
    // mpが足りないメッセージを表示することを確認してください

    void Start()
    {
        Debug.Log("■ 発展課題です。");

        Boss boss = new Boss();

        Debug.Log("---10回呼び出します。---");

        // Magicを10回呼び出す
        for (int i = 0; i < 10; i++)
        {
            boss.Magic();
        }

        Debug.Log("---さらに呼び出します。---");

        // さらに呼び出す
        boss.Magic();

    }

}
