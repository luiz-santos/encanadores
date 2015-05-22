using UnityEngine;
using System.Collections;

//DontDestroy
public class AvoidDestruction : MonoBehaviour {

	void Awake() {
		DontDestroyOnLoad (gameObject);
	}
}
