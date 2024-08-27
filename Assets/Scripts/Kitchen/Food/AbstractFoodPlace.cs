using UnityEngine;

namespace Kitchen.Food {
	public abstract class AbstractFoodPlace : MonoBehaviour {
		public abstract bool TryPlaceFood(Food food);
		public abstract void FreePlace();
	}
}
