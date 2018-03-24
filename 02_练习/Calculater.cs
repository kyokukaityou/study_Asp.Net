using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp
{
    /// <summary>
    /// 计算器输入框
    /// </summary>
    class Calculater
    {
        /// <summary>
        /// 電卓起動
        /// </summary>
        public void Start() {

            bool start = true;
            while (start == true)
            {

                Console.Clear();
                // 電卓起動
                if (this.CalculaterStart() == false) {
                   return;
                }
                Console.Clear();
                Console.WriteLine("計算を続けると,tを入力してください。");
                string tmp = Console.ReadLine();
                if (!tmp.Equals("t"))
                {
                    // 閉じる
                    start = false;
                }
            }
        
        }
        /// <summary>
        /// 電卓演算
        /// </summary>
        private bool CalculaterStart()
        {
            string[] resultTxt = { "加法", "減算", "乗法", "除法" };
            string[] resultCode = { "+", "-", "*", "/" };
            int startA = 0, endB = 0, result = 0;
            // 0:加法 1:減算 2:乗法 3:除法 9:閉じる
            string resultCnt = "";

            Console.WriteLine("###################################");
            Console.WriteLine("-----------    電卓    ------------");
            Console.WriteLine("###################################");

            Console.WriteLine("演算を選択してください");
            Console.WriteLine("0:加法 1:減算 2:乗法 3:除法 9:閉じる");

       
            // 入力チェックフラグ
            bool checkC = false;

            while (checkC == false)
            {
                resultCnt = Console.ReadLine();

                // 入力内容のチェック（0^3以外の場合、再入力）
                if (!resultCnt.Equals("0") && !resultCnt.Equals("1")
                    && !resultCnt.Equals("2") && !resultCnt.Equals("3"))
                {
                    // 9の場合、閉じる
                    if (resultCnt.Equals("9"))
                    {
                        return false;
                    }

                    Console.WriteLine("入力の項目がありません。「0～3」を選択ください。");
                }
                else
                {
                    // 入力正確
                    checkC = true;
                }
            }

            Console.WriteLine("");
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("次に" + resultTxt[Convert.ToInt32(resultCnt)] + "演算を行う( A " + resultCode[Convert.ToInt32(resultCnt)] + " B = ?)");
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("項目Aを入力ください");
            checkC = false;
            while (checkC == false)
            {
                string tmp = Console.ReadLine();
                // 入力内容のチェック
                if (!int.TryParse(tmp, out startA))
                {
                    Console.WriteLine("数字を入力ください。");
                }
                else
                {
                    // 入力正確
                    checkC = true;
                }
            }

            Console.WriteLine("項目Bを入力ください");
            checkC = false;
            while (checkC == false)
            {
                string tmp = Console.ReadLine();
                // 入力内容のチェック
                if (!int.TryParse(tmp, out endB))
                {
                    Console.WriteLine("数字を入力ください。");
                }
                else
                {
                    // 入力正確
                    checkC = true;
                }
            }

            Console.Write("演算中.");
            // 演算
            // 0:加法 1:減算 2:乗法 3:除法 
            switch (resultCnt)
            {
                case "0":
                    result = startA + endB;
                    break;
                case "1":
                    result = startA - endB;
                    break;
                case "2":
                    result = startA * endB;
                    break;
                case "3":
                    result = startA / endB;
                    break;
            }

            // 処理中…
            for (int i = 0; i < 10; i++)
            {
                Thread.Sleep(200);
                Console.Write(".");
            }
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("演算結果");
            Console.WriteLine(startA + resultCode[Convert.ToInt32(resultCnt)] + endB + " = " + result);
            Console.WriteLine("-----------------------------------");
            Console.ReadKey();
            return true;
        }
    }
}
