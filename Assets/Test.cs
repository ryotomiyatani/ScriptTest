using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour {


	public class Boss {
		private int hp = 100;          // 体力
		private int power = 25; // 攻撃力
		private int mp = 5;

	        // 攻撃用の関数
					public void Attack() {
						Debug.Log( this.power + "のダメージを与えた" );
					}

					// 防御用の関数
					public  void Defence(int damage) {
						Debug.Log( damage+"のダメージを受けた" );
						// 残りhpを減らす
						this.hp -= damage;
					}
					//魔法攻撃用の関数
					public void Magic(){
						if(mp >= 5){
									mp -= 5;
									Debug.Log("魔法攻撃をした。残りMPは"+mp);
					}else{
						Debug.Log("MPが足りないため魔法が使えない。");
					}
				}
	}

	void Start () {
		int[] array = {12, 3, 60, 2, 77};
		for(int i = 0; i < array.Length ; i++ ){
			Debug.Log(array[i]);
		}
		for(int i = 4; i >= 0; i--){
			Debug.Log(array[i]);
		}

			// Bossクラスの変数を宣言してインスタンスを代入
			Boss lastboss = new Boss ();

			// 攻撃用の関数を呼び出す
			lastboss.Attack();
			// 防御用の関数を呼び出す
			lastboss.Defence(3);
			for(int i = 0; i <= 10;i++){
				// 魔法攻撃の関数を呼び出す
				lastboss.Magic();
			}
		}

	        // Update is called once per frame
	        void Update () {

	        }
	}
