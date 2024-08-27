using System;
using JetBrains.Annotations;
using UnityEngine;

namespace Kitchen.Food {
	[RequireComponent(typeof(FoodPlace))]
	public sealed class FoodTrasher : MonoBehaviour {

		FoodPlace _place = null;
		float     _timer = 0f;

		void Start() {
			_place = GetComponent<FoodPlace>();
			_timer = Time.realtimeSinceStartup;
		}

		/// <summary>
		/// Освобождает место по двойному тапу если еда на этом месте сгоревшая.
		/// </summary>
		[UsedImplicitly]
		public void TryTrashFood() {
			if ( _place.CurFood == null )
			{
				return;
			}
			
			if ( _place.CurFood.CurStatus == Food.FoodStatus.Overcooked ) 
			{
				_place.FreePlace();
			}
		}
	}
}
