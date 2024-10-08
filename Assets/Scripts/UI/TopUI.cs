using Controllers;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace UI {
	public sealed class TopUI : MonoBehaviour {
		public Image    OrdersBar          = null;
		public TMP_Text OrdersCountText    = null;
		public TMP_Text CustomersCountText = null;

		void Start() {
			GameplayController .Instance.TotalOrdersServedChanged       += OnOrdersChanged;
			CustomersController.Instance.TotalCustomersGeneratedChanged += OnCustomersChanged;
			OnOrdersChanged();
			OnCustomersChanged();
		}

		void OnDestroy() {
			if ( GameplayController.Instance ) {
				GameplayController.Instance.TotalOrdersServedChanged -= OnOrdersChanged;
			}

			if ( CustomersController.Instance ) {
				CustomersController.Instance.TotalCustomersGeneratedChanged -= OnCustomersChanged;
			}
		}

		void OnCustomersChanged() {
			var cc = CustomersController.Instance;
			CustomersCountText.text = (cc.CustomersTargetNumber - cc.TotalCustomersGenerated).ToString();
		}

		void OnOrdersChanged() {
			var gc = GameplayController.Instance;
			OrdersCountText.text = $"{gc.TotalOrdersServed}/{gc.OrdersTarget}";
			OrdersBar.fillAmount = (float) gc.TotalOrdersServed / gc.OrdersTarget;
		}
	}
}
