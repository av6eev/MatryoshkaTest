using System.Collections.Generic;
using UnityEngine;

namespace Kitchen.Food {
	public sealed class FoodVisualizer : MonoBehaviour {
		public string           Name       = null;
		public List<GameObject> AuxObjects = new List<GameObject>();

		public void SetEnabled(bool yesno) {
			gameObject.SetActive(yesno);
			AuxObjects.ForEach(x => x.SetActive(yesno));
		}
	}
}
