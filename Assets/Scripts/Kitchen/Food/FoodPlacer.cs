using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;

namespace Kitchen.Food {
	public sealed class FoodPlacer : MonoBehaviour {
		public string                  FoodName = string.Empty;
		public List<AbstractFoodPlace> Places   = new List<AbstractFoodPlace>();

		[UsedImplicitly]
		public void TryPlaceFood() {
			foreach ( var place in Places ) {
				if ( place.TryPlaceFood(new Food(FoodName)) ) {
					return;
				}
			}
		}
	}
}
