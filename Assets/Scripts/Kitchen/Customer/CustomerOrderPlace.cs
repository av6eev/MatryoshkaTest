using UnityEngine;

namespace Kitchen.Customer {
	public sealed class CustomerOrderPlace : MonoBehaviour {
		public Order.Order CurOrder { get; private set; } = null;

		public bool IsActive { get { return CurOrder != null; } }

		public void Init(Order.Order order) {
			CurOrder = order;
			gameObject.SetActive(true);
		}

		public void Complete() {
			CurOrder = null;
			gameObject.SetActive(false);
		}
	}
}
