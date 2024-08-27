using System.Collections.Generic;
using UnityEngine;

namespace Kitchen.Food {
	public sealed class AutoFoodFiller : MonoBehaviour {
		public string                  FoodName = null;
		public List<AbstractFoodPlace> Places   = new List<AbstractFoodPlace>();

		void Update() {
			foreach ( var place in Places ) {
				place.TryPlaceFood(new Food(FoodName));
			}
		}
	}
}
