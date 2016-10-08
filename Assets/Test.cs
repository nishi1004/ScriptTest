using UnityEngine;
using System.Collections;
public class Boss
{
    private int hp = 100;          // 体力
    private int power = 25; // 攻撃力
    private int mp = 53; //魔力

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

    public void Magic()
    {
        if (mp >= 5)
        {
            mp -= 5;
            Debug.Log("魔法攻撃をした。残りMPは" + mp);
        }else
        {
            Debug.Log("MPが足りないため魔法が使えない。");
        }
    }

}

public class Test : MonoBehaviour
{

    void Start()
    {
        //課題
        //配列を宣言し、初期化
        int[] array = { 1, 2, 3, 4, 5 };

        //順番に表示
        for(int i = 0; i < array.Length; i++)
        {
            Debug.Log(array[i]);
        }
        //逆順に表示
        for (int i = 0; i < array.Length; i++) {
            Debug.Log(array[array.Length - i - 1]);
                }


        // Bossクラスの変数を宣言してインスタンスを代入
        Boss lastboss = new Boss();

        // 攻撃用の関数を呼び出す
        lastboss.Attack();
        // 防御用の関数を呼び出す
        lastboss.Defence(3);

        //Magicを11回実行
        for(int i=0; i < 11; i++)
        {
            lastboss.Magic();
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}