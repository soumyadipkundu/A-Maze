using UnityEngine;
using System.Collections;

public class DestroyCoin : MonoBehaviour {
	public void OnCoinClicked(){
		Destroy(gameObject);
	}
}
