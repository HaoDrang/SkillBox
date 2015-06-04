using UnityEngine;
using System.Collections;
using System;
using System.Linq;

public delegate int dele(int i);
public delegate void paramsDele(params int[] iArray);

public class LambdaTest : MonoBehaviour {


	// Use this for initialization
	void Start () {
		SimpleDelegate ();
		juniorDelegateTest ();
		linqDelegateTest_1 ();
		linqDelegateTest_2 ();
		lambdawithparamiters ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void SimpleDelegate()
	{
		dele testDele = i => i * i;
		int j = testDele (250);
		Debug.Log (j.ToString());
	}

	void juniorDelegateTest()
	{
		paramsDele juniorTest = (i1) =>
		{
			string outStr = "";
			for (int i = 0; i < i1.Length; i++) {
				outStr += string.Format ("-{0:d}-", i1[i].ToString());
			}
			Debug.Log (outStr);
		};
		juniorTest(2,3,4,5,6);
	}

	void linqDelegateTest_1()
	{
		int[] numbers = {1,2,3,4,584,687,94,54,6487,87,4548};
		int oddNumbers = numbers.Count(n=>n % 2 == 1);
		Debug.Log (oddNumbers);
	}

	void linqDelegateTest_2()
	{
		int[] numbers = {1,2,3,4,5,6,7,8,9,10};
		var selecteds = numbers.TakeWhile (n=> n<8);
		string str = "" + selecteds.Count();
		foreach (var item in selecteds) {
			str += item.ToString() + "--";
		}
		Debug.Log (str);
	}

	void lambdawithparamiters()
	{
		int localParam = 250;
		Func<int,int, int> paramScopeTestFun = (a,b)=>a*b-localParam;

		Debug.Log ("666:" + paramScopeTestFun(10,20).ToString());
	}
}
