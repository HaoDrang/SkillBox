using UnityEngine;
using System.Collections;
using System.Reflection;

public class ReflectionTest : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Reflection_1 ();
		Reflection_2 ();
	}

	void Reflection_1 ()
	{
		int i = 111;
		System.Type t = i.GetType ();
		ManualSeperator (1);
		Debug.Log (t.ToString());
		System.Reflection.Assembly info = typeof(System.Int32).Assembly;
		Debug.Log (info.ToString ());
	}

	void Reflection_2 ()
	{
		Assembly a = Assembly.LoadFrom("Resources/Assembly-CSharp.dll");
		ManualSeperator (2);
		if (a != null) {
			foreach (var item in a.GetTypes()) {
				Debug.Log("=..=~#   " + item.FullName);
			}
		}
	}

	void ManualSeperator (int iID)
	{
		string str = "~~~~~~~~~~~~~~~~" + iID + "~~~~~~~~~~~~~~~~";
		string split = "";
		for (int i = 0; i < str.Length; i++) {
			split += "~";
		}
		Debug.Log (split);
		Debug.Log ("~~~~~~~~~~~~~~~~" + iID + "~~~~~~~~~~~~~~~~");
		Debug.Log (split);
	}
}
