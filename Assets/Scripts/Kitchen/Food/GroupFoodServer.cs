using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;

namespace Kitchen.Food {
	public sealed class GroupFoodServer : MonoBehaviour {
		public List<FoodServer> Servers = null;

		[UsedImplicitly]
		public void TryServe() {
			foreach ( var server in Servers ) {
				if ( server.TryServeFood() ) {
					return;
				}
			}
		}
	}
}
